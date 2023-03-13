using PasswordGeneratorLibrary.DataModels;
using PasswordGeneratorLibrary.TextFileTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class PasswordsFileConnector
    {

        private const string PasswordsFile = "PasswordModels.csv";

        /// <summary>
        /// Loads a list of all passwords.
        /// </summary>
        /// <returns>list of PasswordModels</returns>
        public static List<PasswordModel> ListAllPasswords()
        {
            List<PasswordModel> passwords = PasswordsFile.FullFilePath().LoadFile().ConvertToPasswordModels();
            return passwords;
        }

        /// <summary>
        /// Loads a text file and converts it to a list of PasswordModels.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>list of PasswordModels</returns>
        public PasswordModel CreatePassword(PasswordModel model)
        {
           List<PasswordModel> passwords = ListAllPasswords();

            passwords.Add(model);

            passwords.SaveToPasswordFile(PasswordsFile);

            return model;
        }

        /// <summary>
        /// Deletes a selected password from the file.
        /// </summary>
        /// <param name="chosenUser"></param>
        public static void DeletePassword(string chosenPassword)
        {
            List<PasswordModel> passwords = ListAllPasswords();

            foreach (PasswordModel p in passwords)
            {
                if (p.GeneratedPassword == chosenPassword)
                {
                    passwords.Remove(p);

                    TextFileProcessor.SaveToPasswordFile(passwords, PasswordsFile);

                    break;
                }
            }

        }

    }
}
