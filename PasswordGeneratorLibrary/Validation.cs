using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordGeneratorLibrary.DataModels;

namespace PasswordGeneratorLibrary
{
    public static class Validation
    {
        /// <summary>
        /// Checks if the username is already used.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>boolean if username is unique</returns>
        public static bool CheckIfUsedUsername(UserModel newUser)
        {
            string newUserName = newUser.UserName;
            bool uniqueUsername = true;

            List<UserModel> users = UsersFileConnector.ListAllUsers();

            foreach (UserModel u in users)
            {
                if (u.UserName.ToLower() == newUserName.ToLower())
                {
                    uniqueUsername = false;
                    break;
                }
            }

            if (uniqueUsername)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Checks if the given word matches the user's password.
        /// </summary>
        /// <param name="chosenUser"></param>
        /// <param name="comparedPassword"></param>
        /// <returns>boolean if the password is the same as user's one</returns>
        public static bool CheckUsersPassword(string chosenUser, string comparedPassword)
        {

            // TODO - does not work, always returns false
            // TODO - unit testing for this method

            bool passwordMatching = false;

            List<UserModel> users = UsersFileConnector.ListAllUsers();

            foreach (UserModel u in users)
            {
                if (u.UserName == chosenUser)
                {
                    if (u.UserPassword == comparedPassword)
                    {
                        passwordMatching = true;
                        break;
                    }
                }
            }

            if (passwordMatching)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
