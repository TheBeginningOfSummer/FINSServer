using CSharpKit.DataManagement;
using System.Text;

namespace FINSServer
{
    public partial class DisplayData : Form
    {
        public Register Register;
        private int displayMode;

        public DisplayData(Register data)
        {
            InitializeComponent();
            Register = data;
            Task.Run(UpdateData);
        }

        private void DisplayData_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void UpdateData()
        {
            while (true)
            {
                Thread.Sleep(500);
                if (IsHandleCreated)
                    Invoke(SetControl);
            }
        }

        private void SetControl()
        {
            if (displayMode == 0)
            {
                TBDisplay.Text = Register.ShowData(200);
            }
            if (displayMode == 1)
            {
                if (CK字节顺序.Checked)
                    TBDisplay.Text = Register.ShowASCII(200, isReverse: true);
                else
                    TBDisplay.Text = Register.ShowASCII(200);
            }
        }

        private void RB_CheckedChanged(object sender, EventArgs e)
        {
            var rb = (RadioButton)sender;
            string? tag = (string?)rb.Tag;
            if (tag == null) return;
            if (tag == "HEX")
            {
                displayMode = 0;
            }
            if (tag == "ASCII")
            {
                displayMode = 1;
            }
        }

        private void BTN设置寄存器_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayMode == 0)
                    Register.Write(ushort.Parse(CB地址.Text), DataConverter.ValueToBytes(ushort.Parse(CB数据.Text)));
                if (displayMode == 1)
                    Register.Write(ushort.Parse(CB地址.Text), Encoding.ASCII.GetBytes(CB数据.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
