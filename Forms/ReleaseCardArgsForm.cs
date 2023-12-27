using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    public partial class ReleaseCardArgsForm : Form
    {
        public ReleaseCardArgsForm()
        {
            InitializeComponent();
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            try
            {
                ATM.ReleaseCard((int)cardsAmountNumericUpDown.Value);
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
