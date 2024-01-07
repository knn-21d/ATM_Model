namespace ATM_Model.Primary_Classes
{
    // хранилище наличных
    public class CashStorage
    {
        int _fiveThousands; // 5000
        int _thousands; // 1000
        int _fiveHundreds; // 500
        int _hundreds; // 100

        public CashStorage(int fiveThousands, int thousands, int fiveHundreds, int hundreds)
        {
            _fiveThousands = fiveThousands;
            _thousands = thousands;
            _fiveHundreds = fiveHundreds;
            _hundreds = hundreds;
        }

        public void Fill(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // загрузка хранилища
        {
            _fiveThousands += fiveThousands;
            _thousands += thousands;
            _fiveHundreds += fiveHundreds;
            _hundreds += hundreds;
        }

        public void Take(int fiveThousands, int thousands, int fiveHundreds, int hundreds) // выдача наличных
        {
            _fiveThousands -= fiveThousands;
            _thousands -= thousands;
            _fiveHundreds -= fiveHundreds;
            _hundreds -= hundreds;
        }

        public int[] GetStorageState() => new int[] { _fiveThousands, _thousands, _fiveHundreds, _hundreds }; // состояние хранилище

        public int GetTotalAmount() => _fiveThousands * 5000 + _thousands * 1000 + _fiveHundreds * 500 + _hundreds * 100; // общая стоимость банкнот
    }
}
