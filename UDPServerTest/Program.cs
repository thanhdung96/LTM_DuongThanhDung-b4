using System.Net;
using System.Net.Sockets;
using System.Text;
using System;

//forked and modified from https://github.com/trandainhan96/TCP-UDP.git by trandainhan96
namespace UDPServer
{
	//client send first
	class Program
	{
		static byte[] receive, send;
		static void Main(string[] args)
		{
			receive = new byte[1];
			send= new byte[1]{1};

			Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			IPEndPoint ip = new IPEndPoint(IPAddress.Any, 1724);
			server.Bind(ip);
			Console.WriteLine("Server is waiting...");
			EndPoint Client = (EndPoint)ip;

			server.ReceiveFrom(receive, ref Client);		//receive hello packet
			if(receive[0] == 1)
				server.SendTo(send, Client);		//respond hi back
			Console.WriteLine("Received a hello packet and responded back.");
			Console.ReadKey();
			server.Close();
		}
	}
}