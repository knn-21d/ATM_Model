namespace ATM_Model.Primary_Classes
{
    public class Account
    {
        int _nextId = 1;

        public int Id { get; }
        public List<Card> Cards { get; }
        int UnitsBalance { get; set; }
        int CentsBalance { get; set; }
        public string DisplayBalance
        {
            get // проверить
            {
                string result = UnitsBalance.ToString();

                for (int i = result.Length - 3; i > 0; i -= 2)
                {
                    result = result.Insert(i, " ");
                }

                return result + $".{CentsBalance}";
            }
        }

        public Account(int unitsBalance, int centsBalance)
        {
            Id = _nextId;
            _nextId++;
            Cards = new();
            UnitsBalance = unitsBalance;
            CentsBalance = centsBalance;
            CentralDataStorage.AddAccount(this);
        }

        public void Add(int units, int cents) // проверить
        {
            UnitsBalance += (CentsBalance + cents) / 100 + units;
            CentsBalance = (CentsBalance + cents) % 100;
        }

        public void Release(int units, int cents) // проверить
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

        public void AddCard(Card card) => Cards.Add(card);

        public void RemoveCard(Card card) => Cards.Remove(card);
    }
}
