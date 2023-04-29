namespace SKYNET.GUI.Controls
{
    partial class AccountControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.PN_Indicator = new System.Windows.Forms.Panel();
            this.LB_AppID = new System.Windows.Forms.Label();
            this.LB_Time = new System.Windows.Forms.Label();
            this.LB_AccountName = new System.Windows.Forms.Label();
            this.BP_Remove = new System.Windows.Forms.PictureBox();
            this.LB_SteamID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BP_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.LB_SteamID);
            this.panel1.Controls.Add(this.PN_Indicator);
            this.panel1.Controls.Add(this.LB_AppID);
            this.panel1.Controls.Add(this.LB_Time);
            this.panel1.Controls.Add(this.LB_AccountName);
            this.panel1.Controls.Add(this.BP_Remove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 32);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // PN_Indicator
            // 
            this.PN_Indicator.BackColor = System.Drawing.Color.OrangeRed;
            this.PN_Indicator.Dock = System.Windows.Forms.DockStyle.Left;
            this.PN_Indicator.Location = new System.Drawing.Point(0, 0);
            this.PN_Indicator.Name = "PN_Indicator";
            this.PN_Indicator.Size = new System.Drawing.Size(10, 32);
            this.PN_Indicator.TabIndex = 12;
            this.PN_Indicator.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.PN_Indicator.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // LB_AppID
            // 
            this.LB_AppID.AutoSize = true;
            this.LB_AppID.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppID.ForeColor = System.Drawing.Color.LightGray;
            this.LB_AppID.Location = new System.Drawing.Point(521, 8);
            this.LB_AppID.Name = "LB_AppID";
            this.LB_AppID.Size = new System.Drawing.Size(15, 17);
            this.LB_AppID.TabIndex = 11;
            this.LB_AppID.Text = "0";
            this.LB_AppID.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.LB_AppID.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // LB_Time
            // 
            this.LB_Time.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Time.ForeColor = System.Drawing.Color.LightGray;
            this.LB_Time.Location = new System.Drawing.Point(337, 8);
            this.LB_Time.Name = "LB_Time";
            this.LB_Time.Size = new System.Drawing.Size(138, 17);
            this.LB_Time.TabIndex = 9;
            this.LB_Time.Text = "0";
            this.LB_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Time.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.LB_Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // LB_AccountName
            // 
            this.LB_AccountName.AutoSize = true;
            this.LB_AccountName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AccountName.ForeColor = System.Drawing.Color.LightGray;
            this.LB_AccountName.Location = new System.Drawing.Point(34, 8);
            this.LB_AccountName.Name = "LB_AccountName";
            this.LB_AccountName.Size = new System.Drawing.Size(23, 17);
            this.LB_AccountName.TabIndex = 7;
            this.LB_AccountName.Text = "---";
            this.LB_AccountName.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.LB_AccountName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // BP_Remove
            // 
            this.BP_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BP_Remove.Image = global::SKYNET.Properties.Resources.remove;
            this.BP_Remove.Location = new System.Drawing.Point(606, 6);
            this.BP_Remove.Name = "BP_Remove";
            this.BP_Remove.Size = new System.Drawing.Size(22, 22);
            this.BP_Remove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BP_Remove.TabIndex = 0;
            this.BP_Remove.TabStop = false;
            this.BP_Remove.Click += new System.EventHandler(this.BP_Remove_Click);
            this.BP_Remove.MouseLeave += new System.EventHandler(this.Control_MouseLeave);
            this.BP_Remove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Control_MouseMove);
            // 
            // LB_SteamID
            // 
            this.LB_SteamID.AutoSize = true;
            this.LB_SteamID.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_SteamID.ForeColor = System.Drawing.Color.LightGray;
            this.LB_SteamID.Location = new System.Drawing.Point(191, 8);
            this.LB_SteamID.Name = "LB_SteamID";
            this.LB_SteamID.Size = new System.Drawing.Size(23, 17);
            this.LB_SteamID.TabIndex = 13;
            this.LB_SteamID.Text = "---";
            // 
            // AccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel1);
            this.Name = "AccountControl";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(650, 36);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BP_Remove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BP_Remove;
        private System.Windows.Forms.Label LB_AccountName;
        private System.Windows.Forms.Label LB_Time;
        private System.Windows.Forms.Label LB_AppID;
        private System.Windows.Forms.Panel PN_Indicator;
        private System.Windows.Forms.Label LB_SteamID;
    }
}
