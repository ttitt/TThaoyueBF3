using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft;

namespace TThaoyueBF3Master
{
    public class TTMaster
    {
        /// <summary>
        /// 登录函数
        /// </summary>
        /// <param name="UserName">账号</param>
        /// <param name="PassWord">密码</param>
        public static string Login(string UserName, string PassWord)
        {
            string postdata = "username=" + UserName + "&password=" + PassWord + "&act=login&remember-me=remember-me";
            //username=ttitt&password=2312462&act=login&remember-me=remember-me
            return HTTP.Post("http://bf3.axibug.com/ajax.php", postdata, "http://bf3.axibug.com/index.php");
        }
        /// <summary>
        /// 处理登录Json数据
        /// </summary>
        /// <param name="json">Json</param>
        /// <returns></returns>
        public static Dictionary<string, string> Json(string json)
        {
            Newtonsoft.Json.Linq.JObject jobject = Newtonsoft.Json.Linq.JObject.Parse(json);
            Dictionary<string, string> LoginStatus = new Dictionary<string, string>();
            LoginStatus.Add("status", jobject["status"].ToString());
            LoginStatus.Add("code", jobject["code"].ToString());
            LoginStatus.Add("message", jobject["message"].ToString());
            return LoginStatus;
        }
        /// <summary>
        /// 获取在线服务器
        /// </summary>
        /// <param name="url">获取在线服务器地址</param>
        /// <returns></returns>
        public static string GetBF3Server(string url)
        {
            return HTTP.Get(url);
        }
    }
}
