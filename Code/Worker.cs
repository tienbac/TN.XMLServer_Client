using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TN.XMLServer_Client.Code
{
    class Worker
    {
        static ASCIIEncoding encoding = new ASCIIEncoding();
        static Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] msg = Encoding.UTF8.GetBytes("<CitiEvent Type=\"LIFESIG\"><LIFESIG PeriodSec=\"30\" TimeOutSec=\"60\" /></CitiEvent>");
        public void Connect()
        {
            string host = "127.0.0.1";
            int port = 44000;
            Debug.WriteLine("Connecting...");
            socket.Connect(host, port);
            //Debug.WriteLine("Success!");
            bool blockingState = socket.Blocking;
            try
            {
                byte[] tmp = new byte[1];
                socket.Blocking = false;
                socket.Send(tmp, 0, 0);
                Debug.WriteLine("Connected");

                //Thread thread2 = new Thread(Receive);
                //thread2.Start();
            }
            catch (SocketException e)
            {
                // 10035 == WSAEWOULDBLOCK
                if (e.NativeErrorCode.Equals(10035))
                {
                    Console.WriteLine("Still Connected, but the Send would block");
                }
                else
                {
                    Console.WriteLine("Disconnected: error code {0}!", e.NativeErrorCode);
                }
            }
            finally
            {
                socket.Blocking = blockingState;
            }

            Console.WriteLine("Connected: {0}", socket.Connected);
            if (socket.Connected)
            {
                Thread thread1 = new Thread(Send);
                thread1.Start();
            }
            byte[] bytes = new byte[4086];
            while (true)
            {
                var byteCount = socket.Receive(bytes, SocketFlags.None);
                if (byteCount > 0)
                {
                    var mess = Encoding.UTF8.GetString(bytes);
                    //XmlSerializer serializer = new XmlSerializer(typeof(CitiEvent));
                    //CitiEvent citiEvent;
                    //if (!mess.Contains("LIFESIG"))
                    //{
                    //    using (TextReader reader = new StringReader(mess))
                    //    {
                    //        citiEvent = (CitiEvent) serializer.Deserialize(reader);
                    //        Debug.WriteLine($"CitiEvent Type : " + citiEvent.Type);
                    //        Debug.WriteLine($"CitiEvent Alams Type : " + citiEvent.Alarm.Type);
                    //    }
                    //}
                    Debug.WriteLine(mess);
                    Debug.WriteLine("");
                }

            }
        }

        public void Send()
        {
            Console.WriteLine("Connected: {0}", socket.Connected);
            //byte[] msg = Encoding.UTF8.GetBytes("<CitiCommand Type=\"ListAlarm\" Id=\"2\"><ListAlarm FromTime=\"2020/02/24 08:34:42.112\" ToTime=\"2020/02/26 08:34:42.112\" Filter=\"ALL\" /></CitiCommand>");

            while (true)
            {
                int byteCount = socket.Send(msg, SocketFlags.None);
                //Debug.WriteLine("Sent {0} bytes.", byteCount);
                Thread.Sleep(30000);
            }
        }

        public void Receive()
        {
            byte[] bytes = new byte[4086];
            while (true)
            {
                var byteCount = socket.Receive(bytes, SocketFlags.None);
                if (byteCount > 0)
                {
                    Debug.WriteLine(Encoding.UTF8.GetString(bytes));
                    Debug.WriteLine("");
                }
                
            }
        }
    }
}
