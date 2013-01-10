using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antykwariat.Models;

namespace Antykwariat.Controllers
{
    public class SklepController : Controller
    {
        AntykwariatEntities sklepDB = new AntykwariatEntities();

        public ActionResult Index()
        {
            var gatunki = sklepDB.Gatunki.ToList();

            return View(gatunki);
        }


        public ActionResult Browse(string gatunek)
        {
            var gatunekModel = sklepDB.Gatunki.Include("Ksiazki").Single(g => g.Nazwa == gatunek);

            return View(gatunekModel);
        }


        public ActionResult Details(int id)
        {
            var ksiazka = sklepDB.Ksiazki.Find(id);

            return View(ksiazka);
        }



        [ChildActionOnly]
        public ActionResult GatunekMenu()
        {
            var gatunki = sklepDB.Gatunki.ToList();

            return PartialView(gatunki);
        }

    }
}