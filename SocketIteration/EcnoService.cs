using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace SocketIteration
{
    class EcnoService
    {
        TcpClient connectionsocket;

        public EcnoService(TcpClient connectionsocket)
        {
            this.connectionsocket = connectionsocket;

        }
        public void doit()
        {
           
            

            Stream ns = connectionsocket.GetStream();  //provides a Stream
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            sw.AutoFlush = true; // enable automatic flushing

            
            
            string message = sr.ReadLine();
            string answer = message.ToUpper();
            sw.WriteLine(answer);

            Console.WriteLine("Server: " + message);

            Console.WriteLine("No more from server. Press Enter");
            Console.ReadLine();

            ns.Close();

            connectionsocket.Close();
        }
    }
}
