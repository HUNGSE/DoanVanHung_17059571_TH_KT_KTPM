using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
    

namespace Client
{
   public class Program
    {
        private const int BUFFER_SIZE = 1024;
        private const int PORT_NUMBER = 5000;

        static ASCIIEncoding encoding = new ASCIIEncoding();
        static void Main(string[] args)
        {
            try
            {
                TcpClient client = new TcpClient();
                client.Connect("192.168.1.8", PORT_NUMBER);
                Stream stream = client.GetStream();
                Console.WriteLine("Connected to Server.");
                Console.Write("Enter your name: ");
                string str = Console.ReadLine();
                byte[] data = encoding.GetBytes(str);
                stream.Write(data, 0, data.Length);
                data = new byte[BUFFER_SIZE];
                stream.Read(data, 0, BUFFER_SIZE);
                Console.WriteLine(encoding.GetString(data));
                stream.Close();
                client.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            Console.Read();
        }
    }
}
