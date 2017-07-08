using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcOrderItems2.Models;

namespace MvcOrderItems2.Controllers
{
    public class OrderItems2Controller : Controller
    {
        //
        // GET: /OrderItems2/

        public ActionResult Index()
        {
               var iteminfo = new ItemList();

               iteminfo.Items.Insert(0, new ItemsInfo());
               return View();
            
        }
        public ActionResult InsertNumbers()
        {
            var itemInfo = new ItemList();
            itemInfo.Items.Insert(0, new ItemsInfo());
            return View(itemInfo);
        }
        [HttpPost]
        public ActionResult InsertNumbers(int count)
        {
            ItemList list = new ItemList();
            for (int i = 0; i < count; i++)
            {
                list.Items.Add(new ItemsInfo());
            }
            return View(list);
        }

        public ActionResult SortedNumbers(IList<int> numbers)
        {
            
            return View();
        }
    }
}
