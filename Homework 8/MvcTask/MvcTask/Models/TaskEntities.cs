﻿using System;
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
        public DbSet<ListTask> ListTasks { get; set; }
    }
}