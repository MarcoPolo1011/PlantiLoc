using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Progetto.Models;

namespace Progetto.Dtos
{
    public class ordineDto //USO DTO PER SICUREZZA (PER EVITARE DI DOVER ACCEDERE AL SERVER NELL'API ORDINI)
    {
        [Key]
        public int cod_ordine { get; set; }

        //[min3ganticipo]
        public DateTime termine { get; set; }
        public bool completato { get; set; }
        public float latitudine { get; set; }
        public float longitudine { get; set; }

        [ForeignKey("pianta")]
        public int piantaId { get; set; }
        public pianta pianta { get; set; }
        public virtual giardiniere giardiniere { get; set; }
        public virtual paesaggista paesaggista { get; set; }
    }

}