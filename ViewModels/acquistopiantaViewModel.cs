using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Progetto.Models;

namespace Progetto.ViewModels
{
    public class acquistopiantaViewModel
    {
        public IEnumerable<pianta> Piante { get; set; }
        public pianta pianta { get; set; }
        public ordine ordine { get; set; }
        public giardiniere giardiniere { get; set; }
        public IEnumerable<ordine> Ordini { get; set; }
        public IEnumerable<giardiniere> Giardinieri { get; set; }
    }
}