using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using TThaoyueBF3Master;
using System.Drawing.Text;

namespace TThaoyueBF3
{
    public partial class Main : MetroForm
    {
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
            setPlayerRank();
            ServerListF5();
            version.Text = Ram.version;
            //SetFont();
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
            Master.serverJoin(Ram.serverStatus["joinServer"]);
            Master.JoinServer(Ram.serverList, Ram.joinServer);
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
            Ram.joinServer.Clear();
            string jsonText = TTMaster.Login(Ram.UserName, Ram.PassWord);
            try
            {
                Ram.serverStatus = TTMaster.ServerJson(jsonText);
            }
            catch
            {
                MetroMessageBox.Show(this, "皓月服务器炸了，刷新不出来，请稍后再试", "温馨提示");
            }
            ServerListF5();
            加入服务器ToolStripMenuItem.Enabled = false;
        }
        /// <summary>
        /// 加入服务器按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 加入服务器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "你即将进入\r\n" + ServerList.Text, "进服提示");
            //string str = Ram.joinServer[ServerList.Text];
            System.Diagnostics.Process.Start("\"" + Ram.joinServer[ServerList.Text] + "\"");
        }
        /// <summary>
        /// 服务器列表被选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerList_Click(object sender, EventArgs e)
        {
            if (ServerList.Text != "")
                加入服务器ToolStripMenuItem.Enabled = true;
        }
        /// <summary>
        /// 双击服务器按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerList_DoubleClick(object sender, EventArgs e)
        {
            if (ServerList.Text != "")
            {
                ServerList_Click(sender, e);
                加入服务器ToolStripMenuItem_Click(sender, e);
            }
        }
        /// <summary>
        /// ByTT按钮被点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ByTTtext_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ttitt.net");
        }
        /// <summary>
        /// 设置玩家个人信息
        /// </summary>
        public void setPlayerRank()
        {
            id.Text = Ram.UserName;
            imageRank.Load(Ram.serverStatus["rank"]);
            kd.Text = Ram.serverStatus["kd"];
            skill.Text = Ram.serverStatus["skill"];
            spm.Text = Ram.serverStatus["spm"];
            kpm.Text = Ram.serverStatus["kpm"];
            gameTime.Text = Ram.serverStatus["gameTime"];
            MVPweapon.Text = Ram.serverStatus["MVPweapon"];
            headShots.Text = Ram.serverStatus["headShots"];
            killStreakBonus.Text = Ram.serverStatus["killStreakBonus"];
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
