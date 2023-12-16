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
                        ATM.Authorize(0000);
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
            if (item is null) return;
            else if ((string)item == "�����")
            {
                ATM.EjectCard();
                displayListBox.Items.Remove("����� ��������");
                displayListBox.Items.Remove("������ ��������");
                displayListBox.Items.Remove("��������� �������");
                displayListBox.Items.Remove("�����");
            }
            else
            {
                new ArgsForm((string)item).ShowDialog();
            }
            //switch (item)
            //{
            //    case "������� ����":
            //        // ������� ���� � ������� ����� �� �����
            //        break;
            //    case "��������� �����":
            //        // ������� ���� � ������� ���������� ����
            //        break;
            //    case "����� ��������":
            //        // ������� ���� � ������� �����
            //        break;
            //    case "������ ��������":
            //        // ������� ���� � ��������� ������ �������
            //        break;
            //    case "��������� �������":
            //        // ������� ���� � ��������� ����� � ������
            //        break;
            //    case "�����":
            //        ATM.EjectCard();
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}