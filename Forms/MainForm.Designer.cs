namespace ATM_Model
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            confirmButton = new Button();
            cancelButton = new Button();
            pointButton = new Button();
            zeroButton = new Button();
            tripleZeroButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            mainTextBox = new TextBox();
            displayListBox = new ListBox();
            label = new Label();
            ejectButton = new Button();
            newCardsButton = new Button();
            newCardsAmountLabel = new Label();
            receiptButton = new Button();
            receiptLabel = new Label();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.ForeColor = Color.FromArgb(0, 192, 0);
            confirmButton.Location = new Point(236, 397);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(50, 50);
            confirmButton.TabIndex = 4;
            confirmButton.Text = "✔";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmClick;
            // 
            // cancelButton
            // 
            cancelButton.ForeColor = Color.Red;
            cancelButton.Location = new Point(12, 397);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(50, 50);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "❌";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // pointButton
            // 
            pointButton.Location = new Point(68, 397);
            pointButton.Name = "pointButton";
            pointButton.Size = new Size(50, 50);
            pointButton.TabIndex = 6;
            pointButton.Text = ".";
            pointButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(124, 397);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(50, 50);
            zeroButton.TabIndex = 7;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.MouseClick += DigitButtonClick;
            // 
            // tripleZeroButton
            // 
            tripleZeroButton.Location = new Point(180, 397);
            tripleZeroButton.Name = "tripleZeroButton";
            tripleZeroButton.Size = new Size(50, 50);
            tripleZeroButton.TabIndex = 8;
            tripleZeroButton.Text = "000";
            tripleZeroButton.UseVisualStyleBackColor = true;
            tripleZeroButton.MouseClick += DigitButtonClick;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(180, 341);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(50, 50);
            nineButton.TabIndex = 12;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.MouseClick += DigitButtonClick;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(124, 341);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(50, 50);
            eightButton.TabIndex = 11;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.MouseClick += DigitButtonClick;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(68, 341);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(50, 50);
            sevenButton.TabIndex = 10;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.MouseClick += DigitButtonClick;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(180, 285);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(50, 50);
            sixButton.TabIndex = 16;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.MouseClick += DigitButtonClick;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(124, 285);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(50, 50);
            fiveButton.TabIndex = 15;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.MouseClick += DigitButtonClick;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(68, 285);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(50, 50);
            fourButton.TabIndex = 14;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.MouseClick += DigitButtonClick;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(180, 229);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(50, 50);
            threeButton.TabIndex = 19;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.MouseClick += DigitButtonClick;
            // 
            // twoButton
            // 
            twoButton.Location = new Point(124, 229);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(50, 50);
            twoButton.TabIndex = 18;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.MouseClick += DigitButtonClick;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(68, 229);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(50, 50);
            oneButton.TabIndex = 17;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.MouseClick += DigitButtonClick;
            // 
            // mainTextBox
            // 
            mainTextBox.Enabled = false;
            mainTextBox.Location = new Point(12, 165);
            mainTextBox.Name = "mainTextBox";
            mainTextBox.PlaceholderText = "Вставьте карту...";
            mainTextBox.Size = new Size(274, 23);
            mainTextBox.TabIndex = 20;
            // 
            // displayListBox
            // 
            displayListBox.FormattingEnabled = true;
            displayListBox.ItemHeight = 15;
            displayListBox.Location = new Point(12, 12);
            displayListBox.Name = "displayListBox";
            displayListBox.Size = new Size(276, 124);
            displayListBox.TabIndex = 21;
            displayListBox.MouseDoubleClick += DisplayListBoxDoubleClick;
            // 
            // label
            // 
            label.Location = new Point(12, 139);
            label.Name = "label";
            label.Size = new Size(274, 23);
            label.TabIndex = 22;
            // 
            // ejectButton
            // 
            ejectButton.Location = new Point(262, 165);
            ejectButton.Name = "ejectButton";
            ejectButton.Size = new Size(26, 23);
            ejectButton.TabIndex = 23;
            ejectButton.Text = "⏏";
            ejectButton.UseVisualStyleBackColor = true;
            ejectButton.Visible = false;
            ejectButton.Click += EjectButtonClick;
            ejectButton.MouseClick += EjectButtonClick;
            // 
            // newCardsButton
            // 
            newCardsButton.Image = (Image)resources.GetObject("newCardsButton.Image");
            newCardsButton.Location = new Point(12, 194);
            newCardsButton.Name = "newCardsButton";
            newCardsButton.Size = new Size(42, 42);
            newCardsButton.TabIndex = 24;
            newCardsButton.UseVisualStyleBackColor = true;
            newCardsButton.MouseClick += NewCardsButtonClick;
            // 
            // newCardsAmountLabel
            // 
            newCardsAmountLabel.BackColor = Color.Transparent;
            newCardsAmountLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            newCardsAmountLabel.ForeColor = Color.Red;
            newCardsAmountLabel.Location = new Point(35, 221);
            newCardsAmountLabel.Name = "newCardsAmountLabel";
            newCardsAmountLabel.Size = new Size(19, 15);
            newCardsAmountLabel.TabIndex = 25;
            newCardsAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            newCardsAmountLabel.Visible = false;
            // 
            // receiptButton
            // 
            receiptButton.Image = (Image)resources.GetObject("receiptButton.Image");
            receiptButton.Location = new Point(246, 194);
            receiptButton.Name = "receiptButton";
            receiptButton.Size = new Size(42, 42);
            receiptButton.TabIndex = 26;
            receiptButton.UseVisualStyleBackColor = true;
            receiptButton.MouseClick += ReceiptButtonClick;
            // 
            // receiptLabel
            // 
            receiptLabel.BackColor = Color.Transparent;
            receiptLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            receiptLabel.ForeColor = Color.Red;
            receiptLabel.Location = new Point(273, 221);
            receiptLabel.Name = "receiptLabel";
            receiptLabel.Size = new Size(15, 15);
            receiptLabel.TabIndex = 27;
            receiptLabel.Text = "!";
            receiptLabel.TextAlign = ContentAlignment.MiddleCenter;
            receiptLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 459);
            Controls.Add(receiptLabel);
            Controls.Add(receiptButton);
            Controls.Add(newCardsAmountLabel);
            Controls.Add(newCardsButton);
            Controls.Add(ejectButton);
            Controls.Add(label);
            Controls.Add(displayListBox);
            Controls.Add(mainTextBox);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(tripleZeroButton);
            Controls.Add(zeroButton);
            Controls.Add(pointButton);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            KeyPreview = true;
            Name = "MainForm";
            Text = "ATM_Model";
            KeyPress += MainFormKeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button pointButton;
        private Button zeroButton;
        private Button tripleZeroButton;
        private Button confirmButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private TextBox mainTextBox;
        private ListBox displayListBox;
        private Label label;
        private Button ejectButton;
        private Button newCardsButton;
        private Label newCardsAmountLabel;
        private Button receiptButton;
        private Label receiptLabel;
    }
}