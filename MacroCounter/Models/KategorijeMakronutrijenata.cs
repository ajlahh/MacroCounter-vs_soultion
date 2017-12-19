using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MacroCounter.Models
{
    public class KategorijeMakronutrijenata
    {
        [Key]
        public int KategorijaMakronutrijentaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}