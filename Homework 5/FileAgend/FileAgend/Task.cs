using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAgend
{
  public class Task
    {
        private string day;
        private string name;
        private string priority;
        private int hour;

        public string Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

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

        public string Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                hour = value;
            }
        }
    }
}
