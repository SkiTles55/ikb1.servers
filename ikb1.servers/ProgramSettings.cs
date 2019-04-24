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
        int foredit = -1;
        IPAddress foreditGrid = null;

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
            if (sAdd.Text == "Добавить")
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
            else if (sAdd.Text == "Изменить" && foredit != -1)
            {
                IPAddress ip;
                try
                {
                    ip = IPAddress.Parse(sIP.Text);
                    if (sIP.Text != String.Empty && sName.Text != String.Empty)
                    {
                        sListView.Rows[foredit].Cells[0].Value = sIP.Text;
                        sListView.Rows[foredit].Cells[1].Value = sName.Text;
                        if (Program.Servers.ContainsKey(ip))
                            Program.Servers[ip] = sName.Text;
                        else
                        {
                            Program.Servers.Add(ip, sName.Text);
                            if (foreditGrid != null) Program.Servers.Remove(foreditGrid);
                        }
                        foredit = -1;
                        foreditGrid = null;
                        sAdd.Text = "Добавить";
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка"); }
            }
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
                DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить {sListView.Rows[e.RowIndex].Cells[1].Value.ToString()}?", "Удаление", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var ip = sListView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    Program.Servers.Remove(IPAddress.Parse(ip));
                    sListView.Rows.RemoveAt(e.RowIndex);
                }                                   
            }
            if (senderGrid.Columns[e.ColumnIndex].Index == 2 && e.RowIndex >= 0)
            {
                sAdd.Text = "Изменить";
                sIP.Text = sListView.Rows[e.RowIndex].Cells[0].Value.ToString();
                sName.Text = sListView.Rows[e.RowIndex].Cells[1].Value.ToString();
                foredit = e.RowIndex;
                foreditGrid = IPAddress.Parse(sIP.Text);
            }
        }

        private void sIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.') && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void timerInt_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.tint = (int)timerInt.Value;
            Settings.Default.Save();
            Program.aTimer.Interval = Settings.Default.tint * 60000;
        }

        private void popupInt_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.pint = (int)popupInt.Value;
            Settings.Default.Save();
        }
    }
}
