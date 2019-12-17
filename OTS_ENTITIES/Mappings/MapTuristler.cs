using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapTuristler : EntityTypeConfiguration<Turistler>
    {
        public MapTuristler()
        {

            HasKey(x => x.Id);
            Property(x => x.AdSoyad).IsRequired();
            Property(x => x.Cinsiyet).IsRequired();
            Property(x => x.Telefon).IsRequired();
            Property(x => x.Telefon).HasColumnName("TelefonNumarasi");
            Property(x => x.Uyruk).IsRequired();

          
            
        }
    }
}
