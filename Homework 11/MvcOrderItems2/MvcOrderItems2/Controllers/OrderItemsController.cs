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
        //public ActionResult InsertNumbers()
        //{
        //    var iteminfo = new ItemList();
          
        //    iteminfo.Items.Insert(0, new ItemsInfo());
        //    return View(iteminfo);
        //}
        [HttpPost]
        public ActionResult InsertNumbers(int count)
        {
           // ItemList list = new ItemList();
            List<ItemsInfo> info = new List<ItemsInfo>();
            for (int i = 0; i < count; i++) 
            {
               info.Add(new ItemsInfo());
            }
            return View(info);
        }
        [HttpPost]
        public ActionResult SortedNumbers(IList<ItemsInfo> numbers)
        {
//List<ItemsInfo> info = new List<ItemsInfo>();
            numbers = numbers.OrderBy(n => n.Item).ToList();
            return View(numbers.ToList());
        }
    
        //public ActionResult SortedNumbers(ItemsInfo iteminfo)
        //{
        //    return View(iteminfo);
        //}


    }
}
