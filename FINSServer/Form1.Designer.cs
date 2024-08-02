namespace FINSServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TS功能菜单 = new ToolStrip();
            TSB = new ToolStripButton();
            TSTBIP = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            TSTBPort = new ToolStripTextBox();
            TSB保存 = new ToolStripButton();
            TSB查看寄存器 = new ToolStripButton();
            TSCB寄存器区域 = new ToolStripComboBox();
            TBInfo = new TextBox();
            LBClientList = new ListBox();
            BTN设置协议 = new Button();
            BTN测试 = new Button();
            TS功能菜单.SuspendLayout();
            SuspendLayout();
            // 
            // TS功能菜单
            // 
            TS功能菜单.GripStyle = ToolStripGripStyle.Hidden;
            TS功能菜单.Items.AddRange(new ToolStripItem[] { TSB, TSTBIP, toolStripLabel2, TSTBPort, TSB保存, TSB查看寄存器, TSCB寄存器区域 });
            TS功能菜单.Location = new Point(0, 0);
            TS功能菜单.Name = "TS功能菜单";
            TS功能菜单.Size = new Size(914, 25);
            TS功能菜单.TabIndex = 0;
            TS功能菜单.Text = "toolStrip1";
            // 
            // TSB
            // 
            TSB.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB.Image = (Image)resources.GetObject("TSB.Image");
            TSB.ImageTransparentColor = Color.Magenta;
            TSB.Name = "TSB";
            TSB.Size = new Size(23, 22);
            TSB.Text = "IP";
            // 
            // TSTBIP
            // 
            TSTBIP.Name = "TSTBIP";
            TSTBIP.Size = new Size(114, 25);
            TSTBIP.Text = "127.0.0.1";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(32, 22);
            toolStripLabel2.Text = "Port";
            // 
            // TSTBPort
            // 
            TSTBPort.Name = "TSTBPort";
            TSTBPort.Size = new Size(57, 25);
            TSTBPort.Text = "9600";
            // 
            // TSB保存
            // 
            TSB保存.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB保存.Image = (Image)resources.GetObject("TSB保存.Image");
            TSB保存.ImageTransparentColor = Color.Magenta;
            TSB保存.Name = "TSB保存";
            TSB保存.Size = new Size(36, 22);
            TSB保存.Text = "保存";
            TSB保存.Click += TSB保存_Click;
            // 
            // TSB查看寄存器
            // 
            TSB查看寄存器.Alignment = ToolStripItemAlignment.Right;
            TSB查看寄存器.DisplayStyle = ToolStripItemDisplayStyle.Text;
            TSB查看寄存器.Image = (Image)resources.GetObject("TSB查看寄存器.Image");
            TSB查看寄存器.ImageTransparentColor = Color.Magenta;
            TSB查看寄存器.Name = "TSB查看寄存器";
            TSB查看寄存器.Size = new Size(36, 22);
            TSB查看寄存器.Text = "查看";
            TSB查看寄存器.Click += TSB查看寄存器_Click;
            // 
            // TSCB寄存器区域
            // 
            TSCB寄存器区域.Alignment = ToolStripItemAlignment.Right;
            TSCB寄存器区域.Items.AddRange(new object[] { "D区", "W区", "H区" });
            TSCB寄存器区域.Name = "TSCB寄存器区域";
            TSCB寄存器区域.Size = new Size(85, 25);
            TSCB寄存器区域.Text = "D区";
            // 
            // TBInfo
            // 
            TBInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TBInfo.Location = new Point(330, 28);
            TBInfo.Multiline = true;
            TBInfo.Name = "TBInfo";
            TBInfo.ScrollBars = ScrollBars.Vertical;
            TBInfo.Size = new Size(388, 412);
            TBInfo.TabIndex = 1;
            // 
            // LBClientList
            // 
            LBClientList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LBClientList.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            LBClientList.FormattingEnabled = true;
            LBClientList.ItemHeight = 17;
            LBClientList.Location = new Point(14, 28);
            LBClientList.Name = "LBClientList";
            LBClientList.Size = new Size(309, 412);
            LBClientList.TabIndex = 2;
            // 
            // BTN设置协议
            // 
            BTN设置协议.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN设置协议.Font = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
            BTN设置协议.ForeColor = Color.DeepSkyBlue;
            BTN设置协议.Location = new Point(726, 28);
            BTN设置协议.Name = "BTN设置协议";
            BTN设置协议.Size = new Size(86, 23);
            BTN设置协议.TabIndex = 3;
            BTN设置协议.Text = "设置协议数据";
            BTN设置协议.UseVisualStyleBackColor = true;
            BTN设置协议.Click += BTN设置协议_Click;
            // 
            // BTN测试
            // 
            BTN测试.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BTN测试.Location = new Point(726, 57);
            BTN测试.Name = "BTN测试";
            BTN测试.Size = new Size(86, 23);
            BTN测试.TabIndex = 4;
            BTN测试.Text = "测试";
            BTN测试.UseVisualStyleBackColor = true;
            BTN测试.Click += BTN测试_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(BTN测试);
            Controls.Add(BTN设置协议);
            Controls.Add(LBClientList);
            Controls.Add(TBInfo);
            Controls.Add(TS功能菜单);
            Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinsServer";
            TS功能菜单.ResumeLayout(false);
            TS功能菜单.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip TS功能菜单;
        private ToolStripButton TSB;
        private ToolStripTextBox TSTBIP;
        private ToolStripLabel toolStripLabel2;
        private ToolStripTextBox TSTBPort;
        private ToolStripButton TSB保存;
        private ToolStripButton TSB查看寄存器;
        private ToolStripComboBox TSCB寄存器区域;
        private TextBox TBInfo;
        private ListBox LBClientList;
        private Button BTN设置协议;
        private Button BTN测试;
    }
}
