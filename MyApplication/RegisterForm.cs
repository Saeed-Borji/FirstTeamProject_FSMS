using System.Data.Entity;
using System.Linq;

namespace MyApplication
{
	public partial class RegisterForm : Infrastructure.BaseForm
	{
		public RegisterForm()
		{
			InitializeComponent();
		}

		private void RegisterForm_Load(object sender, System.EventArgs e)
		{
		}

		private void SubmitButton_Click(object sender, System.EventArgs e)
		{
			// **************************************************
			if ((string.IsNullOrWhiteSpace(UsernameTextBox.Text)) ||
				(string.IsNullOrWhiteSpace(PasswordTextBox.Text)))
			{
				System.Windows.Forms.MessageBox.Show("Username and Password is requied!");

				return;
			}
			else
			{
				string strErrorMessages = string.Empty;

				if (UsernameTextBox.Text.Length < 6)
				{
					strErrorMessages =
						"Username length should be at least 6 characters!";
				}

				if (PasswordTextBox.Text.Length < 8)
				{
					if (strErrorMessages != string.Empty)
					{
						strErrorMessages +=
							System.Environment.NewLine;
					}

					strErrorMessages +=
						"Password length should be at least 8 characters!";
				}

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

				Models.User oUser = new Models.User();

				oUser.IsActive = true;
				oUser.FullName = FullNameTextBox.Text;
				oUser.Password = PasswordTextBox.Text;
				oUser.Username = UsernameTextBox.Text;

				oDatabaseContext.Users.Add(oUser);

				oDatabaseContext.SaveChanges();

				System.Windows.Forms.MessageBox.Show("Registration Done!");
                
				FullNameTextBox.Text = string.Empty;
				PasswordTextBox.Text = string.Empty;
				UsernameTextBox.Text = string.Empty;
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show("Error: " + ex.Message);
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

		private void ResetButton_Click(object sender, System.EventArgs e)
		{
			UsernameTextBox.Text = string.Empty;
			PasswordTextBox.Text = string.Empty;
			FullNameTextBox.Text = string.Empty;
		}

        private void UsernameTextBox_TextChanged(object sender, System.EventArgs e)
        {

        }
    }
}
