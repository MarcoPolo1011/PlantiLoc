using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Progetto.Dtos;
using Progetto.Models;

namespace Progetto.Controllers.Api
{
    public class NewOrderController : ApiController
    {

        private ApplicationDbContext _context;
        public NewOrderController()
        {
            _context = new ApplicationDbContext();
        }

       
      
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult CreateNewOrder(NewOrderDto newOrder)
        {

            var paesaggista = _context.paesaggistas.Single(p => p.identificativo == newOrder.paesaggistaId);

            var pianta = _context.piantas.Single(c => c.Id == newOrder.piantaId);

            if (pianta.ordinata == true)
                return BadRequest("Pianta non disponibile");

            var ordine = new ordine
            {
                paesaggista = paesaggista,
                pianta = pianta
            };
            _context.ordines.Add(ordine);


            return Ok();
        }
    }
}