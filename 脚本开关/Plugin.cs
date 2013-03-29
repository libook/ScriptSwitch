using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 脚本开关
{
    public class Plugin
    {
        public string name;
        public string cmd;
        public bool showwindow;
        public Plugin(string _name, string _cmd, bool _showwindow)
        {
            name = _name;
            cmd = _cmd;
            showwindow = _showwindow;
        }
    }
}
