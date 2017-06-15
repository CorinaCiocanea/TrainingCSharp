using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTask.Models;
using System.Data.Entity;
using System.Data;
using    System.Web.Mvc.Html;

namespace MvcTask.Controllers
{
    public class StoreTaskController : Controller
    {
        private TaskEntities db = new TaskEntities();

        public ActionResult Index()
        {
            var tasks = db.Tasks.ToList();

            return View(tasks);
        }
        public ActionResult Create(int? parentListId)
        {
            ViewBag.TaskId = new SelectList(db.Tasks, "TaskId");
            //ViewBag.ParentListId = parentListId;
          //  Task task = new Task();
          //  task.ListGenId = parentListId;
           // task.Deadline = DateTime.Now;
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Task task, int? parentListId)
        {
           
            if (ModelState.IsValid)
            {
               
                task.ListGenId = parentListId;
               // list.Tasks.Add(task);
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Edit", "StoreListGen", new { listId = task.ListGenId });
            }
            ViewBag.ListGenId = new SelectList(db.Tasks, "TaskId");
            return View(task);
        }
        public ActionResult Edit(int? parentListId)
        {
            Task task = db.Tasks.Find(parentListId);
            ViewBag.TaskId = new SelectList(db.Tasks, "TaskId", "Name", task.TaskId);
            return View(task);
        }
        [HttpPost]
        public ActionResult Edit(Task task, int? parentListId)
        {
            if (ModelState.IsValid)
            {
                //task.ListGenId = parentListId;
                db.Entry(task).State = EntityState.Modified;
                task.ListGenId = parentListId;
                db.SaveChanges();
                return RedirectToAction("Edit", "StoreListGen", new { listId = task.ListGenId });
            }
            ViewBag.TaskId = new SelectList(db.Tasks, "TaskId", "Name", task.TaskId);
            return View(task);
        }
        public ActionResult Delete(int parentListId)
        {
            Task task = db.Tasks.Find(parentListId);
            return View(task);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost]
        public ActionResult Delete(int parentListId, FormCollection collection)
        {
       
            Task task = db.Tasks.Find(parentListId);
         //  task.ListGenId = parentListId;
            db.Tasks.Remove(task);
            db.SaveChanges();
          // task.ListGenId = parentListId;
            return RedirectToAction("Index");
           // return RedirectToAction("Edit", "StoreListGen", new { listId = task.ListGenId });

        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
