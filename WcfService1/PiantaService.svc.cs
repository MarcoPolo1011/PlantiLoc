using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PiantaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PiantaService.svc or PiantaService.svc.cs at the Solution Explorer and start debugging.
    public class PiantaService : IPiantaService
    {
        private DefaultConnectionEntities5 dce = new DefaultConnectionEntities5();

        public pianta find(int id)
        {
            return dce.piantas.Single(g => g.Id == id);
        }

        public List<pianta> findAll()
        {
            return dce.piantas.ToList();
        }

        public void Addpianta(pianta pianta)
        {
            dce.piantas.Add(pianta);
            dce.SaveChanges();
        }
    }
}
