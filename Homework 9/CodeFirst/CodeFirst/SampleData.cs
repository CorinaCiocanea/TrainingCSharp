using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirst
{
   public class SampleData : DbContext
    {
        public DbSet<Student> Studentss { get; set; }
        public DbSet<Note> Notess { get; set; }
      
    }
}
