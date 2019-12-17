using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
    public class TurManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Turlar tur)
        {
            context.Turlar.Add(tur);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Turlar tur)
        {
            var entity = context.Entry(tur);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Turlar tur)
        {
            var entity = context.Entry(tur);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Turlar GetById(int id)
        {
            Turlar selected = context.Turlar.SingleOrDefault(x => x.TurId == id);
            return selected;
        }
        public List<Turlar> GetAll()
        {
            List<Turlar> Turlar = context.Turlar.ToList();
            return Turlar;
        }
    }
}
