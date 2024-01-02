namespace ATM_Model.Forms
{
    public partial class ViewReceiptsForm : Form
    {
        List<string> _receipts;
        public ViewReceiptsForm(List<string> receipts)
        {
            _receipts = new(receipts);

            InitializeComponent();

            for (int i = 0; i < receipts.Count; i++)
            {
                viewReceiptsMenuStrip.Items.Add($"{i + 1}");
            }

            label.Text = receipts[0];
        }

        private void ViewReceiptsMenuStripItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            label.Text = _receipts[Int32.Parse(e.ClickedItem!.Text) - 1];
        }

        private void OkButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
