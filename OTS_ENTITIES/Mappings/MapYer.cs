using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapYer: EntityTypeConfiguration<Yer>
    {
        public MapYer()
        {
            HasKey(x => x.YerId);
            Property(x => x.Ad).IsRequired();
            Property(x => x.Ad).HasColumnName("YerAdi");
            Property(x => x.Ad).HasColumnType("nvarchar");
            Property(x => x.Ad).HasMaxLength(50);
            Property(x => x.Ucret).HasPrecision(10, 2);
        }
    }
}
