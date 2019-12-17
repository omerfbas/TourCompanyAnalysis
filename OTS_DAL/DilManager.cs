using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
   public class DilManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Dil dil)
        {
            context.Diller.Add(dil);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Dil dil)
        {
            var entity = context.Entry(dil);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Dil dil)
        {
            var entity = context.Entry(dil);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Dil GetById(int id)
        {
            Dil selected = context.Diller.SingleOrDefault(x => x.DilId == id);
            return selected;
        }
        public List<Dil> GetAll()
        {
            List<Dil> dil = context.Diller.ToList();
            return dil;
        }
    }
}
