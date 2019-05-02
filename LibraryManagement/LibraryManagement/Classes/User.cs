using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Classes
{
    class User
    {
        public bool AddUser(string username, string password)
        { 
            //string Hpassword = SHA1(password);
            //Ask username password, store in User + Username.xml as hash

            return true;
        }
        public bool LogIn(string user, string HPass)
        {
            // Search Users for user, compaire with hpass

            return true;
        }


    }
}
