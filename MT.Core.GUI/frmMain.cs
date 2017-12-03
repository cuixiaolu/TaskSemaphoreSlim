using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Threading;

namespace MT.Core.GUI
{
    public partial class frmMain : Skin_Mac
    {
        public frmMain()
        {
            InitializeComponent();
        }
        SemaphoreSlim sem = new SemaphoreSlim(3, 5);
        CancellationTokenSource source = new CancellationTokenSource();

        private delegate void nowValueDelegate(int index, string value, bool success);

        private void btnStart_Click(object sender, EventArgs e)
        {
            source = new CancellationTokenSource();
            pbStatus.Maximum = lvList.Items.Count;
            lblMax.Text = pbStatus.Maximum + "";
            pbStatus.Value = 0;
            var items = lvList.Items;
            foreach (ListViewItem lvItem in items)
            {
                var i = lvList.Items.IndexOf(lvItem);
                Task.Factory.StartNew(() =>
                {

                    sem.Wait();
                    if (!source.Token.IsCancellationRequested)
                    {
                        nowValueDelegate now = new nowValueDelegate(setNow);
                        Invoke(now, i, "等待中……", false);
                        Thread.Sleep(100);
                    }

                    return 4;
                }).ContinueWith((item) =>
                {
                    if (!source.Token.IsCancellationRequested)
                    {
                        nowValueDelegate now = new nowValueDelegate(setNow);
                        Invoke(now, i, "完成", true);
                        Console.WriteLine(i);
                    }
                    sem.Release();
                }); ;
            }

        }

        private void setNow(int index, string nowValue, bool success)
        {
            if (lvList.Items[index].SubItems.Count > 1)
            {
                lvList.Items[index].SubItems[1].Text = nowValue;
            }
            else
            {
                lvList.Items[index].SubItems.Add(nowValue);
            }
            this.lvList.EnsureVisible(index);
            if (success)
            {
                pbStatus.Value += 1;
                lblCurrent.Text = pbStatus.Value + "";
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            source.Cancel();
        }
    }
}
