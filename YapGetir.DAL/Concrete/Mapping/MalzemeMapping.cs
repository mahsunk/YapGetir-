using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetir.Model;

namespace YapGetir.DAL.Concrete.Mapping
{
    public class MalzemeMapping : EntityTypeConfiguration<Malzeme>
    {
        public MalzemeMapping()
        {
            HasRequired(a => a.Tarif)
                .WithMany(a => a.Malzemes)
                .HasForeignKey(a => a.TarifID)
                .WillCascadeOnDelete(false);
        }
    }
}
