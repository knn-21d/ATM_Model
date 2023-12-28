using ATM_Model.Forms;
using ATM_Model.Primary_Classes;

namespace ATM_Model
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayListBox.Items.Add("������� ����");
        }
        ATM.ServiceState state = ATM.State;

        private void ConfirmClick(object sender, EventArgs e)
        {
            switch (state)
            {
                case ATM.ServiceState.NoCard:
                    try
                    {
                        ATM.InsertCard(Convert.ToInt64(cardTextBox.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case ATM.ServiceState.NoPin:
                    try
                    {
                        ATM.Authorize("");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    displayListBox.Items.Add("��������� �����");
                    displayListBox.Items.Add("����� ��������");
                    displayListBox.Items.Add("������ ��������");
                    displayListBox.Items.Add("��������� �������");
                    displayListBox.Items.Add("�����");
                    break;
            }
        }

        private void DisplayListBoxDoubleClick(object sender, MouseEventArgs e)
        {
            int index = displayListBox.IndexFromPoint(e.Location);
            var item = index == -1 || index >= displayListBox.Items.Count ? null : displayListBox.Items[index];

            switch (item)
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
                    ATM.EjectCard();
                    displayListBox.Items.Remove("����� ��������");
                    displayListBox.Items.Remove("������ ��������");
                    displayListBox.Items.Remove("��������� �������");
                    displayListBox.Items.Remove("�����");
                    break;
                default:
                    return;
            }
        }

        private void NewCardsButtonClick(object sender, EventArgs e)
        {
            if (ATM.NewCardsAmount() == 0)
            {
                MessageBox.Show("��������� ����!");
            }
            else
            {
                new CardsContainerForm(ATM.ClearContainer()).ShowDialog();
                newCardsAmountLabel.Visible = false;
            }
        }
    }
}