namespace ATM_Model.Forms
{
    partial class TransferArgsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            accountCheck = new RadioButton();
            cardCheck = new RadioButton();
            addressTextBox = new TextBox();
            cancelButton = new Button();
            okButton = new Button();
            centsNumericUpDown = new NumericUpDown();
            unitsNumericUpDown = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)centsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // accountCheck
            // 
            accountCheck.AutoSize = true;
            accountCheck.Location = new Point(111, 12);
            accountCheck.Name = "accountCheck";
            accountCheck.Size = new Size(74, 19);
            accountCheck.TabIndex = 21;
            accountCheck.TabStop = true;
            accountCheck.Text = "По счёту";
            accountCheck.UseVisualStyleBackColor = true;
            accountCheck.MouseClick += AccountCheckMouseClick;
            // 
            // cardCheck
            // 
            cardCheck.AutoCheck = false;
            cardCheck.AutoSize = true;
            cardCheck.Location = new Point(12, 12);
            cardCheck.Name = "cardCheck";
            cardCheck.Size = new Size(74, 19);
            cardCheck.TabIndex = 20;
            cardCheck.TabStop = true;
            cardCheck.Text = "По карте";
            cardCheck.UseVisualStyleBackColor = true;
            cardCheck.MouseClick += CardCheckMouseClick;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 37);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(191, 23);
            addressTextBox.TabIndex = 19;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(128, 108);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 18;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButtonClick;
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 108);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 17;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // centsNumericUpDown
            // 
            centsNumericUpDown.Location = new Point(128, 66);
            centsNumericUpDown.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            centsNumericUpDown.Name = "centsNumericUpDown";
            centsNumericUpDown.Size = new Size(37, 23);
            centsNumericUpDown.TabIndex = 22;
            // 
            // unitsNumericUpDown
            // 
            unitsNumericUpDown.Location = new Point(11, 66);
            unitsNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            unitsNumericUpDown.Name = "unitsNumericUpDown";
            unitsNumericUpDown.Size = new Size(76, 23);
            unitsNumericUpDown.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 74);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 24;
            label1.Text = "ед.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 74);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 25;
            label2.Text = "сот.";
            // 
            // TransferArgsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 143);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(unitsNumericUpDown);
            Controls.Add(centsNumericUpDown);
            Controls.Add(accountCheck);
            Controls.Add(cardCheck);
            Controls.Add(addressTextBox);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TransferArgsForm";
            Text = "Отправить перевод";
            ((System.ComponentModel.ISupportInitialize)centsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton accountCheck;
        private RadioButton cardCheck;
        private TextBox addressTextBox;
        private Button cancelButton;
        private Button okButton;
        private NumericUpDown centsNumericUpDown;
        private NumericUpDown unitsNumericUpDown;
        private Label label1;
        private Label label2;
    }
}