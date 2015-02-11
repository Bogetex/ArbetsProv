/// Message Service Interface
/// By Ali Abdulhussein on Feb. 10 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMessageService" in both code and config file together.
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        void DoWork();
    }
}
