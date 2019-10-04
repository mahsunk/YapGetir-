using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class KampanyaMapping : EntityTypeConfiguration<Kampanya>
    {
        public KampanyaMapping()
        {
            HasRequired(a => a.Restoran)
               .WithMany(a => a.Kampanyas)
               .HasForeignKey(a => a.RestoranID)
               .WillCascadeOnDelete(false);

            HasRequired(a => a.Urun)
               .WithMany(a => a.Kampanyas)
               .HasForeignKey(a => a.UrunID)
               .WillCascadeOnDelete(false);
        }
    }
}
