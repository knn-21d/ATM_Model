using ATM_Model.Primary_Classes;

namespace ATM_Model.Forms
{
    public partial class ArgsForm : Form
    {
        Account? _account;
        private readonly string _operation;

        //public enum Operation
        //{
        //    CreateAccount,
        //    ReleaseCard,
        //    CashOut,
        //    CashIn,
        //    Transfer
        //}

        public ArgsForm(string operation)
        {
            InitializeComponent();
            _operation = operation;
            Text = operation;

            switch (operation)
            {
                case "Открыть счёт":
                    unitsLabel.Visible = true;
                    centsLabel.Visible = true;
                    unitsNumericUpDown.Visible = true;
                    centsNumericUpDown.Visible = true;
                    instructionLabel.Text = "Зачислить на счёт:";
                    break;
                case "Снять наличные":
                    instructionLabel.Text = "Выберите сумму:";
                    break;
                case "Внести наличные":
                    instructionLabel.Text = "Внесите банкноты:";
                    break;
                case "Отправить перевод":
                    break;
            }

            //switch (op)
            //{
            //    case Operation.CreateAccount:
            //        break;
            //    case Operation.ReleaseCard:
            //        break;
            //    case Operation.CashOut:
            //        break;
            //    case Operation.CashIn:
            //        break;
            //    case Operation.Transfer:
            //        break;

            //}
        }

    }
}
