using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBind.Models;
namespace MvcBind.Controllers
{
    public class MathController : Controller
    {
        //
        // GET: /Math/

        public string Index()
        {
            return "cccc";
        }

        public string Add(int a, int b )
        {
        
            string message = HttpUtility.HtmlEncode("a = " + a + "&" + "b = " + b);
            return message;
        }

        public string Multiply(int a, int b)
        {
            string message = HttpUtility.HtmlEncode("a = " + a + "&" + "b = " + b);
            return message;
        }

        public ActionResult MultiplyInput()
        {
            return View();
        }
        public ActionResult MultiplyModel(Input input)
        {
            return Content((input.a * input.b).ToString());
        }
        public ActionResult MultiplyModelInput()
        {
            return View();
        }
    }
}
