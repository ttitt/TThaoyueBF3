using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
