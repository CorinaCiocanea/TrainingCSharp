using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
   public class Notes
    {
        public int NoteId { get; set; }
        public int Note { get; set; }
        public virtual Student Student { get; set; }
    }
}
