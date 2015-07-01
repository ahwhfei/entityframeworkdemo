using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication4.Models;
using MvcApplication4.Models.Repository;

namespace MvcApplication4.Controllers
{
    public class ArtistsController : Controller
    {
        //private MusicStoreDataContext db = new MusicStoreDataContext();
        private ArtistRepository repository = new ArtistRepository();

        //
        // GET: /Artists/

        public ActionResult Index()
        {
            //return View(db.Artists.ToList());
            return View(repository.GetAll());
        }

        //
        // GET: /Artists/Details/5

        public ActionResult Details(int id = 0)
        {
            Artist artist = repository.Get(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            return View(artist);
        }

        //
        // GET: /Artists/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Artists/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Artist artist)
        {
            if (ModelState.IsValid)
            {
                //db.Artists.Add(artist);
                repository.Add(artist);
                //db.SaveChanges();
                repository.SaveChange();
                return RedirectToAction("Index");
            }

            return View(artist);
        }

    }
}