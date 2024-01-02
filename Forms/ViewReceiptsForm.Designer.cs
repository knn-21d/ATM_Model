namespace ATM_Model.Forms
{
    partial class ViewReceiptsForm
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
            viewReceiptsMenuStrip = new MenuStrip();
            label = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // viewReceiptsMenuStrip
            // 
            viewReceiptsMenuStrip.Location = new Point(0, 0);
            viewReceiptsMenuStrip.Name = "viewReceiptsMenuStrip";
            viewReceiptsMenuStrip.Size = new Size(215, 24);
            viewReceiptsMenuStrip.TabIndex = 1;
            viewReceiptsMenuStrip.Text = "menuStrip1";
            viewReceiptsMenuStrip.ItemClicked += ViewReceiptsMenuStripItemClicked;
            // 
            // label
            // 
            label.Location = new Point(12, 24);
            label.Name = "label";
            label.Size = new Size(191, 38);
            label.TabIndex = 2;
            // 
            // okButton
            // 
            okButton.Location = new Point(128, 65);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 3;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButtonClick;
            // 
            // ViewReceiptsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 100);
            Controls.Add(okButton);
            Controls.Add(label);
            Controls.Add(viewReceiptsMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = viewReceiptsMenuStrip;
            MaximizeBox = false;
            MaximumSize = new Size(231, 139);
            MinimizeBox = false;
            MinimumSize = new Size(231, 139);
            Name = "ViewReceiptsForm";
            Text = "Просмотр чеков";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip viewReceiptsMenuStrip;
        private Label label;
        private Button okButton;
    }
}