using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class UyeFormuMapping : EntityTypeConfiguration<UyeFormu>
    {
        public UyeFormuMapping()
        {
            HasRequired(a => a.UyeTip)
               .WithMany(a => a.UyeFormus)
               .HasForeignKey(a => a.TipID)
               .WillCascadeOnDelete(false);

            //eklenen mapping işlemi
            HasMany(a => a.Restorans)
                .WithRequired(a => a.UyeFormu)
                .HasForeignKey(a => a.UyeID)
                .WillCascadeOnDelete(false);
        }
    }
}
