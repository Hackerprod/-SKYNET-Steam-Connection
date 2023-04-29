using SKYNET.Properties;

namespace SKYNET
{
    partial class frmLogin
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
            this.BT_Close = new SKYNET.Controls.SKYNET_Box();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Username = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.TB_Password = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Login = new SKYNET.GUI.Controls.SKYNET_Button();
            this.CB_RememberMe = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PN_Login = new System.Windows.Forms.Panel();
            this.PN_SteamGuard = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_AccountName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.skyneT_TextBox3 = new SKYNET.GUI.Controls.SKYNET_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PN_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PN_Login.SuspendLayout();
            this.PN_SteamGuard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PN_Top
            // 
            this.PN_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.PN_Top.Controls.Add(this.BT_Close);
            this.PN_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.PN_Top.Location = new System.Drawing.Point(0, 0);
            this.PN_Top.Name = "PN_Top";
            this.PN_Top.Size = new System.Drawing.Size(470, 31);
            this.PN_Top.TabIndex = 0;
            // 
            // BT_Close
            // 
            this.BT_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Close.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.BT_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.BT_Close.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.BT_Close.Image = global::SKYNET.Properties.Resources.close;
            this.BT_Close.ImageSize = 10;
            this.BT_Close.Location = new System.Drawing.Point(436, 0);
            this.BT_Close.MenuMode = false;
            this.BT_Close.MenuSeparation = 8;
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(34, 31);
            this.BT_Close.TabIndex = 0;
            this.BT_Close.BoxClicked += new System.EventHandler(this.BT_Close_BoxClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SKYNET.Properties.Resources.steam_home_vr;
            this.pictureBox1.Location = new System.Drawing.Point(36, 1);
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
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "STEAM";
            // 
            // TB_Username
            // 
            this.TB_Username.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Username.ForeColor = System.Drawing.Color.White;
            this.TB_Username.IsPassword = false;
            this.TB_Username.Location = new System.Drawing.Point(46, 91);
            this.TB_Username.Logo = null;
            this.TB_Username.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.OnlyNumbers = false;
            this.TB_Username.ShowLogo = false;
            this.TB_Username.Size = new System.Drawing.Size(379, 41);
            this.TB_Username.TabIndex = 4;
            this.TB_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TB_Password
            // 
            this.TB_Password.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.TB_Password.ForeColor = System.Drawing.Color.White;
            this.TB_Password.IsPassword = true;
            this.TB_Password.Location = new System.Drawing.Point(46, 167);
            this.TB_Password.Logo = null;
            this.TB_Password.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.OnlyNumbers = false;
            this.TB_Password.ShowLogo = false;
            this.TB_Password.Size = new System.Drawing.Size(379, 41);
            this.TB_Password.TabIndex = 5;
            this.TB_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(43, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(43, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "SIGN IN WITH ACCOUNT NAME";
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
            this.BT_Login.Location = new System.Drawing.Point(117, 257);
            this.BT_Login.MenuMode = false;
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Rounded = false;
            this.BT_Login.Size = new System.Drawing.Size(231, 50);
            this.BT_Login.Style = SKYNET.GUI.Controls.SKYNET_Button._Style.TextOnly;
            this.BT_Login.TabIndex = 8;
            this.BT_Login.Text = "Sign In";
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // CB_RememberMe
            // 
            this.CB_RememberMe.AutoSize = true;
            this.CB_RememberMe.Location = new System.Drawing.Point(46, 224);
            this.CB_RememberMe.Name = "CB_RememberMe";
            this.CB_RememberMe.Size = new System.Drawing.Size(15, 14);
            this.CB_RememberMe.TabIndex = 9;
            this.CB_RememberMe.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(66, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remember me";
            // 
            // PN_Login
            // 
            this.PN_Login.Controls.Add(this.TB_Password);
            this.PN_Login.Controls.Add(this.label4);
            this.PN_Login.Controls.Add(this.pictureBox1);
            this.PN_Login.Controls.Add(this.CB_RememberMe);
            this.PN_Login.Controls.Add(this.label1);
            this.PN_Login.Controls.Add(this.BT_Login);
            this.PN_Login.Controls.Add(this.TB_Username);
            this.PN_Login.Controls.Add(this.label3);
            this.PN_Login.Controls.Add(this.label2);
            this.PN_Login.Location = new System.Drawing.Point(2, 34);
            this.PN_Login.Name = "PN_Login";
            this.PN_Login.Size = new System.Drawing.Size(467, 340);
            this.PN_Login.TabIndex = 11;
            // 
            // PN_SteamGuard
            // 
            this.PN_SteamGuard.Controls.Add(this.label8);
            this.PN_SteamGuard.Controls.Add(this.LB_AccountName);
            this.PN_SteamGuard.Controls.Add(this.label7);
            this.PN_SteamGuard.Controls.Add(this.skyneT_TextBox3);
            this.PN_SteamGuard.Controls.Add(this.label6);
            this.PN_SteamGuard.Controls.Add(this.pictureBox2);
            this.PN_SteamGuard.Controls.Add(this.label5);
            this.PN_SteamGuard.Dock = System.Windows.Forms.DockStyle.Left;
            this.PN_SteamGuard.Location = new System.Drawing.Point(0, 31);
            this.PN_SteamGuard.Name = "PN_SteamGuard";
            this.PN_SteamGuard.Size = new System.Drawing.Size(78, 344);
            this.PN_SteamGuard.TabIndex = 12;
            this.PN_SteamGuard.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(94, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Enter your Steam Mobile app code";
            // 
            // LB_AccountName
            // 
            this.LB_AccountName.AutoSize = true;
            this.LB_AccountName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AccountName.ForeColor = System.Drawing.Color.Silver;
            this.LB_AccountName.Location = new System.Drawing.Point(223, 149);
            this.LB_AccountName.Name = "LB_AccountName";
            this.LB_AccountName.Size = new System.Drawing.Size(23, 17);
            this.LB_AccountName.TabIndex = 10;
            this.LB_AccountName.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(157, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Account:";
            // 
            // skyneT_TextBox3
            // 
            this.skyneT_TextBox3.ActivatedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.skyneT_TextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.skyneT_TextBox3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(68)))));
            this.skyneT_TextBox3.ForeColor = System.Drawing.Color.White;
            this.skyneT_TextBox3.IsPassword = false;
            this.skyneT_TextBox3.Location = new System.Drawing.Point(75, 181);
            this.skyneT_TextBox3.Logo = null;
            this.skyneT_TextBox3.LogoCursor = System.Windows.Forms.Cursors.Default;
            this.skyneT_TextBox3.Name = "skyneT_TextBox3";
            this.skyneT_TextBox3.OnlyNumbers = true;
            this.skyneT_TextBox3.ShowLogo = false;
            this.skyneT_TextBox3.Size = new System.Drawing.Size(313, 56);
            this.skyneT_TextBox3.TabIndex = 8;
            this.skyneT_TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(126, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "STEAM GUARD";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SKYNET.Properties.Resources.steam_home_vr;
            this.pictureBox2.Location = new System.Drawing.Point(148, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(208, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "STEAM";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(470, 375);
            this.Controls.Add(this.PN_SteamGuard);
            this.Controls.Add(this.PN_Login);
            this.Controls.Add(this.PN_Top);
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.PN_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PN_Login.ResumeLayout(false);
            this.PN_Login.PerformLayout();
            this.PN_SteamGuard.ResumeLayout(false);
            this.PN_SteamGuard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PN_Top;
        private Controls.SKYNET_Box BT_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private GUI.Controls.SKYNET_TextBox TB_Username;
        private GUI.Controls.SKYNET_TextBox TB_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GUI.Controls.SKYNET_Button BT_Login;
        private System.Windows.Forms.CheckBox CB_RememberMe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel PN_Login;
        private System.Windows.Forms.Panel PN_SteamGuard;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_AccountName;
        private System.Windows.Forms.Label label7;
        private GUI.Controls.SKYNET_TextBox skyneT_TextBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}