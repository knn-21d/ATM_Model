using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    // форма перевода средств
    public partial class TransferArgsForm : Form
    {
        public TransferArgsForm()
        {
            InitializeComponent();
            cardCheck.Checked = true;
            addressTextBox.PlaceholderText = "Введите номер карты...";
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (cardCheck.Checked) // перевод на карту
                {
                    ATM.SendMoneyToCard(Convert.ToInt64(addressTextBox.Text), (int)unitsNumericUpDown.Value, (int)centsNumericUpDown.Value);
                }
                else if (accountCheck.Checked) // перевод по счёту
                {
                    ATM.SendMoneyToAccount(Convert.ToInt32(addressTextBox.Text), (int)unitsNumericUpDown.Value, (int)centsNumericUpDown.Value);
                }
                MessageBox.Show("Перевод успешно отправлен!");
                addressTextBox.Clear();
                unitsNumericUpDown.Value = 0;
                centsNumericUpDown.Value = 0;
            }
            catch (Exception ex) // средств может не хватить
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AccountCheckMouseClick(object sender, MouseEventArgs e) // перевод по счёту
        {
            accountCheck.Checked = true;
            cardCheck.Checked = false;
            addressTextBox.PlaceholderText = "Введите номер счёта...";
        }

        private void CardCheckMouseClick(object sender, MouseEventArgs e) // перевод по карте
        {
            accountCheck.Checked = false;
            cardCheck.Checked = true;
            addressTextBox.PlaceholderText = "Введите номер карты...";
        }
    }
}
