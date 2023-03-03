using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class UserModel
    {
        /// <summary>
        /// A name of an application's user.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// A 'master' password to login to the application accoumt.
        /// </summary>
        public string UserPassword { get; set; }
    }
}
