using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES.Mappings
{
    class MapFatura : EntityTypeConfiguration<Fatura>
    {
        public MapFatura()
        {
            HasKey(x => x.FaturaId);
            Property(x => x.AdSoyad).HasColumnName("AdiSoyadi");
            Property(x => x.AdSoyad).HasColumnType("nvarchar");
            Property(x => x.AdSoyad).HasMaxLength(50);
            Property(x => x.Adres).HasColumnType("nvarchar");
            Property(x => x.Adres).HasMaxLength(100);
            Property(x => x.Telefon).HasMaxLength(14);
            Property(x => x.Tutar).HasPrecision(10, 2);
            Property(x => x.Mail).HasColumnName("EmailAdresi");
        }
    }
}
