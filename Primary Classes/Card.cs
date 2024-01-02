using System.ComponentModel;

namespace ATM_Model.Primary_Classes
{
    public class Card
    {
        [Browsable(false)] // чтобы некоторые свойства не отображались в таблице
        public long Number { get; }
        public string DisplayNumber // отображение типа "0000 0000 0000 0000"
        {
            get
            {
                char[] result = new char[19];
                string number = Number.ToString();

                //for (int i = 0; i < 17 - number.Length; i++) // дорисовка незначащих нулей
                //{
                //    number = '0' + number;
                //}

                int j = 0;
                for (int i = 0; i < result.Length; i++) // разбиение пробелами
                {
                    if (i == 4 || i == 9 || i == 14)
                    {
                        result[i] = ' ';
                        j--;
                    }
                    else
                    {
                        result[i] = number[j];
                    }
                    j++;
                }
                return new string(result);
            }
        }
        [Browsable(false)]
        public string DisplayCoveredNumber => DisplayNumber.Replace(DisplayNumber.Substring(10, 4), "****"); // отображение типа "0000 0000 **** 0000"
        public string Pin => DisplayNumber.Substring(15); // последние 4 цифры номера 
        [Browsable(false)]
        public int AccountId { get; private set; }
        [Browsable(false)]
        public bool Active { get; private set; }

        private int _triesLeft;

        public Card() // проверить
        {
            Active = false;
            Random rnd = new Random();
            long roll;
            while (true)
            {
                roll = rnd.NextInt64(1000000000000000, 9999999999999999);
                if (CentralDataStorage.FindCard(roll) == null)
                {
                    Number = roll;
                    break;
                }
            }
            CentralDataStorage.AddCard(this);
        }

        public bool TryAuthorize(string pin)
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
            CentralDataStorage.FindAccountById(AccountId)!.RemoveCard(this);
            AccountId = 0;
            Active = false;
        }
    }
}
