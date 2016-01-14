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
            var client = new TcpClient();
            client.Connect("127.0.0.1", 55555);
            var stream = client.GetStream();
            var writer = new StreamWriter(stream);

            writer.WriteLine("test");
            writer.Flush();

            Console.WriteLine("sended");
        }
    }
}
