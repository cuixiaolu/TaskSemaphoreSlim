using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MT.Core.Lib
{
    public partial class UcNetSwitch : UserControl
    {
        public UcNetSwitch()
        {
            InitializeComponent();
        }

        UcAdsl ucAdsl = null;
        UcRouter ucRouter = null;
        UcVpnList ucVpnList = null;


        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            this.CheckNetworkPanel();
        }

        private void CheckNetworkPanel()
        {
            if (radioADSL.Checked)
            {
                panelNet.Controls.Clear();
                panelNet.Controls.Add(ucAdsl);
            }

            if (radioRouter.Checked)
            {
                panelNet.Controls.Clear();
                panelNet.Controls.Add(ucRouter);
            }

            if (radioVpn.Checked)
            {
                panelNet.Controls.Clear();
                //panelNet.Controls.Add(ucVpn);
                panelNet.Controls.Add(ucVpnList);
            }
        }

        public event EventHandler<BoolEventArgs> TestChanged;

        private void UcNetSwitch_Load(object sender, EventArgs e)
        {
            ADSLItem adsl = new ADSLItem();
            //adsl.EntryName = RiftSetConfig.Instance.ADSLName;
            //adsl.Password = RiftSetConfig.Instance.ADSLPwd;
            //adsl.User = RiftSetConfig.Instance.ADSLUser;
            ucAdsl = new UcAdsl(adsl, CoreGUIManager.Instance);
            ucAdsl.TestChanged += TestChanged;

            RouterItem router = new RouterItem();
            //router.RouterType = RiftSetConfig.Instance.RouterType;
            //router.IP = RiftSetConfig.Instance.RouterIP;
            //router.Password = RiftSetConfig.Instance.RouterPwd;
            //router.User = RiftSetConfig.Instance.RouterUser;
            ucRouter = new UcRouter(router, CoreGUIManager.Instance);
            ucRouter.TestChanged += TestChanged;

            VPNFile vpn = new VPNFile();
            //vpn.EntryName = RiftSetConfig.Instance.VpnEntryName;
            //vpn.File = RiftSetConfig.Instance.VpnFile;
            ucVpnList = new UcVpnList(vpn, CoreGUIManager.Instance);
            ucVpnList.TestChanged += TestChanged;
            
        }

        private void chkReconnect_CheckedChanged(object sender, EventArgs e)
        {
            groupRestartMode.Enabled = chkReconnect.Checked;
            if (!chkReconnect.Checked)
            {
                radioADSL.Checked = chkReconnect.Checked;
                radioRouter.Checked = chkReconnect.Checked;
                radioVpn.Checked = chkReconnect.Checked;
                panelNet.Controls.Clear();
            }

            this.CheckNetworkPanel();
        }
        
    }
}
