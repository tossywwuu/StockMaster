using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
namespace hom.MSMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageQueue mq = null;

            int i = 1;
            while (true)
            {
                if (!MessageQueue.Exists(".\\private$\\myQueue"))
                {

                    mq = MessageQueue.Create(".\\private$\\myQueue");
                    XmlMessageFormatter formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    mq.Label = "HelloWorldMsmq"; // 设置队列标签
                    Console.WriteLine("已经创建了一个公共队列");
                    Console.WriteLine("路径为:{0}", mq.Path);
                    Console.WriteLine("队列名字为:{0}", mq.QueueName);


                }
                else
                {
                    mq = null;
                    mq = new MessageQueue(".\\private$\\myQueue");
                }
                Console.WriteLine("1.发消息,2.处理消息,3.退出");
                bool isbreak = false;
                string text = Console.ReadLine();
                switch (text)
                {
                    case "1":
                        Console.Write("输入消息：");
                        text = Console.ReadLine();

                        SendMessage(text);
                        break;
                    case "2":
                        ReadMessage();

                        break;
                    case "3":
                        isbreak = true;
                        break;
                }

                if (isbreak)
                {
                    if (MessageQueue.Exists(".\\private$\\myQueue"))
                    {
                        Console.Write("任意键退出：");
                        Console.Read();
                        // 删除消息队列并退出
                        MessageQueue.Delete(".\\private$\\myQueue");
                    }
                    break;
                }
            }
        }


        /**//// <summary> 
            /// 连接消息队列并发送消息到队列 
            /// </summary> 
        public static void SendMessage(string message)
        {
            try
            {
                //连接到本地的队列 
                MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");

                Message myMessage = new Message();
                myMessage.Body = message;
                myMessage.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                //发送消息到队列中 
                myQueue.Send(myMessage);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ReadMessage()
        {
            try
            {
                Message myMessage = null;
                MessageQueue myQueue = new MessageQueue(".\\private$\\myQueue");
                myQueue.DenySharedReceive = true;
                myQueue.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                do
                {
                    myMessage = myQueue.Receive();

                    //连接到本地的队列 

                  
                    string context = (string)myMessage.Body; //获取消息的内容 
                    Console.WriteLine("消息内容为：" + context);
                } while (true);
                
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
