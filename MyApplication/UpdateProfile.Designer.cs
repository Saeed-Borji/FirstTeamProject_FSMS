namespace MyApplication
{
    partial class UpdateProfile
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
            this.Descriptionlabel = new System.Windows.Forms.Label();
            this.Fullnamelabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.FullnametextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Descriptionlabel
            // 
            this.Descriptionlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Descriptionlabel.AutoSize = true;
            this.Descriptionlabel.Location = new System.Drawing.Point(8, 42);
            this.Descriptionlabel.Name = "Descriptionlabel";
            this.Descriptionlabel.Size = new System.Drawing.Size(60, 13);
            this.Descriptionlabel.TabIndex = 2;
            this.Descriptionlabel.Text = "&Description";
            // 
            // Fullnamelabel
            // 
            this.Fullnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fullnamelabel.AutoSize = true;
            this.Fullnamelabel.Location = new System.Drawing.Point(8, 15);
            this.Fullnamelabel.Name = "Fullnamelabel";
            this.Fullnamelabel.Size = new System.Drawing.Size(49, 13);
            this.Fullnamelabel.TabIndex = 0;
            this.Fullnamelabel.Text = "&Fullname";
            this.Fullnamelabel.Click += new System.EventHandler(this.Usernamelabel_Click);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(87, 39);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(184, 124);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // FullnametextBox
            // 
            this.FullnametextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullnametextBox.Location = new System.Drawing.Point(88, 12);
            this.FullnametextBox.Name = "FullnametextBox";
            this.FullnametextBox.Size = new System.Drawing.Size(183, 20);
            this.FullnametextBox.TabIndex = 1;
            // 
            // Savebutton
            // 
            this.Savebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Savebutton.Location = new System.Drawing.Point(197, 169);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(74, 23);
            this.Savebutton.TabIndex = 4;
            this.Savebutton.Text = "&Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 204);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Descriptionlabel);
            this.Controls.Add(this.Fullnamelabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.FullnametextBox);
            this.Name = "UpdateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProfile";
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Descriptionlabel;
        private System.Windows.Forms.Label Fullnamelabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox FullnametextBox;
        private System.Windows.Forms.Button Savebutton;
    }
}