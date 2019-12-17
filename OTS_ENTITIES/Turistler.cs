using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class Turistler : Kisi
    {
        public int Id { get; set; }

        public Bolge Bolge { get; set; }

        public int BolgeId { get; set; }

        public int TurBiletiId { get; set; }
        public TurBileti TurBileti { get; set; }

        public int FaturaId { get; set; }

        public Fatura Fatura { get; set; }

        


    }
}
