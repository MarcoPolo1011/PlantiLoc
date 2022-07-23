using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GiardiniereService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select GiardiniereService.svc or GiardiniereService.svc.cs at the Solution Explorer and start debugging.
    public class GiardiniereService : IGiardiniereService
    {
        private DefaultConnectionEntities dce = new DefaultConnectionEntities();

        public giardiniere find(int id)
        {
            return dce.giardinieres.Single(g => g.MATgiard == id);
        }

        public List<giardiniere> findAll()
        {
            return dce.giardinieres.ToList();
        }

        public void Addgiard(giardiniere giard)
        {
            dce.giardinieres.Add(giard);
            dce.SaveChanges();
        }
        public bool visemail(string email)
        {
            return dce.giardinieres.Any(x => x.email == email);
        }
    }
}
