using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcTask.Models
{
    public class SampleData : DropCreateDatabaseAlways<TaskEntities>
    {
        protected override void Seed(TaskEntities context)
        {
            

             new List<ListGen>
            {
              new ListGen { Name = "Personal", Description = "Plec la munca", Tasks = new List<Task>()
              {
                 new Task { Name = "task 3", Deadline = new DateTime(1990, 3, 17), Priority = "medium"},
                 new Task { Name = "task 5", Deadline = new DateTime(1989, 2, 12), Priority = "high"},
                 new Task { Name = "task 5", Deadline = new DateTime(2000, 9, 21), Priority = "medium"}
              }},
              new ListGen { Name = "Informatica", Description = "proiect MVC 3", Tasks = new List<Task>()
              {
                 new Task { Name = "task 3", Deadline = new DateTime(1989, 6, 27), Priority = "medium"},
                 new Task { Name = "task 6", Deadline = new DateTime(1980, 8, 13), Priority = "low"},
                 new Task { Name = "task 5", Deadline = new DateTime(2001, 5, 5), Priority = "low"}
              }},
              new ListGen { Name = "Duminica", Description = "Joc tenis", Tasks = new List<Task>()
              {
                new Task { Name = "task 3", Deadline = new DateTime(1989, 6, 22), Priority = "medium"},
                 new Task { Name = "task 1", Deadline = new DateTime(1970, 3, 19), Priority = "high"},
                 new Task { Name = "task 10", Deadline = new DateTime(2017, 11, 21), Priority = "Low"}
              }},
              new ListGen { Name = "Facultate", Description = "Examen", Tasks = new List<Task>()
              {
                new Task { Name = "task 3", Deadline = new DateTime(1989, 6, 22), Priority = "medium"},
                 new Task { Name = "task 1", Deadline = new DateTime(1988, 2, 12), Priority = "low"},
                 new Task { Name = "task 5", Deadline = new DateTime(2002, 5, 21), Priority = "low"}
              }}
            }.ForEach(a => context.ListGens.Add(a));

            new List<Task>
            {
                new Task { Name = "task 3", Deadline = new DateTime(1989, 6, 22), Priority = "medium"},
                new Task { Name = "task 1", Deadline = new DateTime(1989, 2, 12), Priority = "high"},
                new Task { Name = "task 5", Deadline = new DateTime(2017, 5, 21), Priority = "medium"}
            }.ForEach(b => context.Tasks.Add(b));

            //var listgen = new List<ListGen>();
            //var task = new List<Task>();
            //new List<ListTask>
            //{
            //    new ListTask { ListTaskId = 1, ListGen = listgen.Single(g => g.Name == "Personal"), Task = task.Single(t => t.Name == "task 1")},  
            //    new ListTask { ListTaskId = 2, ListGen = listgen.Single(g => g.Name == "Personal"), Task = task.Single(t => t.Name == "task 3")},
            //    new ListTask { ListTaskId = 3, ListGen = listgen.Single(g => g.Name == "Personal"), Task = task.Single(t => t.Name == "task 6")}
                

            //}.ForEach(c => context.ListTasks.Add(c));
        }
    }
}