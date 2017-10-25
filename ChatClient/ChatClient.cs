using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatClient
{
	public partial class ChatClient : Form
	{
		private TcpClient client;
		private NetworkStream netStream;

		private byte[] dataSend, dataReceive;
		private int dataSize;
		private string data;

		public ChatClient()
		{
			InitializeComponent();
			initNetwork();
			startChat();
		}

		private void initNetwork()
		{
			client = new TcpClient();
			client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1724));
			netStream = client.GetStream();
			dataReceive = new byte[1024];
			dataSend = new byte[1024];
		}

		private void startChat()
		{
			while (true)
			{
				//server send first
				listening();
				btnText.Click += btnText_Click;
				btnText.Click -= btnText_Click;
			}
		}

		private void btnText_Click(object sender, System.EventArgs e)
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
			lbxConversation.Items.Add("Server said: " + data);
		}

		private void toggleGUI(bool on)
		{
			btnText.Enabled = on;
			btnImg.Enabled = on;
			btnSound.Enabled = on;
			btnVideo.Enabled = on;
		}
	}
}
