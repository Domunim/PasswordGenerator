using PasswordGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGeneratorUI
{
    public partial class GeneratePasswordForm : Form
    {
        public GeneratePasswordForm()
        {
            InitializeComponent();
        }
         
        string newPassword = "";

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {


            if () // simple selected
            {
                // SimplePasswordGroupBox Visible = true

                if (ValidateForm())
                {

                    // simple - takes a keyword, checkboxes and replace/add until lenght
                    // sets the string to a newPassword variable

                }
                else
                {
                    MessageBox.Show("Provide your keyword to be used in a password.");
                }
            }

            if () // complex selected
            {
                // SimplePasswordGroupBox Visible = false
                
                //random string of a given lenght

                // sets the string to a newPassword variable
            }
            
            // GeneratedPasswordLabel.Text = newPassword;

        }

        /// <summary>
        /// Checks if all requirements for a password are provided.
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            bool output = true;

            if (KeywordTextbox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (GeneratedPasswordLabel != null)
            {
                // Saves the value of the newPassword to a file, refreshes the listbox

                PasswordModel p = new();
                p.Owner = // logged user - how to pass it from another form?
                p.GeneratedPassword = newPassword;

                TextFileConnector txtConnector = new();

                txtConnector.CreatePassword(p);

                // refreshes the listbox in manager form

                Close();

            }
            else
            {
                MessageBox.Show("Generate a password to be saved.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
