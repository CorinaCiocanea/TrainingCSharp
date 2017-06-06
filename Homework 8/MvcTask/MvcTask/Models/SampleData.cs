using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTask.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<TaskEntities>
    {
        protected override void Seed(TaskEntities context)
        {
            //var listgens = new List<ListGen>
            //{
            //  new ListGen { Name = "Personal" },
            //  new ListGen { Name = "Informatica" },
            //  new ListGen { Name = "Duminica" },
            //  new ListGen { Name = "Facultate" }
            //};

            var listgens = new List<ListGen>
            {
              new ListGen { Name = "Personal", Description = "Plec la munca"},
              new ListGen { Name = "Informatica", Description = "proiect MVC 3"},
              new ListGen { Name = "Duminica", Description = "Joc tenis"},
              new ListGen { Name = "Facultate", Description = "Examen"},
            };

            var tasks = new List<Task>
            {
                new Task { Name = "task 1", Deadline = new DateTime(13/03/2017), Priority = "medium"},
                new Task { Name = "task 1", Deadline = new DateTime(13/03/2017), Priority = "medium"},
                new Task { Name = "task 1", Deadline = new DateTime(13/03/2017), Priority = "medium"}
            };
        }
    }
}