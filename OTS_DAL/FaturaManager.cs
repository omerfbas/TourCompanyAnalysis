using OTS_ENTITIES;
using System.Collections.Generic;
using System.Linq;

namespace OTS_DAL
{
  public  class FaturaManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int Add(Fatura fatura)
        {
            context.Faturalar.Add(fatura);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(Fatura fatura)
        {
            var entity = context.Entry(fatura);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(Fatura fatura)
        {
            var entity = context.Entry(fatura);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public Fatura GetById(int id)
        {
            Fatura selected = context.Faturalar.SingleOrDefault(x => x.FaturaId == id);
            return selected;
        }
        public List<Fatura> GetAll()
        {
            List<Fatura> Fatura = context.Faturalar.ToList();
            return Fatura;
        }
    }
}
