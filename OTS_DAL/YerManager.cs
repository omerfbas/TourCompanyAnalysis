using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
  public  class YerManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Yer yer)
        {
            context.Yerler.Add(yer);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Yer yer)
        {
            var entity = context.Entry(yer);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Yer yer)
        {
            var entity = context.Entry(yer);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Yer GetById(int id)
        {
            Yer selected = context.Yerler.SingleOrDefault(x => x.YerId == id);
            return selected;
        }
        public List<Yer> GetAll()
        {
            List<Yer> yer = context.Yerler.ToList();
            return yer;
        }
    }
}

