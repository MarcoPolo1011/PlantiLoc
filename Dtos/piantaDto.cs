using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Dtos
{
    public class piantaDto
    {
        [Key]
        public int Id { get; set; }
        public string nome { get; set; }
        public int taglia { get; set; }
        public bool ordinata { get; set; }
        public double prezzopianta { get; set; }
        public double prezzolavoro { get; set; }
    }
}