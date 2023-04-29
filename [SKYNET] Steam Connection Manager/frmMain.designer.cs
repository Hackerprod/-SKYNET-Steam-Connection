﻿using SKYNET.Properties;

namespace SKYNET
{
    partial class frmMain
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
            this.PN_Top = new System.Windows.Forms.Panel();
            this.BT_Minimize = new SKYNET.Controls.SKYNET_Box();
            this.BT_Close = new SKYNET.Controls.SKYNET_Box();
            this.PN_Login = new System.Windows.Forms.Panel();
            this.PN_SteamGuard = new System.Windows.Forms.Panel();
            this.TB_SteamGuard = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Password = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Login = new SKYNET.GUI.Controls.SKYNET_Button();
            this.TB_Username = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PN_AccountContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_AddAccount = new SKYNET.GUI.Controls.SKYNET_Button();
            this.PN_Top.SuspendLayout();
            this.PN_Login.SuspendLayout();
            this.PN_SteamGuard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PN_Top
            // 
            this.PN_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.PN_Top.Controls.Add(this.BT_Minimize);
            this.PN_Top.Controls.Add(this.BT_Close);
            this.PN_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Top.Location = new System.Drawing.Point(0, 0);
            this.PN_Top.Name = "PN_Top";
            this.PN_Top.Size = new System.Drawing.Size(775, 31);
            this.PN_Top.TabIndex = 0;
            // 
            // BT_Minimize
            // 
            this.BT_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Minimize.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_Minimize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.BT_Minimize.Image = global::SKYNET.Properties.Resources.minimise;
            this.BT_Minimize.ImageSize = 10;
            this.BT_Minimize.Location = new System.Drawing.Point(707, 0);
            this.BT_Minimize.MenuMode = false;
            this.BT_Minimize.MenuSeparation = 8;
            this.BT_Minimize.Name = "BT_Minimize";
            this.BT_Minimize.Size = new System.Drawing.Size(34, 31);
            this.BT_Minimize.TabIndex = 1;
            this.BT_Minimize.BoxClicked += new System.EventHandler(this.BT_Minimize_BoxClicked);
            // 
            // BT_Close
            // 
            this.BT_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Close.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_Close.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.BT_Close.Image = global::SKYNET.Properties.Resources.close;
            this.BT_Close.ImageSize = 10;
            this.BT_Close.Location = new System.Drawing.Point(741, 0);
            this.BT_Close.MenuMode = false;
            this.BT_Close.MenuSeparation = 8;
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(34, 31);
            this.BT_Close.TabIndex = 0;
            this.BT_Close.BoxClicked += new System.EventHandler(this.BT_Close_BoxClicked);
            // 
            // PN_Login
            // 
            this.PN_Login.Controls.Add(this.PN_SteamGuard);
            this.PN_Login.Controls.Add(this.TB_Password);
            this.PN_Login.Controls.Add(this.pictureBox1);
            this.PN_Login.Controls.Add(this.label1);
            this.PN_Login.Controls.Add(this.BT_Login);
            this.PN_Login.Controls.Add(this.TB_Username);
            this.PN_Login.Controls.Add(this.label3);
            this.PN_Login.Controls.Add(this.label2);
            this.PN_Login.Location = new System.Drawing.Point(0, 31);
            this.PN_Login.Name = "PN_Login";
            this.PN_Login.Size = new System.Drawing.Size(23, 229);
            this.PN_Login.TabIndex = 12;
            // 
            // PN_SteamGuard
            // 
            this.PN_SteamGuard.Controls.Add(this.TB_SteamGuard);
            this.PN_SteamGuard.Controls.Add(this.label5);
            this.PN_SteamGuard.Location = new System.Drawing.Point(223, 414);
            this.PN_SteamGuard.Name = "PN_SteamGuard";
            this.PN_SteamGuard.Size = new System.Drawing.Size(372, 147);
            this.PN_SteamGuard.TabIndex = 13;
            this.PN_SteamGuard.Visible = false;
            // 
            // TB_SteamGuard
            // 
            this.TB_SteamGuard.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_SteamGuard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_SteamGuard.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_SteamGuard.ForeColor = System.Drawing.Color.White;
            this.TB_SteamGuard.IsPassword = false;
            this.TB_SteamGuard.Location = new System.Drawing.Point(22, 74);
            this.TB_SteamGuard.Logo = null;
            this.TB_SteamGuard.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_SteamGuard.Name = "TB_SteamGuard";
            this.TB_SteamGuard.OnlyNumbers = false;
            this.TB_SteamGuard.ShowLogo = false;
            this.TB_SteamGuard.Size = new System.Drawing.Size(309, 41);
            this.TB_SteamGuard.TabIndex = 11;
            this.TB_SteamGuard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(19, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "STEAM GUARD";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Password
            // 
            this.TB_Password.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.ForeColor = System.Drawing.Color.White;
            this.TB_Password.IsPassword = true;
            this.TB_Password.Location = new System.Drawing.Point(245, 266);
            this.TB_Password.Logo = null;
            this.TB_Password.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.OnlyNumbers = false;
            this.TB_Password.ShowLogo = false;
            this.TB_Password.Size = new System.Drawing.Size(309, 41);
            this.TB_Password.TabIndex = 5;
            this.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SKYNET.Properties.Resources.steam_home_vr;
            this.pictureBox1.Location = new System.Drawing.Point(235, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "STEAM";
            // 
            // BT_Login
            // 
            this.BT_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.BT_Login.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_Login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.ForeColor = System.Drawing.Color.White;
            this.BT_Login.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_Login.ImageAlignment = SKYNET.GUI.Controls.SKYNET_Button._ImgAlign.Left;
            this.BT_Login.ImageIcon = null;
            this.BT_Login.Location = new System.Drawing.Point(245, 332);
            this.BT_Login.MenuMode = false;
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Rounded = false;
            this.BT_Login.Size = new System.Drawing.Size(309, 50);
            this.BT_Login.Style = SKYNET.GUI.Controls.SKYNET_Button._Style.TextOnly;
            this.BT_Login.TabIndex = 8;
            this.BT_Login.Text = "Sign In";
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // TB_Username
            // 
            this.TB_Username.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.ForeColor = System.Drawing.Color.White;
            this.TB_Username.IsPassword = false;
            this.TB_Username.Location = new System.Drawing.Point(245, 190);
            this.TB_Username.Logo = null;
            this.TB_Username.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.OnlyNumbers = false;
            this.TB_Username.ShowLogo = false;
            this.TB_Username.Size = new System.Drawing.Size(309, 41);
            this.TB_Username.TabIndex = 4;
            this.TB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(242, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SIGN IN WITH ACCOUNT NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(242, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // PN_AccountContainer
            // 
            this.PN_AccountContainer.Location = new System.Drawing.Point(49, 80);
            this.PN_AccountContainer.Name = "PN_AccountContainer";
            this.PN_AccountContainer.Size = new System.Drawing.Size(674, 557);
            this.PN_AccountContainer.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(49, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 31);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(515, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "APPID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(337, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "TIME PLAYED (Hours)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(194, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "STEAM ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(35, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ACCOUNT NAME";
            // 
            // BT_AddAccount
            // 
            this.BT_AddAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
            this.BT_AddAccount.BackColorMouseOver = System.Drawing.Color.Empty;
            this.BT_AddAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BT_AddAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_AddAccount.ForeColor = System.Drawing.Color.White;
            this.BT_AddAccount.ForeColorMouseOver = System.Drawing.Color.Empty;
            this.BT_AddAccount.ImageAlignment = SKYNET.GUI.Controls.SKYNET_Button._ImgAlign.Left;
            this.BT_AddAccount.ImageIcon = null;
            this.BT_AddAccount.Location = new System.Drawing.Point(517, 648);
            this.BT_AddAccount.MenuMode = false;
            this.BT_AddAccount.Name = "BT_AddAccount";
            this.BT_AddAccount.Rounded = false;
            this.BT_AddAccount.Size = new System.Drawing.Size(206, 37);
            this.BT_AddAccount.Style = SKYNET.GUI.Controls.SKYNET_Button._Style.TextOnly;
            this.BT_AddAccount.TabIndex = 14;
            this.BT_AddAccount.Text = "Add Account";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(775, 709);
            this.Controls.Add(this.BT_AddAccount);
            this.Controls.Add(this.PN_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PN_AccountContainer);
            this.Controls.Add(this.PN_Top);
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.PN_Top.ResumeLayout(false);
            this.PN_Login.ResumeLayout(false);
            this.PN_Login.PerformLayout();
            this.PN_SteamGuard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Top;
        private Controls.SKYNET_Box BT_Close;
        private Controls.SKYNET_Box BT_Minimize;
        private System.Windows.Forms.Panel PN_Login;
        private GUI.Controls.SKYNET_TextBox TB_Password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private GUI.Controls.SKYNET_Button BT_Login;
        private GUI.Controls.SKYNET_TextBox TB_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private GUI.Controls.SKYNET_TextBox TB_SteamGuard;
        private System.Windows.Forms.Panel PN_SteamGuard;
        private System.Windows.Forms.Panel PN_AccountContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private GUI.Controls.SKYNET_Button BT_AddAccount;
    }
}