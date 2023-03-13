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
    public class UsersFileConnector
    {

        private const string UsersFile = "UserModels.csv";
        public static string? chosenUser;

        /// <summary>
        /// Loads a list of all users.
        /// </summary>
        /// <returns>list of UserModels</returns>
        public static List<UserModel> ListAllUsers()
        {
            List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();
            return users;
        }

        /// <summary>
        /// Adds a new UserModel to the file.
        /// </summary>
        /// <param name="model"></param>
        /// <returns>UserModel</returns>
        public UserModel CreateUser(UserModel model)
        {
            List<UserModel> users = ListAllUsers();

            users.Add(model);

            users.SaveToUserFile(UsersFile);

            return model;
        }


        /// <summary>
        /// Deletes a selected user from the file.
        /// </summary>
        /// <param name="chosenUser"></param>
        public static void DeleteUser (string chosenUser)
        {
            List<UserModel> users = ListAllUsers();

            foreach (UserModel u in users)
            {
                if (u.UserName == chosenUser)
                {
                    users.Remove(u);
                    
                    TextFileProcessor.SaveToUserFile(users, UsersFile);

                    break;
                }
            }

        }
        
    }
}
