using MacroCounter.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MacroCounter
{
    public class Context:DbContext
    {
        public Context() : base("name=MojCS")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }
        
        public DbSet<Artikal> Artikal { get; set; }
        public DbSet<KategorijaArtikla> KategorijaArtikla { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Namirnice> Namirnice { get; set; }
        public DbSet<Narudzba> Narudzba { get; set; }
        public DbSet<NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<StatusNarudzbe> StatusNarudzbe { get; set; }
        public DbSet<KategorijeNamirnica> KategorijeNamirnica { get; set; }
        public DbSet<KategorijeMakronutrijenata> KategorijeMakronutrijenata { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}