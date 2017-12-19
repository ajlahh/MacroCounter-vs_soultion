using MacroCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.ViewModels
{
    public class AktivnaNarudzbaStavkeVM
    {
        public virtual Artikal Artikal { get; set; }
        public int ArtikalId { get; set; }
        public int Kolicina { get; set; }
    }
}