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
            //opens GeneratePasswordFrom
        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                // Pass selected password and deletes it from the list and file
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
            bool output = true;
            // TODO - tweak the listbox selection
            if (PasswordListBox.selection == 0)
            
            {
                output = false;
            }

            return output;
        }

    }
}
