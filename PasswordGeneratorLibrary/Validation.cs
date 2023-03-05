using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public static class Validation
    {
        
        // TODO - delete the class
        
        /// <summary>
        /// Checks if a chosen username is already used.
        /// </summary>
        /// <param name="models"></param>
        /// <param name="newUser"></param>
        /// <returns>boolean 'true' if username is used</returns>
        public static bool CheckIfUsedUsername(this List<UserModel> models, UserModel newUser)
        {
            string newUserName = newUser.UserName;
            bool uniqueUsername = true;

            foreach (UserModel u in models)
            {
                if (u.UserName == newUserName)
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
    }
}
