using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class Narudzba
    {
        public int NarudzbaId { get; set; }
        public int BrojNarudzbe { get; set; }
        public DateTime Datum { get; set; }
        public int KorisnikId { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public decimal Iznos { get; set; }
        public int StatusNarudzbeId { get; set; }
        public virtual StatusNarudzbe StatusNarudzbe { get; set; }
    }
}