using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Progetto.Models
{
    public class min3ganticipo : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ordine = (ordine)validationContext.ObjectInstance;
            DateTime mindata = DateTime.Now.AddDays(3); //voglio minimo 3 giorni di preavviso

            if (ordine.termine >= mindata)
                return ValidationResult.Success;
            else
                return new ValidationResult("richiesti minimo 3 giorni di preavviso a partire dal " + DateTime.Now);
        }
    }
}