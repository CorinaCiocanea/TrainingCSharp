using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAgend
{
  public class Task
    {
       protected string Day;
        string Name;
        string Priority;
        int Hour;

        public string dDay
        {
            get
            {
                return Day;
            }
            set
            {
                Day = value;
            }
        }

        public string nName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public string pPriority
        {
            get
            {
                return Priority;
            }
            set
            {
                Priority = value;
            }
        }
        public int hHour
        {
            get
            {
                return Hour;
            }
            set
            {
                Hour = value;
            }
        }
    }
}
