using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcReadDateUser.Models
{
   
    public enum Hobby
    {
      Mathematics,
        History,
        English,
        Geography,
        Informatics
    }
    public class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Hobby? Hobby { get; set; }
        public string Message { get; set; }

    }
}