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
            //Application.Run(new CreateUserForm());
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Pass selected username to Deletion Form
                //UserDeletionConfirmationForm();
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
                //Take username
                // passes to the form to display only passwords assigned to the user
                //open PasswordManagerMainScreen();
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
            bool output = true;
            // TODO - tweak the combobox selection
            if (UserChoiceComboBox.selection == 0) 
            {
                output = false;
            }
            // TODO - load a password from a UserModel file and check if it is correct
            if (UsersPasswordTextbox.Text != "blabla")
            {
                output = false;
            }

            return output;
        }
    }
}