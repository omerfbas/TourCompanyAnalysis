using OTS_ENTITIES;
using System.Collections.Generic;
using System.Linq;

namespace OTS_DAL
{
 public   class TuristManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Turistler turist)
        {
            context.Turistler.Add(turist);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Turistler turist)
        {
            var entity = context.Entry(turist);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Turistler turist)
        {
            var entity = context.Entry(turist);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Turistler GetById(int id)
        {
            Turistler selected = context.Turistler.SingleOrDefault(x => x.Id == id);
            return selected;
        }
        public List<Turistler> GetAll()
        {
            List<Turistler> Turistler = context.Turistler.ToList();
            return Turistler;
        }
    }
}
