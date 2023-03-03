using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneratorLibrary
{
    public class PasswordModel
    {
        /// <summary>
        /// A set of characters of an actual generated password.
        /// </summary>
        public string GeneratedPassword { get; set; }

        /// <summary>
        /// A user that generated and owns a password
        /// </summary>
        public string Owner { get; set; }
    }
}