using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YapGetir.UI.MVC.Models
{
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Isaretlendimi { get; set; }
    }
}