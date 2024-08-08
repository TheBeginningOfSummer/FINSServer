using CSharpKit.Communication;
using CSharpKit.DataManagement;
using CSharpKit.FileManagement;
using System.ComponentModel;
using System.Net;

namespace FINSServer
{
    public partial class Form1 : Form
    {
        readonly SocketTool connection;
        readonly FinsTCP finsServer = new();
        //������ʾ����
        readonly DisplayData DArea;
        readonly DisplayData WArea;
        readonly DisplayData HArea;

        readonly BindingList<StringWrapper> clientList = [];

        public Form1()
        {
            InitializeComponent();

            DArea = new(finsServer.DRegister) { Text = "D��" };
            WArea = new(finsServer.WRegister) { Text = "W��" };
            HArea = new(finsServer.HRegister) { Text = "H��" };

            LBClientList.DataSource = clientList;
            LBClientList.DisplayMember = "Value";
            LBClientList.ValueMember = "Value";

            connection = JsonManager.Load<SocketTool>("Config", "FinsServer.json");
            connection.ClientListUpdate += UpdateClient;
            TSTBIP.Text = connection.IP;
            TSTBPort.Text = connection.Port.ToString();
            if (!string.IsNullOrEmpty(TSTBIP.Text) && !string.IsNullOrEmpty(TSTBPort.Text))
                if (connection.StartListening(IPAddress.Parse(TSTBIP.Text), int.Parse(TSTBPort.Text)))
                {
                    TBInfo.AppendText($"[{DateTime.Now}] �����ɹ���{Environment.NewLine}");
                }
            Task.Run(ProcessData);
        }

        private void UpdateClient()
        {
            Invoke(FreshClient);
        }

        private void FreshClient()
        {
            clientList.Clear();
            foreach (var client in connection.ClientDic.Keys)
            {
                clientList.Add(new StringWrapper(client));
            }
        }

        public async Task ProcessData()
        {
            while (await connection.ClientDataChannel.Reader.WaitToReadAsync())
            {
                try
                {
                    if (connection.ClientDataChannel.Reader.TryRead(out var clientData))
                    {
                        while (FinsTCP.ParseHeader(clientData.Data, out int dataLength, out _))
                        {
                            clientData.Client?.Send(finsServer.ProcessRegister(clientData.Data, int.Parse(TSTBIP.Text.Split('.')[3])));
                            clientData.Data[0] = 0x00;//���ݽ�����ϣ�����fins֡ͷ
                            BytesTool.ProcessDataCache(clientData.Data, dataLength + 8);
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void TSB����_Click(object sender, EventArgs e)
        {
            try
            {
                connection.IP = TSTBIP.Text;
                connection.Port = int.Parse(TSTBPort.Text);
                if (JsonManager.Save("Config", "FinsServer.json", connection))
                {
                    MessageBox.Show("����ɹ���");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TSB�鿴�Ĵ���_Click(object sender, EventArgs e)
        {
            switch (TSCB�Ĵ�������.Text)
            {
                case "D��":
                    DArea.Show();
                    break;
                case "W��":
                    WArea.Show();
                    break;
                case "H��":
                    HArea.Show();
                    break;
                default:
                    break;
            }
        }

        private void BTN����Э��_Click(object sender, EventArgs e)
        {
            finsServer.DRegister.Write(0, [0x00, 0x01]);
            finsServer.DRegister.Write(2, [0x00, 0x02]);
            finsServer.WRegister.Write(2, [0x00, 0x03]);
            finsServer.WRegister.Write(30, [0x00, 0x04]);
            finsServer.WRegister.Write(32, [0x00, 0x05]);
            finsServer.HRegister.Write(0, [0xFF, 0xFF]);
            finsServer.HRegister.Write(10, [0xFF, 0xFE]);
            finsServer.HRegister.Write(12, [0xFF, 0xFD]);
        }

        private void BTN����_Click(object sender, EventArgs e)
        {
            
        }



    }
}
