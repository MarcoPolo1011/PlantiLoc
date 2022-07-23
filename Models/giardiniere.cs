using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Progetto.Models
{
    [Serializable]
    public class giardiniere
    {
        [Key]
        public int MATgiard { get; set; }

        [Required(ErrorMessage = "email is required")]
        [DataType(DataType.EmailAddress)]
        [Remote("IsEmail", "giardinieri", ErrorMessage = "email gia in uso")]
        [EmailAddress]
        public string email { get; set; }
        public string nome { get; set; }
        public string cognome { get; set; }
    }

}