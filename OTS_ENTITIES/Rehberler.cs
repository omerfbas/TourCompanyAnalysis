using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class Rehberler : Kisi
    {
        public int Id { get; set; }


        public virtual List<Turlar> Turlar { get; set; }

        public Rehberler()
        {
            Turlar = new List<Turlar>();
        }


    }
}
