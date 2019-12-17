using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_ENTITIES
{
   public class TurYer
    {
        [Key]
        public int Id { get; set; }
        public int TurId { get; set; }
        public int YerId { get; set; }
        public virtual Turlar Tur { get; set; }
        public virtual Yer Yer { get; set; }
    }
}
