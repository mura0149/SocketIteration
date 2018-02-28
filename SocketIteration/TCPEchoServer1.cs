using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketIteration
{
    class TCPEchoServer1
    {
        public static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("192.168.6.171");
            TcpListener serversocket = new TcpListener(ip, 6789);
            serversocket.Start();
            while (true)
            {
                
                TcpClient TcpSocket = serversocket.AcceptTcpClient();
                EcnoService service = new EcnoService(TcpSocket);
                service.doit();
            }

        }

    }
}
