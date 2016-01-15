using System;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Client start");
            var client = new TcpClient();

            client.ConnectAsync("127.0.0.1", 55555).Wait();
           
            Console.WriteLine("Connecting");

            var stream = client.GetStream();
            var writer = new StreamWriter(stream);
            
            Console.WriteLine("Connected");
            
            writer.WriteLine("test");
            Console.WriteLine("write to network stream");
            writer.Flush();

            Console.WriteLine("sended");
        }
    }
}
