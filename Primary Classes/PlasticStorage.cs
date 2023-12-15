namespace ATM_Model.Primary_Classes
{
    internal static class PlasticStorage
    {
        private static readonly List<Card> _unusedCards;
        private static readonly List<Card> _confiscatedCards;
        private static readonly NewCardsContainer _newCardsContainer;

        static PlasticStorage()
        {
            _unusedCards = new();
            _confiscatedCards = new();
            _newCardsContainer = new();
        }

        public static void Confiscate(Card card) // проверить
        {
            _confiscatedCards.Add(card);
        }

        public static void Release() // проверить
        {
            if (_unusedCards.Count == 0) throw new Exception("Выдача карт временно невозможна!");
            else _newCardsContainer.Receive(_unusedCards.ElementAt(0));
        }

        public static void Release(int amount) // проверить
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
                    result.Add(_unusedCards.ElementAt(i));
                    _unusedCards.RemoveAt(i);
                }

                _newCardsContainer.Receive(result);
            }
        }

        public static void Load(int amount) // проверить
        {
            for (int i = 0; i < amount; i++)
            {
                _unusedCards.Add(new Card());
            }
        }

        public static void Unload(int amount) // проверить
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

        public static void UnloadConfiscated(int amount) // проверить
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
