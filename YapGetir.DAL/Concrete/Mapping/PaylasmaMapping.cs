using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class PaylasmaMapping : EntityTypeConfiguration<Paylasma>
    {
        public PaylasmaMapping()
        {
            HasRequired(a => a.Restoran)
                .WithMany(a => a.Paylasmas)
                .HasForeignKey(a => a.RestoranID)
                .WillCascadeOnDelete(false);

            HasRequired(a => a.Asci)
               .WithMany(a => a.Paylasmas)
               .HasForeignKey(a => a.AsciID)
               .WillCascadeOnDelete(false);

            HasRequired(a => a.Tarif)
               .WithMany(a => a.Paylasmas)
               .HasForeignKey(a => a.TarifID)
               .WillCascadeOnDelete(false);

        }
    }
}
