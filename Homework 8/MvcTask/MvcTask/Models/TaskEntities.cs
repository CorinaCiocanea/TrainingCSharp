using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTask.Models
{
    public class TaskEntities : DbContext
    {
        public DbSet<ListGen> ListGens { get; set; }
        public DbSet<Task> Tasks { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ListGen>()
        //        .HasOptional(j => j.Tasks)
        //        .WithMany()
        //        .WillCascadeOnDelete(true);
        //    base.OnModelCreating(modelBuilder);
        //}
      
    }
}