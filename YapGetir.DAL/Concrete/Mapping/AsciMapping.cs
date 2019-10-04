using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class AsciMapping : EntityTypeConfiguration<Asci>
    {
        public AsciMapping()
        {
            HasRequired(a => a.Restoran)
                .WithMany(a => a.Ascis)
                .HasForeignKey(a => a.RestoranID)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Puanlama)
                .WithMany(a => a.Ascis)
                .HasForeignKey(a => a.PuanlamaID)
                .WillCascadeOnDelete(false);
        }
    }
}
