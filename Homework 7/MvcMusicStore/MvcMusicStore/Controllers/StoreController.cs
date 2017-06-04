using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;

namespace MvcMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
           // var genres1 = storeDB.Albums.ToList();
            //var genres = new List<Genre>
            //{
            //    new Genre { Name = "Disco"},
            //    new Genre { Name = "Jazz" },
            //    new Genre { Name = "Rock" }
            //};
            return View(genres);
        }
       
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);
            return View(genreModel);
        }
      
        public ActionResult Details(int id)
        {
            var album = storeDB.Albums.Find(id);
            this.ViewBag.Name = "test";
          
            return View(album);
        }

        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();

            return PartialView(genres);
        }

    }
}
