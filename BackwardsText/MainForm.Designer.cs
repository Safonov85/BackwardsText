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
            this.SpaceLettersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReversTextButton
            // 
            this.ReversTextButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.richTextBox.Size = new System.Drawing.Size(474, 288);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // SpaceLettersButton
            // 
            this.SpaceLettersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SpaceLettersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpaceLettersButton.Location = new System.Drawing.Point(168, 21);
            this.SpaceLettersButton.Name = "SpaceLettersButton";
            this.SpaceLettersButton.Size = new System.Drawing.Size(157, 34);
            this.SpaceLettersButton.TabIndex = 2;
            this.SpaceLettersButton.Text = "Space Letters";
            this.SpaceLettersButton.UseVisualStyleBackColor = true;
            this.SpaceLettersButton.Click += new System.EventHandler(this.SpaceLettersButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 361);
            this.Controls.Add(this.SpaceLettersButton);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.ReversTextButton);
            this.Name = "MainForm";
            this.Text = "Backwards Text";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReversTextButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button SpaceLettersButton;
    }
}

