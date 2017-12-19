using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MacroCounter.Controllers
{
    public class KategorijeMakronutrijenataController : ApiController
    {
        private Context ctx = new Context();

        public class KategorijeInfo
        {
            public int id { get; set; }
            public string naziv { get; set; }
            public string opis { get; set; }
        }

        public class VM
        {
            public List<KategorijeInfo> kategorijeLista { get; set; }
        }
        [HttpGet]
        public VM GetAll()
        {
            return new VM
            {
                kategorijeLista = ctx.KategorijeMakronutrijenata
                    .Select(x => new KategorijeInfo
                    {
                        id = x.KategorijaMakronutrijentaId,
                        naziv = x.Naziv,
                        opis = x.Opis
                    }).ToList()
            };
        }
    }
}
