using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server
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
                IPAddress address = IPAddress.Parse("192.168.1.8");

                TcpListener listener = new TcpListener(address, PORT_NUMBER);
                listener.Start();
                Console.WriteLine("Server started on " + listener.LocalEndpoint);
                Console.WriteLine("Waiting for a connection...");

                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Connection received from " + socket.RemoteEndPoint);
                byte[] data = new byte[BUFFER_SIZE];
                socket.Receive(data);
                string str = encoding.GetString(data);
                socket.Send(encoding.GetBytes("Hello " + str));
                socket.Close();
                listener.Stop();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            Console.Read();
        }
    }
}
        
    

