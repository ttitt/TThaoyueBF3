using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace TThaoyueBF3
{
    class Config
    {
        /// <summary>
        /// 读取账号
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetUserName(string key)
        {
            return ConfigurationManager.AppSettings.Get("UserName");
        }
        /// <summary>
        /// 读取密码
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetPassWord(string key)
        {
            return ConfigurationManager.AppSettings.Get("PassWord");
        }
        public static string GetSavePassWord(string key)
        {
            return ConfigurationManager.AppSettings.Get("SavePassWord");
        }
        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="key">要写入的键</param>
        /// <param name="value">要写入的值</param>
        public static void SetValue(string key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                config.AppSettings.Settings.Add(key, value);
            else
                config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
