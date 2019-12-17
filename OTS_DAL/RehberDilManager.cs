using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
   public class RehberDilManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int add(RehberDil rehberDil)
        {
            context.RehberDil.Add(rehberDil);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(RehberDil rehberDil)
        {
            var entity = context.Entry(rehberDil);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(RehberDil rehberDil)
        {
            var entity = context.Entry(rehberDil);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public List<string> RehberinDilleriniGetir(int id)
        {

              return context.Rehberler.Join(context.RehberDil,
                                        x => x.Id,
                                        z => z.RehberId,
                                        (x, z) => new
                                        {
                                            dil = z.DilId,
                                            rehber = z.RehberId
                                        }).Join(context.Diller,
                                                xz => xz.dil,
                                                y => y.DilId,
                                                (xz, y) => new
                                                {
                                                    dil = y.Ad,
                                                    xz.rehber
                                                }).Where(a => a.rehber == id).Select(x=>x.dil).ToList();
           

        }
        public List<RehberDil> GetAll()
        {
            List<RehberDil> rehberler = context.RehberDil.ToList();

            return rehberler;
        }

    }
}
