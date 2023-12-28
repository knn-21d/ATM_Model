namespace ATM_Model.Forms
{
    partial class CardsContainerForm
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
            cardsDataGridView = new DataGridView();
            label1 = new Label();
            okButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // cardsDataGridView
            // 
            cardsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cardsDataGridView.Location = new Point(12, 27);
            cardsDataGridView.Name = "cardsDataGridView";
            cardsDataGridView.RowTemplate.Height = 25;
            cardsDataGridView.Size = new Size(279, 189);
            cardsDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 1;
            label1.Text = "Вы забрали карты:";
            // 
            // okButton
            // 
            okButton.Location = new Point(216, 222);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // CardsContainerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 257);
            Controls.Add(okButton);
            Controls.Add(label1);
            Controls.Add(cardsDataGridView);
            Name = "CardsContainerForm";
            Text = "CardsContainerForm";
            ((System.ComponentModel.ISupportInitialize)cardsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView cardsDataGridView;
        private Label label1;
        private Button okButton;
    }
}