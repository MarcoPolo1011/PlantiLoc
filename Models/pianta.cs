using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Progetto.Models
{
    public class pianta
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