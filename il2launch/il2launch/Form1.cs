using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Diagnostics;


namespace il2launch
{
    public partial class Form1 : Form
    {
        string keyTR = "dir_tr";
        string keyTRproc = "proc_tr";
        string m_dirtr;
        string m_proctr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitConfig();

            bool res = true;
            res &= StartDir(m_dirtr);

            if (res)
            {
                timer1.Start();
            }
            else
            {
                MessageBox.Show("some error");
            }
        }

        private void InitConfig()
        {
            // for TrackIR
            m_dirtr = GetConfig(keyTR);
            m_proctr = GetConfig(keyTRproc);
        }

        private string GetConfig(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string res = appSettings[key] ?? "";
                if (res == "")
                {
                    MessageBox.Show("First Setting " + key);
                }
                return res;
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
                return "";
            }
        }

        private void SetConfig(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool res = CheckProc(m_proctr);
            if (!res)
            {
                Retry("no tr");
            }
        }

        private void Retry(string msg)
        {
            timer1.Stop();

            DialogResult dr = MessageBox.Show(msg, "press cancel to exit", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.Cancel)
            {
                Close();
            }

            timer1.Start();
        }

        private bool StartDir(string dirname)
        {
            Process.Start(dirname);
            return true;
        }

        private bool CheckProc(string procname)
        {
            if (procname == "")
                return false;

            Process[] list = Process.GetProcessesByName(procname);
            if (list.Length > 0)
                return true;

            return false;
        }

        private void buttonTR_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                m_dirtr = openFileDialog1.FileName;
                m_proctr = openFileDialog1.SafeFileName.Split('.')[0];
                SetConfig(keyTR, m_dirtr);
                SetConfig(keyTRproc, m_proctr);
            }
        }
    }
}
