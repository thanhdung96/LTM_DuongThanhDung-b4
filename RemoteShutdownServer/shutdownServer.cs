using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Diagnostics;
using System;

//server receives command from client to shutdown itself
//client sends signal first
namespace RemoteShutdownServer
{
	class ShutdownServer
	{
		private TcpClient client;
		private TcpListener server;
		private NetworkStream netStream;

		private byte[] dataSend, dataReceive;
		private string data;
		private int dataSize;

		private string[] command;

		public ShutdownServer()
		{
			Console.WriteLine("Server init components...");
			server = new TcpListener(new IPEndPoint(IPAddress.Any, 1724));

			dataReceive = new byte[1024];
			dataSend = new byte[1024];
			command = new string[2];	//first is for command itself, second is the command's parameters
		}

		public void start()
		{
			Console.WriteLine("Server is listening...");
			server.Start();
			client = server.AcceptTcpClient();
			netStream = client.GetStream();
			Console.WriteLine("Server accepted a client...");
		}

		public void listening()
		{
			dataSize = netStream.Read(dataReceive, 0, 1024);
			data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
			if (data == "SYN")		//server sends ACK to respond from SYN
			{
				data = "ACK";
				dataSend = Encoding.ASCII.GetBytes(data);
				netStream.Write(dataSend, 0, data.Length);
			}

			dataSize = netStream.Read(dataReceive, 0, 1024);		//receive command from client
			data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
			command = data.Split(',');		//command received is comma-delimited

			Console.WriteLine("Server received a command and is executing it...");

			execute(command[0], command[1]);		//0 is the command, 1 is the parameters
		}

		private void execute(string proc, string parameters)
		{
			client.Close();
			netStream.Close();
			Console.WriteLine("Command: " + proc + " " + parameters);
			//Process.Start(proc, parameters);
		}
	}
}
