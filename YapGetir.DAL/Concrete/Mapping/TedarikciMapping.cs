using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class TedarikciMapping : EntityTypeConfiguration<Tedarikci>
    {
        public TedarikciMapping()
        {
            HasRequired(a => a.UyeFormu)
               .WithMany(a => a.Tedarikcis)
               .HasForeignKey(a => a.UyeID)
               .WillCascadeOnDelete(false);


            HasRequired(a => a.Restoran)
           .WithMany(a => a.Tedarikcis)
           .HasForeignKey(a => a.RestoranID)
           .WillCascadeOnDelete(false);
        }
    }
}
