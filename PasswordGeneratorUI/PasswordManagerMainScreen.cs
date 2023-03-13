using PasswordGeneratorLibrary;
using PasswordGeneratorLibrary.DataModels;
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

            RefreshListbox();
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
                PasswordsFileConnector.DeletePassword(PasswordListBox.SelectedItem.ToString());

                RefreshListbox();
            }
            else
            {
                MessageBox.Show("Select a password to be deleted.");
            }
        }

        public void RefreshListbox()
        {
            List<PasswordModel> passwords = PasswordsFileConnector.ListAllPasswords();

            foreach (PasswordModel p in passwords)
            {
                PasswordListBox.Items.Add(p);
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
