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
                        ATM.Authorize(0000);
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
            if (item is null) return;
            else if ((string)item == "Выход")
            {
                ATM.EjectCard();
                displayListBox.Items.Remove("Снять наличные");
                displayListBox.Items.Remove("Внести наличные");
                displayListBox.Items.Remove("Отправить перевод");
                displayListBox.Items.Remove("Выход");
            }
            else
            {
                new ArgsForm((string)item).ShowDialog();
            }
            //switch (item)
            //{
            //    case "Открыть счёт":
            //        // создать окно с выбором суммы на счету
            //        break;
            //    case "Выпустить карту":
            //        // создать окно с выбором количества карт
            //        break;
            //    case "Снять наличные":
            //        // создать окно с выбором суммы
            //        break;
            //    case "Внести наличные":
            //        // создать окно с указанием набора банкнот
            //        break;
            //    case "Отправить перевод":
            //        // создать окно с указанием суммы и адреса
            //        break;
            //    case "Выход":
            //        ATM.EjectCard();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}