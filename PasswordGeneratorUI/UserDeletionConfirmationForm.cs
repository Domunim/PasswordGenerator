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
    public partial class UserDeletionConfirmationForm : Form
    {
        public UserDeletionConfirmationForm()
        {
            InitializeComponent();
        }
        
        // Takes a username of user to be deleted
        //UserDeleteHeader.Text = $"Are you sure to delete {deletingUser.ToString()}?";

        private void UserDeletionRejectionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserDeletionConfirmationButton_Click(object sender, EventArgs e)
        {
            // TODO - delete user
            // takes a username from UserDeleteLabel
            // if == deletes from the List
            // saves back
            // closes the form

            MessageBox.Show("The user has been deleted.");

            Close();
        }
    }
}
