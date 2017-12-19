using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class KategorijeNamirnica
    {
            [Key]
            public int KategorijaNamirniceId { get; set; }
            public string Naziv { get; set; }
            public string Opis { get; set; }
        }
}