namespace DHCPServer
{
	class Program
	{
		private static dhcpd dhcpd;

		static void Main(string[] args)
		{
			dhcpd = new dhcpd(100, 150);
			while (true)
				dhcpd.startListening();
		}
	}
}
