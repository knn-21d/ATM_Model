namespace ATM_Model.Forms
{
    partial class CashOutArgsForm
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
            cashOutNumericUpDown = new NumericUpDown();
            InstructionLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cashOutNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cashOutNumericUpDown
            // 
            cashOutNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            cashOutNumericUpDown.Location = new Point(12, 31);
            cashOutNumericUpDown.Maximum = new decimal(new int[] { 2147483600, 0, 0, 0 });
            cashOutNumericUpDown.Name = "cashOutNumericUpDown";
            cashOutNumericUpDown.Size = new Size(191, 23);
            cashOutNumericUpDown.TabIndex = 10;
            cashOutNumericUpDown.ValueChanged += CashOutNumericUpDownValueChanged;
            // 
            // InstructionLabel
            // 
            InstructionLabel.Location = new Point(12, 9);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(164, 19);
            InstructionLabel.TabIndex = 11;
            InstructionLabel.Text = "Выберите сумму";
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 65);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 12;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(128, 65);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 13;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButtonClick;
            // 
            // CashOutArgsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 100);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(InstructionLabel);
            Controls.Add(cashOutNumericUpDown);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(231, 139);
            MinimizeBox = false;
            MinimumSize = new Size(231, 139);
            Name = "CashOutArgsForm";
            Text = "Снятие наличных";
            ((System.ComponentModel.ISupportInitialize)cashOutNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown cashOutNumericUpDown;
        private Label InstructionLabel;
        private Button okButton;
        private Button cancelButton;
    }
}