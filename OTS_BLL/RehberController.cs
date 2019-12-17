using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OTS_DAL;
using OTS_ENTITIES;

namespace OTS_BLL
{
   public class RehberController
    {
        RehberManager manager = new RehberManager();
        public bool Add(Rehberler rehber)
        {
            return manager.Add(rehber) > 0;
        }
        public bool Update(Rehberler rehber)
        {
            return manager.Update(rehber) > 0;
        }
        public bool Delete(Rehberler rehber)
        {
            return manager.Delete(rehber) > 0;
        }
        public Rehberler GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Rehberler> GetByDilId(int id)
        {
            RehberDilManager rehberDilManager = new RehberDilManager();
            List<Rehberler> rehberler = new List<Rehberler>();
            List<RehberDil> rehberDil = rehberDilManager.GetAll();
            List<int> RehberIdler = rehberDil.Where(x => x.DilId == id).Select(x => x.RehberId).ToList();
            foreach (int rehberId in RehberIdler)
            {
                rehberler.Add(manager.GetById(rehberId));
            }
            return rehberler;
            
        }
        public List<Rehberler> GetAll()
        {

            return manager.GetAll();
        }
        RehberYerManager rehberYerManager = new RehberYerManager();
        public List<string> RehberinYerleriniGetir(int id)
        {
            return rehberYerManager.RehberinYerleriniGetir(id);
        }


    }
}
