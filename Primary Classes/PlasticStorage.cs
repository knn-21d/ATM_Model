namespace ATM_Model.Primary_Classes
{
    public class PlasticStorage
    {
        private readonly List<Card> _unusedCards;
        private readonly List<Card> _confiscatedCards;
        private readonly NewCardsContainer _newCardsContainer;

        public PlasticStorage()
        {
            _unusedCards = new();
            _confiscatedCards = new();
            _newCardsContainer = new();
        }

        public void Confiscate(Card card) // проверить
        {
            _confiscatedCards.Add(card);
        }

        public void Release(int accountId) // проверить
        {
            if (_unusedCards.Count == 0) throw new Exception("Выдача карт временно невозможна!");
            else
            {
                Card card = _unusedCards.ElementAt(0);
                card.Activate(accountId);
                _newCardsContainer.Receive(card);
            }
        }

        public void Release(int amount, int accountId) // проверить
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

        public void Load(int amount) // проверить
        {
            for (int i = 0; i < amount; i++)
            {
                _unusedCards.Add(new Card());
            }
        }

        public void Unload(int amount) // проверить
        {
            if (amount > _unusedCards.Count)
            {
                amount = _unusedCards.Count;
            }

            for (int i = amount - 1; i >= 0; i--)
            {
                _unusedCards.RemoveAt(i);
            }
        }

        public void UnloadConfiscated(int amount) // проверить
        {
            if (amount > _confiscatedCards.Count)
            {
                amount = _confiscatedCards.Count;
            }

            for (int i = amount - 1; i >= 0; i--)
            {
                _confiscatedCards.RemoveAt(i);
            }
        }
    }
}
