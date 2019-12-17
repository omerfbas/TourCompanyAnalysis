using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_DAL
{
  public  class TurYerManager
    {
        OTS_CONTEXT context = new OTS_CONTEXT();
        public int add(TurYer turYer)
        {
            context.TurYer.Add(turYer);
            int value = context.SaveChanges();
            return value;
        }
        public int Update(TurYer turYer)
        {
            var entity = context.Entry(turYer);
            entity.State = System.Data.Entity.EntityState.Modified;
            int value = context.SaveChanges();
            return value;
        }
        public int Delete(TurYer turYer)
        {
            var entity = context.Entry(turYer);
            entity.State = System.Data.Entity.EntityState.Deleted;
            int value = context.SaveChanges();
            return value;
        }
        public List<string> TurunYerleriniGetir(int id)
        {

            return context.Turlar.Join(context.TurYer,
                                      x => x.TurId,
                                      z => z.TurId,
                                      (x, z) => new
                                      {
                                          yer = z.YerId,
                                          tur = z.TurId
                                      }).Join(context.Yerler,
                                              xz => xz.yer,
                                              y => y.YerId,
                                              (xz, y) => new
                                              {
                                                  yer = y.Ad,
                                                  tur = xz.tur
                                              }).Where(a => a.tur == id).Select(x => x.yer).ToList();


        }
        public List<Yer> TurunYerleriniGetir(Turlar tur)
        {

            var yerler= context.Turlar.Join(context.TurYer,
                                      x => x.TurId,
                                      z => z.TurId,
                                      (x, z) => new
                                      {
                                          yer = z.YerId,
                                          tur = z.TurId
                                      }).Join(context.Yerler,
                                              xz => xz.yer,
                                              y => y.YerId,
                                              (xz, y) => new
                                              {
                                                  yer = y.Ad,
                                                  yerFiyat=y.Ucret,
                                                  tur = xz.tur
                                              }).Where(a => a.tur == tur.TurId).ToList();
            List<Yer> yerUcret = new List<Yer>();
            foreach (var item in yerler)
            {
                Yer yer = new Yer();
                yer.Ucret = item.yerFiyat;
                yer.Ad = yer.Ad;
                yerUcret.Add(yer);
            }
            return yerUcret;


        }
        public List<TurYer> GetAll()
        {
            List<TurYer> turYer = context.TurYer.ToList();
            return turYer;
        }
    }
}
