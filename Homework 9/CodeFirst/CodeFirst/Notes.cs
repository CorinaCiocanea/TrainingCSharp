using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public enum Materials 
    {
      Database,
        POO,
        Computer_networks


    }
   public class Note
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public Materials Material { get; set; }
      //  public virtual Student Student { get; set; }
    }
}
