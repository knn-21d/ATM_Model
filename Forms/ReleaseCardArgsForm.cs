using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    // форма выпуска карт
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
                ATM.ReleaseCard((int)cardsAmountNumericUpDown.Value); // в метод передаётся запрашиваемое количество карт
                Close();
            }
            catch (Exception ex) // готовых к выдаче карт может не хватать
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
