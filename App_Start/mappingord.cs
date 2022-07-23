using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Progetto.Dtos;
using Progetto.Models;

namespace Progetto.App_Start
{
    public class mappingord : Profile
    {
        public mappingord()
        {
            Mapper.CreateMap<ordine, ordineDto>();
            Mapper.CreateMap<ordineDto, ordine>();
            Mapper.CreateMap<paesaggista, paesaggistaDto>();
            Mapper.CreateMap<paesaggistaDto, paesaggista>();
            Mapper.CreateMap<giardiniere, giardiniereDto>();
            Mapper.CreateMap<giardiniereDto, giardiniere>();
            Mapper.CreateMap<pianta, piantaDto>();
            Mapper.CreateMap<piantaDto, pianta>();
        }
    }
}