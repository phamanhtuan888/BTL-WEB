using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ananas.App_code
{
    public class User
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string repassword { get; set; }



        public User()
        {

        }
        public User(string name, string email, string password, string repassword)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.repassword = repassword;

        }
    }
}