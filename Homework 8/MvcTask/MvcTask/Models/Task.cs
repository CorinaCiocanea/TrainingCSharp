using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTask.Models
{
    public enum Priority 
    { 
        high,
        medium,
        low
    
    };
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Priority { get; set; }
    }
}