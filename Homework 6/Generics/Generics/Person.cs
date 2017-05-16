using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  public  class Person : IPerson
    {
        public string name;
        public long cnp;
        public DateTime dateBirth;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public long CNP
        {
            get
            {
                return cnp;
            }
            set
            {
                cnp = value;
            }
        }
        public DateTime DateBirth
        {
            get
            {
                return dateBirth;
            }
            set
            {
                dateBirth = value;
            }
        }
        public bool ValidateDate<T>(T person) where T : IPerson
        {
            //string[] time = { "", "__/__?____" };
            bool succes = true;
            if (DateTime.TryParse(Console.ReadLine(), out dateBirth))
            {
                succes = false;
            }
            return succes;
       }
        //public bool Validate2<T>(T person) where T : IPerson
        //{
        //    if (person.DateBirth == "2")
        //    {
        //        return true;
        //    }
        //    return false;

        }
    }

