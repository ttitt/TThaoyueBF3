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
using System.Threading;
using TThaoyueBF3Master;
using System.Drawing.Text;

namespace TThaoyueBF3
{
    public partial class Main : MetroForm
    {
        bool tab = false;
        public Main(Form fm)
        {
            InitializeComponent();
            fm.Visible = false;
        }
        /// <summary>
        /// 用户关闭窗口后发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// 窗口加载时发生的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            //Thread th = new Thread(KA);
            //th.IsBackground = true;
            //th.Start();
            ServerListF5();
            SetFont();
        }
        /// <summary>
        /// 设置字体
        /// </summary>
        private void SetFont()
        {
            //路径             
            string path = "TThaoyueBF3Font.ttf";
            //读取字体文件             
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(path);
            //实例化字体             
            Font f = new Font(pfc.Families[0], 14, FontStyle.Bold);
            //设置字体            
            ServerList.Font = f;
            ServerListMenu.Font = f;
        }
        /// <summary>
        /// 服务器列表刷新
        /// </summary>
        private void ServerListF5()
        {
            Master.serverName(Ram.serverStatus["serverName"]);
            Master.serverPlayerCount(Ram.serverStatus["playerCount"]);
            Master.merge(Ram.serverName, Ram.serverPlayerCount);
            foreach (var item in Ram.serverList)
            {
                ServerList.Items.Add(item);
            }
        }
        /// <summary>
        /// 刷新服务器按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 刷新服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServerList.Items.Clear();
            Ram.serverList.Clear();
            Ram.serverName.Clear();
            Ram.serverPlayerCount.Clear();
            string jsonText = TTMaster.Login(Ram.UserName, Ram.PassWord);
            Ram.serverStatus = TTMaster.ServerJson(jsonText);
            ServerListF5();
        }
        /// <summary>
        /// 加入服务器按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 加入服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (tab)
        }
        /// <summary>
        /// 服务器列表被选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerList_Click(object sender, EventArgs e)
        {
            tab = true;
        }

        /// <summary>
        /// 心跳
        /// </summary>
        //private void KA()
        //{
        //    while (true)
        //    {
        //        string jsonText = TTMaster.Login(Ram.UserName, Ram.PassWord);
        //        Ram.serverStatus = TTMaster.ServerJson(jsonText);
        //        ServerListF5();
        //        Thread.Sleep(3000);
        //    }            
        //}
    }
}
