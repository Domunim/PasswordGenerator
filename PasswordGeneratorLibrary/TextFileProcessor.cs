using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary.TextFileTools
{
    internal static class TextFileProcessor
    {
        /// <summary>
        /// Converts a file name to a path.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>a full text file path</returns>
        public static string FullFilePath(this string fileName) // UserModel.csv
        {
            return $"C:\\Users\\User\\source\\repos\\PasswordGenerator\\data\\{fileName}";
        }

        /// <summary>
        /// Loads a file based on a full name path.
        /// </summary>
        /// <param name="file"></param>
        /// <returns>list of all text lines</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        
        }

        /// <summary>
        /// Converts all users to a list.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>a list of UserModels</returns>
        public static List<UserModel> ConvertToUserModels(this List<string> lines)
        {
            List<UserModel> output = new();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                UserModel u = new();
                u.UserName = columns[0];
                u.UserPassword = columns[1];
                output.Add(u);
            }
            return output;
        }

        // Checks if a new username is already used

        public static bool CheckIfUsedUsername(this List<UserModel> models, UserModel newUser)
        {
            string newUserName = newUser.UserName;

            foreach (UserModel u in models)
            {

                if (u.UserName == newUserName)
                {
                    return false;
                }

                else
                {
                    return true;
                }

            }
            // else
            // {
            // TODO - Pop up a message box that the username is already used. 
            // }
        }


        // Convert all users to list<string>
        // Save the list<string> to the text file

        public static void SaveToUserFile(this List<UserModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (UserModel u in models)
            {
                lines.Add($"{u.UserName},{u.UserPassword}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

    }
}