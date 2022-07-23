using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Progetto.Models;
using Progetto.ViewModels;
using static Progetto.Models.ApplicationUser;
//using Progetto.OrdineService;

namespace Progetto.Controllers
{
    public class ordiniController : Controller
    {
        //private OrdineServiceClient osc = new OrdineServiceClient();

        private ApplicationDbContext _context;
        public ordiniController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }



        public ActionResult PDetails(int Id)
        {
            var pianta = _context.piantas.SingleOrDefault(p => p.Id == Id);
            //var pianta = osc.findp(Id);

            if (pianta == null)
                return HttpNotFound();

            return Content("Pianta: " + pianta.nome + "<br />" + "Ordinata: " + pianta.ordinata + "<br />" + "Prezzo pianta: " + pianta.prezzopianta + "<br />" + "Prezzo lavoro: " + pianta.prezzolavoro + "<br />" + "Taglia: " + pianta.taglia + "<br />" + "Codice: " + pianta.Id);
        }



        [Authorize]
        public ViewResult New()
        {
            var piante = _context.piantas.Where(p => p.ordinata == false).ToList();
            
            var viewModel = new acquistopiantaViewModel
            {
                Piante = piante
            };
            return View(viewModel);
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.ordine ordine)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new acquistopiantaViewModel
                {
                    ordine = ordine,
                    Piante = _context.piantas.ToList()
                };
                return View("New", viewModel);
            }
            ordine.completato = false;
            if(ordine.cod_ordine == 0)
                _context.ordines.Add(ordine);
            _context.SaveChanges();
            var ord = _context.ordines.Include(o => o.pianta).Include(o => o.giardiniere).First(o => o.cod_ordine == ordine.cod_ordine); //indivord
            ord.pianta.ordinata = true;//
            _context.SaveChanges();
            return RedirectToAction("Index", "ordini");
        }

        public ActionResult Index()
        {
            var ordini = _context.ordines.Include(o => o.pianta).Include(o => o.giardiniere).Include(o => o.paesaggista).ToList();
            //var ordini = osc.findAll();

            return View(ordini);
        }

        

        //([HttpGet]
        public ActionResult giardselect()
        {
            var viewModel = new acquistopiantaViewModel
            {
                Giardinieri = _context.giardinieres.ToList(),
                giardiniere = new Models.giardiniere(),
                Ordini = _context.ordines.Where(o => o.giardiniereId == null).ToList(),
                Piante = _context.piantas.ToList()
            };

            return View(viewModel);
        }

        
        
        [HttpPost]
        public ActionResult Complete(Models.ordine ordine, Models.giardiniere giardiniere) //aggiungo un giardiniere a ordine e setto completato = true
        {
            var ord = _context.ordines.Include(g => g.giardiniere).Include(o => o.pianta).First(o => o.cod_ordine == ordine.cod_ordine);
            if (ord.giardiniereId != null)
            {
                return Content("Ordine già preso in carica da un altro giardiniere MAT: " + ord.giardiniereId);
            }
            ord.completato = true;
            ord.giardiniereId = giardiniere.MATgiard;
            _context.SaveChanges();
            return View(ord);
        }



        public ActionResult infogiard() //ci ho messo un'intera giornata
        {
            var numperg = _context.ordines.Include(g => g.giardiniere).Include(g => g.pianta).Where(g => g.giardiniereId != null)
                .GroupBy(g => new { g.giardiniereId, g.giardiniere.nome, g.giardiniere.cognome, g.giardiniere.email })
                .Select(grp => new riassuntoGiard
                {
                    ID = (int)grp.Key.giardiniereId,
                    nome = grp.Key.nome,
                    cognome = grp.Key.cognome,
                    email = grp.Key.email,
                    guadagno = grp.Sum(a => a.pianta.prezzolavoro),
                    noexe = grp.Count()
                });

            return View(numperg.AsNoTracking().ToList());
        }
    }
}