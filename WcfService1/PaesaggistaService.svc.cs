using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PaesaggistaService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PaesaggistaService.svc or PaesaggistaService.svc.cs at the Solution Explorer and start debugging.
    public class PaesaggistaService : IPaesaggistaService
    {
        private DefaultConnectionEntities1 dce = new DefaultConnectionEntities1();

        public paesaggista find(int id)
        {
            return dce.paesaggistas.Single(g => g.identificativo == id);
        }

        public List<paesaggista> findAll()
        {
            return dce.paesaggistas.ToList();
        }

        public void Addpaes(paesaggista paes)
        {
            dce.paesaggistas.Add(paes);
            dce.SaveChanges();
        }
        public bool visemail(string email)
        {
            return dce.paesaggistas.Any(x => x.email == email);
        }
    }
}
