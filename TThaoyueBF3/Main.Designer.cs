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
            this.ServerListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerList
            // 
            this.ServerList.ContextMenuStrip = this.ServerListMenu;
            this.ServerList.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerList.FormattingEnabled = true;
            this.ServerList.ItemHeight = 16;
            this.ServerList.Location = new System.Drawing.Point(58, 72);
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
            this.ByTTtext.Location = new System.Drawing.Point(569, 291);
            this.ByTTtext.Name = "ByTTtext";
            this.ByTTtext.Size = new System.Drawing.Size(75, 23);
            this.ByTTtext.TabIndex = 1;
            this.ByTTtext.Text = "By：TT";
            this.ByTTtext.UseSelectable = true;
            this.ByTTtext.Click += new System.EventHandler(this.ByTTtext_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 325);
            this.Controls.Add(this.ServerList);
            this.Controls.Add(this.ByTTtext);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Resizable = false;
            this.Text = "TT皓月BF3登录器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ServerListMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ServerList;
        private MetroFramework.Controls.MetroContextMenu ServerListMenu;
        private System.Windows.Forms.ToolStripMenuItem 加入服务器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新服务器ToolStripMenuItem;
        private MetroFramework.Controls.MetroLink ByTTtext;
    }
}