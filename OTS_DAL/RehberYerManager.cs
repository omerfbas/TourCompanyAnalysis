using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
   public class RehberYerManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int add(RehberYer rehberYer)
        {
            context.RehberYer.Add(rehberYer);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(RehberYer rehberYer)
        {
            var entity = context.Entry(rehberYer);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(RehberYer rehberYer)
        {
            var entity = context.Entry(rehberYer);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public List<RehberYer> GetAll()
        {
            List<RehberYer> rehberYer = context.RehberYer.ToList();
            return rehberYer;
        }
        public List<string> RehberinYerleriniGetir(int id)
        {

            return context.Rehberler.Join(context.RehberYer,
                                      x => x.Id,
                                      z => z.RehberId,
                                      (x, z) => new
                                      {
                                          yer = z.YerId,
                                          rehber = z.RehberId
                                      }).Join(context.Yerler,
                                              xz => xz.yer,
                                              y => y.YerId,
                                              (xz, y) => new
                                              {
                                                  yer = y.Ad,
                                                  rehber = xz.rehber
                                              }).Where(a => a.rehber == id).Select(x => x.yer).ToList();


        }
    }
}
