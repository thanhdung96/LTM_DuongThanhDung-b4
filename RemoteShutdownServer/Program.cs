namespace RemoteShutdownServer
{
	class Program
	{
		private static ShutdownServer server;
		static void Main(string[] args)
		{
			server = new ShutdownServer();
			server.start();
			server.listening();
		}
	}
}
