using System;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml;
using System.Collections;

namespace 脚本开关
{
    class XmlIO
    {
        private static string filepath = @".\\config.xml";

        public static void new_plugin(string pluginname, string plugincmd,bool showwindow)
        {//新建插件
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlNode root = xmlDoc.SelectSingleNode("Plugins");//查找<Plugins>

            //检测重复
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("Plugins").ChildNodes;//获取Plugins节点的所有子节点
            foreach (XmlNode xn in nodeList)//遍历所有子节点
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                if (xe.GetAttribute("name") == pluginname)//如果name属性值为pluginname
                {
                    throw (new Exception(pluginname+"已存在！"));
                    return;
                }
            }

            XmlElement xe1 = xmlDoc.CreateElement("plugin");//创建一个<plugin>节点
            xe1.SetAttribute("name", pluginname);//设置该节点name属性
            xe1.SetAttribute("showwindow", showwindow.ToString());//设置该节点showwindow属性
            XmlElement xesub1 = xmlDoc.CreateElement("cmd");
            xesub1.InnerText = plugincmd;//设置文本节点<cmd>
            xe1.AppendChild(xesub1);//添加到<plugin>节点中
            root.AppendChild(xe1);//添加到<Plugins>节点中
            xmlDoc.Save(filepath);
        }

        public static void change_plugin(string pluginname, string newname, string cmd, bool showwindow)
        {//修改所有属性值
            change_plugin(pluginname, "name", newname);
            change_plugin(newname, "showwindow", showwindow.ToString());
            change_plugin(newname, cmd);
        }

        public static void change_plugin(string pluginname, string property, string newvalue)
        {//修改插件属性
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("Plugins").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("name") == pluginname)
                {
                    if (property == "name")
                    {
                        //检测重复
                        XmlNodeList nodeList = xmlDoc.SelectSingleNode("Plugins").ChildNodes;//获取Plugins节点的所有子节点
                        int temptimes=0;
                        foreach (XmlNode xn2 in nodeList)//遍历所有子节点
                        {
                            XmlElement xe2 = (XmlElement)xn2;//将子节点类型转换为XmlElement类型
                            if (xe2.GetAttribute("name") == pluginname)//如果name属性值为pluginname
                            {
                                temptimes++;
                                if (temptimes > 1)
                                {
                                    throw (new Exception(pluginname + "已存在！"));
                                    return;
                                }
                            }
                        }
                    }
                    xe.SetAttribute(property,newvalue);
                    break;
                }
            }

            xmlDoc.Save(filepath);
        }

        public static void change_plugin(string pluginname, string newcmd)
        {//修改插件文本节点<cmd>
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("Plugins").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("name") == pluginname)
                {
                    xe.SelectSingleNode("cmd").InnerText=newcmd;
                    break;
                }
            }

            xmlDoc.Save(filepath);
        }

        public static void delete_plugin(string pluginname)
        {//删除插件
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);

            XmlNodeList xnl = xmlDoc.SelectSingleNode("Plugins").ChildNodes;
            foreach (XmlNode xn in xnl)
            {
                XmlElement xe = (XmlElement)xn;
                if (xe.GetAttribute("name") == pluginname)
                {
                    xmlDoc.SelectSingleNode("Plugins").RemoveChild(xn);//删除节点
                    break;
                }
            }

            xmlDoc.Save(filepath);
        }

        public static ArrayList list_plugins()
        {//读取文件列出所有内容
            ArrayList al = new ArrayList();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filepath);
            XmlNode xn = xmlDoc.SelectSingleNode("Plugins");
            XmlNodeList xnl = xn.ChildNodes;

            foreach (XmlNode xnf in xnl)
            {
                XmlElement xe = (XmlElement)xnf;
                al.Add(new Plugin(xe.GetAttribute("name"), xe.SelectSingleNode("cmd").InnerText, Convert.ToBoolean(xe.GetAttribute("showwindow"))));//将此插件的所有信息放入al中
            }
            return al;
        }
    }
}
