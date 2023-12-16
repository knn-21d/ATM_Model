namespace ATM_Model.Forms
{
    partial class ArgsForm
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
            unitsLabel = new Label();
            unitsNumericUpDown = new NumericUpDown();
            centsNumericUpDown = new NumericUpDown();
            centsLabel = new Label();
            instructionLabel = new Label();
            okButton = new Button();
            cancelButton = new Button();
            cashOutNumericUpDown = new NumericUpDown();
            fiveThousandsNumericUpDown = new NumericUpDown();
            hundredsNumericUpDown = new NumericUpDown();
            thousandsNumericUpDown = new NumericUpDown();
            fiveHundredsNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)unitsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cashOutNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveThousandsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hundredsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thousandsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveHundredsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Location = new Point(103, 45);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Size = new Size(22, 15);
            unitsLabel.TabIndex = 2;
            unitsLabel.Text = "ед.";
            unitsLabel.Visible = false;
            // 
            // unitsNumericUpDown
            // 
            unitsNumericUpDown.Location = new Point(12, 43);
            unitsNumericUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            unitsNumericUpDown.Name = "unitsNumericUpDown";
            unitsNumericUpDown.Size = new Size(85, 23);
            unitsNumericUpDown.TabIndex = 3;
            unitsNumericUpDown.Visible = false;
            // 
            // centsNumericUpDown
            // 
            centsNumericUpDown.Location = new Point(131, 43);
            centsNumericUpDown.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            centsNumericUpDown.Name = "centsNumericUpDown";
            centsNumericUpDown.Size = new Size(38, 23);
            centsNumericUpDown.TabIndex = 4;
            centsNumericUpDown.Visible = false;
            // 
            // centsLabel
            // 
            centsLabel.AutoSize = true;
            centsLabel.Location = new Point(175, 45);
            centsLabel.Name = "centsLabel";
            centsLabel.Size = new Size(28, 15);
            centsLabel.TabIndex = 5;
            centsLabel.Text = "сот.";
            centsLabel.Visible = false;
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Location = new Point(12, 25);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(111, 15);
            instructionLabel.TabIndex = 6;
            instructionLabel.Text = "Зачислить на счёт:";
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 72);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 7;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(128, 72);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // cashOutNumericUpDown
            // 
            cashOutNumericUpDown.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            cashOutNumericUpDown.Location = new Point(49, 43);
            cashOutNumericUpDown.Maximum = new decimal(new int[] { 2147483600, 0, 0, 0 });
            cashOutNumericUpDown.Name = "cashOutNumericUpDown";
            cashOutNumericUpDown.Size = new Size(120, 23);
            cashOutNumericUpDown.TabIndex = 9;
            cashOutNumericUpDown.Visible = false;
            // 
            // fiveThousandsNumericUpDown
            // 
            fiveThousandsNumericUpDown.Enabled = false;
            fiveThousandsNumericUpDown.Location = new Point(12, 43);
            fiveThousandsNumericUpDown.Name = "fiveThousandsNumericUpDown";
            fiveThousandsNumericUpDown.Size = new Size(42, 23);
            fiveThousandsNumericUpDown.TabIndex = 10;
            fiveThousandsNumericUpDown.Visible = false;
            // 
            // hundredsNumericUpDown
            // 
            hundredsNumericUpDown.Enabled = false;
            hundredsNumericUpDown.Location = new Point(161, 43);
            hundredsNumericUpDown.Name = "hundredsNumericUpDown";
            hundredsNumericUpDown.Size = new Size(42, 23);
            hundredsNumericUpDown.TabIndex = 11;
            hundredsNumericUpDown.Visible = false;
            // 
            // thousandsNumericUpDown
            // 
            thousandsNumericUpDown.Enabled = false;
            thousandsNumericUpDown.Location = new Point(60, 43);
            thousandsNumericUpDown.Name = "thousandsNumericUpDown";
            thousandsNumericUpDown.Size = new Size(42, 23);
            thousandsNumericUpDown.TabIndex = 12;
            thousandsNumericUpDown.Visible = false;
            // 
            // fiveHundredsNumericUpDown
            // 
            fiveHundredsNumericUpDown.Enabled = false;
            fiveHundredsNumericUpDown.Location = new Point(113, 43);
            fiveHundredsNumericUpDown.Name = "fiveHundredsNumericUpDown";
            fiveHundredsNumericUpDown.Size = new Size(42, 23);
            fiveHundredsNumericUpDown.TabIndex = 13;
            fiveHundredsNumericUpDown.Visible = false;
            // 
            // ArgsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 100);
            Controls.Add(fiveHundredsNumericUpDown);
            Controls.Add(thousandsNumericUpDown);
            Controls.Add(hundredsNumericUpDown);
            Controls.Add(fiveThousandsNumericUpDown);
            Controls.Add(cashOutNumericUpDown);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(instructionLabel);
            Controls.Add(centsLabel);
            Controls.Add(centsNumericUpDown);
            Controls.Add(unitsNumericUpDown);
            Controls.Add(unitsLabel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ArgsForm";
            Text = "ArgsForm";
            ((System.ComponentModel.ISupportInitialize)unitsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)centsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)cashOutNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveThousandsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)hundredsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)thousandsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveHundredsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unitsTextBox;
        private TextBox textBox1;
        private Label unitsLabel;
        private NumericUpDown unitsNumericUpDown;
        private NumericUpDown centsNumericUpDown;
        private Label centsLabel;
        private Label instructionLabel;
        private Button okButton;
        private Button cancelButton;
        private NumericUpDown cashOutNumericUpDown;
        private NumericUpDown fiveThousandsNumericUpDown;
        private NumericUpDown hundredsNumericUpDown;
        private NumericUpDown thousandsNumericUpDown;
        private NumericUpDown fiveHundredsNumericUpDown;
    }
}