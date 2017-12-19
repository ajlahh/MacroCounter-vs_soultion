using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.Models
{
    public class AutentifikacijaProvjeraVM
    {
        public int KorisnikId { get; set; }
        public string Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
    }
}