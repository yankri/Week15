using MyCloset2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyClosetApp.Controllers
{
    public class HomeController : Controller
    {
        private MyCloset2Context db = new MyCloset2Context();

        public List<IPhotoGiver> GetListofAllItems ()
        {
            List<IPhotoGiver> allItems = new List<IPhotoGiver>();
            allItems.AddRange(db.Tops.ToList());
            allItems.AddRange(db.Bottoms.ToList());
            allItems.AddRange(db.Accessories.ToList());
            allItems.AddRange(db.Shoes.ToList());

            return allItems;
        }

        public ActionResult Index()
        {
            List <IPhotoGiver> allItems = GetListofAllItems();

            return View(allItems);
        }
        public ActionResult Spring()
        {
            List<IPhotoGiver> allItems = GetListofAllItems();

            return View(allItems);
        }
    }
}