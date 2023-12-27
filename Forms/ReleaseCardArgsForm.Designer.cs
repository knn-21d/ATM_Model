namespace ATM_Model.Forms
{
    partial class ReleaseCardArgsForm
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
            cancelButton = new Button();
            okButton = new Button();
            InstructionLabel = new Label();
            cardsAmountNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cardsAmountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(128, 65);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButtonClick;
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 65);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 16;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // InstructionLabel
            // 
            InstructionLabel.Location = new Point(12, 9);
            InstructionLabel.Name = "InstructionLabel";
            InstructionLabel.Size = new Size(164, 19);
            InstructionLabel.TabIndex = 15;
            InstructionLabel.Text = "Выберите количество";
            // 
            // cardsAmountNumericUpDown
            // 
            cardsAmountNumericUpDown.Location = new Point(12, 31);
            cardsAmountNumericUpDown.Maximum = new decimal(new int[] { 2147483600, 0, 0, 0 });
            cardsAmountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cardsAmountNumericUpDown.Name = "cardsAmountNumericUpDown";
            cardsAmountNumericUpDown.Size = new Size(191, 23);
            cardsAmountNumericUpDown.TabIndex = 14;
            cardsAmountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ReleaseCardArgsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 100);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(InstructionLabel);
            Controls.Add(cardsAmountNumericUpDown);
            MaximizeBox = false;
            MaximumSize = new Size(231, 139);
            MinimizeBox = false;
            MinimumSize = new Size(231, 139);
            Name = "ReleaseCardArgsForm";
            Text = "Выпуск карт";
            ((System.ComponentModel.ISupportInitialize)cardsAmountNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cancelButton;
        private Button okButton;
        private Label InstructionLabel;
        private NumericUpDown cardsAmountNumericUpDown;
    }
}