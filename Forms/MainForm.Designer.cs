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
            confirmButton = new Button();
            cancelButton = new Button();
            pointButton = new Button();
            zeroButton = new Button();
            tripleZeroButton = new Button();
            rightArrowButton = new Button();
            nineButton = new Button();
            eightButton = new Button();
            sevenButton = new Button();
            leftArrowButton = new Button();
            sixButton = new Button();
            fiveButton = new Button();
            fourButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            cardTextBox = new TextBox();
            displayListBox = new ListBox();
            label = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // confirmButton
            // 
            confirmButton.ForeColor = Color.FromArgb(0, 192, 0);
            confirmButton.Location = new Point(238, 359);
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
            cancelButton.Location = new Point(12, 359);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(50, 50);
            cancelButton.TabIndex = 5;
            cancelButton.Text = "❌";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // pointButton
            // 
            pointButton.Location = new Point(68, 359);
            pointButton.Name = "pointButton";
            pointButton.Size = new Size(50, 50);
            pointButton.TabIndex = 6;
            pointButton.Text = ".";
            pointButton.UseVisualStyleBackColor = true;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(124, 359);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(50, 50);
            zeroButton.TabIndex = 7;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            // 
            // tripleZeroButton
            // 
            tripleZeroButton.Location = new Point(180, 359);
            tripleZeroButton.Name = "tripleZeroButton";
            tripleZeroButton.Size = new Size(50, 50);
            tripleZeroButton.TabIndex = 8;
            tripleZeroButton.Text = "000";
            tripleZeroButton.UseVisualStyleBackColor = true;
            // 
            // rightArrowButton
            // 
            rightArrowButton.Location = new Point(236, 303);
            rightArrowButton.Name = "rightArrowButton";
            rightArrowButton.Size = new Size(50, 50);
            rightArrowButton.TabIndex = 13;
            rightArrowButton.Text = "→";
            rightArrowButton.UseVisualStyleBackColor = true;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(180, 303);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(50, 50);
            nineButton.TabIndex = 12;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(124, 303);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(50, 50);
            eightButton.TabIndex = 11;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(68, 303);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(50, 50);
            sevenButton.TabIndex = 10;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            // 
            // leftArrowButton
            // 
            leftArrowButton.Location = new Point(12, 303);
            leftArrowButton.Name = "leftArrowButton";
            leftArrowButton.Size = new Size(50, 50);
            leftArrowButton.TabIndex = 9;
            leftArrowButton.Text = "←";
            leftArrowButton.UseVisualStyleBackColor = true;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(180, 247);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(50, 50);
            sixButton.TabIndex = 16;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(124, 247);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(50, 50);
            fiveButton.TabIndex = 15;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(68, 247);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(50, 50);
            fourButton.TabIndex = 14;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(180, 191);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(50, 50);
            threeButton.TabIndex = 19;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            // 
            // twoButton
            // 
            twoButton.Location = new Point(124, 191);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(50, 50);
            twoButton.TabIndex = 18;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(68, 191);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(50, 50);
            oneButton.TabIndex = 17;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            // 
            // cardTextBox
            // 
            cardTextBox.Location = new Point(12, 162);
            cardTextBox.Name = "cardTextBox";
            cardTextBox.PlaceholderText = "Вставьте карту...";
            cardTextBox.Size = new Size(244, 23);
            cardTextBox.TabIndex = 20;
            // 
            // displayListBox
            // 
            displayListBox.FormattingEnabled = true;
            displayListBox.ItemHeight = 15;
            displayListBox.Location = new Point(12, 12);
            displayListBox.Name = "displayListBox";
            displayListBox.Size = new Size(274, 124);
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
            // button1
            // 
            button1.Location = new Point(262, 162);
            button1.Name = "button1";
            button1.Size = new Size(26, 23);
            button1.TabIndex = 23;
            button1.Text = "⏏";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 421);
            Controls.Add(button1);
            Controls.Add(label);
            Controls.Add(displayListBox);
            Controls.Add(cardTextBox);
            Controls.Add(threeButton);
            Controls.Add(twoButton);
            Controls.Add(oneButton);
            Controls.Add(sixButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(rightArrowButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(leftArrowButton);
            Controls.Add(tripleZeroButton);
            Controls.Add(zeroButton);
            Controls.Add(pointButton);
            Controls.Add(cancelButton);
            Controls.Add(confirmButton);
            Name = "MainForm";
            Text = "ATM_Model";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button pointButton;
        private Button zeroButton;
        private Button tripleZeroButton;
        private Button confirmButton;
        private Button rightArrowButton;
        private Button nineButton;
        private Button eightButton;
        private Button sevenButton;
        private Button leftArrowButton;
        private Button sixButton;
        private Button fiveButton;
        private Button fourButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private TextBox cardTextBox;
        private ListBox displayListBox;
        private Label label;
        private Button button1;
    }
}