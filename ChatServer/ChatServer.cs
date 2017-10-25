using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatServer
{
	public partial class ChatServer : Form
	{
		private TcpListener server;
		private TcpClient client;
		private NetworkStream netStream;

		private byte[] dataSend, dataReceive;
		private int dataSize;
		private string data;

		public ChatServer()
		{
			InitializeComponent();
			initNetwork();
			startChat();
		}

		private void startChat()
		{
			while (true)
			{
				//server send first
				btnText.Click += btnText_Click;
				btnText.Click -= btnText_Click;
				listening();
			}
		}

		private void toggleGUI(bool on)
		{
			btnText.Enabled = on;
			btnImg.Enabled = on;
			btnSound.Enabled = on;
			btnVideo.Enabled = on;
		}

		private void initNetwork()
		{
			server = new TcpListener(new IPEndPoint(IPAddress.Any, 1724));
			server.Start();

			client = server.AcceptTcpClient();
			netStream = client.GetStream();
			toggleGUI(true);

			dataSend = new byte[1024];
			dataReceive = new byte[1024];
		}

		void btnText_Click(object sender, System.EventArgs e)
		{
			toggleGUI(true);
			dataSend = Encoding.ASCII.GetBytes(txtInput.Text);
			netStream.Write(dataSend, 0, txtInput.Text.Length);
			lbxConversation.Items.Add("I said: " + txtInput.Text);
			toggleGUI(false);
		}

		private void listening()
		{
			dataSize = netStream.Read(dataReceive, 0, 1024);
			data = Encoding.ASCII.GetString(dataReceive, 0, dataSize);
			lbxConversation.Items.Add("Client said: " + data);
		}
	}
}
