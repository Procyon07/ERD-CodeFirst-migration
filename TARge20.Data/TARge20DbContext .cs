using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARge20.Core.Domain;

namespace TARge20.Data
{
    public class TARge20DbContext : DbContext
    {

        public TARge20DbContext(DbContextOptions<TARge20DbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Tootaja> Tootaja { get; set; }
        public DbSet<Lapsed> Lapsed { get; set; }
        public DbSet<Laenatud> Laenatud { get; set; }
        public DbSet<AmetiNimetus> AmetiNimetus { get; set; }
        public DbSet<FirmaHarukontor> FirmaHarukontor { get; set; }
        public DbSet<FirmaPeakontor> FirmaPeakontor { get; set; }
        public DbSet<HaigusLehed> HaigusLehed { get; set; }
        public DbSet<Ligipaasuload> Ligipaasuload { get; set; }
        public DbSet<TerviseKontroll> TerviseKontroll { get; set; }
        public DbSet<Vihje> Vihje { get; set; }
        public DbSet<Palve> Palve { get; set; }
        public DbSet<PuhkusteNimekiri> PuhkusteNimekiri { get; set; }
    }
}