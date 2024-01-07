namespace ATM_Model.Primary_Classes
{
    public class Account
    {
        static int _nextId = 100001; // номер следующего счёта при открытии

        public int Id { get; } // номер счёта
        public List<Card> Cards { get; } // связанные карты
        int UnitsBalance { get; set; } // единицы
        int CentsBalance { get; set; } // сотые
        public string DisplayBalance // отображаемый баланс
        {
            get
            {
                string result = UnitsBalance.ToString();

                for (int i = result.Length - 3; i > 0; i -= 2)
                {
                    result = result.Insert(i, " ");
                }

                return result + $".{CentsBalance}";
            }
        }

        public Account(int unitsBalance, int centsBalance) // может быть указан первичный баланс
        {
            Id = _nextId;
            _nextId++;
            Cards = new();
            UnitsBalance = unitsBalance;
            CentsBalance = centsBalance;
            CentralDataStorage.AddAccount(this);
        }

        public void Add(int units, int cents) // зачисление
        {
            UnitsBalance += (CentsBalance + cents) / 100 + units;
            CentsBalance = (CentsBalance + cents) % 100;
        }

        public void Release(int units, int cents) // отчисление
        {
            if (units > UnitsBalance || units == UnitsBalance && CentsBalance > cents)
            {
                throw new Exception("Недостаточно средств!");
            }
            else
            {
                UnitsBalance -= units + (cents + CentsBalance) % 100;
                CentsBalance = cents > CentsBalance ? 100 + CentsBalance - cents : CentsBalance - cents;
            }
        }

        public void AddCard(Card card) => Cards.Add(card); // привязка карты к счёту

        public void RemoveCard(Card card) => Cards.Remove(card); // отвязка карты
    }
}
