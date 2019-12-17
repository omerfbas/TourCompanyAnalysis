using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
    public class TurController
    {
        TurManager manager = new TurManager();
        TurYerManager turYerManager = new TurYerManager();
        public bool Add(Turlar turlar)
        {
            return manager.Add(turlar) > 0;
        }
        public bool Update(Turlar turlar)
        {
            return manager.Update(turlar) > 0;
        }
        public bool Delete(Turlar turlar)
        {
            return manager.Delete(turlar) > 0;
        }
        public Turlar GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Turlar> GetAll()
        {

            return manager.GetAll();
        }
        public List<string> TurunYerleriniGetir(int id)
        {
            return turYerManager.TurunYerleriniGetir(id);
        }
        public decimal TurunYerlerininFiyatlariGetir(Turlar tur)
        {
            decimal fiyat=0;
            List<Yer> turunYerleri = turYerManager.TurunYerleriniGetir(tur);
            foreach (Yer item in turunYerleri)
            {
                fiyat+=item.Ucret;
            }
            return fiyat;
           
        }
        public bool TurYerAdd(TurYer turYer)
        {
            return turYerManager.add(turYer) > 0;
        }
        public Turlar GetLast()
        {
            return manager.GetAll().LastOrDefault();
        }
    }
}
