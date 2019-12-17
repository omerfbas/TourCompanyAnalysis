using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
   public class TurBiletiManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(TurBileti turBileti)
        {
            context.TurBileti.Add(turBileti);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(TurBileti turBileti)
        {
            var entity = context.Entry(turBileti);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(TurBileti TurBileti)
        {
            var entity = context.Entry(TurBileti);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public TurBileti GetById(int id)
        {
            TurBileti selected = context.TurBileti.SingleOrDefault(x => x.Id == id);
            return selected;
        }
        public List<TurBileti> GetAll()
        {
            List<TurBileti> TurBileti = context.TurBileti.ToList();
            return TurBileti;
        }
    }
}
