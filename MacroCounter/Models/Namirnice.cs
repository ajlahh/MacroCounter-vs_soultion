using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class Namirnice
    {
        [Key]
        public int NamirnicaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KalorijskaVrijednost { get; set; }
        public int Proteini { get; set; }
        public int Ugljikohidrati { get; set; }
        public int Masti { get; set; }
    }
}