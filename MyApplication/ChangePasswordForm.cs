using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MyApplication
{
    public partial class ChangeForm : Infrastructure.BaseForm
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReNewPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            OldPasswordTextBox.Text = string.Empty;
            NewPasswordTextBox.Text = string.Empty;
            ReNewPasswordTextBox.Text = string.Empty;

            OldPasswordTextBox.Focus();

        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }

        private void OldPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(OldPasswordTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(NewPasswordTextBox.Text)) ||
                (string.IsNullOrWhiteSpace(ReNewPasswordTextBox.Text)))
            {
                System.Windows.Forms.MessageBox.Show("Old , New and Re-New Password is requied!");

                return;
            }
            if (NewPasswordTextBox.Text.Length <8 || ReNewPasswordTextBox.Text.Length < 8)
            {
                    MessageBox.Show("Password length should be at least 8 characters!");
            }
            else 
            {
                string strErrorMessages = string.Empty;

                // اگر خطایی وجود داشت
                if (strErrorMessages != string.Empty)
                {
                    System.Windows.Forms.MessageBox.Show(strErrorMessages);

                    return;
                }
            }
            // **************************************************
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                oDatabaseContext.Users
                .Where(Current => string.Compare(Current.Password,OldPasswordTextBox.Text, true) == 0)
                .FirstOrDefault();

                if (oUser == null)
                {
                    MessageBox.Show("Your Old Password is not correct!");
                    OldPasswordTextBox.Text = string.Empty;
                    NewPasswordTextBox.Text = string.Empty;
                    ReNewPasswordTextBox.Text = string.Empty;
                    OldPasswordTextBox.Focus();
                    return;
                }
                else if (string.Compare(NewPasswordTextBox.Text, ReNewPasswordTextBox.Text, ignoreCase: false) != 0)
                {
                    MessageBox.Show("New Password And Re-New Password is not mach!");
                    NewPasswordTextBox.Text = string.Empty;
                    ReNewPasswordTextBox.Text = string.Empty;
                    NewPasswordTextBox.Focus();
                }
                else
                {
                    oUser.Password = NewPasswordTextBox.Text;
                    oDatabaseContext.SaveChanges();
                    MessageBox.Show("Change Password is Done!");
                    Hide();
                }


            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!!!!" + ex.Message);
            }
            finally
            {
                if (oDatabaseContext != null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }

        }
    }
}
