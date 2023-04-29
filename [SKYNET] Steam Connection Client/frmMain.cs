using dota2ping.GUI;
using SKYNET.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmMain : frmBase
    {
        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            SetMouseMove(PN_Top);

        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void BT_Close_BoxClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_Minimize_BoxClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
