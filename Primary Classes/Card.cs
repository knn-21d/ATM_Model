namespace ATM_Model.Primary_Classes
{
    public class Card
    {
        public long Number { get; }
        public string DisplayNumber
        {
            get // проверить
            {
                char[] result = new char[19];
                string number = Number.ToString();
                for (int i = result.Length - 1; i >= 0; i--)
                {
                    if ((i + 1) % 5 == 0 && i > 0)
                    {
                        result[i] = ' ';
                        continue;
                    }

                    if (i > result.Length - 9 && i < result.Length - 5)
                    {
                        result[i] = '*';
                    }
                    else if (number.Length - i - 1 > 0)
                    {
                        result[i] = number[number.Length - i];
                    }
                    else
                    {
                        result[i] = '0';
                    }
                }

                return new string(result);
            }
        }
        public int Pin { get => (int)(Number % 10000); }
        public int AccountId { get; private set; }
        public bool Active { get; private set; }
        private int _triesLeft;

        public Card() // проверить
        {
            Active = false;
            Random rnd = new Random();
            long roll;
            while (true)
            {
                roll = rnd.NextInt64(1, 9999999999999999);
                if (CentralDataStorage.FindCard(roll) == null)
                {
                    Number = roll;
                    break;
                }
            }
            CentralDataStorage.AddCard(this);
        }

        public bool TryAuthorize(int pin)
        {
            if (pin == Pin)
            {
                _triesLeft = 3;
                return true;
            }
            else
            {
                if (_triesLeft > 1)
                {
                    _triesLeft--;
                    throw new Exception($"Неверный ПИН-код! Осталось попыток: {_triesLeft}");
                }
                else
                {
                    Deactivate();
                    throw new Exception("Карта заблокирована!");
                }
            }
        }

        public void Activate(int accountId)
        {
            AccountId = accountId;
            Active = true;
            CentralDataStorage.FindAccountById(accountId)!.AddCard(this);
            _triesLeft = 3;
        }

        public void Deactivate()
        {
            AccountId = 0;
            Active = false;
            CentralDataStorage.FindAccountById(AccountId)!.RemoveCard(this);
        }
    }
}
