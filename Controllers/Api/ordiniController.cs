using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Progetto.Models;
using static Progetto.Models.ApplicationUser;
using System.Data.Entity;
using AutoMapper;
using Progetto.Dtos;

namespace Progetto.Controllers.Api
{
    public class ordiniController : ApiController
    {
        private ApplicationDbContext _context;
        public ordiniController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/ordini
        public IEnumerable<ordineDto> GetOrdini()
        {
            return _context.ordines.ToList().Select(Mapper.Map<ordine, ordineDto>);
        }


        //GET /api/ordini/1
        public IHttpActionResult Getordine(int id)
        {
            var ordine = _context.ordines.SingleOrDefault(o => o.cod_ordine == id);
            if (ordine == null)
                return NotFound();
            return Ok(Mapper.Map<ordine, ordineDto>(ordine));
        }


        //POST /api/ordini
        [HttpPost]
        public IHttpActionResult Createordine(ordineDto ordineDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var ordine = Mapper.Map<ordineDto, ordine>(ordineDto);
            _context.ordines.Add(ordine);
            _context.SaveChanges();

            ordineDto.cod_ordine = ordine.cod_ordine;
            return Created(new Uri(Request.RequestUri + "/" + ordine.cod_ordine), ordineDto);
        }

        // PUT /api/ordini/
        [HttpPut]
        public void Updateordine(int id, ordineDto ordineDto)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());

            var ordineInDb = _context.ordines.SingleOrDefault(o => o.cod_ordine == id);

            if (ordineInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            Mapper.Map(ordineDto, ordineInDb);

            _context.SaveChanges();
        }


        //DELETE /api/ordini/1
        [HttpDelete]
        public void Deleteordine(int id)
        {
            var ordineInDb = _context.ordines.SingleOrDefault(o => o.cod_ordine == id);

            if (ordineInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            _context.ordines.Remove(ordineInDb);
            _context.SaveChanges();
        }
    }



    
    
}
