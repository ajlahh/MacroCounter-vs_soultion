using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MacroCounter.Controllers
{
    public class NamirniceController : ApiController
    {
        private Context ctx = new Context();

        public class NamirniceInfo
        {
            public int id { get; set; }
            public string naziv { get; set; }
            public string opis { get; set; }
            public int kalorijskaVrijednost { get; set; }
            public int proteini { get; set; }
            public int ugljikohidrati { get; set; }
            public int masti { get; set; }
        }

        public class VM
        {
            public List<NamirniceInfo> namirniceLista { get; set; }
        }
        
        [HttpGet]
        public VM GetAll()
        {
            return new VM
            {
                namirniceLista = ctx.Namirnice
                    .Select(x => new NamirniceInfo
                    {
                        id = x.NamirnicaId,
                        naziv = x.Naziv,
                        opis = x.Opis,
                        kalorijskaVrijednost= x.KalorijskaVrijednost,
                        proteini=x.Proteini,
                        ugljikohidrati=x.Ugljikohidrati,
                        masti=x.Masti
                    }).ToList()
            };
        }
        [HttpGet]
        public NamirniceInfo GetById(int id)
        {
            NamirniceInfo model = ctx.Namirnice.Where(x => x.NamirnicaId == id).Select(s => new NamirniceInfo
            {
                id=s.NamirnicaId,
                naziv = s.Naziv,
                opis = s.Opis,
                kalorijskaVrijednost = s.KalorijskaVrijednost,
                proteini = s.Proteini,
                ugljikohidrati = s.Ugljikohidrati,
                masti = s.Masti
            }).SingleOrDefault();

            return model;
        }
    }
}
