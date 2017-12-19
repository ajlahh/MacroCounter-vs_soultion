using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class NarudzbaStavke
    {
        public int NarudzbaStavkeId { get; set; }
        public int NarudzbaId { get; set; }
        public virtual Narudzba Narudzba { get; set; }
        public int ArtikalId { get; set; }
        public virtual Artikal Artikal { get; set; }
        public int Kolicina { get; set; }
    }
}