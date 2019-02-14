namespace FuckDPI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbInterface = new System.Windows.Forms.ComboBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIPv4MTU = new System.Windows.Forms.TextBox();
            this.numIPv4MTUModified = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIPv4Address = new System.Windows.Forms.TextBox();
            this.txtMAC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btRevert = new System.Windows.Forms.Button();
            this.btApply = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIPv4MTUModified)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adpter";
            // 
            // cbInterface
            // 
            this.cbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterface.FormattingEnabled = true;
            this.cbInterface.Location = new System.Drawing.Point(57, 10);
            this.cbInterface.Name = "cbInterface";
            this.cbInterface.Size = new System.Drawing.Size(289, 21);
            this.cbInterface.TabIndex = 1;
            this.cbInterface.SelectedIndexChanged += new System.EventHandler(this.cbInterface_SelectedIndexChanged);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(357, 8);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIPv4MTU);
            this.groupBox1.Controls.Add(this.numIPv4MTUModified);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIPv4Address);
            this.groupBox1.Controls.Add(this.txtMAC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 130);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // txtIPv4MTU
            // 
            this.txtIPv4MTU.Location = new System.Drawing.Point(96, 94);
            this.txtIPv4MTU.Name = "txtIPv4MTU";
            this.txtIPv4MTU.ReadOnly = true;
            this.txtIPv4MTU.Size = new System.Drawing.Size(135, 20);
            this.txtIPv4MTU.TabIndex = 11;
            // 
            // numIPv4MTUModified
            // 
            this.numIPv4MTUModified.Location = new System.Drawing.Point(278, 95);
            this.numIPv4MTUModified.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.numIPv4MTUModified.Name = "numIPv4MTUModified";
            this.numIPv4MTUModified.Size = new System.Drawing.Size(135, 20);
            this.numIPv4MTUModified.TabIndex = 10;
            this.numIPv4MTUModified.Value = new decimal(new int[] {
            256,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(237, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "->";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "IPv4 MTU";
            // 
            // txtIPv4Address
            // 
            this.txtIPv4Address.Location = new System.Drawing.Point(96, 58);
            this.txtIPv4Address.Name = "txtIPv4Address";
            this.txtIPv4Address.ReadOnly = true;
            this.txtIPv4Address.Size = new System.Drawing.Size(317, 20);
            this.txtIPv4Address.TabIndex = 4;
            // 
            // txtMAC
            // 
            this.txtMAC.Enabled = false;
            this.txtMAC.Location = new System.Drawing.Point(96, 23);
            this.txtMAC.Name = "txtMAC";
            this.txtMAC.ReadOnly = true;
            this.txtMAC.Size = new System.Drawing.Size(317, 20);
            this.txtMAC.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "IPv4 Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MAC";
            // 
            // btRevert
            // 
            this.btRevert.Enabled = false;
            this.btRevert.Location = new System.Drawing.Point(226, 184);
            this.btRevert.Name = "btRevert";
            this.btRevert.Size = new System.Drawing.Size(98, 23);
            this.btRevert.TabIndex = 4;
            this.btRevert.Text = "&Revert";
            this.btRevert.UseVisualStyleBackColor = true;
            this.btRevert.Click += new System.EventHandler(this.btRevert_Click);
            // 
            // btApply
            // 
            this.btApply.Location = new System.Drawing.Point(334, 184);
            this.btApply.Name = "btApply";
            this.btApply.Size = new System.Drawing.Size(98, 23);
            this.btApply.TabIndex = 5;
            this.btApply.Text = "&Apply";
            this.btApply.UseVisualStyleBackColor = true;
            this.btApply.Click += new System.EventHandler(this.btApply_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipTitle = "FuckDPI";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FuckDPI";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 219);
            this.Controls.Add(this.btApply);
            this.Controls.Add(this.btRevert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.cbInterface);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuckDPI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIPv4MTUModified)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInterface;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIPv4Address;
        private System.Windows.Forms.TextBox txtMAC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numIPv4MTUModified;
        private System.Windows.Forms.Button btRevert;
        private System.Windows.Forms.Button btApply;
        private System.Windows.Forms.TextBox txtIPv4MTU;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

