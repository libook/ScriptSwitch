namespace 脚本开关
{
    partial class ConfigurePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurePanel));
            this.NameList = new System.Windows.Forms.ListBox();
            this.cmdtext = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.restorebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.newbutton = new System.Windows.Forms.Button();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxshowwindow = new System.Windows.Forms.CheckBox();
            this.remnantbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NameList
            // 
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 12;
            this.NameList.Location = new System.Drawing.Point(12, 12);
            this.NameList.Name = "NameList";
            this.NameList.ScrollAlwaysVisible = true;
            this.NameList.Size = new System.Drawing.Size(120, 532);
            this.NameList.Sorted = true;
            this.NameList.TabIndex = 0;
            this.NameList.SelectedValueChanged += new System.EventHandler(this.NameList_SelectedValueChanged);
            // 
            // cmdtext
            // 
            this.cmdtext.Location = new System.Drawing.Point(138, 93);
            this.cmdtext.Multiline = true;
            this.cmdtext.Name = "cmdtext";
            this.cmdtext.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.cmdtext.Size = new System.Drawing.Size(634, 451);
            this.cmdtext.TabIndex = 1;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(697, 12);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 75);
            this.savebutton.TabIndex = 2;
            this.savebutton.Text = "保存";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // restorebutton
            // 
            this.restorebutton.Location = new System.Drawing.Point(616, 12);
            this.restorebutton.Name = "restorebutton";
            this.restorebutton.Size = new System.Drawing.Size(75, 75);
            this.restorebutton.TabIndex = 3;
            this.restorebutton.Text = "恢复";
            this.restorebutton.UseVisualStyleBackColor = true;
            this.restorebutton.Click += new System.EventHandler(this.restorebutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(535, 12);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 75);
            this.deletebutton.TabIndex = 4;
            this.deletebutton.Text = "删除";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // newbutton
            // 
            this.newbutton.Location = new System.Drawing.Point(454, 12);
            this.newbutton.Name = "newbutton";
            this.newbutton.Size = new System.Drawing.Size(75, 75);
            this.newbutton.TabIndex = 5;
            this.newbutton.Text = "添加";
            this.newbutton.UseVisualStyleBackColor = true;
            this.newbutton.Click += new System.EventHandler(this.newbutton_Click);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(185, 66);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(102, 21);
            this.nametextBox.TabIndex = 6;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "名称：";
            // 
            // checkBoxshowwindow
            // 
            this.checkBoxshowwindow.AutoSize = true;
            this.checkBoxshowwindow.Location = new System.Drawing.Point(293, 69);
            this.checkBoxshowwindow.Name = "checkBoxshowwindow";
            this.checkBoxshowwindow.Size = new System.Drawing.Size(72, 16);
            this.checkBoxshowwindow.TabIndex = 9;
            this.checkBoxshowwindow.Text = "显示窗口";
            this.checkBoxshowwindow.UseVisualStyleBackColor = true;
            // 
            // remnantbutton
            // 
            this.remnantbutton.Enabled = false;
            this.remnantbutton.Location = new System.Drawing.Point(138, 12);
            this.remnantbutton.Name = "remnantbutton";
            this.remnantbutton.Size = new System.Drawing.Size(305, 48);
            this.remnantbutton.TabIndex = 10;
            this.remnantbutton.Text = "查找残余进程中。。。";
            this.remnantbutton.UseVisualStyleBackColor = true;
            this.remnantbutton.Click += new System.EventHandler(this.remnantbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "书中叶";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timerR
            // 
            this.timerR.Interval = 500;
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // ConfigurePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.remnantbutton);
            this.Controls.Add(this.checkBoxshowwindow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.newbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.restorebutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.cmdtext);
            this.Controls.Add(this.NameList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConfigurePanel";
            this.Text = "脚本开关-配置";
            this.Load += new System.EventHandler(this.ConfigurePanel_Load);
            this.ClientSizeChanged += new System.EventHandler(this.ConfigurePanel_ClientSizeChanged);
            this.VisibleChanged += new System.EventHandler(this.ConfigurePanel_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.TextBox cmdtext;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button restorebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button newbutton;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxshowwindow;
        private System.Windows.Forms.Button remnantbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerR;
    }
}