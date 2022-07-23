using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGiardiniereService" in both code and config file together.
    [ServiceContract]
    public interface IGiardiniereService
    {
        [OperationContract]
        List<giardiniere> findAll();

        [OperationContract]
        giardiniere find(int id);

        [OperationContract]
        void Addgiard(giardiniere giard);

        [OperationContract]
        bool visemail(string email);
    }
}
