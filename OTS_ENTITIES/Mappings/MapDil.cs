using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapDil: EntityTypeConfiguration<Dil>
    {
        public MapDil()
        {
            HasKey(x => x.DilId);
            Property(x => x.Ad).IsRequired();
            Property(x => x.Ad).HasColumnType("nvarchar");
            Property(x => x.Ad).HasMaxLength(50);
        }
    }
}
