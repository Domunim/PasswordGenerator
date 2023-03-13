using PasswordGeneratorLibrary;
using PasswordGeneratorLibrary.DataModels;
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

        const string allCharType = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                                   "0123456789~`!@#$%^&*()_-+={}[]:;<>,.?/";
        string newPassword = "";

        private void SimpleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SimpleRadioButton.Checked)
            {
                SimplePasswordGroupBox.Visible = true;
            }
            else
            {
                SimplePasswordGroupBox.Visible = false;
            }
        }

        private void GeneratePasswordButton_Click(object sender, EventArgs e)
        {
            int finalLength = Convert.ToInt32(LenghtTrackBar.Value);

            if (SimpleRadioButton.Checked)
            {
                if (ValidateForm())
                {
                    string keyword = KeywordTextbox.Text;
                    string charType = "";

                    if (keyword.Length <= finalLength)
                    {
                        if (CapitalLettersCheckBox.Checked)
                        {
                            charType += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        }

                        if (LowercaseLettersCheckBox.Checked)
                        {
                            charType += "abcdefghijklmnopqrstuvwxyz";
                        }

                        if (NumbersCheckBox.Checked)
                        {
                            charType += "0123456789";
                        }

                        if (SpecialCharsCheckBox.Checked)
                        {
                            charType += "~`!@#$%^&*()_-+={}[]:;<>,.?/";
                        }

                        if (ReplaceRadioButton.Checked)
                        {
                            newPassword = PasswordGeneratingLogic.GenerateSimplePassword(finalLength, PasswordGeneratingLogic.ReplaceKeywordChars(keyword), charType);
                        }

                        else
                        {
                            if (charType != "")
                            {
                                newPassword = PasswordGeneratingLogic.GenerateSimplePassword(finalLength, keyword, charType);
                            }
                            else
                            {
                                MessageBox.Show("Choose at least one type of characters to add.");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("The length of keyword cannot exceed the password's length.");
                    }

                }
                else
                {
                    MessageBox.Show("Provide your keyword to be used in a password.");
                }
            }

            if (ComplexRadioButton.Checked)
            {
                newPassword = PasswordGeneratingLogic.GenerateRandomPart(finalLength, allCharType);
            }
            
            GeneratedPasswordLabel.Text = $"{newPassword}";
        }

        /// <summary>
        /// Checks if all requirements for a password are provided.
        /// </summary>
        /// <returns>boolean if all requirements are met.</returns>
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
            if (newPassword != "")
            {

                PasswordModel p = new();
                p.Owner = LoginForm.chosenUser;
                p.GeneratedPassword = newPassword;

                PasswordsFileConnector txtConnector = new();

                txtConnector.CreatePassword(p);

                PasswordManagerMainScreen.RefreshListbox();

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

        private void LenghtTrackBar_Scroll(object sender, EventArgs e)
        {
            CharacterNumberLabel.Text = LenghtTrackBar.Value.ToString();
        }
    }
}
