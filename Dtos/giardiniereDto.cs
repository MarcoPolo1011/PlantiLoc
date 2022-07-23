using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Dtos
{
    public class giardiniereDto
    {
        [Key]
        public int MATgiard { get; set; }

        public string email { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
    }
}