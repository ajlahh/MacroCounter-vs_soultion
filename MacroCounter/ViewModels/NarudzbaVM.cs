using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MacroCounter.ViewModels
{
    public class NarudzbaVM
    {
        public class StavkeVM
        {
            public string Artikal { get; set; }
            public string Cijena { get; set; }
            public string Kolicina { get; set; }
        }
        public string BrojNarudzbe { get; set; }
        public decimal Iznos { get; set; }
        public List<StavkeVM> StavkeN { get; set; }
    }
}