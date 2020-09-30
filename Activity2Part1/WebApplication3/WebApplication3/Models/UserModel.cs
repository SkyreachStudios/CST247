using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class UserModel
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public UserModel(string name, string email, string phone) {

            Name = name;
            Email = email;
            Phone = phone;

        }


    }
}