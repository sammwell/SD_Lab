using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using core;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Dns.GetHostEntry("localhost");
            var ipAddress = host.AddressList.First();
            var serverEndpoint = new IPEndPoint(ipAddress, 9000);

            Socket serverSocket = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.Connect(serverEndpoint);

            Console.WriteLine($"Successfully connected to server on: {serverSocket.RemoteEndPoint}");

            while (true)
            {
                var msg = new Message {Content = "Hello world!"};
                Console.WriteLine($"Sending msg with content: {msg.Content}");
                var stream = Serializer.ToStream(msg);
                var bytesSent = serverSocket.Send(stream.GetBuffer());

                Console.WriteLine("Waiting to receive");

                var buffer = new byte[2048];
                var bytesReceived = serverSocket.Receive(buffer);
                if (bytesReceived != 0)
                {
                    var receivedMessage = (Message)Serializer.FromStream(new MemoryStream(buffer));
                    Console.WriteLine($"Received message: {receivedMessage.Content}");
                }

                Console.WriteLine("Received done");
            }
        }
    }
}
