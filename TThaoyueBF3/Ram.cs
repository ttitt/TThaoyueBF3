using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;

namespace TThaoyueBF3
{
    public static class Ram
    {
        /// <summary>
        /// 用户账号
        /// </summary>
        public static string UserName;
        /// <summary>
        /// 用户密码
        /// </summary>
        public static string PassWord;
        /// <summary>
        /// 是否保存密码状态
        /// </summary>
        public static string SavePassWord;
        /// <summary>
        /// 服务器状态
        /// </summary>
        public static Dictionary<string, string> serverStatus;
        /// <summary>
        /// 服务器名字
        /// </summary>
        public static List<string> serverName = new List<string>();
        /// <summary>
        /// 服务器当前玩家数量
        /// </summary>
        public static List<string> serverPlayerCount = new List<string>();
        /// <summary>
        /// 服务器列表
        /// </summary>
        public static List<string> serverList = new List<string>();
        /// <summary>
        /// 字体
        /// </summary>
        public static Font font;
    }
}
