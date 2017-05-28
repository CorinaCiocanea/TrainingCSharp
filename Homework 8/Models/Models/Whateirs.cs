using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class Whateirs
    {
        private string name;
        private int id;
        private string coordinator;
        public List<Tables> tables { get; set; }
      

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
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }
        public string Coordinator
        {
            get
            {
                return coordinator;
            }
            set
            {
                coordinator = value;
            }
        }
    }
}
