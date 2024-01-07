namespace ATM_Model.Primary_Classes
{
    // чековый принтер
    public class ReceiptWriter
    {
        List<string> _printedReceipts = new(); // список готовых чеков

        public bool HasPrintedReceipts => _printedReceipts.Count > 0;

        public enum Operation
        {
            CashOut,
            CashIn,
            SendToCard,
            SendToAccount,
            AccountCreated,
            CardReleased
        }

        // печать чека
        public void Write(int accountId, int operationResult, Operation operation, Card? receiverCard, Account? receiver, Card? releasedCard)
        {
            Card? card = ATM.GetCard();
            string message;

            switch (operation)
            {
                case Operation.CashOut:
                    message = $"Снято {operationResult} со счёта {accountId} по карте {card!.DisplayCoveredNumber}";
                    break;
                case Operation.CashIn:
                    message = $"Зачислено {operationResult} на счёт {accountId} по карте {card!.DisplayCoveredNumber}";
                    break;
                case Operation.SendToCard:
                    message = $"Отправлено {operationResult} на карту {receiverCard!.DisplayCoveredNumber}";
                    break;
                case Operation.SendToAccount:
                    message = $"Отправлено {operationResult} на счёт №{receiverCard!.DisplayCoveredNumber}";
                    break;
                case Operation.AccountCreated:
                    message = $"Открыт счёт №{accountId}; зачислено на счёт: {operationResult} ед.";
                    break;
                case Operation.CardReleased:
                    message = $"Выпущена карта {releasedCard!.DisplayNumber} для счёта №{accountId}";
                    break;
                default:
                    message = "Не удалось провести операцию!";
                    break;
            }

            _printedReceipts.Add(message);
        }

        public List<string> ClearReceipts() // сорвать чеки
        {
            List<string> result = new(_printedReceipts);
            _printedReceipts.Clear();
            return result;
        }
    }
}
