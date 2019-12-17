using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
   public class BolgeController
    {
        BolgeManager manager = new BolgeManager();
        public bool Add(Bolge bolge)
        {
            return manager.Add(bolge) > 0;
        }
        public bool Update(Bolge bolge)
        {
            return manager.Update(bolge) > 0;
        }
        public bool Delete(Bolge bolge)
        {
            return manager.Delete(bolge) > 0;
        }
        public Bolge GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Bolge> GetAll()
        {

            return manager.GetAll();
        }


    }
}
