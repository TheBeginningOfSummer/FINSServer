namespace FINSServer
{
    partial class DisplayData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TBDisplay = new TextBox();
            RBHex = new RadioButton();
            RBASCII = new RadioButton();
            CK字节顺序 = new CheckBox();
            BTN设置寄存器 = new Button();
            label1 = new Label();
            label2 = new Label();
            CB地址 = new ComboBox();
            CB数据 = new ComboBox();
            SuspendLayout();
            // 
            // TBDisplay
            // 
            TBDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TBDisplay.Location = new Point(12, 12);
            TBDisplay.Multiline = true;
            TBDisplay.Name = "TBDisplay";
            TBDisplay.ReadOnly = true;
            TBDisplay.ScrollBars = ScrollBars.Vertical;
            TBDisplay.Size = new Size(681, 389);
            TBDisplay.TabIndex = 0;
            // 
            // RBHex
            // 
            RBHex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RBHex.AutoSize = true;
            RBHex.Checked = true;
            RBHex.Location = new Point(12, 411);
            RBHex.Name = "RBHex";
            RBHex.Size = new Size(50, 21);
            RBHex.TabIndex = 1;
            RBHex.TabStop = true;
            RBHex.Tag = "HEX";
            RBHex.Text = "HEX";
            RBHex.UseVisualStyleBackColor = true;
            RBHex.CheckedChanged += RB_CheckedChanged;
            // 
            // RBASCII
            // 
            RBASCII.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RBASCII.AutoSize = true;
            RBASCII.Location = new Point(68, 411);
            RBASCII.Name = "RBASCII";
            RBASCII.Size = new Size(57, 21);
            RBASCII.TabIndex = 2;
            RBASCII.Tag = "ASCII";
            RBASCII.Text = "ASCII";
            RBASCII.UseVisualStyleBackColor = true;
            RBASCII.CheckedChanged += RB_CheckedChanged;
            // 
            // CK字节顺序
            // 
            CK字节顺序.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CK字节顺序.AutoSize = true;
            CK字节顺序.Location = new Point(131, 412);
            CK字节顺序.Name = "CK字节顺序";
            CK字节顺序.Size = new Size(106, 21);
            CK字节顺序.TabIndex = 3;
            CK字节顺序.Text = "ASCII字节顺序";
            CK字节顺序.UseVisualStyleBackColor = true;
            // 
            // BTN设置寄存器
            // 
            BTN设置寄存器.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTN设置寄存器.Font = new Font("Microsoft YaHei UI", 8F);
            BTN设置寄存器.Location = new Point(618, 409);
            BTN设置寄存器.Name = "BTN设置寄存器";
            BTN设置寄存器.Size = new Size(75, 23);
            BTN设置寄存器.TabIndex = 4;
            BTN设置寄存器.Text = "设置寄存器";
            BTN设置寄存器.UseVisualStyleBackColor = true;
            BTN设置寄存器.Click += BTN设置寄存器_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(486, 413);
            label1.Name = "label1";
            label1.Size = new Size(20, 17);
            label1.TabIndex = 6;
            label1.Text = "值";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(385, 413);
            label2.Name = "label2";
            label2.Size = new Size(32, 17);
            label2.TabIndex = 8;
            label2.Text = "地址";
            // 
            // CB地址
            // 
            CB地址.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CB地址.FormattingEnabled = true;
            CB地址.Items.AddRange(new object[] { "3", "36" });
            CB地址.Location = new Point(423, 410);
            CB地址.Name = "CB地址";
            CB地址.Size = new Size(50, 25);
            CB地址.TabIndex = 9;
            CB地址.Text = "0";
            // 
            // CB数据
            // 
            CB数据.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CB数据.FormattingEnabled = true;
            CB数据.Items.AddRange(new object[] { "0", ":9" });
            CB数据.Location = new Point(512, 410);
            CB数据.Name = "CB数据";
            CB数据.Size = new Size(100, 25);
            CB数据.TabIndex = 10;
            CB数据.Text = "0";
            // 
            // DisplayData
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 444);
            Controls.Add(CB数据);
            Controls.Add(CB地址);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTN设置寄存器);
            Controls.Add(CK字节顺序);
            Controls.Add(RBASCII);
            Controls.Add(RBHex);
            Controls.Add(TBDisplay);
            Name = "DisplayData";
            Text = "DisplayData";
            FormClosing += DisplayData_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TBDisplay;
        private RadioButton RBHex;
        private RadioButton RBASCII;
        private CheckBox CK字节顺序;
        private Button BTN设置寄存器;
        private Label label1;
        private Label label2;
        private ComboBox CB地址;
        private ComboBox CB数据;
    }
}