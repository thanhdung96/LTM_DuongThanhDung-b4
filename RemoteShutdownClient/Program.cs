namespace RemoteShutdownClient
{
	class Program
	{
		private static ShutdownClient client;
		static void Main(string[] args)
		{
			client = new ShutdownClient();
			client.connect();
			client.sendCommand(false);		//send a shutdown command
			System.Console.ReadKey();
		}
	}
}
