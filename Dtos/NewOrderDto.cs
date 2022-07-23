using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Progetto.Models;

namespace Progetto.Dtos
{
    public class NewOrderDto
    {
        public int paesaggistaId { get; set; }
        public int piantaId { get; set; }
        public DateTime termine { get; set; }
        public float latitudine { get; set; }
        public float longitudine { get; set; }
    }
}