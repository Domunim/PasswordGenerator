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
        
        private void UserDeletionRejectionButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserDeletionConfirmationButton_Click(object sender, EventArgs e)
        {
            // TODO - delete user logic

            // takes a username from deletingUser
            // if == deletes from the List
            // saves back

            MessageBox.Show("The user has been deleted.");

            Close();
        }

    }
}
