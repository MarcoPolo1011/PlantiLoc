using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Progetto.Models;
using static Progetto.Models.ApplicationUser;
using Progetto.PaesaggistaService;
using System.Data.Entity.Validation;

namespace Progetto.Controllers
{
    public class paesaggistiController : Controller
    {
        private PaesaggistaServiceClient psc = new PaesaggistaServiceClient();

        public ActionResult Index()
        {
            var paesaggisti = psc.findAll(); //uso servizio WCF per visualizzare tutti i paesaggisti

            psc.Close();
            return View(paesaggisti);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaesaggistaService.paesaggista paesaggista)
        {
            if (!ModelState.IsValid)
            {
                return View("New", paesaggista);
            }
            try
            {
                psc.Addpaes(paesaggista); //uso servizio WCF per aggiungere un paesaggista
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            psc.Close();
            return RedirectToAction("Index", "paesaggisti");
        }


        public JsonResult IsEmail(string email) //per che email siano univoche quando registro un nuovo paesaggista
        {
            return Json(!psc.visemail(email), JsonRequestBehavior.AllowGet); //uso servizio WCF che ritorna un bool per controllare se email è già in uso
            psc.Close();
        }
        

    }
}