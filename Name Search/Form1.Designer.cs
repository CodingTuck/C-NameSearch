namespace Name_Search
{
    partial class Form1
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
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.girlTextBox = new System.Windows.Forms.TextBox();
            this.boyLabel = new System.Windows.Forms.Label();
            this.girlLabel = new System.Windows.Forms.Label();
            this.checkNameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(37, 67);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(151, 20);
            this.boyTextBox.TabIndex = 0;
            // 
            // girlTextBox
            // 
            this.girlTextBox.Location = new System.Drawing.Point(194, 67);
            this.girlTextBox.Name = "girlTextBox";
            this.girlTextBox.Size = new System.Drawing.Size(151, 20);
            this.girlTextBox.TabIndex = 1;
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.Location = new System.Drawing.Point(91, 51);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(56, 13);
            this.boyLabel.TabIndex = 2;
            this.boyLabel.Text = "Boy Name";
            // 
            // girlLabel
            // 
            this.girlLabel.AutoSize = true;
            this.girlLabel.Location = new System.Drawing.Point(244, 51);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(53, 13);
            this.girlLabel.TabIndex = 3;
            this.girlLabel.Text = "Girl Name";
            // 
            // checkNameButton
            // 
            this.checkNameButton.Location = new System.Drawing.Point(94, 112);
            this.checkNameButton.Name = "checkNameButton";
            this.checkNameButton.Size = new System.Drawing.Size(91, 50);
            this.checkNameButton.TabIndex = 4;
            this.checkNameButton.Text = "Check Name For Top 200";
            this.checkNameButton.UseVisualStyleBackColor = true;
            this.checkNameButton.Click += new System.EventHandler(this.checkNameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(194, 112);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 50);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 174);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkNameButton);
            this.Controls.Add(this.girlLabel);
            this.Controls.Add(this.boyLabel);
            this.Controls.Add(this.girlTextBox);
            this.Controls.Add(this.boyTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox girlTextBox;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.Button checkNameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

