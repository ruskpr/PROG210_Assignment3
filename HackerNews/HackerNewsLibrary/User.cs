using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerNewsLibrary
{
    public class User
    {
        #region Properties
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string About { get; set; }
        public DateTime DateCreated { get; set; }
        #endregion

        #region Constructor
        public User(string usrnm, string pass, string email)
        {
            UserName = usrnm;
            Password = pass;
            Email = email;
            DateCreated = DateTime.Now;
        }
        #endregion
    }
}
