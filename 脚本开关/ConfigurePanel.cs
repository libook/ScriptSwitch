using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;

namespace 脚本开关
{
    public partial class ConfigurePanel : Form
    {
        MainPanel father;
        ArrayList al;
        int shit = 0;//记录visible属性变化了几次   SHIT！！！C#太不靠谱了！！！

        public ConfigurePanel()
        {
            InitializeComponent();
        }

        #region 关闭确认
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(     //调用消息发送消息的window API函数
            int hwnd,                                       //接受消息的窗体句柄
            int wMsg,                                       //消息内容
            int wParam,                                   //消息的附加信息
             int lParam                                     //消息的附加值
        );

        protected override void WndProc(ref Message m)          //重写消息泵
        {
            const int WM_CLOSE = 0x010;    //关闭窗体的消息值
            //const int WM_DESTROY = 0x002;  //销毁窗体的消息值
            switch (m.Msg)
            {
                case WM_CLOSE:                             //截获关闭窗体的消息
                    DialogResult r = MessageBox.Show("是否要真的退出", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else
                    { return; }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

        private void ConfigurePanel_ClientSizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                father.Reloadmenu();
            }
            Refresh();
        }

        private void ConfigurePanel_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        public void Show(MainPanel sender)
        {
            father = sender;
            this.Visible = true;
        }

        private void Refresh()
        {//刷新所有数据
            father.Reloadmenu();
            this.al = father.al;
            NameList.Items.Clear();
            foreach (Plugin pl in al)
            {
                NameList.Items.Add(pl.name);
            }
            if (nametextBox.Text != "")
            {
                NameList.SelectedItem = nametextBox.Text;
            }
        }

        private void NameList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (NameList.SelectedItem == null)
            {
                return;
            }
            foreach (Plugin pl in al)
            {
                if (pl.name == NameList.SelectedItem.ToString())
                {
                    this.cmdtext.Text = pl.cmd.Trim();
                    this.nametextBox.Text = pl.name;
                    this.checkBoxshowwindow.Checked = pl.showwindow;
                    break;
                }
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要保存？此操作不可撤销！", "保存", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                XmlIO.change_plugin(NameList.SelectedItem.ToString(), nametextBox.Text, "\r\n" + cmdtext.Text + "\r\n", checkBoxshowwindow.Checked);
                Refresh();
            }
        }

        private void restorebutton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要恢复到修改之前？", "恢复", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                foreach (Plugin pl in al)
                {
                    if (pl.name == NameList.SelectedItem.ToString())
                    {
                        this.cmdtext.Text = pl.cmd.Trim();
                        this.nametextBox.Text = pl.name;
                        this.checkBoxshowwindow.Checked = pl.showwindow;
                        break;
                    }
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("确定要删除？", "删除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                XmlIO.delete_plugin(nametextBox.Text);
                Refresh();
                nametextBox.Text = "";
                cmdtext.Text = "";
            }
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            string newsname = "新建项" + new Random().Next().ToString();
            bool badluck = true;
            while (badluck)
            {
                badluck = false;
                newsname = "新建项" + new Random().Next().ToString();
                try
                {
                    XmlIO.new_plugin(newsname, "", true);
                }
                catch (Exception)
                {
                    badluck = true;
                }
            }
            Refresh();
            NameList.SelectedIndex = NameList.Items.IndexOf(newsname);
            nametextBox.Focus();
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {
            if (NameList.SelectedItem == null)
            {
                deletebutton.Enabled = false;
                savebutton.Enabled = false;
                restorebutton.Enabled = false;
            }
            else
            {
                if (nametextBox.Text == "")
                {
                    savebutton.Enabled = false;
                }
                else
                {
                    deletebutton.Enabled = true;
                    savebutton.Enabled = true;
                    restorebutton.Enabled = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {//标签点击小程序
            if (this.label2.Text == "书中叶")
            { this.label2.Text = "QQ:125198688"; }
            else
            { this.label2.Text = "书中叶"; }
        }

        private void remnantbutton_Click(object sender, EventArgs e)
        {//结束残余进程
            DialogResult r = MessageBox.Show("确定要关闭全部亲？此操作会结束所有已知的残余进程。\n注意：在脚本中执行程序要使用start哦！否则可能会在清理残余进程的时候一起被清理掉", "关闭所有残余进程", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                Remnant.killall();
                Refresh();
            }
        }

        private void timerR_Tick(object sender, EventArgs e)
        {//每一秒检查一次残余进程
            if (Remnant.number() > 0)
            {
                remnantbutton.Enabled = true;
                remnantbutton.Text = Remnant.number().ToString() + "个残余进程，单击此处全部关闭";
            }
            else
            {
                remnantbutton.Enabled = false;
                remnantbutton.Text = "没有残余进程";
            }
        }

        private void ConfigurePanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                timerR.Start();
            }
            else
            {
                timerR.Stop();
                remnantbutton.Enabled = false;
                remnantbutton.Text = "查找残余进程中。。。";
            }
        }
    }
}
