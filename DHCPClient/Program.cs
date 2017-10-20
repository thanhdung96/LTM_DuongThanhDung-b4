namespace DHCPClient
{
	class Program
	{
		private static dhcClient client;
		static void Main(string[] args)
		{
			client = new dhcClient();
			System.Console.WriteLine("Received: " + client.requestAddress());
			System.Console.ReadKey();
		}
	}
}
