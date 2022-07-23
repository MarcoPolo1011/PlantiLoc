using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Progetto.Models.ApplicationUser;
using Progetto.Models;
using Progetto.GiardiniereService;
using System.Data.Entity.Validation;

namespace Progetto.Controllers
{
    public class giardinieriController : Controller
    {
        private GiardiniereServiceClient gsc = new GiardiniereServiceClient(); //uso servizio WCF

        private ApplicationDbContext _context;
        

        public ActionResult Index()
        {
            //var giardinieri = _context.giardinieres.ToList();
            var giardinieri = gsc.findAll(); //uso servizio WCF

            gsc.Close();
            return View(giardinieri);
        }

        
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(GiardiniereService.giardiniere giardiniere)
        {
            if (!ModelState.IsValid)
            {
                return View("New", giardiniere);
            }
            //_context.giardinieres.Add(giardiniere);
            //_context.SaveChanges();
            try
            {
                gsc.Addgiard(giardiniere); //uso servizio WCF per creare nuovo giardiniere
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            gsc.Close();
            return RedirectToAction("Index", "giardinieri");
        }


        public JsonResult IsEmail(string email) //per che email siano univoche al registro di un nuovo giardiniere
        {
            return Json(!gsc.visemail(email), JsonRequestBehavior.AllowGet); //uso servizio WCF per controllare se email già in uso quando creo nuovo giardiniere
            gsc.Close();
        }

    }
}