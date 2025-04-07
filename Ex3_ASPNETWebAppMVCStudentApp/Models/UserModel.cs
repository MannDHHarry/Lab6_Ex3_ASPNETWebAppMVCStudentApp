using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ex3_ASPNETWebAppMVCStudentApp.Models
{
    public class UserModel
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
    }
}