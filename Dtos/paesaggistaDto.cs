using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Dtos
{
    public class paesaggistaDto
    {
        [Key]
        public int identificativo { get; set; }

        public string email { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

    }
}