using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PasswordGeneratorLibrary.DataModels;

namespace PasswordGeneratorLibrary.TextFileTools
{
    internal static class TextFileProcessor
    {
        /// <summary>
        /// Converts a file name to a path.
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>a full text file path</returns>
        public static string FullFilePath(this string fileName)
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
                // TODO - check if a comma in password and user breaks the column wrapping
                PasswordModel p = new();
                p.Owner = columns[0];
                p.GeneratedPassword = columns[1];
                output.Add(p);
            }
            return output;
        }

        /// <summary>
        /// Converts all users to a List<string> & saves it to a text file.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
        public static void SaveToUserFile(this List<UserModel> models, string fileName)
        {
            List<string> lines = new();

            foreach (UserModel u in models)
            {
                lines.Add($"{u.UserName},{u.UserPassword}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);

        }

        /// <summary>
        /// Converts all passwords to a List<string> & saves it to a text file.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="fileName"></param>
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