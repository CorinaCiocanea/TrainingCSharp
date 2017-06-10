﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    public enum Specializations {
          
        Mathematics,
        Informatics,
        History,
        Geography,
        English,
        Sociology
    }
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public long CNP { get; set; }
        public Specializations Specialization { get; set; }
        
    }
}