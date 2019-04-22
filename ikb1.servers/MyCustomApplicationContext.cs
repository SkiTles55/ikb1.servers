using ikb1.servers;
using ikb1.servers.Properties;
using System;
using System.Windows.Forms;

public class MyCustomApplicationContext : ApplicationContext
{
    private NotifyIcon trayIcon;

    public MyCustomApplicationContext()
    {
        trayIcon = new NotifyIcon()
        {
            Icon = Resources.AppIcon,
            Text = "ikb1.servers",
            ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Настройки", EdSettings),
                new MenuItem("Выход", Exit)
            }),
            Visible = true
        };
    }

    void Exit(object sender, EventArgs e)
    {
        trayIcon.Visible = false;
        Application.Exit();
    }

    void EdSettings(object sender, EventArgs e)
    {
        ProgramSettings ps = new ProgramSettings();
        ps.Show();
    }

    public void ShowMessage(string text) => trayIcon.ShowBalloonTip(4000, "Информация", text, ToolTipIcon.Warning);
}
