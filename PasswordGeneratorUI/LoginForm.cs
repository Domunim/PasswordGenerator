namespace PasswordGeneratorUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
                // TODO - Pass selected username to Deletion Form
                UserDeletionConfirmationForm deleteUserForm = new();
                deleteUserForm.Show();
            }
            else
            {
                MessageBox.Show("Select a user and provide the password to delete the user.");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {         
            if (ValidateForm())
            {
                // Take username and passes to the form to display only passwords assigned to the user

                PasswordManagerMainScreen mainScreen = new();
                mainScreen.Show();

            }
            else
            {
                MessageBox.Show("Select a user and provide the password to log in.");
            }

        }

        /// <summary>
        /// Checks if a user is selected and a correct password is provided.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {

            if (UserChoiceComboBox.SelectedItem == null)
            {
                return false;
            }                
            
            //TODO - load a password from a UserModel file and check if it is correct,
            //add a method's argument of username to fetch the password

            else if (UsersPasswordTextbox.Text != "password_loaded_placeholder") // password loaded from the file
            {
                return false;
            }
            
            return true;
        }
    }
}