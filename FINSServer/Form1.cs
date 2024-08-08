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
        //数据显示窗口
        readonly DisplayData DArea;
        readonly DisplayData WArea;
        readonly DisplayData HArea;

        readonly BindingList<StringWrapper> clientList = [];

        public Form1()
        {
            InitializeComponent();

            DArea = new(finsServer.DRegister) { Text = "D区" };
            WArea = new(finsServer.WRegister) { Text = "W区" };
            HArea = new(finsServer.HRegister) { Text = "H区" };

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
                    TBInfo.AppendText($"[{DateTime.Now}] 监听成功。{Environment.NewLine}");
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
                            clientData.Data[0] = 0x00;//数据解析完毕，更改fins帧头
                            BytesTool.ProcessDataCache(clientData.Data, dataLength + 8);
                        }
                    }
                }
                catch (Exception)
                {
                    
                }
            }
        }

        private void TSB保存_Click(object sender, EventArgs e)
        {
            try
            {
                connection.IP = TSTBIP.Text;
                connection.Port = int.Parse(TSTBPort.Text);
                if (JsonManager.Save("Config", "FinsServer.json", connection))
                {
                    MessageBox.Show("保存成功。");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TSB查看寄存器_Click(object sender, EventArgs e)
        {
            switch (TSCB寄存器区域.Text)
            {
                case "D区":
                    DArea.Show();
                    break;
                case "W区":
                    WArea.Show();
                    break;
                case "H区":
                    HArea.Show();
                    break;
                default:
                    break;
            }
        }

        private void BTN设置协议_Click(object sender, EventArgs e)
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

        private void BTN测试_Click(object sender, EventArgs e)
        {
            
        }



    }
}
