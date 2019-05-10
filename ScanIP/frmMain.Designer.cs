namespace ScanIP
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIPMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIPMin = new System.Windows.Forms.TextBox();
            this.radioTipo2 = new System.Windows.Forms.RadioButton();
            this.radioTipo1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.grpPortScanner = new System.Windows.Forms.GroupBox();
            this.radioPort2 = new System.Windows.Forms.RadioButton();
            this.txtPortSpecifics = new System.Windows.Forms.TextBox();
            this.radioPort1 = new System.Windows.Forms.RadioButton();
            this.txtPortRange = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.lstRes = new System.Windows.Forms.ListBox();
            this.butStart = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.statuStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpGeneral = new System.Windows.Forms.GroupBox();
            this.butPause = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpAddress.SuspendLayout();
            this.grpPortScanner.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statuStrip1.SuspendLayout();
            this.grpGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddress
            // 
            this.grpAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAddress.Controls.Add(this.label7);
            this.grpAddress.Controls.Add(this.label6);
            this.grpAddress.Controls.Add(this.txtIPMax);
            this.grpAddress.Controls.Add(this.label5);
            this.grpAddress.Controls.Add(this.txtIPMin);
            this.grpAddress.Controls.Add(this.radioTipo2);
            this.grpAddress.Controls.Add(this.radioTipo1);
            this.grpAddress.Controls.Add(this.label1);
            this.grpAddress.Controls.Add(this.txtHost);
            this.grpAddress.Location = new System.Drawing.Point(9, 10);
            this.grpAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAddress.Size = new System.Drawing.Size(608, 132);
            this.grpAddress.TabIndex = 0;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address options";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max value";
            // 
            // txtIPMax
            // 
            this.txtIPMax.Location = new System.Drawing.Point(107, 82);
            this.txtIPMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIPMax.Name = "txtIPMax";
            this.txtIPMax.Size = new System.Drawing.Size(88, 20);
            this.txtIPMax.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Min value";
            // 
            // txtIPMin
            // 
            this.txtIPMin.Location = new System.Drawing.Point(16, 82);
            this.txtIPMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIPMin.Name = "txtIPMin";
            this.txtIPMin.Size = new System.Drawing.Size(88, 20);
            this.txtIPMin.TabIndex = 1;
            // 
            // radioTipo2
            // 
            this.radioTipo2.AutoSize = true;
            this.radioTipo2.Location = new System.Drawing.Point(256, 83);
            this.radioTipo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioTipo2.Name = "radioTipo2";
            this.radioTipo2.Size = new System.Drawing.Size(85, 17);
            this.radioTipo2.TabIndex = 4;
            this.radioTipo2.TabStop = true;
            this.radioTipo2.Text = "Port scanner";
            this.radioTipo2.UseVisualStyleBackColor = true;
            this.radioTipo2.Click += new System.EventHandler(this.RadioTipo_Click);
            // 
            // radioTipo1
            // 
            this.radioTipo1.AutoSize = true;
            this.radioTipo1.Location = new System.Drawing.Point(209, 83);
            this.radioTipo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioTipo1.Name = "radioTipo1";
            this.radioTipo1.Size = new System.Drawing.Size(46, 17);
            this.radioTipo1.TabIndex = 3;
            this.radioTipo1.TabStop = true;
            this.radioTipo1.Text = "Ping";
            this.radioTipo1.UseVisualStyleBackColor = true;
            this.radioTipo1.Click += new System.EventHandler(this.RadioTipo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP Adress or Host";
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(16, 38);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(581, 20);
            this.txtHost.TabIndex = 0;
            // 
            // grpPortScanner
            // 
            this.grpPortScanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPortScanner.Controls.Add(this.radioPort2);
            this.grpPortScanner.Controls.Add(this.txtPortSpecifics);
            this.grpPortScanner.Controls.Add(this.radioPort1);
            this.grpPortScanner.Controls.Add(this.txtPortRange);
            this.grpPortScanner.Location = new System.Drawing.Point(621, 10);
            this.grpPortScanner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPortScanner.Name = "grpPortScanner";
            this.grpPortScanner.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPortScanner.Size = new System.Drawing.Size(206, 78);
            this.grpPortScanner.TabIndex = 1;
            this.grpPortScanner.TabStop = false;
            this.grpPortScanner.Text = "Port scanner options";
            // 
            // radioPort2
            // 
            this.radioPort2.AutoSize = true;
            this.radioPort2.Location = new System.Drawing.Point(14, 45);
            this.radioPort2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioPort2.Name = "radioPort2";
            this.radioPort2.Size = new System.Drawing.Size(92, 17);
            this.radioPort2.TabIndex = 8;
            this.radioPort2.TabStop = true;
            this.radioPort2.Text = "Specific ports:";
            this.radioPort2.UseVisualStyleBackColor = true;
            this.radioPort2.Click += new System.EventHandler(this.RadioPort_Click);
            // 
            // txtPortSpecifics
            // 
            this.txtPortSpecifics.Location = new System.Drawing.Point(115, 44);
            this.txtPortSpecifics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortSpecifics.Name = "txtPortSpecifics";
            this.txtPortSpecifics.Size = new System.Drawing.Size(87, 20);
            this.txtPortSpecifics.TabIndex = 7;
            // 
            // radioPort1
            // 
            this.radioPort1.AutoSize = true;
            this.radioPort1.Location = new System.Drawing.Point(14, 22);
            this.radioPort1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioPort1.Name = "radioPort1";
            this.radioPort1.Size = new System.Drawing.Size(77, 17);
            this.radioPort1.TabIndex = 6;
            this.radioPort1.TabStop = true;
            this.radioPort1.Text = "Port range:";
            this.radioPort1.UseVisualStyleBackColor = true;
            this.radioPort1.Click += new System.EventHandler(this.RadioPort_Click);
            // 
            // txtPortRange
            // 
            this.txtPortRange.Location = new System.Drawing.Point(115, 21);
            this.txtPortRange.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPortRange.Name = "txtPortRange";
            this.txtPortRange.Size = new System.Drawing.Size(87, 20);
            this.txtPortRange.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Timeout (ms.)";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(104, 20);
            this.txtTimeout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(91, 20);
            this.txtTimeout.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lstInfo);
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(438, 315);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(9, 146);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1MinSize = 250;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(818, 319);
            this.splitContainer1.SplitterDistance = 442;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 15;
            // 
            // lstInfo
            // 
            this.lstInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(2, 15);
            this.lstInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(434, 298);
            this.lstInfo.TabIndex = 11;
            this.lstInfo.DoubleClick += new System.EventHandler(this.lstRes_DoubleClick);
            // 
            // lstRes
            // 
            this.lstRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Location = new System.Drawing.Point(2, 15);
            this.lstRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(363, 298);
            this.lstRes.TabIndex = 13;
            this.lstRes.DoubleClick += new System.EventHandler(this.lstRes_DoubleClick);
            // 
            // butStart
            // 
            this.butStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butStart.Location = new System.Drawing.Point(9, 469);
            this.butStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(72, 25);
            this.butStart.TabIndex = 8;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.ButStart_Click);
            // 
            // butStop
            // 
            this.butStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butStop.Location = new System.Drawing.Point(162, 469);
            this.butStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(72, 25);
            this.butStop.TabIndex = 9;
            this.butStop.Text = "Stop";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.ButStop_Click);
            // 
            // butExit
            // 
            this.butExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butExit.Location = new System.Drawing.Point(755, 469);
            this.butExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(72, 25);
            this.butExit.TabIndex = 10;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.ButExit_Click);
            // 
            // statuStrip1
            // 
            this.statuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statuStrip1.Location = new System.Drawing.Point(0, 497);
            this.statuStrip1.Name = "statuStrip1";
            this.statuStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statuStrip1.Size = new System.Drawing.Size(839, 22);
            this.statuStrip1.TabIndex = 7;
            this.statuStrip1.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 17);
            this.lblInfo.Text = "toolStripStatusLabel1";
            // 
            // grpGeneral
            // 
            this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpGeneral.Controls.Add(this.label4);
            this.grpGeneral.Controls.Add(this.txtTimeout);
            this.grpGeneral.Location = new System.Drawing.Point(621, 93);
            this.grpGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGeneral.Name = "grpGeneral";
            this.grpGeneral.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpGeneral.Size = new System.Drawing.Size(206, 49);
            this.grpGeneral.TabIndex = 7;
            this.grpGeneral.TabStop = false;
            this.grpGeneral.Text = "General options";
            // 
            // butPause
            // 
            this.butPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butPause.Location = new System.Drawing.Point(86, 469);
            this.butPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(72, 25);
            this.butPause.TabIndex = 31;
            this.butPause.Text = "Pause";
            this.butPause.UseVisualStyleBackColor = true;
            this.butPause.Click += new System.EventHandler(this.ButPause_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lstRes);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(367, 315);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.grpGeneral);
            this.Controls.Add(this.statuStrip1);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.grpPortScanner);
            this.Controls.Add(this.grpAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(604, 454);
            this.Name = "frmMain";
            this.Text = "IpScan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpPortScanner.ResumeLayout(false);
            this.grpPortScanner.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statuStrip1.ResumeLayout(false);
            this.statuStrip1.PerformLayout();
            this.grpGeneral.ResumeLayout(false);
            this.grpGeneral.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.RadioButton radioTipo2;
        private System.Windows.Forms.RadioButton radioTipo1;
        private System.Windows.Forms.GroupBox grpPortScanner;
        private System.Windows.Forms.TextBox txtPortRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIPMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIPMax;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.StatusStrip statuStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.GroupBox grpGeneral;
        private System.Windows.Forms.ListBox lstRes;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.RadioButton radioPort2;
        private System.Windows.Forms.TextBox txtPortSpecifics;
        private System.Windows.Forms.RadioButton radioPort1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

