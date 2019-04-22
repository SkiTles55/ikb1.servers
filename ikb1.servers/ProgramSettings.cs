using ikb1.servers.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace ikb1.servers
{
    public partial class ProgramSettings : Form
    {
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public ProgramSettings()
        {
            InitializeComponent();
            Icon = Resources.AppIcon;
            if (rkApp.GetValue("ikb1.servers") == null)
                AutoStartCheckBox.Checked = false;
            else
                AutoStartCheckBox.Checked = true;            
            foreach (var s in Program.Servers)
                sListView.Rows.Add(s.Key, s.Value);
        }

        private void AutoStartCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AutoStart = AutoStartCheckBox.Checked;
            Settings.Default.Save();
            if (AutoStartCheckBox.Checked)
                rkApp.SetValue("ikb1.servers", Application.ExecutablePath);
            else
                rkApp.DeleteValue("ikb1.servers", false);
        }

        private void sAdd_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            try
            {
                ip = IPAddress.Parse(sIP.Text);
                if (sIP.Text != String.Empty && sName.Text != String.Empty && !Program.Servers.ContainsKey(ip))
                {
                    Program.Servers.Add(ip, sName.Text);
                    sListView.Rows.Add(sIP.Text, sName.Text);
                    sIP.Text = String.Empty;
                    sName.Text = String.Empty;
                }
                else
                {
                    MessageBox.Show("Такой IP адрес уже добавлен!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }            
        }

        private void ProgramSettings_Deactivate(object sender, EventArgs e)
        {
            Settings.Default.serversList = JsonConvert.SerializeObject(Program.Servers);
            Settings.Default.Save();
        }

        private void sListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Index == 3 && e.RowIndex >= 0)
            {
                var ip = sListView.Rows[e.RowIndex].Cells[0].Value.ToString();
                Program.Servers.Remove(IPAddress.Parse(ip));
                sListView.Rows.RemoveAt(e.RowIndex);               
            }
            if (senderGrid.Columns[e.ColumnIndex].Index == 2 && e.RowIndex >= 0)
            {

            }
        }

        private void sIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.') && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
    }
}
