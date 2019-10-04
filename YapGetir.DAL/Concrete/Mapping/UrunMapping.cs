using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class UrunMapping : EntityTypeConfiguration<Urun>
    {
        public UrunMapping()
        {
            HasRequired(a => a.Kategori)
            .WithMany(a => a.Uruns)
            .HasForeignKey(a => a.KategoriID)
            .WillCascadeOnDelete(false);

            HasRequired(a => a.Tedarikci)
         .WithMany(a => a.Uruns)
         .HasForeignKey(a => a.TedarikciID)
         .WillCascadeOnDelete(false);

            HasRequired(a => a.UyeFormu)
         .WithMany(a => a.Uruns)
         .HasForeignKey(a => a.UyeID)
         .WillCascadeOnDelete(false);
        }
    }
}
