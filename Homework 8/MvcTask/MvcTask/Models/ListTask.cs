using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTask.Models
{
    public class ListTask
    {
        public int ListTaskId { get; set; }
        public ListGen ListGen { get; set; }
        public Task Task { get; set; }
        //public List<ListGen> ListGens { get; set; }
        //public List<Task> Tasks { get; set; }
    }
}