using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class KategoriMapping : EntityTypeConfiguration<Kategori>
    {
        public KategoriMapping()
        {
            HasRequired(a => a.KategoriTur)
               .WithMany(a => a.Kategoris)
               .HasForeignKey(a => a.KategoriTurID)
               .WillCascadeOnDelete(false);
        }
    }
}
