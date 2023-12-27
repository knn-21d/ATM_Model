using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    public partial class CashInArgsForm : Form
    {
        public CashInArgsForm()
        {
            InitializeComponent();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Печатать чек?", "Внесение наличных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) ATM.RequestReceipt();
            ATM.CashToBalance((int)fiveThousandsNumericUpDown.Value, (int)thousandsNumericUpDown.Value, (int)fiveHundredsNumericUpDown.Value, (int)hundredsNumericUpDown.Value);
            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
