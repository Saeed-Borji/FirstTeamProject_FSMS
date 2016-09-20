namespace MyApplication
{
    partial class ChangeForm
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
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPaswordLabel = new System.Windows.Forms.Label();
            this.ReEnterNewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ReNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(12, 9);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(118, 13);
            this.OldPasswordLabel.TabIndex = 0;
            this.OldPasswordLabel.Text = "&Enter   old      password";
            this.OldPasswordLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NewPaswordLabel
            // 
            this.NewPaswordLabel.AutoSize = true;
            this.NewPaswordLabel.Location = new System.Drawing.Point(12, 38);
            this.NewPaswordLabel.Name = "NewPaswordLabel";
            this.NewPaswordLabel.Size = new System.Drawing.Size(118, 13);
            this.NewPaswordLabel.TabIndex = 2;
            this.NewPaswordLabel.Text = "&Enter   new    password";
            // 
            // ReEnterNewPasswordLabel
            // 
            this.ReEnterNewPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReEnterNewPasswordLabel.AutoSize = true;
            this.ReEnterNewPasswordLabel.Location = new System.Drawing.Point(12, 68);
            this.ReEnterNewPasswordLabel.Name = "ReEnterNewPasswordLabel";
            this.ReEnterNewPasswordLabel.Size = new System.Drawing.Size(119, 13);
            this.ReEnterNewPasswordLabel.TabIndex = 4;
            this.ReEnterNewPasswordLabel.Text = "&Re-enter new password";
            // 
            // OldPasswordTextBox
            // 
            this.OldPasswordTextBox.Location = new System.Drawing.Point(133, 6);
            this.OldPasswordTextBox.Name = "OldPasswordTextBox";
            this.OldPasswordTextBox.Size = new System.Drawing.Size(168, 20);
            this.OldPasswordTextBox.TabIndex = 1;
            this.OldPasswordTextBox.TextChanged += new System.EventHandler(this.OldPasswordTextBox_TextChanged);
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(133, 35);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.Size = new System.Drawing.Size(168, 20);
            this.NewPasswordTextBox.TabIndex = 3;
            this.NewPasswordTextBox.TextChanged += new System.EventHandler(this.NewPasswordTextBox_TextChanged);
            // 
            // ReNewPasswordTextBox
            // 
            this.ReNewPasswordTextBox.Location = new System.Drawing.Point(133, 61);
            this.ReNewPasswordTextBox.Name = "ReNewPasswordTextBox";
            this.ReNewPasswordTextBox.Size = new System.Drawing.Size(168, 20);
            this.ReNewPasswordTextBox.TabIndex = 5;
            this.ReNewPasswordTextBox.TextChanged += new System.EventHandler(this.ReNewPasswordTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(133, 87);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(226, 87);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "&Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 122);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ReNewPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OldPasswordTextBox);
            this.Controls.Add(this.ReEnterNewPasswordLabel);
            this.Controls.Add(this.NewPaswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.MaximumSize = new System.Drawing.Size(330, 160);
            this.MinimumSize = new System.Drawing.Size(330, 160);
            this.Name = "ChangeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change passwors";
            this.Load += new System.EventHandler(this.ChangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPaswordLabel;
        private System.Windows.Forms.Label ReEnterNewPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTextBox;
        private System.Windows.Forms.TextBox NewPasswordTextBox;
        private System.Windows.Forms.TextBox ReNewPasswordTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetButton;
    }
}