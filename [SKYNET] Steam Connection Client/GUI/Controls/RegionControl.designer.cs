using SKYNET.GUI.Controls;
using SKYNET.Properties;

namespace SKYNET
{
    partial class RegionControl
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
            this.label44 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_ZoneName = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LB_Ping = new System.Windows.Forms.Label();
            this.GB_Top = new SKYNET.Controls.GradiantBox();
            this.GB_Right = new SKYNET.Controls.GradiantBox();
            this.GB_Left = new SKYNET.Controls.GradiantBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label44.Font = new System.Drawing.Font("Calibri", 12F);
            this.label44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label44.Location = new System.Drawing.Point(54, 5);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(45, 19);
            this.label44.TabIndex = 0;
            this.label44.Text = "Ping: ";
            this.label44.Click += new System.EventHandler(this.PersonaName_Click);
            this.label44.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.label44.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LB_Ping);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label44);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 33);
            this.panel1.TabIndex = 9;
            this.panel1.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LB_ZoneName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 46);
            this.panel2.TabIndex = 10;
            this.panel2.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // LB_ZoneName
            // 
            this.LB_ZoneName.AutoSize = true;
            this.LB_ZoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ZoneName.ForeColor = System.Drawing.Color.Transparent;
            this.LB_ZoneName.Location = new System.Drawing.Point(8, 12);
            this.LB_ZoneName.Name = "LB_ZoneName";
            this.LB_ZoneName.Size = new System.Drawing.Size(76, 20);
            this.LB_ZoneName.TabIndex = 3;
            this.LB_ZoneName.Text = "US East";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(2, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(162, 2);
            this.panelTop.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.GB_Top);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 136);
            this.panel4.TabIndex = 11;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.GB_Left);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(2, 138);
            this.panelLeft.TabIndex = 54;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.GB_Right);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(164, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(2, 138);
            this.panelRight.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // LB_Ping
            // 
            this.LB_Ping.AutoSize = true;
            this.LB_Ping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_Ping.Font = new System.Drawing.Font("Calibri", 12F);
            this.LB_Ping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.LB_Ping.Location = new System.Drawing.Point(102, 6);
            this.LB_Ping.Name = "LB_Ping";
            this.LB_Ping.Size = new System.Drawing.Size(40, 19);
            this.LB_Ping.TabIndex = 3;
            this.LB_Ping.Text = "0 ms";
            // 
            // GB_Top
            // 
            this.GB_Top.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GB_Top.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.GB_Top.Location = new System.Drawing.Point(0, 105);
            this.GB_Top.Mode = SKYNET.Controls.Mode.Vertical;
            this.GB_Top.Name = "GB_Top";
            this.GB_Top.RigthColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(74)))), ((int)(((byte)(88)))));
            this.GB_Top.Size = new System.Drawing.Size(162, 31);
            this.GB_Top.TabIndex = 265;
            this.GB_Top.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.GB_Top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // GB_Right
            // 
            this.GB_Right.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_Right.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.GB_Right.Location = new System.Drawing.Point(0, 0);
            this.GB_Right.Mode = SKYNET.Controls.Mode.Vertical;
            this.GB_Right.Name = "GB_Right";
            this.GB_Right.RigthColor = System.Drawing.Color.Empty;
            this.GB_Right.Size = new System.Drawing.Size(2, 64);
            this.GB_Right.TabIndex = 57;
            this.GB_Right.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.GB_Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // GB_Left
            // 
            this.GB_Left.Dock = System.Windows.Forms.DockStyle.Top;
            this.GB_Left.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(187)))), ((int)(((byte)(106)))));
            this.GB_Left.Location = new System.Drawing.Point(0, 0);
            this.GB_Left.Mode = SKYNET.Controls.Mode.Vertical;
            this.GB_Left.Name = "GB_Left";
            this.GB_Left.RigthColor = System.Drawing.Color.Empty;
            this.GB_Left.Size = new System.Drawing.Size(2, 64);
            this.GB_Left.TabIndex = 56;
            this.GB_Left.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.GB_Left.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(102, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 267;
            this.label1.Text = "0 ms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(8, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 266;
            this.label2.Text = "Packet lost: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(102, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 269;
            this.label3.Text = "0 ms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(8, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 268;
            this.label4.Text = "Ping average:";
            // 
            // RegionControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MaximumSize = new System.Drawing.Size(166, 138);
            this.MinimumSize = new System.Drawing.Size(166, 138);
            this.Name = "RegionControl";
            this.Size = new System.Drawing.Size(166, 138);
            this.MouseLeave += new System.EventHandler(this.Controls_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Controls_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private Controls.GradiantBox GB_Left;
        private Controls.GradiantBox GB_Right;
        private Controls.GradiantBox GB_Top;
        private System.Windows.Forms.Label LB_ZoneName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LB_Ping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
