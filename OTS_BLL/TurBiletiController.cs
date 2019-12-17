using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
  public  class TurBiletiController
    {
        TurBiletiManager manager = new TurBiletiManager();
        public bool Add(TurBileti turBileti)
        {
            return manager.Add(turBileti) > 0;
        }
        public bool Update(TurBileti turBileti)
        {
            return manager.Update(turBileti) > 0;
        }
        public bool Delete(TurBileti turBileti)
        {
            return manager.Delete(turBileti) > 0;
        }
        public TurBileti GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<TurBileti> GetAll()
        {

            return manager.GetAll();
        }
        public TurBileti GetLast()
        {
            return manager.GetAll().LastOrDefault();
        }
    }
}
