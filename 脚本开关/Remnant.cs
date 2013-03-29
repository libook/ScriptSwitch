using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace 脚本开关
{
    static class Remnant
    {
        private static ArrayList rp = new ArrayList();
        public static void add(Process p)
        {
            rp.Add(p);
        }
        public static void killall()
        {
            Process[] ap = new Process[rp.Count];
            rp.CopyTo(ap);
            for (int i = 0; i < ap.Length;i++ )
            {
                if (!ap[i].HasExited)
                {
                    ap[i].Kill();
                }
            }
            rp.Clear();
        }
        public static int number()
        {
            Process[] ap = new Process[rp.Count];
            rp.CopyTo(ap);
            for (int i = 0; i < ap.Length; i++)
            {
                if (ap[i].HasExited)
                {
                    rp.Remove(ap[i]);
                }
                else
                {
                    if (ap[i].ProcessName != "cmd")
                    {
                        rp.Remove(ap[i]);
                    }
                }
            }
            return rp.Count;
        }
    }
}
