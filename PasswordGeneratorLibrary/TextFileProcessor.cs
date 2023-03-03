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
        public static string FullFilePath(this string fileName) // {Something}Model.csv
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

        /// <summary>
        /// Converts all passwords to a list.
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>a list of PasswordModels</returns>
        public static List<PasswordModel> ConvertToPasswordModels(this List<string> lines)
        {
            List<PasswordModel> output = new();

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');

                PasswordModel p = new();
                p.Owner = columns[0];
                p.GeneratedPassword = columns[1];
                output.Add(p);
            }
            return output;
        }


        // TODO - Method that checks if a username is used

        /// <summary>
        /// Checks if a chosen username is already used.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="newUser"></param>
        /// <returns>boolean 'true' if username is used</returns>
        //public static bool CheckIfUsedUsername(this List<UserModel> models, UserModel newUser)
        //{
        //    string newUserName = newUser.UserName;



        //   foreach (UserModel u in models)
        //    {
        //        if (u.UserName == newUserName)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}

        //bool usedUsername = false;

        //do while (!usedUsername)
        //{
        //   foreach (UserModel u in models)
        //   {
        //      if (u.UserName == newUserName)
        //
        //      {
        //          return true;
        //      }

        //      else

        //      {
        //          return false;
        //      }
        //}

        // Convert all users to a List<string> & save it to a text file

        public static void SaveToUserFile(this List<UserModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (UserModel u in models)
            {
                lines.Add($"{u.UserName},{u.UserPassword}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        // Convert all passwords to a List<string> & save it to a text file

        public static void SaveToPasswordFile(this List<PasswordModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (PasswordModel p in models)
            {
                lines.Add($"{p.Owner},{p.GeneratedPassword}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

    }
}