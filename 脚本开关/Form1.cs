using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace 脚本开关
{
    public partial class MainPanel : Form
    {
        ConfigurePanel cp = new ConfigurePanel();
        public ArrayList al;

        ToolStripMenuItem exit, configure, reload; ToolStripSeparator line;//默认菜单项

        public MainPanel()
        {
            InitializeComponent();
            Reloadmenu();
        }

        private void MainPanel_VisibleChanged(object sender, EventArgs e)
        {

            this.notifyIcon_Main.Visible = true;
            this.Hide();
            notifyIcon_Main.ShowBalloonTip(3000, "脚本开关", "“咔哒！”\n开关已上油，确保灵活！", ToolTipIcon.Info);
        }

        private void notifyIcon_Main_Click(object sender, EventArgs e)
        {
            //EventArgs继承自MouseEventArgs,所以可以强转  
            MouseEventArgs Mouse_e = (MouseEventArgs)e;

            //点鼠标左键 
            if (Mouse_e.Button == MouseButtons.Left)
            {
                cp.Show(this);
                cp.WindowState = FormWindowState.Normal;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("是否要真的退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (Directory.Exists(@".\cache") == true)//如果不存在就创建文件夹
                {
                    Directory.Delete((".\\cache"), true);//删除文件夹以及文件夹中的子目录，文件
                }
                Application.Exit();
            }
        }

        private void ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cp.Show(this);
            cp.WindowState = FormWindowState.Normal;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            //这里是坑爹的玩意呀！！！！！你妹的.NET！！！！！竟然不执行Load事件！！！！！我勒个去！！！！！！我勒个擦！！！！！！
        }

        public void Reloadmenu()
        {//重新载入菜单
            exit = ExitToolStripMenuItem; configure = ConfigToolStripMenuItem; reload = ReloadToolStripMenuItem; line = toolStripSeparator2;//保存默认菜单项
            menu.Items.Clear();
            menu.Items.Add(exit); menu.Items.Add(configure); menu.Items.Add(reload); menu.Items.Add(line);//恢复默认菜单项
            al = XmlIO.list_plugins();
            foreach (Plugin plugin in al)
            {
                menu.Items.Add(new ToolStripMenuItem(plugin.name, null, CmdToolStripMenuItem_Click));
            }
        }

        private void CmdToolStripMenuItem_Click(object sender, EventArgs e)
        {//菜单项公共单击事件
            foreach (Plugin pl in al)
            {
                if (sender.ToString() == pl.name)
                {
                    if (Directory.Exists(@".\cache") == false)//如果不存在就创建文件夹
                    {
                        Directory.CreateDirectory(@".\cache");
                    }
                    FileStream file = File.Open(@".\cache\" + pl.name + ".cmd", FileMode.Create);
                    StreamWriter writer = new StreamWriter(file, Encoding.Default);
                    writer.Write(pl.cmd.Trim());
                    writer.Flush();
                    file.Flush();
                    file.Close();

                    if (pl.showwindow)
                    {
                        CMDIO.sendcmd(@"start cache\" + pl.name + ".cmd & exit");
                    }
                    else 
                    {
                        CMDIO.sendcmd(@"cache\" + pl.name + ".cmd & exit");
                    }
                    return;
                }
            }
        }

        private void ReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reloadmenu();
        }
    }
}
