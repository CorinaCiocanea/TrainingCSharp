using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcTask.Models;
using System.Data.Entity;
using System.Data;

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
        public ActionResult Create(int parentListId)
        {
            ViewBag.TaskId = new SelectList(db.Tasks, "TaskId");
            //ViewBag.ParentListId = parentListId;
          //  Task task = new Task();
          //  task.ListGenId = parentListId;
           // task.Deadline = DateTime.Now;
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Task task, int parentListId)
        {
           
            if (ModelState.IsValid)
            {
               
               // task.ListGenId = parentListId;
               // list.Tasks.Add(task);
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Edit", "StoreListGen", new { id = task.ListGenId });
            }
            ViewBag.ListGenId = new SelectList(db.Tasks, "TaskId");
            return View(task);
        }
        public ActionResult Edit(int id)
        {
            Task task = db.Tasks.Find(id);
            ViewBag.GenreId = new SelectList(db.Tasks, "TaskId", "Name", task.TaskId);
            return View(task);
        }
        [HttpPost]
        public ActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreId = new SelectList(db.Tasks, "TaskId", "Name", task.TaskId);
            return View(task);
        }
        public ActionResult Delete(int id)
        {
            Task task = db.Tasks.Find(id);
            return View(task);
        }

        //
        // POST: /StoreManager/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            Task task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

    }
}
