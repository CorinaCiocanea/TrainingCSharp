using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTask.Models;

namespace MvcTask.Controllers
{
    public class StoreController : Controller
    {
        TaskEntities storeDB = new TaskEntities();
        
        public ActionResult Index()
        {
           var listgens = storeDB.ListGens.ToList();

           return View(listgens);
        }
        //
        // GET: /Store/Browse
        //public string Browse()
        //{
        //    return "Hello from Store.Browse()";
        //}
        public ActionResult Browse(string listgen)
        {
            var listgenModel = new ListGen { Name = listgen };
            return View(listgenModel);
        }
        //
        // GET: /Store/Details
        //public string Details()
        //{
        //    return "Hello from Store.Details()";
        //}

        public ActionResult Details(int id)
        {
            var listtask = new Task { Name = "Monday" + id };
            return View(listtask);
        }
    }
}
