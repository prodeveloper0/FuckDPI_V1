using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuckDPI
{
    public partial class MainForm : Form
    {
        NicHelper helper = new NicHelper();

        static int SetMTU(string nic_name, object mtu, string proto = "ipv4")
        {
            string netshopt = String.Format(@"interface {0} set subinterface \""{1}\"" mtu={2} store=persistent", proto, nic_name, mtu);
            return ProcessHelper.ExecuteAndWait(@"netsh.exe", netshopt, true);
        }

        void RefreshAdapterList()
        {
            cbInterface.Items.Clear();
            cbInterface.Items.AddRange(helper.ToNameArray());
            if (cbInterface.Items.Count != 0)
                cbInterface.SelectedIndex = 0;
        }

        void ShowAdapterInformation(bool show_alert = true)
        {
            NetworkInterface nic = helper[cbInterface.Text];
            if (nic == null && show_alert == true)
            {
                MessageBox.Show(this, "Cannot retreive adapter information", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtMAC.Text = nic.GetPhysicalAddress().ToString();
            txtIPv4Address.Text = nic.GetIPProperties().UnicastAddresses.FirstOrDefault(addr => addr.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork).Address.ToString();
            txtIPv4MTU.Text = nic.GetIPProperties().GetIPv4Properties().Mtu.ToString();
        }

        void RevertAdapterStatusFromFile(string filename = @"fdpi.txt")
        {
            try
            {
                string[] lines = File.ReadAllLines(filename);
                if (lines.Count() != 3)
                    return;
                SetMTU(lines[0], lines[1], lines[2]);
            } catch
            {

            }
        }

        void SaveAdapterStatusToFile(string filename = @"fdpi.txt")
        {
            try
            {
                string[] lines = new string[] { cbInterface.Text, txtIPv4MTU.Text, "ipv4" };
                File.WriteAllLines(filename, lines);
            } catch
            {

            }
        }

        void DeleteAdapterStatusFile(string filename = @"fdpi.txt")
        {
            try
            {
                File.Delete(filename);
            } catch
            {

            }
        }

        void RevertAdapterStatus(bool show_alert = true)
        {
            cbInterface.Enabled = true;
            btRefresh.Enabled = true;
            numIPv4MTUModified.Enabled = true;
            btRevert.Enabled = false;
            btApply.Enabled = true;

            NetworkInterface nic = helper[cbInterface.Text];
            if (nic == null && show_alert == true)
            {
                MessageBox.Show(this, "Cannot retreive adapter information", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SetMTU(cbInterface.Text, txtIPv4MTU.Text);
        }

        void ApplyAdapterStatus(bool show_alert = true)
        {
            cbInterface.Enabled = false;
            btRefresh.Enabled = false;
            numIPv4MTUModified.Enabled = false;
            btRevert.Enabled = true;
            btApply.Enabled = false;

            NetworkInterface nic = helper[cbInterface.Text];
            if (nic == null && show_alert == true)
            {
                MessageBox.Show(this, "Cannot retreive adapter information", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SetMTU(cbInterface.Text, numIPv4MTUModified.Value);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RevertAdapterStatusFromFile();
            DeleteAdapterStatusFile();
            RefreshAdapterList();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            RevertAdapterStatus(false);
            DeleteAdapterStatusFile();
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            RefreshAdapterList();
        }

        private void btRevert_Click(object sender, EventArgs e)
        {
            RevertAdapterStatus();
            DeleteAdapterStatusFile();
        }

        private void btApply_Click(object sender, EventArgs e)
        {
            ApplyAdapterStatus();
            SaveAdapterStatusToFile();
        }

        private void cbInterface_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowAdapterInformation();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.Hide();
        }
    }
}
