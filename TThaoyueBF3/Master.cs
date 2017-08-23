using System;
using System.Collections.Generic;
using MetroFramework;

namespace TThaoyueBF3
{
    class Master
    {
        /// <summary>
        /// 保存账号和密码
        /// </summary>
        public static void SavePassWord()
        {
            if (Ram.SavePassWord == "true")
            {
                Config.SetValue("UserName", Ram.UserName);
                Config.SetValue("PassWord", Ram.PassWord);
                Config.SetValue("SavePassWord", Ram.SavePassWord);
            }
            else
            {
                Config.SetValue("UserName", null);
                Config.SetValue("PassWord", null);
                Config.SetValue("SavePassWord", Ram.SavePassWord);
            }
        }
        /// <summary>
        /// 服务器名字处理
        /// </summary>
        /// <param name="serverName">要处理的服务器名字</param>
        public static void serverName(string serverName)
        {
            for (int i = 0; i < Convert.ToInt32(Ram.serverStatus["serverCount"]); i++)
            {
                int strend = serverName.IndexOf('"');
                serverName = serverName.Substring(strend + 1);
                strend = serverName.IndexOf('"');
                Ram.serverName.Add(serverName.Substring(0, strend));
                serverName = serverName.Substring(strend + 1);
            }
        }
        /// <summary>
        /// 服务器在线玩家处理
        /// </summary>
        /// <param name="serverPlayerCount">要处理的服务器玩家</param>
        public static void serverPlayerCount(string serverPlayerCount)
        {
            for (int i = 0; i < Convert.ToInt32(Ram.serverStatus["serverCount"]); i++)
            {
                int strend = serverPlayerCount.IndexOf('"');
                serverPlayerCount = serverPlayerCount.Substring(strend + 1);
                strend = serverPlayerCount.IndexOf('"');
                Ram.serverPlayerCount.Add(serverPlayerCount.Substring(0, strend));
                serverPlayerCount = serverPlayerCount.Substring(strend + 1);
            }
        }
        /// <summary>
        /// 加入服务器代码处理
        /// </summary>
        /// <param name="serverJoin">要处理的加入服务器</param>
        public static void serverJoin(string serverJoin)
        {
            serverJoin = serverJoin.Replace("\r\n", "");
            serverJoin = serverJoin.Replace("\"", "");
            serverJoin = serverJoin.Replace("[", "");
            serverJoin = serverJoin.Replace("]", "");
            serverJoin = serverJoin.Replace(" ", "");
            //serverJoin = serverJoin.Substring(2);
            for (int i = 0; i < Convert.ToInt32(Ram.serverStatus["serverCount"]) - 1; i++)
            {
                int strend = serverJoin.IndexOf(",");
                Ram.serverJoin.Add(serverJoin.Substring(0, strend));
                serverJoin = serverJoin.Substring(strend + 1);
            }
            Ram.serverJoin.Add(serverJoin);
        }
        /// <summary>
        /// 双剑合并
        /// </summary>
        /// <param name="one">第一把剑</param>
        /// <param name="two">第二把剑</param>
        public static void merge(List<string> one, List<string> two)
        {
            string str;
            for (int i = 0; i < one.Count; i++)
            {
                str = one[i] + two[i];
                Ram.serverList.Add(str);
            }
        }
        /// <summary>
        /// 最终结果
        /// </summary>
        /// <param name="serverList">服务器列表</param>
        /// <param name="joinServer">进服代码</param>
        public static void JoinServer(List<string> serverList, Dictionary<string, string> joinServer)
        {
            for (int i = 0; i < serverList.Count; i++)
            {
                if (joinServer.ContainsKey(serverList[i]))
                    joinServer.Add(serverList[i] + " ", Ram.serverJoin[i]);
                else
                    joinServer.Add(serverList[i], Ram.serverJoin[i]);
            }
        }
        /// <summary>
        /// 控制台命令处理函数
        /// </summary>
        /// <param name="Console">输入的控制台命令</param>
        /// <param name="main">主窗口</param>
        /// <param name="form">登录窗口</param>
        public static void ConsoleCommand(string Console, Main main)
        {
            switch (Console)
            {
                case "color red":
                    main.Style = MetroColorStyle.Red;
                    FormF5(main);
                    Config.SetValue("Theme", "red");
                    MetroMessageBox.Show(main, "已经为你更改配色为红色", "Console");
                    break;
                case "color blue":
                    main.Style = MetroColorStyle.Blue;
                    FormF5(main);
                    Config.SetValue("Theme", "blue");
                    MetroMessageBox.Show(main, "已经为你更改配色为蓝色", "Console");
                    break;
                case "color green":
                    main.Style = MetroColorStyle.Green;
                    FormF5(main);
                    Config.SetValue("Theme", "green");
                    MetroMessageBox.Show(main, "已经为你更改配色为原谅色", "Console");
                    break;
                case "color orange":
                    main.Style = MetroColorStyle.Orange;
                    FormF5(main);
                    Config.SetValue("Theme", "orange");
                    MetroMessageBox.Show(main, "已经为你更改配色为橙色", "Console");
                    break;
                case "color pink":
                    main.Style = MetroColorStyle.Pink;
                    FormF5(main);
                    Config.SetValue("Theme", "pink");
                    MetroMessageBox.Show(main, "已经为你更改配色为粉红色", "Console");
                    break;
                case "color black":
                    main.Style = MetroColorStyle.Black;
                    FormF5(main);
                    Config.SetValue("Theme", "black");
                    MetroMessageBox.Show(main, "已经为你更改配色为黑色", "Console");
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "关于":
                    MetroMessageBox.Show(main, "这是目前为止最好的BF3盗版私服的登录器，我们在没有任何数据，并且在辣鸡皓月各种封杀的情况下，做出来的登录器都秒杀他官方的。", "TT提示");
                    break;
                default:
                    if (Console.Contains("TT") && Console.Contains("SB"))
                    {
                        MetroMessageBox.Show(main, "你SB，你全家都是SB，没想到吧？", "TT提示");
                    }
                    else if (Console.Contains("SB"))
                    {
                        MetroMessageBox.Show(main, "骂的好，鼓掌", "TT提示");
                    }
                    break;
            }
        }
        /// <summary>
        /// 奇葩的窗体刷新功能
        /// </summary>
        /// <param name="main">Main</param>
        private static void FormF5(Main main)
        {
            main.Enabled = false;
            main.Enabled = true;
        }
        /// <summary>
        /// 奇葩的窗体刷新功能
        /// </summary>
        /// <param name="form1">Form1</param>
        private static void FormF5(Form1 form1)
        {
            form1.Enabled = false;
            form1.Enabled = true;
        }
        /// <summary>
        /// 设置Form1主题函数
        /// </summary>
        /// <param name="fm"></param>
        public static void SetForm1Theme(Form1 fm)
        {
            fm.Style = FormStyle();
        }
        /// <summary>
        /// 设置Main主题函数
        /// </summary>
        /// <param name="main"></param>
        public static void SetMainTheme(Main main)
        {
            main.Style = FormStyle();
        }
        /// <summary>
        /// 设置风格
        /// </summary>
        /// <returns></returns>
        public static MetroColorStyle FormStyle()
        {
            switch (Ram.Theme)
            {
                case "blue":
                    return MetroColorStyle.Blue;
                case "red":
                    return MetroColorStyle.Red;
                case "green":
                    return MetroColorStyle.Green;
                case "orange":
                    return MetroColorStyle.Orange;
                case "pink":
                    return MetroColorStyle.Pink;
                case "black":
                    return MetroColorStyle.Black;
                default:
                    return MetroColorStyle.Blue;
            }
        }
    }
}
