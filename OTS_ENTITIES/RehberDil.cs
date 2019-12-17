using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
    public class RehberDil
    {
        [Key]
        public int Id { get; set; }
        public int RehberId { get; set; }
        public int DilId { get; set; }
        public virtual Rehberler Rehber { get; set; }
        public virtual Dil Dil { get; set; }
    }
}
