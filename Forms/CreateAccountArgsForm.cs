using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    // форма открытия счёта, которая также имитирует загрузку банкнот
    public partial class CreateAccountArgsForm : Form
    {
        public CreateAccountArgsForm()
        {
            InitializeComponent();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Печатать чек?", "Открытие счёта", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) ATM.RequestReceipt();

            int accountId = ATM.CreateAccount(
                (int)fiveThousandsNumericUpDown.Value * 5000 +
                (int)thousandsNumericUpDown.Value * 1000 +
                (int)fiveHundredsNumericUpDown.Value * 500 +
                (int)hundredsNumericUpDown.Value * 100,
                0);

            MessageBox.Show($"Счёт №{accountId} успешно открыт!");
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
