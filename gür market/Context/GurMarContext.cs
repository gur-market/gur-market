using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gür_market.sınıflar;


namespace gür_market.Context
{
    public class GurMarContext : DbContext
    {
      
        public GurMarContext():base("dbConnection")
        {

            Database.SetInitializer(new DataInitializer());

        }
        public DbSet<Stok> Stoks { get; set; }
        public DbSet<Kasa> Kasas { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Tedarikci> Tedarikcis { get; set; }
        public DbSet<VeresiyeSatis> VeresiyeSatiss { get; set; }
        public DbSet<PesinSatis> PesinSatiss { get; set; }
        public DbSet<UrunAl> UrunAls { get; set; }

    }
}
