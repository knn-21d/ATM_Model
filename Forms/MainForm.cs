using ATM_Model.Forms;
using ATM_Model.Primary_Classes;

namespace ATM_Model
{
    public partial class MainForm : Form
    {
        string enteredPin = "";
        Card? ejectedCard;
        public MainForm()
        {
            InitializeComponent();
            displayListBox.Items.Add("Открыть счёт");
            confirmButton.Focus();
        }

        private void ActionChosen(string? action)
        {
            switch (action)
            {
                case "Открыть счёт":
                    new CreateAccountArgsForm().ShowDialog();
                    if (ATM.NewCardsAmount() > 0)
                    {
                        newCardsAmountLabel.Visible = true;
                        newCardsAmountLabel.Text = ATM.NewCardsAmount().ToString();
                    }
                    break;
                case "Выпустить карту":
                    new ReleaseCardArgsForm().ShowDialog();
                    if (ATM.NewCardsAmount() > 0)
                    {
                        newCardsAmountLabel.Visible = true;
                        newCardsAmountLabel.Text = ATM.NewCardsAmount().ToString();
                    }
                    break;
                case "Показать баланс":
                    MessageBox.Show(ATM.GetBalance());
                    break;
                case "Снять наличные":
                    new CashOutArgsForm().ShowDialog();
                    break;
                case "Внести наличные":
                    new CashInArgsForm().ShowDialog();
                    break;
                case "Отправить перевод":
                    new TransferArgsForm().ShowDialog();
                    break;
                case "Выход":
                    ejectedCard = ATM.EjectCard();
                    ejectButton.Visible = true;
                    mainTextBox.Text = "Заберите карту...";
                    mainTextBox.Size = new Size(244, 23);
                    displayListBox.Items.Remove("Выпустить карту");
                    displayListBox.Items.Remove("Показать баланс");
                    displayListBox.Items.Remove("Снять наличные");
                    displayListBox.Items.Remove("Внести наличные");
                    displayListBox.Items.Remove("Отправить перевод");
                    displayListBox.Items.Remove("Выход");
                    break;
                default:
                    return;
            }

            if (ATM.HasPrintedReceipts())
            {
                receiptLabel.Visible = true;
            }
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            switch (ATM.State)
            {
                case ATM.ServiceState.NoCard:
                    try
                    {
                        ATM.InsertCard(Convert.ToInt64(mainTextBox.Text));

                        label.Text = "Введите пин-код: ";

                        for (int i = 0; i < mainTextBox.Text.Length; i += 5) // разбиение номера карты пробелами
                        {
                            mainTextBox.Text = mainTextBox.Text.Insert(4 + i, " ");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ATM.ServiceState.NoPin:
                    try
                    {
                        ATM.Authorize(enteredPin);
                        label.Text = "";
                        displayListBox.Items.Add("Выпустить карту");
                        displayListBox.Items.Add("Показать баланс");
                        displayListBox.Items.Add("Снять наличные");
                        displayListBox.Items.Add("Внести наличные");
                        displayListBox.Items.Add("Отправить перевод");
                        displayListBox.Items.Add("Выход");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        enteredPin = "";
                    }
                    break;
                case ATM.ServiceState.Authorized:
                    ActionChosen((string?)displayListBox.SelectedItem);
                    break;
            }
        }

        private void DisplayListBoxDoubleClick(object sender, MouseEventArgs e)
        {
            int index = displayListBox.IndexFromPoint(e.Location);
            var item = index == -1 || index >= displayListBox.Items.Count ? null : displayListBox.Items[index];

            ActionChosen((string?)item);
        }

        private void NewCardsButtonClick(object sender, MouseEventArgs e) // открыть лоток выдачи карт
        {
            if (ATM.NewCardsAmount() == 0)
            {
                MessageBox.Show("Контейнер пуст!");
            }
            else if (ATM.NewCardsAmount() == 1)
            {
                Card card = ATM.ClearContainer()[0];
                MessageBox.Show($"Вы получили карту...\n\nНомер: {card.DisplayNumber}\tпин-код: {card.Pin}");
            }
            else
            {
                new CardsContainerForm(ATM.ClearContainer()).ShowDialog();
            }
            newCardsAmountLabel.Visible = false;
        }

        private void EjectButtonClick(object sender, MouseEventArgs e)
        {
            if (ATM.State != ATM.ServiceState.NoCard)
            {
                Card card = ATM.EjectCard()!;
                MessageBox.Show($"Вы забрали карту: {card!.DisplayNumber}");
            }
        }

        private void DigitButtonClick(object sender, MouseEventArgs e) // считывание с кнопок формы
        {
            if (ATM.State == ATM.ServiceState.NoPin && label.Text.Length < 21)
            {
                label.Text += '*';
                enteredPin += ((Button)sender).Text;
            }
            else if (ATM.State == ATM.ServiceState.NoCard)
            {
                mainTextBox.Text += ((Button)sender).Text;
            }
        }

        private void RemoveLastSymbol()
        {
            if (mainTextBox.Text.Length > 0 && ATM.State == ATM.ServiceState.NoCard)
            {
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1); // стирание последнего символа
            }
            else if (label.Text.Length > 17 && ATM.State == ATM.ServiceState.NoPin)
            {
                label.Text = label.Text.Remove(label.Text.Length - 1);
                enteredPin = enteredPin.Remove(enteredPin.Length - 1);
            }
        }

        private void MainFormKeyPress(object sender, KeyPressEventArgs e) // считывание с клавиатуры
        {
            if (Int32.TryParse(e.KeyChar.ToString(), out int _)) // цифры
            {
                if (ATM.State == ATM.ServiceState.NoPin && label.Text.Length < 21)
                {
                    label.Text += '*';
                    enteredPin += e.KeyChar;
                }
                else if (ATM.State == ATM.ServiceState.NoCard)
                {
                    mainTextBox.Text += e.KeyChar;
                }
            }
            else if (e.KeyChar == (char)8) // backspace
            {
                RemoveLastSymbol();
            }
        }

        private void LeftArrowButtonClick(object sender, MouseEventArgs e) => RemoveLastSymbol();

        private void ReceiptButtonClick(object sender, MouseEventArgs e)
        {
            List<string> result = ATM.ClearReceipts();
            if (result.Count > 0)
            {
                new ViewReceiptsForm(result).ShowDialog();
                receiptLabel.Visible = false;
            }
        }

        private void EjectButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show($"Вы забрали карту {ejectedCard!.DisplayNumber}");
            ejectButton.Visible = false;
            mainTextBox.Size = new Size(274, 23);
            mainTextBox.Text = "";
        }
    }
}