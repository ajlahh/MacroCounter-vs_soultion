using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Biljeske { get; set; }        
    }
}