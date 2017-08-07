using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using TThaoyueBF3Master;
using Newtonsoft.Json;
using System.IO;
using System.Drawing.Text;

namespace TThaoyueBF3
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        /// <summary>
        /// OK按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            Ram.UserName = UserNameTextBox.Text;
            Ram.PassWord = PassWordTextBox.Text;
            Master.SavePassWord();
            string JsonText = TTMaster.Login(UserNameTextBox.Text, PassWordTextBox.Text);
            string loginStatus = TTMaster.loginJson(JsonText);
            if (loginStatus == "ok")
            {
                Ram.serverStatus = TTMaster.ServerJson(JsonText);
                MetroMessageBox.Show(this, "恭喜你登录成功", "TT提示");
                Main main = new Main(this);
                main.ShowDialog();
            }
            else
            {
                MetroMessageBox.Show(this, "用户名或者账号错误", "TT提示");
            }

        }
        /// <summary>
        /// 窗口加载时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            Ram.UserName = Config.GetUserName("UserName");
            Ram.PassWord = Config.GetPassWord("PassWord");
            Ram.SavePassWord = Config.GetSavePassWord("SavePassWord");
            if (Ram.SavePassWord == "true")
            {
                UserNameTextBox.Text = Ram.UserName;
                PassWordTextBox.Text = Ram.PassWord;
                SavePassWord.Checked = true;
            }
        }
        /// <summary>
        /// 保存密码滑块发生变化的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePassWord_CheckedChanged(object sender, EventArgs e)
        {
            if (SavePassWord.Checked == true)
                Ram.SavePassWord = "true";
            else
                Ram.SavePassWord = "false";
        }
        /// <summary>
        /// By:TT被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ByTTtext_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ttitt.net");
            //System.Diagnostics.Process.Start("bf3Lan://LXdlYk1vZGUgTVAgLU9yaWdpbl9Ob0FwcEZvY3VzIC1vbmxpbmVFbnZpcm9ubWVudCBwcm9kIC1sb2dpblRva2VuIDAtMC0wLTAtMC0wIC1BdXRoVG9rZW4gMC0wLTAtMC0wLTAgLXJlcXVlc3RTdGF0ZSBTdGF0ZV9DbGFpbVJlc2VydmF0aW9uIC1yZXF1ZXN0U3RhdGVQYXJhbXMgIjxkYXRhIHB1dGluc3F1YWQ9XCJ0cnVlXCIgZ2FtZWlkPVwiMjk3M1wiIHBlcnNvbmFyZWY9XCIzMzg2NDg5NjA5NjE2MzMzXCIgbGV2ZWxtb2RlPVwibXBcIj48L2RhdGE+InwxMDEuMjAwLjE2NS4yNDh8");
        }
    }
}
