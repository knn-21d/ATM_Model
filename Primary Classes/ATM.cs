namespace ATM_Model.Primary_Classes
{
    public static class ATM
    {
        static Account? _currentAccount;
        static Card? _currentCard;
        static CashStorage _cashStorage;
        static PlasticStorage _plasticStorage;
        static ReceiptWriter _writer;
        static CardReader _reader;
        static NewCardsContainer _newCardsContainer;
        static bool _isReceiptNeeded;
        public static ServiceState State { get; set; } 

        public enum ServiceState
        {
            NoCard,
            NoPin,
            Authorized
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

        public static int CreateAccount(int units, int cents)
        {
            _currentAccount = new(units, cents);
            ReleaseCard();
            return _currentAccount.Id;
        }

        public static void ReleaseCard()
        {
            _plasticStorage.Release(_currentAccount!.Id);
        }

        public static void ReleaseCard(int amount)
        {
            _plasticStorage.Release(amount, _currentAccount!.Id);
        }

        public static List<Card> ClearContainer() => _newCardsContainer.Clear();

        public static void InsertCard(long cardNumber)
        {
            _reader.Insert(cardNumber);
            State = ServiceState.NoPin;
        }

        public static Card? EjectCard() // проверить
        {
            var result = _currentCard;
            _currentCard = null;
            _currentAccount = null;
            _reader.Eject();
            State = ServiceState.NoCard;
            return result;
        }

        public static Account? ReceiveAccountDetails(long cardNumber) => CentralDataStorage.FindAccountByCard(cardNumber); // проверить

        public static void Authorize(string pin) // проверить
        {
            _currentCard = _reader.Read();

            if (_currentCard is null)
            {
                throw new Exception("Карта невалидна!");
            }
            
            try
            {
                if (_currentCard.TryAuthorize(pin))
                {
                    _currentAccount = CentralDataStorage.FindAccountByCard(_currentCard.Number);
                    State = ServiceState.Authorized;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "Карта заблокирована!")
                {
                    _plasticStorage.Confiscate(EjectCard()!);
                    State = ServiceState.NoCard;
                }
                throw ex; // хз
            }
        }

        public static void SendMoneyToCard(long cardNumber, int units, int cents) // проверить
        {
            CentralDataStorage.FindAccountByCard(cardNumber)?.Add(units, cents);
            _currentAccount?.Release(units, cents);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, _currentCard!.Number, units, ReceiptWriter.Operation.Send, cardNumber);
                _isReceiptNeeded = false;
            }
        }

        public static void SendMoneyToAccount(int accountId, int units, int cents) // проверить
        {
            CentralDataStorage.FindAccountById(accountId)?.Add(units, cents);
            _currentAccount?.Release(units, cents);
        }

        public static void CashToBalance(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // проверить
        {
            int amount = 5000 * fiveThousands + 1000 * thousands + 500 * fiveHundreds + 100 * hundreds;
            _cashStorage.Fill(fiveThousands, thousands, fiveHundreds, hundreds);
            _currentAccount?.Add(amount, 0);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, _currentCard!.Number, amount, ReceiptWriter.Operation.CashIn, null);
                _isReceiptNeeded = false;
            }
        }

        public static int[] CalculateBanknotesAmounts(int fiveThousands, int thousands, int fiveHundreds, int hundreds)
        {   // проверить (крайне сомнительно)
            int[] state = _cashStorage.GetStorageState();
            int amountStored = _cashStorage.GetTotalAmount();
            int amountNeeded = fiveThousands * 5000 + thousands * 1000 + fiveHundreds * 500 + hundreds * 100;
            int[] result = new int[4];


            if (amountStored < 100)
            {
                throw new Exception("Снятие наличных временно невозможно!");
            }
            else if (amountNeeded > amountStored)
            {
                throw new Exception($"Не удалось снять наличные! Максимум: {amountStored}");
            }
            else if (amountNeeded < 100)
            {
                throw new Exception("Не удалось снять наличные! Минимум: 100");
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

        public static void CashFromBalance(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // проверить
        {
            int amount = 5000 * fiveThousands + 1000 * thousands + 500 * fiveHundreds + 100 * hundreds;
            int[] cash = CalculateBanknotesAmounts(fiveThousands, thousands, fiveHundreds, hundreds);

            _currentAccount?.Release(amount, 0);
            _cashStorage.Take(cash[0], cash[1], cash[2], cash[3]);

            if (_isReceiptNeeded)
            {
                _writer.Write(_currentAccount!.Id, _currentCard!.Number, amount, ReceiptWriter.Operation.CashOut, null);
                _isReceiptNeeded = false;
            }
        }

        public static void CashFromBalance(int amount) // проверить
        {
            int fivefiveThousands = amount / 5000;
            int thousands = amount % 5000 / 1000;
            int fiveHundreds = amount % 5000 % 1000 / 500;
            int hundreds = amount % 5000 % 1000 % 500 / 100;
            CashFromBalance(fivefiveThousands, thousands, fiveHundreds, hundreds);
        }

        public static void RequestReceipt() => _isReceiptNeeded = true;

        public static int NewCardsAmount() => _newCardsContainer.Amount;
    }
}
