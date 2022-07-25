using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace Progetto.Models
{
    public class paesaggista
    {
        [Key]
        public int identificativo { get; set; }


        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        [Remote("IsEmail", "paesaggisti", ErrorMessage = "email gia in uso")]
        [EmailAddress]
        public string email { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }

    }

}