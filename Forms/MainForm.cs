using ATM_Model.Forms;
using ATM_Model.Primary_Classes;

namespace ATM_Model
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayListBox.Items.Add("Открыть счёт");
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
                    displayListBox.Items.Add("Выпустить карту");
                    displayListBox.Items.Add("Снять наличные");
                    displayListBox.Items.Add("Внести наличные");
                    displayListBox.Items.Add("Отправить перевод");
                    displayListBox.Items.Add("Выход");
                    break;
            }
        }

        private void DisplayListBoxDoubleClick(object sender, MouseEventArgs e)
        {
            int index = displayListBox.IndexFromPoint(e.Location);
            var item = index == -1 || index >= displayListBox.Items.Count ? null : displayListBox.Items[index];

            switch (item)
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
                    ATM.EjectCard();
                    displayListBox.Items.Remove("Снять наличные");
                    displayListBox.Items.Remove("Внести наличные");
                    displayListBox.Items.Remove("Отправить перевод");
                    displayListBox.Items.Remove("Выход");
                    break;
                default:
                    return;
            }
        }

        private void NewCardsButtonClick(object sender, EventArgs e)
        {
            if (ATM.NewCardsAmount() == 0)
            {
                MessageBox.Show("Контейнер пуст!");
            }
            else
            {
                new CardsContainerForm(ATM.ClearContainer()).ShowDialog();
                newCardsAmountLabel.Visible = false;
            }
        }
    }
}