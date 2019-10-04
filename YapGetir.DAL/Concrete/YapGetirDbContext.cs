using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using YapGetir.DAL.Concrete.Mapping;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete
{
    public class YapGetirDbContext : DbContext
    {
        public YapGetirDbContext() : base("Server=DESKTOP-4ED5LPQ; Database=YapGetirDB;Integrated Security=true")
        {
            Database.SetInitializer<YapGetirDbContext>(new MyStrategy());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AsciMapping());
            modelBuilder.Configurations.Add(new KampanyaMapping());
            modelBuilder.Configurations.Add(new KategoriMapping());
            modelBuilder.Configurations.Add(new KategoriTurMapping());
            modelBuilder.Configurations.Add(new MalzemeMapping());
            modelBuilder.Configurations.Add(new OdemeMapping());
            modelBuilder.Configurations.Add(new PaylasmaMapping());
            modelBuilder.Configurations.Add(new PuanlamaMapping());
            modelBuilder.Configurations.Add(new RestoranMapping());
            modelBuilder.Configurations.Add(new SiparisMapping());
            modelBuilder.Configurations.Add(new TarifMapping());
            modelBuilder.Configurations.Add(new TedarikciMapping());
            modelBuilder.Configurations.Add(new UrunMapping());
            modelBuilder.Configurations.Add(new UyeFormuMapping());
            modelBuilder.Configurations.Add(new UyeTipMapping());
            modelBuilder.Configurations.Add(new YorumMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Asci> Asci { get; set; }
        public DbSet<Kampanya> Kampanya { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        public DbSet<KategoriTur> KategoriTur { get; set; }
        public DbSet<Malzeme> Malzeme { get; set; }
        public DbSet<Odeme> Odeme { get; set; }
        public DbSet<Paylasma> Paylasma { get; set; }
        public DbSet<Puanlama> Puanlama { get; set; }
        public DbSet<Restoran> Restoran { get; set; }
        public DbSet<Siparis> Siparise { get; set; }
        public DbSet<Tarif> Tarif { get; set; }
        public DbSet<Tedarikci> Tedarikci { get; set; }
        public DbSet<Urun> Urun { get; set; }
        public DbSet<UyeFormu> UyeFormu { get; set; }
        public DbSet<UyeTip> UyeTip { get; set; }
        public DbSet<Yorum> Yorum { get; set; }

    }
}
