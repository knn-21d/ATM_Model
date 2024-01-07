namespace ATM_Model.Primary_Classes
{
    // хранилище данных
    // выполняет роль центрального компьютера банка, указанного в формулировке задания
    public static class CentralDataStorage
    {
        private readonly static List<Account> _accounts; // список счетов
        public static List<Account> GetAccounts => new(_accounts);
        private readonly static List<Card> _cards; // список карт
        public static List<Card> GetCards => new(_cards);

        static CentralDataStorage()
        {
            _accounts = new List<Account>();
            _cards = new List<Card>();
        }

        public static void AddAccount(Account account) => _accounts.Add(account); // добавить счёт в список

        public static void AddCard(Card card) => _cards.Add(card); // добавить карту

        public static Card? FindCard(long cardNumber) => _cards.FirstOrDefault(c => c.Number == cardNumber); // найти карту по номеру
        
        public static List<Card>? FindCards(int accountId) => new(_cards.Where(c => c.AccountId == accountId)); // найти связанные карты счёта

        public static Account? FindAccountByCard(long cardNumber) => _accounts.FirstOrDefault(a => a.Id == FindCard(cardNumber)?.AccountId); // найти счёт по номеру карты

        public static Account? FindAccountById(int id) => _accounts.FirstOrDefault(a => a.Id == id); // найти счёт по номеру
    }
}
