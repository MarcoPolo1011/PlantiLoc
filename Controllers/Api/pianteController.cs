using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Progetto.Dtos;
using Progetto.Models;
using static Progetto.Models.ApplicationUser;

namespace Progetto.Controllers.Api
{
    public class pianteController : ApiController
    {
        private ApplicationDbContext _context;
        public pianteController()
        {
            _context = new ApplicationDbContext();
        }

       //GET/api/piante
        public IEnumerable<pianta> GetPiante()
        {
            return _context.piantas.ToList();
        }

        //GET /api/piante/1
        public IHttpActionResult Getpianta(int id)
        {
            var pianta = _context.piantas.SingleOrDefault(o => o.Id == id);
            if (pianta == null)
                return NotFound();
            return Ok(Mapper.Map<pianta, piantaDto>(pianta));
        }

        //DELETE /api/piante/1
        [HttpDelete]
        public void Deletepianta(int id)
        {
            var piantaInDb = _context.piantas.SingleOrDefault(o => o.Id == id);

            if (piantaInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            _context.piantas.Remove(piantaInDb);
            _context.SaveChanges();
        }


        //POST/api/piante
        [HttpPost]
        public IHttpActionResult Createordine(piantaDto piantaDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var pianta = Mapper.Map<piantaDto,pianta>(piantaDto);
            _context.piantas.Add(pianta);
            _context.SaveChanges();

            piantaDto.Id = pianta.Id;
            return Created(new Uri(Request.RequestUri + "/" + pianta.Id), piantaDto);
        }


        //PUT/api/piante
        [HttpPut]
        public void Updateordine(int id, piantaDto piantaDto)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());

            var piantaInDb = _context.piantas.SingleOrDefault(o => o.Id == id);

            if (piantaInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            Mapper.Map(piantaDto, piantaInDb);

            _context.SaveChanges();
        }
    }
}

