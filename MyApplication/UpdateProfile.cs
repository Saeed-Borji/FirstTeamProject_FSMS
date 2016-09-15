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
    public partial class UpdateProfile : Infrastructure.BaseForm
    {
        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void Usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.Authentication.Id)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                FullnametextBox.Text = oUser.FullName;
                DescriptionTextBox.Text = oUser.Description;

                oDatabaseContext.SaveChanges();

                //System.Windows.Forms.MessageBox.Show("Your profile was updated succefully.");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + ex.Message);

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

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            Models.DatabaseContext oDatabaseContext = null;

            try
            {
                oDatabaseContext =
                    new Models.DatabaseContext();

                Models.User oUser =
                    oDatabaseContext.Users
                    .Where(current => current.Id == Infrastructure.Utility.Authentication.Id)
                    .FirstOrDefault();

                if (oUser == null)
                {
                    System.Windows.Forms.Application.Exit();
                }

                oUser.FullName = FullnametextBox.Text ;
                oUser.Description = DescriptionTextBox.Text ;

                oDatabaseContext.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Your profile was updated succefully.");

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error:" + ex.Message);

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
