using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorUI
{
    public partial class PasswordManagerMainScreen : Form
    {
        public PasswordManagerMainScreen()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {

            GeneratePasswordForm generatePassword = new();
            generatePassword.Show();

        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // TODO - Pass selected password and deletes it from the list and file
            }
            else
            {
                MessageBox.Show("Select a password to be deleted.");
            }
        }

        /// <summary>
        /// Checks if a user is selected and a correct password is provided.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            
            if (PasswordListBox.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
