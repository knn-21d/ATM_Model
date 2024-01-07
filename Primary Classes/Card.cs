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
        public int AccountId { get; private set; } // номер связанного счёта (0, если карта неактивна)
        [Browsable(false)]
        public bool Active { get; private set; }

        private int _triesLeft; // осталось попыток

        public Card()
        {
            Active = false;
            Random rnd = new();
            long roll;
            while (true)
            {
                roll = rnd.NextInt64(1000000000000000, 9999999999999999); // случайный 16-значный номер
                if (CentralDataStorage.FindCard(roll) == null)
                {
                    Number = roll;
                    break;
                }
            }
            CentralDataStorage.AddCard(this);
        }

        public bool TryAuthorize(string pin) // возвращает true в случае успеха авторизации или выбрасывает исключение
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

        public void Activate(int accountId) // активация карты и привязка её к счёту пользователя
        {
            AccountId = accountId;
            Active = true;
            CentralDataStorage.FindAccountById(accountId)!.AddCard(this);
            _triesLeft = 3;
        }

        public void Deactivate() // блокировка карты
        {
            CentralDataStorage.FindAccountById(AccountId)!.RemoveCard(this);
            AccountId = 0;
            Active = false;
        }
    }
}
