using PasswordGeneratorLibrary.TextFileTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class TextFileConnector
    {

        private const string UsersFile = "UserModels.csv";
        private const string PasswordsFile = "PasswordModels.csv";

        public UserModel CreateUser(UserModel model)
        {

            // Loads a text file and converts it to a list of UserModels

            List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();

            // Checks if a username is already used and add if not.

            //if (!users.CheckIfUsedUsername(model))
            //{
            //    users.Add(model);
            //}

            users.Add(model);

            users.SaveToUserFile(UsersFile);

            return model;
        }

        public PasswordModel CreatePassword(PasswordModel model)
        {

            // Loads a text file and converts it to a list of PasswordModels

            List<PasswordModel> passwords = PasswordsFile.FullFilePath().LoadFile().ConvertToPasswordModels();

            passwords.Add(model);

            passwords.SaveToPasswordFile(PasswordsFile);

            return model;
        }



    }
}
