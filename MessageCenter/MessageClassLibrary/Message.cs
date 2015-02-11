/// Message info class
/// By Ali Abdulhussein on Feb. 10 2015.
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
    [DataContract]
    public class Message
    {
        private int m_MessageId;
        private string m_MessageBody;
        private DateTime m_MessageTime;

        [DataMember]
        public int MessageID 
        { 
            get{return m_MessageId+1;} 
            set{m_MessageId=value;}
        }
        
        [DataMember]
        public string MessageBody 
        {
            get { return m_MessageBody; }
            set { m_MessageBody = value; }
        }

        [DataMember]
        public DateTime MessageTime 
        {
            get { return m_MessageTime; }
            set { m_MessageTime = value; } 
        }

    }
}
