using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Progetto.ViewModels
{
    public class riassuntoGiard
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        [Remote("IsEmail", "giardinieri", ErrorMessage = "email gia in uso")]
        [EmailAddress]
        public string email { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
        public int noexe { get; set; }
        public double guadagno { get; set; }
    }
}