using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

//client sends commands to shutdown server
//client sends signal first
namespace RemoteShutdownClient
{
	class ShutdownClient
	{
		private TcpClient client;
		private NetworkStream netStream;

		private byte[] dataSend, dataReceive;
		private string data;
		private int dataSize;

		private const string shutdownCommand = "shutdown,/s /t 0";	//shutdown command, comma-delimited
		private const string restartCommand = "shutdown,/r /t 0";	//restart command, comma-delimited

		public ShutdownClient()
		{
			Console.WriteLine("Client init components...");
			client = new TcpClient();
			dataReceive = new byte[1024];
			dataSend = new byte[1024];
		}

		public void connect()
		{
			Console.WriteLine("Client connecting to server...");
			client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724));
			netStream = client.GetStream();
			Console.WriteLine("Connected");
		}

		public void sendCommand(bool isRestartCommand)
		{
			//say hello to server
			data = "SYN";
			dataSend = Encoding.ASCII.GetBytes(data);
			netStream.Write(dataSend, 0, data.Length);

			dataSize = netStream.Read(dataReceive, 0, 1024);
			data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
			Console.WriteLine("Client sending command...");
			if (data == "ACK")		//if server is synchronized, start sending command
			{
				if (isRestartCommand)
				{
					dataSend = Encoding.ASCII.GetBytes(restartCommand);
					netStream.Write(dataSend, 0, restartCommand.Length);
				}
				else
				{
					dataSend = Encoding.ASCII.GetBytes(shutdownCommand);
					netStream.Write(dataSend, 0, shutdownCommand.Length);
				}
				Console.WriteLine("Command sent...");
			}
			
			dataSize = netStream.Read(dataReceive, 0, 1024);
			data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
			if (data == "FYN")		//if server received the command and responded back to shutdown itself
			{
				client.Close();
				netStream.Close();
				Console.WriteLine("Client disconnected from server...");
			}
		}
	}
}
