using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Progetto.Models
{
    [Serializable]
    public class ordine
    {
        [Key]
        public int cod_ordine { get; set; }

        [min3ganticipo]
        public DateTime termine { get; set; }
        public bool completato { get; set; }
        public float latitudine { get; set; }
        public float longitudine { get; set; }

        [ForeignKey("pianta")]
        public int piantaId { get; set; }

        [ForeignKey("giardiniere")]
        public int? giardiniereId { get; set; }

        [ForeignKey("paesaggista")]
        public int? paesaggistaId { get; set; }



        //convenzione: aggiungo Id alla fine: signnifica che è una foreign key invece di fare: public paesaggista email_paesaggista { get; set; }
        public pianta pianta { get; set; }
        public giardiniere giardiniere { get; set; }
        public paesaggista paesaggista { get; set; }


    }

}