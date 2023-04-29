using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SKYNET.Properties;
using System.Net;

namespace SKYNET
{
    public partial class RegionControl : UserControl
    {
        private string zoneName;

        [Category("SKYNET")]
        public int QualityID { get; set; }

        [Category("SKYNET")]
        public string ZoneName
        {
            get { return zoneName; }
            set {
                zoneName = value;
                LB_ZoneName.Text = value;
            }
        }
        
        public RegionControl()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void PersonaName_Click(object sender, EventArgs e)
        {
        }

        private void Controls_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.FromArgb(53, 64, 78);
            GB_Top.LeftColor = Color.FromArgb(53, 64, 78);
            GB_Left.Height = Height;
            GB_Right.Height = Height;
        }

        private void Controls_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(43, 54, 68);
            GB_Top.LeftColor = Color.FromArgb(43, 54, 68);
            GB_Left.Height = 125;
            GB_Right.Height = 125;
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
