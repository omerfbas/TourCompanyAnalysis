using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapTurlar : EntityTypeConfiguration<Turlar>
    {
        public MapTurlar()
        {
            HasKey(x => x.TurId);
            Property(x => x.Ad).IsRequired();
            Property(x => x.Fiyat).HasPrecision(10, 2);
            Property(x => x.Ad).HasColumnName("TurAdi");

        }
    }
}
