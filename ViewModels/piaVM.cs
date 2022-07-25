using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.ViewModels
{
    public class piaVM
    {
        [Key]
        public int plantId { get; set; }
        public float latitudine { get; set; }
        public float longitudine { get; set; }
    }
}