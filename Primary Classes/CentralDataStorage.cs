namespace ATM_Model.Primary_Classes
{
    public static class CentralDataStorage
    {
        private readonly static List<Account> _accounts;
        public static List<Account> GetAccounts => new(_accounts);
        private readonly static List<Card> _cards;
        public static List<Card> GetCards => new(_cards);

        static CentralDataStorage()
        {
            _accounts = new List<Account>();
            _cards = new List<Card>();                       
        }

        public static void AddAccount(Account account) => _accounts.Add(account);

        public static void AddCard(Card card) => _cards.Add(card);

        public static Card? FindCard(long cardNumber) => _cards.FirstOrDefault(c => c.Number == cardNumber);
        
        public static List<Card>? FindCards(int accountId) => new(_cards.Where(c => c.AccountId == accountId));

        public static Account? FindAccountByCard(long cardNumber) => _accounts.FirstOrDefault(a => a.Id == FindCard(cardNumber).AccountId);

        public static Account? FindAccountById(int id) => _accounts.FirstOrDefault(a => a.Id == id);
    }
}
