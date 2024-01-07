namespace ATM_Model.Primary_Classes
{
    // основной класс управления, который уже, в свою очередь, взаимодействует со внутренними элементами системы,
    // не выпуская их торчать снаружи (инкапсулирует их)
    public static class ATM
    {
        static Account? _currentAccount; // авторизованный пользователь
        static Card? _currentCard; // введённая карта
        static CashStorage _cashStorage; // хранилище банкнот
        static PlasticStorage _plasticStorage; // хранилище карт
        static ReceiptWriter _writer; // чековый принтер
        static CardReader _reader; // приёмник карт
        static NewCardsContainer _newCardsContainer; // новые карты подаются сюда
        static bool _isReceiptNeeded; // был ли запрошен чек
        public static ServiceState State { get; set; } // состояние обслуживания

        public enum ServiceState
        {
            NoCard, // до ввода карты
            NoPin, // во ввода пин-кода
            Authorized // пользователь авторизован
        }

        static ATM()
        {
            _cashStorage = new(100, 100, 100, 100);
            _writer = new();
            _reader = new();
            _newCardsContainer = new();
            _plasticStorage = new(_newCardsContainer);
            _plasticStorage.Load(100);
            State = ServiceState.NoCard;
        }

        public static int CreateAccount(int units, int cents) // открыть счёт и вернуть его номер
        {
            _currentAccount = new(units, cents);
            ReleaseCard();

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount.Id, units, ReceiptWriter.Operation.AccountCreated, null, null, _currentAccount.Cards[0]);
                _isReceiptNeeded = false;
            }

            return _currentAccount.Id;
        }

        public static void ReleaseCard() // выпуск одной карты
        {
            _plasticStorage.Release(_currentAccount!.Id);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount.Id, 0, ReceiptWriter.Operation.CardReleased, null, null, _newCardsContainer.GetCards()[_newCardsContainer.Amount - 1]);
            }
        }

        public static void ReleaseCard(int amount) // выпуск amount карт
        {
            int oldCount = _newCardsContainer.Amount; // костыльная переменная на случай, если имеются новые карты, которые пользователь ещё не забрал
            _plasticStorage.Release(amount, _currentAccount!.Id);

            if (_isReceiptNeeded)
            {
                for (int i = oldCount; i < _newCardsContainer.Amount - 1; i++) // oldCount помогает избегать повторной печати чеков
                {
                    _writer.Write(_currentAccount!.Id, 0, ReceiptWriter.Operation.CardReleased, null, null, _newCardsContainer.GetCards()[i]);
                }
                _isReceiptNeeded = false;
            }
        }

        public static List<Card> ClearContainer() => _newCardsContainer.Clear(); // забрать свежевыпущенные карты

        public static void InsertCard(long cardNumber) // вставить карту
        {
            _reader.Insert(cardNumber);
            _currentCard = _reader.Read();

            if (_currentCard is null)
            {
                throw new Exception("Карта невалидна!");
            }

            State = ServiceState.NoPin;
        }

        public static Card? EjectCard() // вытолкнуть карту
        {
            var result = _currentCard;
            _currentCard = null;
            _currentAccount = null;
            _reader.Eject();
            State = ServiceState.NoCard;
            return result;
        }

        public static Account? ReceiveAccountDetails(long cardNumber) => CentralDataStorage.FindAccountByCard(cardNumber); // запрос информации о счёте

        public static void Authorize(string pin) // ввести пин-код
        {
            try
            {
                if (_currentCard!.TryAuthorize(pin))
                {
                    _currentAccount = CentralDataStorage.FindAccountByCard(_currentCard.Number);
                    State = ServiceState.Authorized;
                }
            }
            catch (Exception ex) when (ex.Message == "Карта заблокирована!")
            {
                _plasticStorage.Confiscate(EjectCard()!);
                State = ServiceState.NoCard;
                throw;
            }
        }

        public static void SendMoneyToCard(long cardNumber, int units, int cents) // перевод на карту
        {
            Account? receiver = CentralDataStorage.FindAccountByCard(cardNumber);
            if (receiver is not null)
            {
                _currentAccount!.Release(units, cents);
                receiver.Add(units, cents);
            }
            else
            {
                throw new Exception("Карта получателя не найдена!");
            }

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, units, ReceiptWriter.Operation.SendToCard, CentralDataStorage.FindCard(cardNumber), null, null);
                _isReceiptNeeded = false;
            }
        }

        public static void SendMoneyToAccount(int accountId, int units, int cents) // перевод по номеру счёта
        {
            Account? receiver = CentralDataStorage.FindAccountById(accountId);

            if (receiver is not null)
            {
                _currentAccount!.Release(units, cents);
                receiver!.Add(units, cents);
            }
            else
            {
                _isReceiptNeeded = false;
                throw new Exception("Номер счёта получателя не найден!");
            }

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, units, ReceiptWriter.Operation.SendToAccount, null, receiver, null);
                _isReceiptNeeded = false;
            }
        }

        public static void CashToBalance(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // зачисление наличных
        {
            int amount = 5000 * fiveThousands + 1000 * thousands + 500 * fiveHundreds + 100 * hundreds;
            _cashStorage.Fill(fiveThousands, thousands, fiveHundreds, hundreds);
            _currentAccount!.Add(amount, 0);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, amount, ReceiptWriter.Operation.CashIn, null, null, null);
                _isReceiptNeeded = false;
            }
        }

        public static int[] CalculateBanknotesAmounts(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // подсчёт банкнот на выдачу
        {
            int[] state = _cashStorage.GetStorageState();
            int amountStored = _cashStorage.GetTotalAmount();
            int amountNeeded = fiveThousands * 5000 + thousands * 1000 + fiveHundreds * 500 + hundreds * 100;
            int[] result = new int[4]; // последовательность количества банкнот: 5000, 1000, 500 и 100 соответственно


            if (amountStored < 100)
            {
                throw new Exception("Снятие наличных временно невозможно!");
            }
            else if (amountNeeded > amountStored)
            {
                throw new Exception($"Не удалось снять наличные! Максимум: {amountStored}");
            }

            if (state[0] <= fiveThousands)
            {
                result[0] += state[0];
                fiveThousands -= state[0];
                thousands += fiveThousands * 5;
            }
            else
            {
                result[0] += fiveThousands;
                state[0] -= fiveThousands;
            }
            fiveThousands = 0;
            amountNeeded -= result[0] * 5000;

            if (state[1] <= thousands)
            {
                result[1] += state[1];
                thousands -= state[1];
                fiveHundreds += thousands * 2;
            }
            else
            {
                result[1] += thousands;
                state[1] -= thousands;
            }
            thousands = 0;
            amountNeeded -= result[2] * 1000;

            if (state[2] <= fiveHundreds)
            {
                result[2] += state[2];
                fiveHundreds -= state[2];
                hundreds += fiveHundreds * 5;
            }
            else
            {
                result[2] += fiveHundreds;
                state[2] -= fiveHundreds;
            }
            fiveHundreds = 0;
            amountNeeded -= state[2] * 500;

            result[3] += state[3];
            hundreds -= state[3];
            amountNeeded -= state[3] * 100;

            if (amountNeeded > 0)
            {
                throw new Exception($"Снятие указанной суммы невозможно! Выберите на {amountNeeded} меньше");
            }

            return result;
        }

        public static void CashFromBalance(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // выдача посчитанных банкнот
        {
            int amount = 5000 * fiveThousands + 1000 * thousands + 500 * fiveHundreds + 100 * hundreds;
            int[] cash = CalculateBanknotesAmounts(fiveThousands, thousands, fiveHundreds, hundreds);

            _currentAccount!.Release(amount, 0);
            _cashStorage.Take(cash[0], cash[1], cash[2], cash[3]);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, amount, ReceiptWriter.Operation.CashOut, null, null, null);
                _isReceiptNeeded = false;
            }
        }

        public static void CashFromBalance(int amount) // снятие наличных по сумме
        {
            int fivefiveThousands = amount / 5000;
            int thousands = amount % 5000 / 1000;
            int fiveHundreds = amount % 5000 % 1000 / 500;
            int hundreds = amount % 5000 % 1000 % 500 / 100;
            CashFromBalance(fivefiveThousands, thousands, fiveHundreds, hundreds);
        }

        public static void RequestReceipt() => _isReceiptNeeded = true; // запросить чек

        public static int NewCardsAmount() => _newCardsContainer.Amount; // количество карт 

        public static string GetBalance() => _currentAccount!.DisplayBalance; // запрос баланса

        public static Card? GetCard() => _currentCard; // запрос карты

        public static bool HasPrintedReceipts() => _writer.HasPrintedReceipts; // есть ли распечатанные чеки

        public static List<string> ClearReceipts() => _writer.ClearReceipts(); // сорвать чеки
    }
}
