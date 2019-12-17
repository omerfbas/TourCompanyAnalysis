using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
   public class BolgeManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Bolge bolge)
        {
            context.Bolgeler.Add(bolge);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Bolge bolge)
        {
            var entity = context.Entry(bolge);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Bolge bolge)
        {
            var entity = context.Entry(bolge);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Bolge GetById(int id)
        {
            Bolge selected = context.Bolgeler.SingleOrDefault(x => x.BolgeId == id);
            return selected;
        }
        public List<Bolge> GetAll()
        {
            List<Bolge> bolge = context.Bolgeler.ToList();
            return bolge;
        }
    }
}
