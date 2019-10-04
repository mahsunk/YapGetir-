using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class TarifMapping : EntityTypeConfiguration<Tarif>
    {
        public TarifMapping()
        {
            HasRequired(a => a.Kategori)
               .WithMany(a => a.Tarifs)
               .HasForeignKey(a => a.KategoriID)
               .WillCascadeOnDelete(false);

            HasRequired(a => a.Puanlama)
             .WithMany(a => a.Tarifs)
             .HasForeignKey(a => a.PuanlamaID)
             .WillCascadeOnDelete(false);

        }
    }
}
