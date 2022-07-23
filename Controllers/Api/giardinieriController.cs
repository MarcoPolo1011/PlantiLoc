using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Progetto.Dtos;
using Progetto.Models;

namespace Progetto.Controllers.Api
{
    public class giardinieriController : ApiController
    {
        private ApplicationDbContext _context;
        public giardinieriController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/giardinieri
        public IEnumerable<giardiniere> Getgiardinieri()
        {
            return _context.giardinieres.ToList();
        }

        //GET /api/ordini/1
        public IHttpActionResult Getgiardiniere(int id)
        {
            var giardiniere = _context.giardinieres.SingleOrDefault(o => o.MATgiard == id);
            if (giardiniere == null)
                return NotFound();
            return Ok(Mapper.Map<giardiniere, giardiniereDto>(giardiniere));
        }


        // PUT /api/giardinieri/
        [System.Web.Mvc.HttpPut]
        public void Updategiardiniere(int id, giardiniereDto giardiniereDto)
        {
            if (!ModelState.IsValid)
                throw new HttpRequestException(HttpStatusCode.BadRequest.ToString());

            var giardiniereInDb = _context.giardinieres.SingleOrDefault(o => o.MATgiard == id);

            if (giardiniereInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            Mapper.Map(giardiniereDto, giardiniereInDb);

            _context.SaveChanges();
        }


        //POST /api/giardinieri
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Creategiardiniere(giardiniereDto giardiniereDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var giardiniere = Mapper.Map<giardiniereDto, giardiniere>(giardiniereDto);
            _context.giardinieres.Add(giardiniere);
            _context.SaveChanges();

            giardiniereDto.MATgiard = giardiniere.MATgiard;
            return Created(new Uri(Request.RequestUri + "/" + giardiniere.MATgiard), giardiniereDto);
        }


        //DELETE /api/giardinieri/1
        [System.Web.Mvc.HttpDelete]
        public void Deletegiardiniere(int id)
        {
            var giardiniereInDb = _context.giardinieres.SingleOrDefault(o => o.MATgiard == id);

            if (giardiniereInDb == null)
                throw new HttpRequestException(HttpStatusCode.NotFound.ToString());

            _context.giardinieres.Remove(giardiniereInDb);
            _context.SaveChanges();
        }

    }
}