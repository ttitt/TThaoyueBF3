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
        /// 登录判断
        /// </summary>
        /// <param name="LoginStatus">登录状态</param>
        /// <returns></returns>
        public static string Login(Dictionary<string, string> LoginStatus)
        {
            if (LoginStatus["status"] == "ok")
                return "ok";
            else
                return "ng";
        }
        /// <summary>
        /// 得到BF3服务器数量
        /// </summary>
        /// <param name="BF3ServerHtml">BF3ServerHtml</param>
        /// <returns></returns>
        public static int GetBF3ServerNum(string BF3ServerHtml)
        {
            int ServerCount = (BF3ServerHtml.Length - BF3ServerHtml.Replace("bf3Lan://", "").Length) / 9;
            return ServerCount;
        }
        /// <summary>
        /// 得到所有服务器名字
        /// </summary>
        /// <param name="BF3ServerHtml">BF3ServerHtml</param>
        /// <param name="ServerCount">服务器数量</param>
        /// <returns></returns>
        public static List<string> GetBF3ServerName(string BF3ServerHtml,int ServerCount)
        {
            int StrEnd;
            List<string> ServerName = new List<string>();
            for (int i = 0; i < ServerCount; i++)
            {
                StrEnd =  BF3ServerHtml.IndexOf("<font face=");
                BF3ServerHtml = BF3ServerHtml.Substring(StrEnd + 18);
                StrEnd = BF3ServerHtml.IndexOf("</font>");
                ServerName.Add(BF3ServerHtml.Substring(0, StrEnd));
                BF3ServerHtml = BF3ServerHtml.Substring(StrEnd + 18);
            }
            return ServerName;
        }
    }
}
