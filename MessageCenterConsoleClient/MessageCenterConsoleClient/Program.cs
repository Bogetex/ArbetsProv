using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageCenterConsoleClient.MessageService;

namespace MessageCenterConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string msgBody = string.Empty;
            int msgId = 0;
            
            MessageService.MessageServiceClient proxy = new MessageServiceClient();
            MessageService.Message msgobj = new MessageService.Message();

            while (true)
            {
                Console.WriteLine("Write Message Or exit to end app:");
                msgBody = Console.ReadLine();

               
                //msgobj.MessageID = msgId + 1;
                msgobj.MessageBody = msgBody;
                msgobj.MessageTime = DateTime.Now;

                if (msgBody == "exit")
                {
                    break;
                }
                proxy.InsertMessage(msgobj);

               

            }
        }
    }
}
