using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class TurBileti // Bu classta müşteriye çıktı olarak bilet vericez, tur hakkında, ödeme hakkında bilgileri içericek
    {        
        public int Id { get; set; }        

        public Turlar Turlar { get; set; }

        public int TurId { get; set; }

        public Fatura Fatura { get; set; }

        public int FaturaId { get; set; }

        //public virtual List<Turistler> Turistler { get; set; } // Tur biletinin birden çok turisti olabilir.

        //public TurBileti()
        //{
        //    Turistler = new List<Turistler>();
        //}


    }
}
