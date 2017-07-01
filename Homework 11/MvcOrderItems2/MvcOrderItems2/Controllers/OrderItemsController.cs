using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOrderItems2.Models;

namespace MvcOrderItems2.Controllers
{
    public class OrderItemsController : Controller
    {
        //
        // GET: /OrderItems/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InsertNumbers()
        {
            var iteminfo = new ItemList();
          
            iteminfo.Items.Insert(0, new ItemsInfo());
            return View(iteminfo);
        }
        [HttpPost]
        public ActionResult InsertNumbers(ItemsInfo iteminfo)
        {
            return View(iteminfo);
        }
        public ActionResult SortedNumbers()
        {
            var iteminfo = new ItemList();
            iteminfo.Items.Insert(0, new ItemsInfo());
            return View(iteminfo);
        }
    
        public ActionResult SortedNumbers(ItemsInfo iteminfo)
        {
            return View(iteminfo);
        }


    }
}
