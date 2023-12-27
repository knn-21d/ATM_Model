namespace ATM_Model.Primary_Classes
{
    public class NewCardsContainer
    {
        readonly List<Card> _content;

        public NewCardsContainer()
        {
            _content = new List<Card>();
        }

        public void Receive(List<Card> cards) => _content.Concat(cards);

        public void Receive(Card card) => _content.Add(card);

        public List<Card> Clear()
        {
            var result = new List<Card>(_content);
            _content.Clear();
            return result;
        }
    }
}
