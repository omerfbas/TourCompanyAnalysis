using OTS_ENTITIES;
using System.Collections.Generic;
using System.Linq;

namespace OTS_DAL
{
   public class RehberManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Rehberler rehber)
        {
            context.Rehberler.Add(rehber);
           int value= context.SaveChanges();
           return value;
        }
        public int Update(Rehberler rehber)
        {
            var entity = context.Entry(rehber);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Rehberler rehber)
        {
            var entity = context.Entry(rehber);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Rehberler GetById(int id)
        {
            Rehberler selected= context.Rehberler.SingleOrDefault(x => x.Id == id);
            return selected;
        }
        public List<Rehberler> GetAll()
        {
            List<Rehberler> rehberler = context.Rehberler.ToList();
            return rehberler;
        }

    }
}
