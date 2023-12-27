using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    public partial class CashOutArgsForm : Form
    {
        public CashOutArgsForm()
        {
            InitializeComponent();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Печатать чек?", "Снятие наличных", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) ATM.RequestReceipt();

            try
            {
                ATM.CashFromBalance((int)cashOutNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
