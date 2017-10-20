﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DHCPClient
{
	class dhcClient
	{
		private TcpClient client;
		private NetworkStream netStream;
		private byte[] dataSend, dataReceive;

		string ip;

		public dhcClient()
		{
			Console.WriteLine("Client init components...");
			dataReceive = new byte[1024];
			dataSend = new byte[1024];

			client = new TcpClient();
		}

		public string requestAddress()
		{
			client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724));
			netStream = client.GetStream();
			Console.WriteLine("Client connected to server...");

			string data = "DISCOVER";
			dataSend = Encoding.ASCII.GetBytes(data);
			netStream.Write(dataSend, 0, data.Length);

			int dataSize = netStream.Read(dataReceive, 0, 1024);
			ip = Encoding.ASCII.GetString(dataReceive, 0, dataSize);

			data = "FYN";
			dataSend = Encoding.ASCII.GetBytes(data);
			netStream.Write(dataSend, 0, data.Length);

			client.Close();
			netStream.Close();
			return ip;
		}
	}
}
