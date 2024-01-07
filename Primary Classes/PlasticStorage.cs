namespace ATM_Model.Primary_Classes
{
    // хранилище неактивных карт (новых и заблокированных)
    public class PlasticStorage
    {
        private readonly List<Card> _unusedCards;
        private readonly List<Card> _confiscatedCards;
        private readonly NewCardsContainer _newCardsContainer;

        public PlasticStorage(NewCardsContainer container)
        {
            _unusedCards = new();
            _confiscatedCards = new();
            _newCardsContainer = container;
        }

        public void Confiscate(Card card) // изъять карту 
        {
            _confiscatedCards.Add(card);
        }

        public void Release(int accountId) // выдача карты
        {
            if (_unusedCards.Count == 0) throw new Exception("Выдача карт временно невозможна!");
            else
            {
                Card card = _unusedCards.ElementAt(0);
                _unusedCards.Remove(card);
                card.Activate(accountId);
                _newCardsContainer.Receive(card);
            }
        }

        public void Release(int amount, int accountId) // выдача amount карт
        {
            if (amount == 0)
            {
                throw new Exception("Выберите количество!");
            }

            if (_unusedCards.Count == 0)
            {
                throw new Exception("Выдача карт временно невозможна!");
            }
            else if (amount > _unusedCards.Count)
            {
                throw new Exception($"Максимум карт: {_unusedCards.Count}");
            }
            else
            {
                List<Card> result = new();

                for (int i = amount - 1; i >= 0; i--)
                {
                    Card card = _unusedCards.ElementAt(i);
                    card.Activate(accountId);
                    result.Add(card);
                    _unusedCards.Remove(card);
                }

                _newCardsContainer.Receive(result);
            }
        }

        public void Load(int amount) // пополнить запас неиспользованных карт
        {
            for (int i = 0; i < amount; i++)
            {
                _unusedCards.Add(new Card());
            }
        }
    }
}
