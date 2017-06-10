using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MvcTask.Models
{
    public class ListTask
    {
        public int ListTaskId { get; set; }
        public int ListGenId { get; set; }
        public int TaskID { get; set; }
        public virtual ListGen ListGen { get; set; }
        public virtual Task Task {get; set;}

        
    }
}