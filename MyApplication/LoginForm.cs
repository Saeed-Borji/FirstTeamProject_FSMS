using System.Data.Entity;
using System.Linq;

namespace MyApplication
{
    public partial class LoginForm : Infrastructure.BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void UsernametextBox_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, System.EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(UsernametextBox.Text)) ||
                (string.IsNullOrWhiteSpace(PasswordtextBox.Text)))
            {
                System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

                return;
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
                    .Where(Current => string.Compare(Current.Username, UsernametextBox.Text, true) == 0)
                    .FirstOrDefault();

                if (oUser==null)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");
                    return;
                }

                if (string.Compare(oUser.Password, PasswordtextBox.Text, ignoreCase:false)!=0)
                {
                    System.Windows.Forms.MessageBox.Show("Username and/or Password is not correct!");
                    return;
                }

                if (oUser.IsActive==false)
                {
                    System.Windows.Forms.MessageBox.Show("you can not login in this application!  please contact support.");
                    return;
                }

                Infrastructure.Utility.Authentication = oUser;

                Hide();

                Main frmMain = new Main();

                frmMain.Show();

            
            }

            catch (System.Exception ex)
            {

                System.Windows.Forms.MessageBox.Show("Error!!!!"+ex.Message);
            }
            finally
            {
                if (oDatabaseContext!=null)
                {
                    oDatabaseContext.Dispose();
                    oDatabaseContext = null;
                }
            }

        }

        private void Cancelbutton_Click(object sender, System.EventArgs e)
        {
            RegisterForm frmRegister = new RegisterForm();
            frmRegister.Show();
        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            UsernametextBox.Text = string.Empty;
            PasswordtextBox.Text = string.Empty;

            UsernametextBox.Focus();
        }
    }
}

