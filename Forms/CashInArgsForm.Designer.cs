namespace ATM_Model.Forms
{
    partial class CashInArgsForm
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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            instructionLabel = new Label();
            cancelButton = new Button();
            okButton = new Button();
            hundredsNumericUpDown = new NumericUpDown();
            fiveThousandsNumericUpDown = new NumericUpDown();
            thousandsNumericUpDown = new NumericUpDown();
            fiveHundredsNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)hundredsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveThousandsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)thousandsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fiveHundredsNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(161, 40);
            label4.Name = "label4";
            label4.Size = new Size(25, 15);
            label4.TabIndex = 35;
            label4.Text = "100";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 40);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 34;
            label3.Text = "500";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 40);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 33;
            label2.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 32;
            label1.Text = "5000";
            // 
            // instructionLabel
            // 
            instructionLabel.Location = new Point(12, 9);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(191, 31);
            instructionLabel.TabIndex = 31;
            instructionLabel.Text = "Загрузите банкноты для пополнения счёта:";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(128, 87);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 30;
            cancelButton.Text = "Отменить";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButtonClick;
            // 
            // okButton
            // 
            okButton.Location = new Point(12, 87);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 29;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // hundredsNumericUpDown
            // 
            hundredsNumericUpDown.Enabled = false;
            hundredsNumericUpDown.Location = new Point(161, 58);
            hundredsNumericUpDown.Name = "hundredsNumericUpDown";
            hundredsNumericUpDown.Size = new Size(42, 23);
            hundredsNumericUpDown.TabIndex = 28;
            // 
            // fiveThousandsNumericUpDown
            // 
            fiveThousandsNumericUpDown.Enabled = false;
            fiveThousandsNumericUpDown.Location = new Point(12, 58);
            fiveThousandsNumericUpDown.Name = "fiveThousandsNumericUpDown";
            fiveThousandsNumericUpDown.Size = new Size(42, 23);
            fiveThousandsNumericUpDown.TabIndex = 27;
            // 
            // thousandsNumericUpDown
            // 
            thousandsNumericUpDown.Enabled = false;
            thousandsNumericUpDown.Location = new Point(60, 58);
            thousandsNumericUpDown.Name = "thousandsNumericUpDown";
            thousandsNumericUpDown.Size = new Size(42, 23);
            thousandsNumericUpDown.TabIndex = 26;
            // 
            // fiveHundredsNumericUpDown
            // 
            fiveHundredsNumericUpDown.Enabled = false;
            fiveHundredsNumericUpDown.Location = new Point(113, 58);
            fiveHundredsNumericUpDown.Name = "fiveHundredsNumericUpDown";
            fiveHundredsNumericUpDown.Size = new Size(42, 23);
            fiveHundredsNumericUpDown.TabIndex = 25;
            // 
            // CashInArgsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 120);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(instructionLabel);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(hundredsNumericUpDown);
            Controls.Add(fiveThousandsNumericUpDown);
            Controls.Add(thousandsNumericUpDown);
            Controls.Add(fiveHundredsNumericUpDown);
            MaximizeBox = false;
            MaximumSize = new Size(231, 159);
            MinimizeBox = false;
            MinimumSize = new Size(231, 159);
            Name = "CashInArgsForm";
            Text = "Внесение наличных";
            ((System.ComponentModel.ISupportInitialize)hundredsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveThousandsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)thousandsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fiveHundredsNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label instructionLabel;
        private Button cancelButton;
        private Button okButton;
        private NumericUpDown hundredsNumericUpDown;
        private NumericUpDown fiveThousandsNumericUpDown;
        private NumericUpDown thousandsNumericUpDown;
        private NumericUpDown fiveHundredsNumericUpDown;
    }
}