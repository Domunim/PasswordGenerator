using PasswordGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorUI
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UserPasswordValue.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UserModel model = new();
                model.UserName = UsernameValue.Text;
                model.UserPassword = UserPasswordValue.Text;

                // TODO - connect using a TextFileConnector instance (below)

                // TextFileConnector.CreateUser(model);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Please provide your username and a password.");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (UsernameValue.Text.Length == 0)
            {
                output = false;
            }

            if (UserPasswordValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
