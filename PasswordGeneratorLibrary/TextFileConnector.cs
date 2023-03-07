using PasswordGeneratorLibrary.TextFileTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class TextFileConnector
    {

        private const string UsersFile = "UserModels.csv";
        private const string PasswordsFile = "PasswordModels.csv";
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
        
        
        public UserModel CreateUser(UserModel model)
        {
            // Loads a text file and converts it to a list of UserModels

            //previously - List<UserModel> users = UsersFile.FullFilePath().LoadFile().ConvertToUserModels();

            List<UserModel> users = ListAllUsers();

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

        /// <summary>
        /// Checks if the username is already used.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns>boolean if username is unique</returns>
        public static bool CheckIfUsedUsername(UserModel newUser)
        {
            string newUserName = newUser.UserName;
            bool uniqueUsername = true;

            List<UserModel> users = ListAllUsers();

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
        /// Deletes a selected user from the file.
        /// </summary>
        /// <param name="chosenUser"></param>
        public static void DeleteUser (string chosenUser)
        {
            // TODO - does not work (does not delete)

            List<UserModel> users = ListAllUsers();

            foreach (UserModel u in users)
            {
                if (u.UserName.ToLower() == chosenUser.ToLower())
                {
                    users.Remove(u);

                    break;
                }
            }

            TextFileProcessor.SaveToUserFile(users, UsersFile);

        }

        /// <summary>
        /// Checks if the given word matches the user's password.
        /// </summary>
        /// <param name="chosenUser"></param>
        /// <param name="comparedPassword"></param>
        /// <returns>boolean if the password is the same as user's one</returns>
        public static bool CheckUsersPassword(string chosenUser, string comparedPassword)
        {

            // TODO - does not work, logs in even with null paswword

            bool passwordMatching = false;

            List<UserModel> users = ListAllUsers();

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


        /// <summary>
        /// Generates a string of pseudo-random characters of given length.
        /// </summary>
        /// <param name="finalLength"></param>
        /// <returns>string of random characters of a given lenght</returns>

        public static string GenerateRandomPart(int finalLength, string charType)
        {
            var stringChars = new char[finalLength];

            Random random = new();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = charType[random.Next(charType.Length)];
            }

            string randomPart = new(stringChars);

            return randomPart;

        }

        /// <summary>
        /// Combines given keyword with a random string.
        /// </summary>
        /// <param name="finalLength"></param>
        /// <param name="keyword"></param>
        /// <param name="charType"></param>
        /// <returns>Final password in a simple model.</returns>
        public static string GenerateSimplePassword(int finalLength, string keyword, string charType)
        {

            if (finalLength - keyword.Length > 0)
            {
                string simplePassword = keyword + GenerateRandomPart(finalLength - keyword.Length, charType);
                return simplePassword;
            }
            else
            {
                return keyword;
            }

        }

        public static string ReplaceKeywordChars(string keyword)
        {
            return keyword.Replace('o', '0').Replace('a', '@').Replace('i', '!').Replace('s', '$').Replace('b', '8');
        }

    }
}
