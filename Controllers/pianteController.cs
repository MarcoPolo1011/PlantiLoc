using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Progetto.Models;
using Progetto.ViewModels;
using System.Data.SqlClient;
using static Progetto.Models.ApplicationUser;
using System.Data.Entity;
using System.Data.Entity.Validation;
using Progetto.PiantaService;

namespace Progetto.Controllers
{
    public class pianteController : Controller
    {
        private PiantaServiceClient psc = new PiantaServiceClient();

        public ActionResult Index()
        {
            var piante = psc.findAll();
            psc.Close();
            if (User.IsInRole(RoleName.CanManagePlants)) //solamente admin e m@l.com possono apportare modofiche a piante, chiunque altro puo solo vedere la lista di piante
                return View("Index", piante);
            
            return View("ReadOnlyList", piante);
        }


        public ActionResult Details(int Id)
        {
            var pianta = psc.find(Id);

            psc.Close();
            if (pianta == null)
                return HttpNotFound();

            return Content(pianta.nome + "<br />" + pianta.ordinata + "<br />" + pianta.prezzopianta + "<br />" + pianta.prezzolavoro + "<br />" + pianta.taglia);
        }


        [Authorize(Roles = RoleName.CanManagePlants)]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PiantaService.pianta pianta)
        {
            if (!ModelState.IsValid)
            {
                return View("New", pianta);
            }
            pianta.ordinata = false;
            try
            {
                psc.Addpianta(pianta);
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            psc.Close();
            return RedirectToAction("Index", "piante");
        }



    }
}