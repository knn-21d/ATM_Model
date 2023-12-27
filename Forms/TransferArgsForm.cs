using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    public partial class TransferArgsForm : Form
    {
        public TransferArgsForm()
        {
            InitializeComponent();
        }

        private void CardCheckCheckedChanged(object sender, EventArgs e) // протестировать и возможно переименовать
        {
            cardCheck.Checked = true;
            accountCheck.Checked = false;
            addressTextBox.PlaceholderText = "Введите номер счёта...";
        }

        private void AccountCheckCheckedChanged(object sender, EventArgs e) // см. комментарий выше
        {
            accountCheck.Checked = true;
            cardCheck.Checked = false;
            addressTextBox.PlaceholderText = "Введите номер карты...";
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (cardCheck.Checked)
                {
                    ATM.SendMoneyToCard(Convert.ToInt64(addressTextBox.Text), (int)unitsNumericUpDown.Value, (int)centsNumericUpDown.Value);
                }
                else if (accountCheck.Checked)
                {
                    ATM.SendMoneyToAccount(Convert.ToInt32(addressTextBox.Text), (int)unitsNumericUpDown.Value, (int)centsNumericUpDown.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
