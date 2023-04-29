using dota2ping.GUI;
using SKYNET.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmLogin : frmBase
    {
        public frmLogin()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            SetMouseMove(PN_Top);

        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            SteamManager.Initialize();
            SteamManager.OnLoginSuccess += SteamManager_OnLoginSuccess;
            SteamManager.OnSteamGuardRequest += SteamManager_OnSteamGuardRequest; 
        }

        private void SteamManager_OnSteamGuardRequest(object sender, int e)
        {
            PN_SteamGuard.Visible = true;
        }

        private void SteamManager_OnLoginSuccess(object sender, int e)
        {
            Visible = false;
            new frmMain().ShowDialog();
        }

        private void BT_Close_BoxClicked(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void BT_Minimize_BoxClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Username.Text) && string.IsNullOrEmpty(TB_Password.Text))
            {
                return;
            }

            SteamManager.Login(TB_Username.Text, TB_Password.Text);
        }

    }
}
