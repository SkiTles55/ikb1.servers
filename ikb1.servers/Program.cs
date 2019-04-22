using ikb1.servers.Properties;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ikb1.servers
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        ///        

        public static Dictionary<IPAddress, string> Servers { get; set; }
        static System.Timers.Timer aTimer;
        public static MyCustomApplicationContext icon;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Servers = new Dictionary<IPAddress, string>();
            var set = JsonConvert.DeserializeObject<Dictionary<string, string>>(Settings.Default.serversList);
            if (set != null)
            {
                foreach (var s in set)
                    if (!Servers.ContainsKey(IPAddress.Parse(s.Key))) Servers.Add(IPAddress.Parse(s.Key), s.Value);
            }
            icon = new MyCustomApplicationContext();
            aTimer = new System.Timers.Timer(40000);
            aTimer.Elapsed += CheckServers;
            aTimer.Interval = 40000;
            aTimer.Enabled = true;
            Application.Run(icon);
        }

        static void CheckServers(object sender, System.Timers.ElapsedEventArgs e)
        {
            string output = String.Empty;
            foreach (var pc in Servers)
            {
                Ping p1 = new Ping();
                PingReply PR = p1.Send(pc.Key);
                if (PR.Status != IPStatus.Success)
                {
                    if (output != String.Empty) output += Environment.NewLine;
                    output += "Сервер " + pc.Value + " (" + pc.Key.ToString() + ") недоступен";
                }
            }
            if (output != String.Empty) icon.ShowMessage(output);
        }
    }
}
