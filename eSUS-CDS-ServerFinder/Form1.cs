using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eSUS_CDS_ServerFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addLogMessage(string message = "") => TextBox_Logger.AppendText(message + Environment.NewLine);

        private void Button_OpenCDS_Click(object sender, EventArgs e)
        {
            Process pProcess = new Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a ";
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();

            LinkLabel_TargetURL.Enabled = false;
            TextBox_Logger.Clear();

            bool found = false;
            string targetURL = null;
            string cmdOutput = pProcess.StandardOutput.ReadToEnd();
            string pattern = @"(?<ip>([0-9]{1,3}\.?){4})\s*(?<mac>([a-f0-9]{2}-?){6})";

            foreach (Match m in Regex.Matches(cmdOutput, pattern, RegexOptions.IgnoreCase))
            {
                string MAC = m.Groups["mac"].Value.ToUpper();
                string IP = m.Groups["ip"].Value;

                addLogMessage("Analisando MAC: " + MAC);

                if (MAC == Properties.Settings.Default.MacAddress.ToUpper())
                {
                    addLogMessage("MÁQUINA ENCONTRADA!");

                    found = true;
                    targetURL = $"http://{IP}:8090/esus/";
                    LinkLabel_TargetURL.Text = targetURL;
                    LinkLabel_TargetURL.Enabled = true;
                    Process.Start(targetURL);
                    break;
                }
            }

            // MAC NOT FOUND ON LAN
            if (!found)
            {
                addLogMessage("Nenhum MAC correspondente.");
                MessageBox.Show("Máquina não encontrada na rede, verifique o MAC e se o computador destino está ligado e conectado na mesma rede.", "Finder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_SaveSetting_Click(object sender, EventArgs e)
        {
            
            string targetMacAddress = TextBox_MacAddress.Text.Trim().Replace(':', '-');

            if (String.IsNullOrEmpty(targetMacAddress))
            {
                MessageBox.Show("MAC vazio, impossível salvar.");
                return;
            }


            Properties.Settings.Default.MacAddress = targetMacAddress;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox_MacAddress.Text = Properties.Settings.Default.MacAddress;
        }

        private void LinkLabel_TargetURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            Process.Start(link.Text);
        }
    }
}
