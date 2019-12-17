using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public abstract class Kisi
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]


        public string AdSoyad { get; set; }

        public string Cinsiyet { get; set; }

        public string Telefon { get; set; }

        public string Mail { get; set; }

        public string Uyruk { get; set; }

        public DateTime DogumTarihi { get; set; }

        public virtual List<Dil> Diller { get; set; }

     

    }
    
}
