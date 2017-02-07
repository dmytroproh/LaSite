using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LaSite.Models;

namespace LaSite.Controllers
{
    public class HomeController : Controller
    {


        WorkOfArtContext db = new WorkOfArtContext();

        public ActionResult Index()
        {
           
            IEnumerable<WorkOfArt> workOfArts = db.WorkOfArts;

            ViewBag.WorkOfArts = workOfArts;
      
            return View();
        }
    }
}