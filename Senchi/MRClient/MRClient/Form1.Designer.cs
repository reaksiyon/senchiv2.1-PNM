namespace MRClient
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SendBTN = new System.Windows.Forms.Button();
            this.msgTB = new System.Windows.Forms.TextBox();
            this.ConnectCheck = new System.Windows.Forms.Label();
            this.NickTB = new System.Windows.Forms.TextBox();
            this.NickLB = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TextPanel = new System.Windows.Forms.TextBox();
            this.ipAdd = new System.Windows.Forms.Label();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.ConnectBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendBTN
            // 
            this.SendBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SendBTN.ForeColor = System.Drawing.Color.LightPink;
            this.SendBTN.Location = new System.Drawing.Point(327, 452);
            this.SendBTN.Name = "SendBTN";
            this.SendBTN.Size = new System.Drawing.Size(89, 34);
            this.SendBTN.TabIndex = 1;
            this.SendBTN.Text = "Send";
            this.SendBTN.UseVisualStyleBackColor = true;
            this.SendBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // msgTB
            // 
            this.msgTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgTB.Location = new System.Drawing.Point(30, 459);
            this.msgTB.Name = "msgTB";
            this.msgTB.Size = new System.Drawing.Size(295, 20);
            this.msgTB.TabIndex = 2;
            this.msgTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // ConnectCheck
            // 
            this.ConnectCheck.BackColor = System.Drawing.Color.Transparent;
            this.ConnectCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConnectCheck.Location = new System.Drawing.Point(1, 500);
            this.ConnectCheck.Name = "ConnectCheck";
            this.ConnectCheck.Size = new System.Drawing.Size(193, 13);
            this.ConnectCheck.TabIndex = 3;
            this.ConnectCheck.Text = "CONNECTION ERROR!";
            this.ConnectCheck.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConnectCheck.Click += new System.EventHandler(this.ConnectCheck_Click);
            // 
            // NickTB
            // 
            this.NickTB.Location = new System.Drawing.Point(166, 0);
            this.NickTB.Name = "NickTB";
            this.NickTB.Size = new System.Drawing.Size(100, 20);
            this.NickTB.TabIndex = 4;
            // 
            // NickLB
            // 
            this.NickLB.AutoSize = true;
            this.NickLB.BackColor = System.Drawing.Color.Transparent;
            this.NickLB.Location = new System.Drawing.Point(128, 3);
            this.NickLB.Name = "NickLB";
            this.NickLB.Size = new System.Drawing.Size(32, 13);
            this.NickLB.TabIndex = 5;
            this.NickLB.Text = "Nick:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.Color.LavenderBlush;
            this.TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPanel.ForeColor = System.Drawing.Color.HotPink;
            this.TextPanel.Location = new System.Drawing.Point(30, 23);
            this.TextPanel.Multiline = true;
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(386, 423);
            this.TextPanel.TabIndex = 6;
            // 
            // ipAdd
            // 
            this.ipAdd.AutoSize = true;
            this.ipAdd.BackColor = System.Drawing.Color.Transparent;
            this.ipAdd.Location = new System.Drawing.Point(4, 2);
            this.ipAdd.Name = "ipAdd";
            this.ipAdd.Size = new System.Drawing.Size(20, 13);
            this.ipAdd.TabIndex = 7;
            this.ipAdd.Text = "IP:";
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(27, 0);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(95, 20);
            this.ipTB.TabIndex = 8;
            this.ipTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // ConnectBTN
            // 
            this.ConnectBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ConnectBTN.ForeColor = System.Drawing.Color.LightPink;
            this.ConnectBTN.Location = new System.Drawing.Point(302, 1);
            this.ConnectBTN.Name = "ConnectBTN";
            this.ConnectBTN.Size = new System.Drawing.Size(114, 18);
            this.ConnectBTN.TabIndex = 9;
            this.ConnectBTN.Text = "Connect";
            this.ConnectBTN.UseVisualStyleBackColor = true;
            this.ConnectBTN.Click += new System.EventHandler(this.connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 514);
            this.Controls.Add(this.ConnectBTN);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.ipAdd);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.NickLB);
            this.Controls.Add(this.NickTB);
            this.Controls.Add(this.ConnectCheck);
            this.Controls.Add(this.msgTB);
            this.Controls.Add(this.SendBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Senchi v2.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SendBTN;
        private System.Windows.Forms.TextBox msgTB;
        private System.Windows.Forms.Label ConnectCheck;
        private System.Windows.Forms.TextBox NickTB;
        private System.Windows.Forms.Label NickLB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox TextPanel;
        private System.Windows.Forms.Label ipAdd;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Button ConnectBTN;
    }
}

