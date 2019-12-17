using OTS_DAL;
using OTS_ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS_BLL
{
   public class FaturaContoller
    {
        FaturaManager manager = new FaturaManager();
        public bool Add(Fatura fatura)
        {
            return manager.Add(fatura) > 0;
        }
        public bool Update(Fatura fatura)
        {
            return manager.Update(fatura) > 0;
        }
        public bool Delete(Fatura fatura)
        {
            return manager.Delete(fatura) > 0;
        }
        public Fatura GetById(int id)
        {
            return manager.GetById(id);

        }
        public List<Fatura> GetAll()
        {

            return manager.GetAll();
        }
        public Fatura GetLast()
        {
            return manager.GetAll().LastOrDefault();
        }
    }
}
