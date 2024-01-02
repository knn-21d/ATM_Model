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
            displayListBox.Items.Add("������� ����");
            confirmButton.Focus();
        }

        private void ActionChosen(string? action)
        {
            switch (action)
            {
                case "������� ����":
                    new CreateAccountArgsForm().ShowDialog();
                    if (ATM.NewCardsAmount() > 0)
                    {
                        newCardsAmountLabel.Visible = true;
                        newCardsAmountLabel.Text = ATM.NewCardsAmount().ToString();
                    }
                    break;
                case "��������� �����":
                    new ReleaseCardArgsForm().ShowDialog();
                    if (ATM.NewCardsAmount() > 0)
                    {
                        newCardsAmountLabel.Visible = true;
                        newCardsAmountLabel.Text = ATM.NewCardsAmount().ToString();
                    }
                    break;
                case "�������� ������":
                    MessageBox.Show(ATM.GetBalance());
                    break;
                case "����� ��������":
                    new CashOutArgsForm().ShowDialog();
                    break;
                case "������ ��������":
                    new CashInArgsForm().ShowDialog();
                    break;
                case "��������� �������":
                    new TransferArgsForm().ShowDialog();
                    break;
                case "�����":
                    ejectedCard = ATM.EjectCard();
                    ejectButton.Visible = true;
                    mainTextBox.Text = "�������� �����...";
                    mainTextBox.Size = new Size(244, 23);
                    displayListBox.Items.Remove("��������� �����");
                    displayListBox.Items.Remove("�������� ������");
                    displayListBox.Items.Remove("����� ��������");
                    displayListBox.Items.Remove("������ ��������");
                    displayListBox.Items.Remove("��������� �������");
                    displayListBox.Items.Remove("�����");
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

                        label.Text = "������� ���-���: ";

                        for (int i = 0; i < mainTextBox.Text.Length; i += 5) // ��������� ������ ����� ���������
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
                        displayListBox.Items.Add("��������� �����");
                        displayListBox.Items.Add("�������� ������");
                        displayListBox.Items.Add("����� ��������");
                        displayListBox.Items.Add("������ ��������");
                        displayListBox.Items.Add("��������� �������");
                        displayListBox.Items.Add("�����");
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

        private void NewCardsButtonClick(object sender, MouseEventArgs e) // ������� ����� ������ ����
        {
            if (ATM.NewCardsAmount() == 0)
            {
                MessageBox.Show("��������� ����!");
            }
            else if (ATM.NewCardsAmount() == 1)
            {
                Card card = ATM.ClearContainer()[0];
                MessageBox.Show($"�� �������� �����...\n\n�����: {card.DisplayNumber}\t���-���: {card.Pin}");
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
                MessageBox.Show($"�� ������� �����: {card!.DisplayNumber}");
            }
        }

        private void DigitButtonClick(object sender, MouseEventArgs e) // ���������� � ������ �����
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
                mainTextBox.Text = mainTextBox.Text.Remove(mainTextBox.Text.Length - 1); // �������� ���������� �������
            }
            else if (label.Text.Length > 17 && ATM.State == ATM.ServiceState.NoPin)
            {
                label.Text = label.Text.Remove(label.Text.Length - 1);
                enteredPin = enteredPin.Remove(enteredPin.Length - 1);
            }
        }

        private void MainFormKeyPress(object sender, KeyPressEventArgs e) // ���������� � ����������
        {
            if (Int32.TryParse(e.KeyChar.ToString(), out int _)) // �����
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
            MessageBox.Show($"�� ������� ����� {ejectedCard!.DisplayNumber}");
            ejectButton.Visible = false;
            mainTextBox.Size = new Size(274, 23);
            mainTextBox.Text = "";
        }
    }
}