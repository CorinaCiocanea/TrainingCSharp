using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAgend
{
  public class Agend
    {
        string Days;
        string Tasks;
        string Priority;
        int Hour;

        public string dDays
        {
            get
            {
                return Days;
            }
            set
            {
                Days = value;
            }
        }

        public string tTasks
        {
            get
            {
                return Tasks;
            }
            set
            {
                Tasks = value;
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
