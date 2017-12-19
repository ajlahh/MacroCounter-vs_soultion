using MacroCounter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace MacroCounter.Controllers
{
    public class AutentifikacijaController : ApiController
    {
        [HttpGet]
        public AutentifikacijaProvjeraVM Provjera(string korisnickoIme, string lozinka)
        {
            Context ctx = new Context();

            AutentifikacijaProvjeraVM model = ctx.Korisnik.Where(x => x.KorisnickoIme == korisnickoIme && x.Lozinka == lozinka)
                .Select(x => new AutentifikacijaProvjeraVM
                {
                    KorisnikId = x.KorisnikId,
                    Id = x.KorisnikId.ToString(),
                    Ime = x.Ime,
                    Prezime = x.Prezime,
                    KorisnickoIme = x.KorisnickoIme
                }).SingleOrDefault();

            return model;
        }

        /*
        [ResponseType(typeof(AutentifikacijaProvjeraVM))]
        public IHttpActionResult PutKorisnik(AutentifikacijaProvjeraVM korisnik)
        {

            Context ctx = new Context();

            Korisnik k = ctx.Korisnici.Find(int.Parse(korisnik.id));
            k.Ime = korisnik.Ime;
            k.Prezime = korisnik.Prezime;
            k.DatumRodjenja = DateTime.Parse(korisnik.DatumRodjenja);

            ctx.Entry(k).State = EntityState.Modified;
            ctx.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = korisnik.id }, korisnik);
        }
        */
    }
}