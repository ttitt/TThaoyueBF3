using System.Collections.Generic;
using Newtonsoft.Json.Linq;

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
            string postdata = "username=" + UserName + "&password=" + PassWord;
            return HTTP.Post("http://www.ttitt.net/api/TThaoyueBF3.php", postdata);
            //return HTTP.Post("http://1.1.1.1/TThaoyueBF3.php", postdata);
        }
        /// <summary>
        /// 处理登录Json数据
        /// </summary>
        /// <param name="json">Json</param>
        /// <returns></returns>
        public static string loginJson(string json)
        {
            
            JObject jo = JObject.Parse(json);
            string loginStatus = jo["status"].ToString();
            //LoginStatus.Add("serverName", jo["serverName"].ToString());
            //LoginStatus.Add("playerCount", jo["playerCount"].ToString());
            return loginStatus;
        }
        /// <summary>
        /// 处理服务器Json数据
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Dictionary<string,string> ServerJson(string json)
        {
            JObject jo = JObject.Parse(json);
            Dictionary<string, string> serverStatus = new Dictionary<string, string>();
            serverStatus.Add("serverCount", jo["serverCount"].ToString());
            serverStatus.Add("serverName", jo["serverName"].ToString());
            serverStatus.Add("playerCount", jo["playerCount"].ToString());
            serverStatus.Add("joinServer", jo["joinServer"].ToString());
            serverStatus.Add("rank", jo["rank"].ToString());
            serverStatus.Add("skill", jo["skill"].ToString());
            serverStatus.Add("kd", jo["kd"].ToString());
            serverStatus.Add("spm", jo["spm"].ToString());
            serverStatus.Add("kpm", jo["kpm"].ToString());
            serverStatus.Add("gameTime", jo["gameTime"].ToString());
            serverStatus.Add("MVPweapon", jo["MVPweapon"].ToString());
            serverStatus.Add("headShots", jo["headShots"].ToString());
            serverStatus.Add("killStreakBonus", jo["killStreakBonus"].ToString());
            serverStatus.Add("message", jo["message"].ToString());
            return serverStatus;
        }
    }
}
