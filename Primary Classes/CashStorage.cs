namespace ATM_Model.Primary_Classes
{
    internal class CashStorage
    {
        int _fiveThousands;
        int _thousands;
        int _fiveHundreds;
        int _hundreds;

        public CashStorage(int fiveThousands, int thousands, int fiveHundreds, int hundreds)
        {
            _fiveThousands = fiveThousands;
            _thousands = thousands;
            _fiveHundreds = fiveHundreds;
            _hundreds = hundreds;
        }

        public void Fill(int fiveThousands, int thousands, int fiveHundreds, int hundreds)
        {
            _fiveThousands += fiveThousands;
            _thousands += thousands;
            _fiveHundreds += fiveHundreds;
            _hundreds += hundreds;
        }

        public void Take(int fiveThousands, int thousands, int fiveHundreds, int hundreds)
        {
            _fiveThousands -= fiveThousands;
            _thousands -= thousands;
            _fiveHundreds -= fiveHundreds;
            _hundreds -= hundreds;
        }

        public int[] GetStorageState() => new int[] { _fiveThousands, _thousands, _fiveHundreds, _hundreds };

        public int GetTotalAmount() => _fiveThousands * 5000 + _thousands * 1000 + _fiveHundreds * 500 + _hundreds * 100;
    }
}
