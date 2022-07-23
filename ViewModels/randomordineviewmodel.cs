using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Progetto.Models;

namespace Progetto.ViewModels
{
    public class randomordineviewmodel
    {
        public ordine ordine { get; set; }
        public List<pianta> piante { get; set; }
    }
}