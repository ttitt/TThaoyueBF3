﻿namespace TThaoyueBF3
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PassWordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.CancelButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.OKButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SavePassWord = new MetroFramework.Controls.MetroToggle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ByTTtext = new MetroFramework.Controls.MetroLink();
            this.TTmouse = new MetroFramework.Components.MetroToolTip();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.VersionText = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // UserNameTextBox
            // 
            // 
            // 
            // 
            this.UserNameTextBox.CustomButton.Image = null;
            this.UserNameTextBox.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.UserNameTextBox.CustomButton.Name = "";
            this.UserNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.UserNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.UserNameTextBox.CustomButton.TabIndex = 1;
            this.UserNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.UserNameTextBox.CustomButton.UseSelectable = true;
            this.UserNameTextBox.CustomButton.Visible = false;
            this.UserNameTextBox.DisplayIcon = true;
            this.UserNameTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("UserNameTextBox.Icon")));
            this.UserNameTextBox.Lines = new string[0];
            this.UserNameTextBox.Location = new System.Drawing.Point(88, 92);
            this.UserNameTextBox.MaxLength = 32767;
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.PasswordChar = '\0';
            this.UserNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserNameTextBox.SelectedText = "";
            this.UserNameTextBox.SelectionLength = 0;
            this.UserNameTextBox.SelectionStart = 0;
            this.UserNameTextBox.Size = new System.Drawing.Size(124, 23);
            this.UserNameTextBox.TabIndex = 0;
            this.TTmouse.SetToolTip(this.UserNameTextBox, "在这里输入账号");
            this.UserNameTextBox.UseSelectable = true;
            this.UserNameTextBox.WaterMark = "UserName";
            this.UserNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PassWordTextBox
            // 
            // 
            // 
            // 
            this.PassWordTextBox.CustomButton.Image = null;
            this.PassWordTextBox.CustomButton.Location = new System.Drawing.Point(102, 1);
            this.PassWordTextBox.CustomButton.Name = "";
            this.PassWordTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PassWordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PassWordTextBox.CustomButton.TabIndex = 1;
            this.PassWordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PassWordTextBox.CustomButton.UseSelectable = true;
            this.PassWordTextBox.CustomButton.Visible = false;
            this.PassWordTextBox.DisplayIcon = true;
            this.PassWordTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("PassWordTextBox.Icon")));
            this.PassWordTextBox.Lines = new string[0];
            this.PassWordTextBox.Location = new System.Drawing.Point(88, 150);
            this.PassWordTextBox.MaxLength = 32767;
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.PasswordChar = '●';
            this.PassWordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PassWordTextBox.SelectedText = "";
            this.PassWordTextBox.SelectionLength = 0;
            this.PassWordTextBox.SelectionStart = 0;
            this.PassWordTextBox.Size = new System.Drawing.Size(124, 23);
            this.PassWordTextBox.TabIndex = 1;
            this.TTmouse.SetToolTip(this.PassWordTextBox, "在这里输入密码");
            this.PassWordTextBox.UseSelectable = true;
            this.PassWordTextBox.WaterMark = "PassWord";
            this.PassWordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PassWordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.PassWordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PassWordTextBox_KeyDown);
            // 
            // CancelButton
            // 
            this.CancelButton.Image = null;
            this.CancelButton.Location = new System.Drawing.Point(87, 221);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(53, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.TTmouse.SetToolTip(this.CancelButton, "退出");
            this.CancelButton.UseSelectable = true;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Image = null;
            this.OKButton.Location = new System.Drawing.Point(159, 221);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(53, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.TTmouse.SetToolTip(this.OKButton, "登录");
            this.OKButton.UseSelectable = true;
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // SavePassWord
            // 
            this.SavePassWord.AutoSize = true;
            this.SavePassWord.DisplayStatus = false;
            this.SavePassWord.Location = new System.Drawing.Point(146, 192);
            this.SavePassWord.Name = "SavePassWord";
            this.SavePassWord.Size = new System.Drawing.Size(50, 16);
            this.SavePassWord.TabIndex = 4;
            this.SavePassWord.Text = "Off";
            this.TTmouse.SetToolTip(this.SavePassWord, "是否保存密码");
            this.SavePassWord.UseSelectable = true;
            this.SavePassWord.CheckedChanged += new System.EventHandler(this.SavePassWord_CheckedChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(104, 190);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Save";
            // 
            // ByTTtext
            // 
            this.ByTTtext.Location = new System.Drawing.Point(220, 259);
            this.ByTTtext.Name = "ByTTtext";
            this.ByTTtext.Size = new System.Drawing.Size(57, 20);
            this.ByTTtext.TabIndex = 6;
            this.ByTTtext.Text = "By：TT";
            this.TTmouse.SetToolTip(this.ByTTtext, "访问TT官网");
            this.ByTTtext.UseSelectable = true;
            this.ByTTtext.Click += new System.EventHandler(this.ByTTtext_Click);
            // 
            // TTmouse
            // 
            this.TTmouse.Style = MetroFramework.MetroColorStyle.Blue;
            this.TTmouse.StyleManager = null;
            this.TTmouse.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(26, 260);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 19);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Version:";
            this.TTmouse.SetToolTip(this.metroLabel2, "当前版本号");
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Location = new System.Drawing.Point(75, 260);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(42, 19);
            this.VersionText.TabIndex = 9;
            this.VersionText.Text = "labal1";
            this.TTmouse.SetToolTip(this.VersionText, "当前版本号");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 286);
            this.ControlBox = false;
            this.Controls.Add(this.VersionText);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.ByTTtext);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.SavePassWord);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.Resizable = false;
            this.Text = "TT皓月BF3登录器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox UserNameTextBox;
        private MetroFramework.Controls.MetroTextBox PassWordTextBox;
#pragma warning disable CS0108 // “Form1.CancelButton”隐藏继承的成员“Form.CancelButton”。如果是有意隐藏，请使用关键字 new。
        private MetroFramework.Controls.MetroTextBox.MetroTextButton CancelButton;
#pragma warning restore CS0108 // “Form1.CancelButton”隐藏继承的成员“Form.CancelButton”。如果是有意隐藏，请使用关键字 new。
        private MetroFramework.Controls.MetroTextBox.MetroTextButton OKButton;
        private MetroFramework.Controls.MetroToggle SavePassWord;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink ByTTtext;
        private MetroFramework.Components.MetroToolTip TTmouse;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel VersionText;
    }
}

