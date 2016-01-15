using System;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new TcpClient();
            client.ConnectAsync("127.0.0.1", 55555).Wait();
            var stream = client.GetStream();
            var writer = new StreamWriter(stream);

            writer.WriteLine("test");
            writer.Flush();

            Console.WriteLine("sended");
        }
    }
}
