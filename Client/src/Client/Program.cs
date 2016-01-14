using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            client.Connect("127.0.0.1", 55555);
            
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
