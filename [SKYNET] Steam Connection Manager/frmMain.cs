using dota2ping.GUI;
using SKYNET.GUI;
using SKYNET.GUI.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace SKYNET
{
    public partial class frmMain : frmBase
    {
        public List<AccountDetail> AccountDetails;

        public frmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            SetMouseMove(PN_Top);

            AccountDetails = new List<AccountDetail>();

            //TB_Username.Text = "GD2_10";
            //TB_Password.Text = "Loops890415*";
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            if (File.Exists(Path.Combine(Common.GetPath(), "AccountDetails.json")))
            {
                try
                {
                    string json = File.ReadAllText(Path.Combine(Common.GetPath(), "AccountDetails.json"));
                    AccountDetails = new JavaScriptSerializer().Deserialize<List<AccountDetail>> (json);
                }
                catch 
                {
                    AccountDetails = new List<AccountDetail>();
                }
            }

            if (AccountDetails.Any())
            {
                foreach (var account in AccountDetails)
                {
                    var control = new AccountControl(account.AccountName, account.Password, 570);
                    control.OnRemoveAccount += Control_OnRemoveAccount;
                    control.Dock = DockStyle.Top;
                    Common.InvokeAddControl(PN_AccountContainer, control);
                }
            }
        }

        private void BT_Close_BoxClicked(object sender, EventArgs e)
        {
            var filePath = Path.Combine(Common.GetPath(), "AccountDetails.json");
            try
            {
                string json = new JavaScriptSerializer().Serialize(AccountDetails);
                File.WriteAllText(filePath, json);
            }
            catch
            {
            }

            Process.GetCurrentProcess().Kill();
        }

        private void BT_Minimize_BoxClicked(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Username.Text) || string.IsNullOrEmpty(TB_Password.Text))
            {
                return;
            }

            var exists = AccountDetails.Find(a => a.AccountName == TB_Username.Text);
            if (exists != null)
            {
                return;
            }

            var control = new AccountControl(TB_Username.Text, TB_Password.Text, 570);
            control.OnRemoveAccount += Control_OnRemoveAccount;
            control.Dock = DockStyle.Top;
            Common.InvokeAddControl(PN_AccountContainer, control);

            AccountDetails.Add(new AccountDetail()
            {
                AccountName = TB_Username.Text,
                Password = TB_Password.Text,
                AppID = 570,
            });

            TB_Username.Text = "";
            TB_Password.Text = "";
        }

        private void Control_OnRemoveAccount(object sender, AccountControl e)
        {
            Common.InvokeAction(this, new Action(() =>
            {
                var exists = AccountDetails.Find(a => a.AccountName == e.Username);
                if (exists != null)
                {
                    AccountDetails.Remove(exists);
                }

                PN_AccountContainer.Controls.Remove(e);

            }));
        }
    }
}
