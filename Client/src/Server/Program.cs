using System;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int port = 55555;
            var listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start();

            var client = listener.AcceptTcpClientAsync().Result;
            var stream = client.GetStream();

            var reader = new StreamReader(stream);

            Console.WriteLine(reader.ReadLine());
        }
    }
}
