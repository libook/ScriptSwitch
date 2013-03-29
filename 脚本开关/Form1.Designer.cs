using System.Windows.Forms;
using System;

namespace 脚本开关
{
    partial class MainPanel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.menu;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "脚本开关";
            this.notifyIcon_Main.Visible = true;
            this.notifyIcon_Main.Click += new System.EventHandler(this.notifyIcon_Main_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.ConfigToolStripMenuItem,
            this.ReloadToolStripMenuItem,
            this.toolStripSeparator2});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(153, 98);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Tag = "系统";
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ConfigToolStripMenuItem
            // 
            this.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem";
            this.ConfigToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ConfigToolStripMenuItem.Tag = "系统";
            this.ConfigToolStripMenuItem.Text = "配置";
            this.ConfigToolStripMenuItem.Click += new System.EventHandler(this.ConfigToolStripMenuItem_Click);
            // 
            // ReloadToolStripMenuItem
            // 
            this.ReloadToolStripMenuItem.Name = "ReloadToolStripMenuItem";
            this.ReloadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ReloadToolStripMenuItem.Tag = "系统";
            this.ReloadToolStripMenuItem.Text = "重新载入";
            this.ReloadToolStripMenuItem.Click += new System.EventHandler(this.ReloadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            this.toolStripSeparator2.Tag = "系统";
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(128, 23);
            this.ControlBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPanel";
            this.Opacity = 0D;
            this.ShowInTaskbar = false;
            this.Text = "主面板";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MainPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.MainPanel_VisibleChanged);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon_Main;
        private ContextMenuStrip menu;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem ConfigToolStripMenuItem;
        private ToolStripMenuItem ReloadToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
    }
}

