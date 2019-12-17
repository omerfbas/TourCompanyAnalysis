using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Linq;
using System.Collections.Generic;

namespace OTS_BLL
{
   public class YerController
    {
        YerManager manager = new YerManager();
        RehberYerManager yerManager = new RehberYerManager();
        public bool Add(Yer yer)
        {
            return manager.Add(yer) > 0;
        }
        public bool Update(Yer yer)
        {
            return manager.Update(yer) > 0;
        }
        public bool Delete(Yer yer)
        {
            return manager.Delete(yer) > 0;
        }
        public Yer GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Yer> GetAll()
        {

            return manager.GetAll();
        }
        public List<string> RehberinYerleriniGetir(int id)
        {
            return yerManager.RehberinYerleriniGetir(id);
        }
        public bool RehberYerAdd(RehberYer rehberYer)
        {
            return yerManager.add(rehberYer) > 0;
        }

        public void RehberYerDelete(int rehberId)
        {
            List<RehberYer> rehberYer = yerManager.GetAll().Where(x => x.RehberId == rehberId).ToList();
            foreach (RehberYer item in rehberYer)
            {
                yerManager.Delete(item);
            }

        }

        TurYerManager turYerManager = new TurYerManager();
        public void TurYerDelete(int turId)
        {
            List<TurYer> turYer = turYerManager.GetAll().Where(x => x.TurId == turId).ToList();
            foreach (TurYer item in turYer)
            {
                turYerManager.Delete(item);
            }

        }

    }
}
