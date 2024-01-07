using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    // форма снятия наличных
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
                Close();
            }
            catch (Exception ex) // если недостаточно банкнот в аппарате или средств на счёте
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CashOutNumericUpDownValueChanged(object sender, EventArgs e)
        {
            cashOutNumericUpDown.Value -= cashOutNumericUpDown.Value % 100; // запрашиваемая сумма всегда будет кратна 100
        }
    }
}
