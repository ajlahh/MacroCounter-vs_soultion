using MacroCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.ViewModels
{
    public class ArtikalVM
    {
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public int KategorijaArtiklaID { get; set; }
        public virtual KategorijaArtikla KategorijaArtikla { get; set; }
        public string Proizvodjac { get; set; }
        public decimal Cijena { get; set; }


        //public byte[] Slika { get; set; }
        public string Slika { get; set; }
    }
}