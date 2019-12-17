using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
  public  class TuristlerContoller
    {
        TuristManager manager = new TuristManager();
        public bool Add(Turistler turist)
        {
            return manager.Add(turist) > 0;
        }
        public bool Update(Turistler turist)
        {
            return manager.Update(turist) > 0;
        }
        public bool Delete(Turistler turist)
        {
            return manager.Delete(turist) > 0;
        }
        public Turistler GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Turistler> GetAll()
        {

            return manager.GetAll();
        }
    }
}
