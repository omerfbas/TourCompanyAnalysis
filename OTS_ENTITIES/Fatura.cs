using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class Fatura
    {
        public int FaturaId { get; set; }

        public string AdSoyad { get; set; }

        public string Adres { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public decimal Tutar { get; set; }

        public DateTime FaturaTarihi { get; set; }

        public string OdemeTipi { get; set; }

    }
}
