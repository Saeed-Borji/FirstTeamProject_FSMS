namespace MyApplication
{
    partial class Main
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
            this.MymenuStrip = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MystatusStrip = new System.Windows.Forms.StatusStrip();
            this.UsernametoolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.discriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MymenuStrip.SuspendLayout();
            this.MystatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MymenuStrip
            // 
            this.MymenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MymenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem});
            this.MymenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MymenuStrip.Name = "MymenuStrip";
            this.MymenuStrip.Size = new System.Drawing.Size(331, 42);
            this.MymenuStrip.TabIndex = 0;
            this.MymenuStrip.Text = "MymenuStriptxt";
            this.MymenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(100, 38);
            this.settingToolStripMenuItem.Text = "setting";
            // 
            // updateProfileToolStripMenuItem
            // 
            this.updateProfileToolStripMenuItem.AutoToolTip = true;
            this.updateProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discriptionToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            this.updateProfileToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.updateProfileToolStripMenuItem.Text = "&Update Profile";
            this.updateProfileToolStripMenuItem.Click += new System.EventHandler(this.updateProfieToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MystatusStrip
            // 
            this.MystatusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.MystatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsernametoolStripStatusLabel});
            this.MystatusStrip.Location = new System.Drawing.Point(0, 224);
            this.MystatusStrip.Name = "MystatusStrip";
            this.MystatusStrip.Size = new System.Drawing.Size(331, 37);
            this.MystatusStrip.TabIndex = 1;
            this.MystatusStrip.Text = "MystatusStriptxt";
            // 
            // UsernametoolStripStatusLabel
            // 
            this.UsernametoolStripStatusLabel.Name = "UsernametoolStripStatusLabel";
            this.UsernametoolStripStatusLabel.Size = new System.Drawing.Size(332, 32);
            this.UsernametoolStripStatusLabel.Text = "UsernametoolStripStatusLabel";
            this.UsernametoolStripStatusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // discriptionToolStripMenuItem
            // 
            this.discriptionToolStripMenuItem.Name = "discriptionToolStripMenuItem";
            this.discriptionToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.discriptionToolStripMenuItem.Text = "Discription";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(301, 38);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.MystatusStrip);
            this.Controls.Add(this.MymenuStrip);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.MymenuStrip;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MymenuStrip.ResumeLayout(false);
            this.MymenuStrip.PerformLayout();
            this.MystatusStrip.ResumeLayout(false);
            this.MystatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MymenuStrip;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProfileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip MystatusStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel UsernametoolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem discriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
    }
}