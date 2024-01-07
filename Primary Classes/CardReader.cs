namespace ATM_Model.Primary_Classes
{
    // устройство считывания карт
    public class CardReader
    {
        Card? _currentCard;

        public void Insert(long cardNumber) => _currentCard = CentralDataStorage.FindCard(cardNumber);

        public Card? Read() => _currentCard;

        public void Eject() => _currentCard = null;
    }
}