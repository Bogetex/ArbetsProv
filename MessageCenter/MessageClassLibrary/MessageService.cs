/// Message Service Class Libraray
/// By Ali Abdulhussein on Feb. 10 2015.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using System.ServiceModel.Web;
using System.Configuration;

/// Message Service Class
/// Implemet ImessageService Interface
namespace MessageClassLibrary
{
    public class MessageService:IMessageService
    {
        /// <summary>
        /// Seed List with some test data
        /// </summary>
        public static List<Message> m_messageList = new List<Message>()
        {
            new Message{MessageID=1,MessageBody="Test01",MessageTime=DateTime.Now},
            new Message{MessageID=2, MessageBody="Test02",MessageTime=DateTime.Now},
        };

        /// <summary>
        /// Insert new message to list
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool InsertMessage(Message obj)
        {
            obj.MessageID = m_messageList.Count;
            try
            {
                m_messageList.Add(obj);
                return true;
            }
            catch
            {
                return false;
            }

        }

        /// <summary>
        /// Show all message list
        /// </summary>
        /// <returns></returns>
        public List<Message> GetAllMessage()
        {
            m_messageList.Sort( delegate(Message a, Message b) 
            {
                return b.MessageTime.CompareTo(a.MessageTime);
            });
            return m_messageList;
        }
    }
}
