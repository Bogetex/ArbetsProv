using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Web;

namespace MessageClassLibrary
{
    [ServiceContract]
    interface IMessageService
    {
        [OperationContract]
        bool InsertMessage(Message obj);

        [OperationContract]
        List<Message> GetAllMessage();
    }

    
}
