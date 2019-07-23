using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayes.Models
{
    public class User:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public string Passwod { get; set; }
        public string Login { get; set; }
    }
}
