using PasswordGeneratorLibrary;
using System.Xml.Linq;
using System;
using PasswordGeneratorLibrary.DataModels;

namespace PasswordGeneratorUI
{
    public partial class LoginForm : Form
    {
        internal static string? chosenUser;

        public LoginForm()
        {
            InitializeComponent();

            RefreshCombobox();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UsersPasswordTextbox.PasswordChar = ShowPasswordCheckBox.Checked ? '\0' : '*';
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {         
            CreateUserForm createUserForm = new();
            createUserForm.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                chosenUser = UserChoiceComboBox.Text;

                UserDeletionConfirmationForm deleteUserForm = new();

                deleteUserForm.Show();
            }
            else
            {
                MessageBox.Show("Select a user and provide a valid password to delete the user.");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {         
            if (ValidateForm())
            {
                chosenUser = UserChoiceComboBox.Text;

                PasswordManagerMainScreen mainScreen = new();

                mainScreen.Show();

            }
            else
            {
                MessageBox.Show("Select a user and provide a valid password to log in.");
            }

        }

        /// <summary>
        /// Checks if a user is selected and a correct password is provided.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (UserChoiceComboBox.SelectedItem != null && 
                Validation.CheckUsersPassword(UserChoiceComboBox.SelectedItem.ToString(), UsersPasswordTextbox.Text))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public void RefreshCombobox()
        {
            List<UserModel> users = UsersFileConnector.ListAllUsers();

            foreach (UserModel u in users)
            {
                UserChoiceComboBox.Items.Add(u);
            }
        }


    }
}