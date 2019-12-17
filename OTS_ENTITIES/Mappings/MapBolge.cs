using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapBolge: EntityTypeConfiguration<Bolge>
    {
        public MapBolge()
        {
            HasKey(x => x.BolgeId);
            Property(x => x.Ad).IsRequired();
            Property(x => x.Ad).HasColumnName("BolgeAdi");
            Property(x => x.Ad).HasColumnType("nvarchar");
            Property(x => x.Ad).HasMaxLength(50);
            Property(x => x.UlasimGideri).HasPrecision(10, 2);
        }
    }
}
