using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Progetto.Dtos;
using Progetto.Models;

namespace Progetto.Controllers.Api
{
    public class paesaggistiController : ApiController
    {
        private ApplicationDbContext _context;
        public paesaggistiController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/paesaggisti
        public IEnumerable<paesaggista> GetPaesaggisti()
        {
            return _context.paesaggistas.ToList();
        }

        //GET /api/piante/1
        public IHttpActionResult Getpaesaggista(int id)
        {
            var paesaggista = _context.paesaggistas.SingleOrDefault(o => o.identificativo == id);
            if (paesaggista == null)
                return NotFound();
            return Ok(Mapper.Map<paesaggista, paesaggistaDto>(paesaggista));
        }

        //DELETE /api/paesaggisti/1
        [System.Web.Mvc.HttpDelete]
        public void Deletepaesaggista(int id)
        {
            var paesaggistaInDb = _context.paesaggistas.SingleOrDefault(o => o.identificativo == id);

            if (paesaggistaInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            _context.paesaggistas.Remove(paesaggistaInDb);
            _context.SaveChanges();
        }


        //POST/api/paesaggisti
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Createpaesaggista(paesaggistaDto paesaggistaDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var paesaggista = Mapper.Map<paesaggistaDto, paesaggista>(paesaggistaDto);
            _context.paesaggistas.Add(paesaggista);
            _context.SaveChanges();

            paesaggistaDto.identificativo = paesaggista.identificativo;
            return Created(new Uri(Request.RequestUri + "/" + paesaggista.identificativo), paesaggistaDto);
        }


        //PUT/api/paesaggisti
        [System.Web.Mvc.HttpPut]
        public void Updatepaesaggista(int id, paesaggistaDto paesaggistaDto)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());

            var paesaggistaInDb = _context.paesaggistas.SingleOrDefault(o => o.identificativo == id);

            if (paesaggistaInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            Mapper.Map(paesaggistaDto, paesaggistaInDb);

            _context.SaveChanges();
        }

    }
}