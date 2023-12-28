namespace ATM_Model.Primary_Classes
{
    public class ReceiptWriter
    {
        public enum Operation
        {
            CashOut,
            CashIn,
            Send
        }

        public string Write(int accountId, long cardNumber, int operationResult, Operation operation, long? receiverCardNumber)
        {
            Card? card = CentralDataStorage.FindCard(cardNumber);
            string message;

            switch (operation)
            {
                case Operation.CashOut:
                    message = $"Снято {-operationResult} со счёта {accountId} по карте {card?.DisplayCoveredNumber}";
                    break;
                case Operation.CashIn:
                    message = $"Зачислено {operationResult} на счёт {accountId} по карте {card?.DisplayCoveredNumber}";
                    break;
                case Operation.Send:
                    Card? receiverCard = CentralDataStorage.FindCard((long)receiverCardNumber);
                    message = $"Отправлено {operationResult} на карту {receiverCard?.DisplayCoveredNumber}";
                    break;
                default:
                    message = "Не удалось провести операцию!";
                    break;
            }

            return message;
        }
    }
}
