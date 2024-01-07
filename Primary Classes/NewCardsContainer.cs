namespace ATM_Model.Primary_Classes
{
    // сюда поступают только что оформленные и активированные карты
    public class NewCardsContainer
    {
        List<Card> _content; // содержимое

        public int Amount => _content.Count; // количество карт

        public NewCardsContainer()
        {
            _content = new List<Card>();
        }

        public void Receive(List<Card> cards) => _content.Concat(cards); // поступление новых карт

        public void Receive(Card card) // поступление карты
        {
            _content.Add(card);
        }

        public List<Card> GetCards() => new(_content); // отображает содержащиеся карты

        public List<Card> Clear() // то же, что и выше, только карты забираются из контейнера
        {
            var result = GetCards();
            _content.Clear();
            return result;
        }
    }
}
