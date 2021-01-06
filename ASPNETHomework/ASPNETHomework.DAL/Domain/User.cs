using System;
using System.Collections.Generic;
using System.Text;

namespace ASPNETHomework.DAL.Domain
{
    /// <summary>
    /// User.
    /// </summary>
    public class User:BaseEntity
    {
        /// <summary>
        /// Login.
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        public string Password { get; set; }
    }
}
