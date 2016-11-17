using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Main : Infrastructure.BaseForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UsernametoolStripStatusLabel.Text =
                Infrastructure.Utility.Authentication.Username;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updateProfieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult enmResult =
                System.Windows.Forms.MessageBox.Show
                (text:"خارج میشی؟", 
                caption: "fdgsjkdgsadfg",
                buttons: System.Windows.Forms.MessageBoxButtons.YesNoCancel,
                icon:System.Windows.Forms.MessageBoxIcon.Question,
                defaultButton:System.Windows.Forms.MessageBoxDefaultButton.Button2,
                options:System.Windows.Forms.MessageBoxOptions.RightAlign | 
                System.Windows.Forms.MessageBoxOptions.RtlReading);

            if (enmResult==System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateProfile frmUpdateProfile = new UpdateProfile();
            frmUpdateProfile.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeForm frmChangeForm = new ChangeForm();
            frmChangeForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ثبتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerRadForm frmAddCustomer = new AddCustomerRadForm();
            frmAddCustomer.Show();
            
        }
    }
}
