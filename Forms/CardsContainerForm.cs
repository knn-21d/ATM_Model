using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    // форма имитирует лоток для выдачи новых карт
    public partial class CardsContainerForm : Form
    {
        public CardsContainerForm(List<Card> content)
        {
            InitializeComponent();
            cardsDataGridView.DataSource = content;
            cardsDataGridView.Columns[0].HeaderText = "Number";
            cardsDataGridView.Columns[0].Width = 120;
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
