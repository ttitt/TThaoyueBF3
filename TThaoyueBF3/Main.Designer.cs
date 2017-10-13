namespace TThaoyueBF3
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ServerList = new System.Windows.Forms.ListBox();
            this.ServerListMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.加入服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新服务器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByTTtext = new MetroFramework.Controls.MetroLink();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.killStreakBonus = new MetroFramework.Controls.MetroLabel();
            this.headShots = new MetroFramework.Controls.MetroLabel();
            this.MVPweapon = new MetroFramework.Controls.MetroLabel();
            this.gameTime = new MetroFramework.Controls.MetroLabel();
            this.kpm = new MetroFramework.Controls.MetroLabel();
            this.spm = new MetroFramework.Controls.MetroLabel();
            this.kd = new MetroFramework.Controls.MetroLabel();
            this.skill = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.imageRank = new System.Windows.Forms.PictureBox();
            this.id = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.TTmouse = new MetroFramework.Components.MetroToolTip();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.version = new MetroFramework.Controls.MetroLabel();
            this.message = new MetroFramework.Controls.MetroLabel();
            this.Console = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ServerListMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageRank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.ContextMenuStrip = this.ServerListMenu;
            this.ServerList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerList.FormattingEnabled = true;
            this.ServerList.ItemHeight = 16;
            this.ServerList.Location = new System.Drawing.Point(58, 82);
            this.ServerList.Name = "ServerList";
            this.ServerList.Size = new System.Drawing.Size(586, 212);
            this.ServerList.TabIndex = 0;
            this.ServerList.Click += new System.EventHandler(this.ServerList_Click);
            this.ServerList.DoubleClick += new System.EventHandler(this.ServerList_DoubleClick);
            // 
            // ServerListMenu
            // 
            this.ServerListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加入服务器ToolStripMenuItem,
            this.刷新服务器ToolStripMenuItem});
            this.ServerListMenu.Name = "ServerListMenu";
            this.ServerListMenu.Size = new System.Drawing.Size(137, 48);
            // 
            // 加入服务器ToolStripMenuItem
            // 
            this.加入服务器ToolStripMenuItem.Enabled = false;
            this.加入服务器ToolStripMenuItem.Name = "加入服务器ToolStripMenuItem";
            this.加入服务器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.加入服务器ToolStripMenuItem.Text = "加入服务器";
            this.加入服务器ToolStripMenuItem.Click += new System.EventHandler(this.加入服务器ToolStripMenuItem_Click);
            // 
            // 刷新服务器ToolStripMenuItem
            // 
            this.刷新服务器ToolStripMenuItem.Name = "刷新服务器ToolStripMenuItem";
            this.刷新服务器ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新服务器ToolStripMenuItem.Text = "刷新服务器";
            this.刷新服务器ToolStripMenuItem.Click += new System.EventHandler(this.刷新服务器ToolStripMenuItem_Click);
            // 
            // ByTTtext
            // 
            this.ByTTtext.Location = new System.Drawing.Point(569, 459);
            this.ByTTtext.Name = "ByTTtext";
            this.ByTTtext.Size = new System.Drawing.Size(75, 23);
            this.ByTTtext.TabIndex = 1;
            this.ByTTtext.Text = "By：TT";
            this.TTmouse.SetToolTip(this.ByTTtext, "点击访问TT官网");
            this.ByTTtext.UseSelectable = true;
            this.ByTTtext.Click += new System.EventHandler(this.ByTTtext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.killStreakBonus);
            this.groupBox1.Controls.Add(this.headShots);
            this.groupBox1.Controls.Add(this.MVPweapon);
            this.groupBox1.Controls.Add(this.gameTime);
            this.groupBox1.Controls.Add(this.kpm);
            this.groupBox1.Controls.Add(this.spm);
            this.groupBox1.Controls.Add(this.kd);
            this.groupBox1.Controls.Add(this.skill);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.imageRank);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(58, 320);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // killStreakBonus
            // 
            this.killStreakBonus.AutoSize = true;
            this.killStreakBonus.Location = new System.Drawing.Point(524, 99);
            this.killStreakBonus.Name = "killStreakBonus";
            this.killStreakBonus.Size = new System.Drawing.Size(16, 19);
            this.killStreakBonus.TabIndex = 18;
            this.killStreakBonus.Text = "0";
            // 
            // headShots
            // 
            this.headShots.AutoSize = true;
            this.headShots.Location = new System.Drawing.Point(524, 60);
            this.headShots.Name = "headShots";
            this.headShots.Size = new System.Drawing.Size(16, 19);
            this.headShots.TabIndex = 17;
            this.headShots.Text = "0";
            // 
            // MVPweapon
            // 
            this.MVPweapon.AutoSize = true;
            this.MVPweapon.Location = new System.Drawing.Point(524, 21);
            this.MVPweapon.Name = "MVPweapon";
            this.MVPweapon.Size = new System.Drawing.Size(16, 19);
            this.MVPweapon.TabIndex = 16;
            this.MVPweapon.Text = "0";
            // 
            // gameTime
            // 
            this.gameTime.AutoSize = true;
            this.gameTime.Location = new System.Drawing.Point(345, 99);
            this.gameTime.Name = "gameTime";
            this.gameTime.Size = new System.Drawing.Size(16, 19);
            this.gameTime.TabIndex = 15;
            this.gameTime.Text = "0";
            // 
            // kpm
            // 
            this.kpm.AutoSize = true;
            this.kpm.Location = new System.Drawing.Point(345, 60);
            this.kpm.Name = "kpm";
            this.kpm.Size = new System.Drawing.Size(16, 19);
            this.kpm.TabIndex = 14;
            this.kpm.Text = "0";
            // 
            // spm
            // 
            this.spm.AutoSize = true;
            this.spm.Location = new System.Drawing.Point(345, 21);
            this.spm.Name = "spm";
            this.spm.Size = new System.Drawing.Size(16, 19);
            this.spm.TabIndex = 13;
            this.spm.Text = "0";
            // 
            // kd
            // 
            this.kd.AutoSize = true;
            this.kd.Location = new System.Drawing.Point(206, 82);
            this.kd.Name = "kd";
            this.kd.Size = new System.Drawing.Size(16, 19);
            this.kd.TabIndex = 12;
            this.kd.Text = "0";
            // 
            // skill
            // 
            this.skill.AutoSize = true;
            this.skill.Location = new System.Drawing.Point(206, 45);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(16, 19);
            this.skill.TabIndex = 11;
            this.skill.Text = "0";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(419, 99);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "最高连续击杀：";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(419, 60);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(107, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "最远爆头距离：";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(419, 21);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(107, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "最佳使用武器：";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(259, 99);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(93, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "总游戏时间：";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(259, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(93, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "每分钟杀敌：";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(259, 21);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "每分钟得分：";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(147, 82);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "击杀比：";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(147, 45);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "技巧值：";
            // 
            // imageRank
            // 
            this.imageRank.Location = new System.Drawing.Point(20, 43);
            this.imageRank.Name = "imageRank";
            this.imageRank.Size = new System.Drawing.Size(85, 84);
            this.imageRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageRank.TabIndex = 2;
            this.imageRank.TabStop = false;
            this.TTmouse.SetToolTip(this.imageRank, "你的等级");
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(46, 21);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(83, 19);
            this.id.TabIndex = 1;
            this.id.Text = "metroLabel2";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(58, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(107, 19);
            this.metroLabel10.TabIndex = 3;
            this.metroLabel10.Text = "当前服务器列表";
            this.TTmouse.SetToolTip(this.metroLabel10, "当前服务器列表");
            // 
            // TTmouse
            // 
            this.TTmouse.Style = MetroFramework.MetroColorStyle.Blue;
            this.TTmouse.StyleManager = null;
            this.TTmouse.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(32, 463);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(54, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Version:";
            this.TTmouse.SetToolTip(this.metroLabel11, "当前版本号");
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(80, 463);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(16, 19);
            this.version.TabIndex = 5;
            this.version.Text = "0";
            this.TTmouse.SetToolTip(this.version, "当前版本号");
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(192, 463);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(88, 19);
            this.message.TabIndex = 6;
            this.message.Text = "metroLabel12";
            this.TTmouse.SetToolTip(this.message, "TT公告");
            // 
            // Console
            // 
            // 
            // 
            // 
            this.Console.CustomButton.Image = null;
            this.Console.CustomButton.Location = new System.Drawing.Point(417, 1);
            this.Console.CustomButton.Name = "";
            this.Console.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Console.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Console.CustomButton.TabIndex = 1;
            this.Console.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Console.CustomButton.UseSelectable = true;
            this.Console.CustomButton.Visible = false;
            this.Console.DisplayIcon = true;
            this.Console.Icon = ((System.Drawing.Image)(resources.GetObject("Console.Icon")));
            this.Console.Lines = new string[0];
            this.Console.Location = new System.Drawing.Point(167, 299);
            this.Console.MaxLength = 32767;
            this.Console.Name = "Console";
            this.Console.PasswordChar = '\0';
            this.Console.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Console.SelectedText = "";
            this.Console.SelectionLength = 0;
            this.Console.SelectionStart = 0;
            this.Console.Size = new System.Drawing.Size(439, 23);
            this.Console.TabIndex = 19;
            this.TTmouse.SetToolTip(this.Console, "控制台");
            this.Console.UseSelectable = true;
            this.Console.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Console.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Console.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Console_KeyDown);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(78, 301);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(74, 19);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "TT Console";
            this.TTmouse.SetToolTip(this.metroLabel13, "TT 控制台");
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(133, 463);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 19);
            this.metroLabel12.TabIndex = 7;
            this.metroLabel12.Text = "TT公告:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 490);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.message);
            this.Controls.Add(this.version);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.ByTTtext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Text = "TT皓月BF3登录器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ServerListMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageRank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ServerList;
        private MetroFramework.Controls.MetroContextMenu ServerListMenu;
        private System.Windows.Forms.ToolStripMenuItem 加入服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新服务器ToolStripMenuItem;
        private MetroFramework.Controls.MetroLink ByTTtext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imageRank;
        private MetroFramework.Controls.MetroLabel id;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel killStreakBonus;
        private MetroFramework.Controls.MetroLabel headShots;
        private MetroFramework.Controls.MetroLabel MVPweapon;
        private MetroFramework.Controls.MetroLabel gameTime;
        private MetroFramework.Controls.MetroLabel kpm;
        private MetroFramework.Controls.MetroLabel spm;
        private MetroFramework.Controls.MetroLabel kd;
        private MetroFramework.Controls.MetroLabel skill;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Components.MetroToolTip TTmouse;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel version;
        private MetroFramework.Controls.MetroLabel message;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox Console;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}