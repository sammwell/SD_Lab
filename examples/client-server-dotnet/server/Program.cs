using System.Net;
using System.Net.Sockets;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Dns.GetHostEntry("localhost");
            var ipAddress = host.AddressList[0];
            var localEndPoint = new IPEndPoint(ipAddress, 9000);
            var serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Bind(localEndPoint);
            serverSocket.Listen(10);

            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                var connection = new Connection(clientSocket);
            }
        }
    }
}
