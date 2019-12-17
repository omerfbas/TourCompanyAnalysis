using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
  public class DilController
    {
        DilManager manager = new DilManager();
        RehberDilManager rehberDilManager = new RehberDilManager();

        public bool Add(Dil dil)
        {
            bool varMi = false;
            List<Dil> diller = GetAll();
            foreach (Dil item in diller)
            {
                if (item.Ad == dil.Ad) varMi = true;
            }
            if (varMi) return false;
            else return manager.Add(dil) > 0;
        }

        public bool Delete(Dil dil)
        {
            return manager.Delete(dil) > 0;
        }
        public Dil GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Dil> GetAll()
        {

            return manager.GetAll();
        }
        public List<string> RehberinDilleriniGetir(int id)
        {
            return rehberDilManager.RehberinDilleriniGetir(id);
        }
         public bool RehberDilAdd(RehberDil rehberDil)
        {
            return rehberDilManager.add(rehberDil) > 0;
        }

        
        public void RehberDilDelete(int rehberId)
        {
            List<RehberDil> rehberDil = rehberDilManager.GetAll().Where(x => x.RehberId == rehberId).ToList();
            foreach (RehberDil item in rehberDil)
            {
                rehberDilManager.Delete(item);
            }

        }
    }
}
