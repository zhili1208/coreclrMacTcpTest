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
            Console.WriteLine("Server start");
            int port = 55555;
            var listener = new TcpListener(IPAddress.Loopback, port);
            listener.Start();
            Console.WriteLine("start listening");

            var client = listener.AcceptTcpClient();
            var stream = client.GetStream();

            var reader = new StreamReader(stream);
            
            Console.WriteLine("Connected");
            
            var data = reader.ReadLine();

            if (data == null) {
                Console.WriteLine("data is null");
            } 
            else 
            {
                Console.WriteLine(data);
            }            
        }
    }
}
