using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System;

namespace Bai_2
{
	public partial class Form1 : Form
	{
		IPEndPoint host;
		TcpClient tcpClient;
		UdpClient udpClient;

		byte[] receive;

		public Form1()
		{
			InitializeComponent();

			initComponents();
		}

		private void initComponents()
		{
			host = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724);
			tcpClient = new TcpClient();
			udpClient = new UdpClient();
			receive = new byte[0];
		}

		private void txtCheck_Click(object sender, System.EventArgs e)
		{
			try
			{
				int port = Convert.ToInt32(txtPort.Text);
				host = new IPEndPoint(IPAddress.Parse(txtHost.Text), port);

				tcpClient.Connect(host);

				udpClient.Connect(host);
				udpClient.Send(new byte[] { 1 }, 1);		//send 1 byte of 1 as hello packet
				receive = udpClient.Receive(ref host);
			}
			catch (FormatException)
			{
				txtResult.Text = "Invalid input format\n";
			}
			catch (ArgumentNullException)
			{
				txtResult.Text = "Invalid input format\n";
			}
			catch (SocketException)
			{
				txtResult.Text = "Cannot connect to host\n";
			}
			catch (IndexOutOfRangeException exc)
			{
				txtResult.Text = exc.Message;
			}
			if (tcpClient.Connected)
			{
				txtResult.Text = host.ToString() + " opens for TCP\n";
				tcpClient.Close();
			}
			else
			{
				Console.WriteLine();
			}
			if (receive.Length == 1)
			{
				if(receive[0] == 1){
					txtResult.Text += host.ToString() + " opens for UDP\n";
					udpClient.Close();
				}
			}
			else
			{
				txtResult.Text += host.ToString() + " closed for UDP\n";
				udpClient.Close();
			}
		}
	}
}
