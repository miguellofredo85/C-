﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket= new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // InterNetwork is IPv4 | Stream is out -in data

            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            
            socket.Bind(endPoint);

            socket.Listen(5);

            Console.WriteLine("Listening");

            Socket listen = socket.Accept();

            byte[] bytes = new byte[255];

            int buffer = listen.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize<byte>(ref bytes, buffer);

            Console.WriteLine("Client said: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socket.Close();

            Console.WriteLine("Server finish\n Press a key to exit...");

            Console.ReadKey();
        }
    }
}
