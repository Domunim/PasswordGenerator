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

        public UserModel CreateUser(UserModel model)
        {

            // Loads a text file and converts it to a list of UserModels

            List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();

            // Checks if a username is already used.

            if (!users.CheckIfUsedUsername(model))
            {
                users.Add(model);
            }

            users.SaveToUserFile(UsersFile);

            return model;
        }



    }
}
