using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class Turlar
    {
        [Key]
        public int TurId { get; set; }
        public int RehberId { get; set; }
        public virtual Rehberler Rehber { get; set; }
        public int DilId { get; set; }
        public virtual Dil Dil { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public int Kapasite { get; set; }
        public int MevcutKisiSayisi { get; set; }
        public DateTime Tarihi { get; set; }
        public decimal Fiyat { get; set; }



    }
}
