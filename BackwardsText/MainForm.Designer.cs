namespace BackwardsText
{
    partial class MainForm
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
            this.ReversTextButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.UpperLowerCaseCombo = new System.Windows.Forms.ComboBox();
            this.SpaceLetterPlusButton = new System.Windows.Forms.Button();
            this.SpaceLetterMinusButton = new System.Windows.Forms.Button();
            this.SpaceLettersLabel = new System.Windows.Forms.Label();
            this.ListWordsButton = new System.Windows.Forms.Button();
            this.WordAmountLabel = new System.Windows.Forms.Label();
            this.LetterAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReversTextButton
            // 
            this.ReversTextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReversTextButton.Location = new System.Drawing.Point(12, 21);
            this.ReversTextButton.Name = "ReversTextButton";
            this.ReversTextButton.Size = new System.Drawing.Size(150, 34);
            this.ReversTextButton.TabIndex = 0;
            this.ReversTextButton.Text = "Reverse Text";
            this.ReversTextButton.UseVisualStyleBackColor = true;
            this.ReversTextButton.Click += new System.EventHandler(this.ReversTextButton_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Location = new System.Drawing.Point(12, 61);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(822, 288);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // UpperLowerCaseCombo
            // 
            this.UpperLowerCaseCombo.FormattingEnabled = true;
            this.UpperLowerCaseCombo.Items.AddRange(new object[] {
            "UpperCase",
            "LowerCase"});
            this.UpperLowerCaseCombo.Location = new System.Drawing.Point(332, 21);
            this.UpperLowerCaseCombo.Name = "UpperLowerCaseCombo";
            this.UpperLowerCaseCombo.Size = new System.Drawing.Size(154, 21);
            this.UpperLowerCaseCombo.TabIndex = 3;
            this.UpperLowerCaseCombo.SelectedIndexChanged += new System.EventHandler(this.UpperLowerCaseCombo_SelectedIndexChanged);
            // 
            // SpaceLetterPlusButton
            // 
            this.SpaceLetterPlusButton.Location = new System.Drawing.Point(298, 21);
            this.SpaceLetterPlusButton.Name = "SpaceLetterPlusButton";
            this.SpaceLetterPlusButton.Size = new System.Drawing.Size(28, 34);
            this.SpaceLetterPlusButton.TabIndex = 4;
            this.SpaceLetterPlusButton.Text = "+";
            this.SpaceLetterPlusButton.UseVisualStyleBackColor = true;
            this.SpaceLetterPlusButton.Click += new System.EventHandler(this.SpaceLetterPlusButton_Click);
            // 
            // SpaceLetterMinusButton
            // 
            this.SpaceLetterMinusButton.Location = new System.Drawing.Point(168, 21);
            this.SpaceLetterMinusButton.Name = "SpaceLetterMinusButton";
            this.SpaceLetterMinusButton.Size = new System.Drawing.Size(28, 34);
            this.SpaceLetterMinusButton.TabIndex = 5;
            this.SpaceLetterMinusButton.Text = "-";
            this.SpaceLetterMinusButton.UseVisualStyleBackColor = true;
            this.SpaceLetterMinusButton.Click += new System.EventHandler(this.SpaceLetterMinusButton_Click);
            // 
            // SpaceLettersLabel
            // 
            this.SpaceLettersLabel.AutoSize = true;
            this.SpaceLettersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceLettersLabel.Location = new System.Drawing.Point(198, 30);
            this.SpaceLettersLabel.Name = "SpaceLettersLabel";
            this.SpaceLettersLabel.Size = new System.Drawing.Size(99, 16);
            this.SpaceLettersLabel.TabIndex = 6;
            this.SpaceLettersLabel.Text = "-Space Letters-";
            // 
            // ListWordsButton
            // 
            this.ListWordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListWordsButton.Location = new System.Drawing.Point(492, 21);
            this.ListWordsButton.Name = "ListWordsButton";
            this.ListWordsButton.Size = new System.Drawing.Size(99, 34);
            this.ListWordsButton.TabIndex = 7;
            this.ListWordsButton.Text = "List Words";
            this.ListWordsButton.UseVisualStyleBackColor = true;
            this.ListWordsButton.Click += new System.EventHandler(this.ListWordsButton_Click);
            // 
            // WordAmountLabel
            // 
            this.WordAmountLabel.AutoSize = true;
            this.WordAmountLabel.Location = new System.Drawing.Point(597, 21);
            this.WordAmountLabel.Name = "WordAmountLabel";
            this.WordAmountLabel.Size = new System.Drawing.Size(84, 13);
            this.WordAmountLabel.TabIndex = 8;
            this.WordAmountLabel.Text = "Word Amount: 0";
            // 
            // LetterAmountLabel
            // 
            this.LetterAmountLabel.AutoSize = true;
            this.LetterAmountLabel.Location = new System.Drawing.Point(596, 35);
            this.LetterAmountLabel.Name = "LetterAmountLabel";
            this.LetterAmountLabel.Size = new System.Drawing.Size(85, 13);
            this.LetterAmountLabel.TabIndex = 9;
            this.LetterAmountLabel.Text = "Letter Amount: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 361);
            this.Controls.Add(this.LetterAmountLabel);
            this.Controls.Add(this.WordAmountLabel);
            this.Controls.Add(this.ListWordsButton);
            this.Controls.Add(this.SpaceLettersLabel);
            this.Controls.Add(this.SpaceLetterMinusButton);
            this.Controls.Add(this.SpaceLetterPlusButton);
            this.Controls.Add(this.UpperLowerCaseCombo);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.ReversTextButton);
            this.Name = "MainForm";
            this.Text = "Backwards Text";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReversTextButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.ComboBox UpperLowerCaseCombo;
        private System.Windows.Forms.Button SpaceLetterPlusButton;
        private System.Windows.Forms.Button SpaceLetterMinusButton;
        private System.Windows.Forms.Label SpaceLettersLabel;
        private System.Windows.Forms.Button ListWordsButton;
        private System.Windows.Forms.Label WordAmountLabel;
        private System.Windows.Forms.Label LetterAmountLabel;
    }
}

