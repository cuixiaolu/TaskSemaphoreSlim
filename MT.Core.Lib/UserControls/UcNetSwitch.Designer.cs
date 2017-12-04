namespace MT.Core.Lib
{
    partial class UcNetSwitch
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.chkReconnect = new System.Windows.Forms.CheckBox();
            this.groupRestartMode = new System.Windows.Forms.GroupBox();
            this.radioVpn = new System.Windows.Forms.RadioButton();
            this.radioRouter = new System.Windows.Forms.RadioButton();
            this.radioADSL = new System.Windows.Forms.RadioButton();
            this.panelNet = new System.Windows.Forms.Panel();
            this.groupRestartMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkReconnect
            // 
            this.chkReconnect.AutoSize = true;
            this.chkReconnect.Location = new System.Drawing.Point(7, 3);
            this.chkReconnect.Name = "chkReconnect";
            this.chkReconnect.Size = new System.Drawing.Size(120, 16);
            this.chkReconnect.TabIndex = 39;
            this.chkReconnect.Text = "是否支持网络重连";
            this.chkReconnect.UseVisualStyleBackColor = true;
            this.chkReconnect.CheckedChanged += new System.EventHandler(this.chkReconnect_CheckedChanged);
            // 
            // groupRestartMode
            // 
            this.groupRestartMode.Controls.Add(this.radioVpn);
            this.groupRestartMode.Controls.Add(this.radioRouter);
            this.groupRestartMode.Controls.Add(this.radioADSL);
            this.groupRestartMode.Enabled = false;
            this.groupRestartMode.Location = new System.Drawing.Point(7, 18);
            this.groupRestartMode.Name = "groupRestartMode";
            this.groupRestartMode.Size = new System.Drawing.Size(289, 37);
            this.groupRestartMode.TabIndex = 40;
            this.groupRestartMode.TabStop = false;
            // 
            // radioVpn
            // 
            this.radioVpn.AutoSize = true;
            this.radioVpn.Location = new System.Drawing.Point(157, 14);
            this.radioVpn.Name = "radioVpn";
            this.radioVpn.Size = new System.Drawing.Size(41, 16);
            this.radioVpn.TabIndex = 2;
            this.radioVpn.TabStop = true;
            this.radioVpn.Text = "VPN";
            this.radioVpn.UseVisualStyleBackColor = true;
            this.radioVpn.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioRouter
            // 
            this.radioRouter.AutoSize = true;
            this.radioRouter.Location = new System.Drawing.Point(77, 14);
            this.radioRouter.Name = "radioRouter";
            this.radioRouter.Size = new System.Drawing.Size(59, 16);
            this.radioRouter.TabIndex = 1;
            this.radioRouter.TabStop = true;
            this.radioRouter.Text = "路由器";
            this.radioRouter.UseVisualStyleBackColor = true;
            this.radioRouter.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioADSL
            // 
            this.radioADSL.AutoSize = true;
            this.radioADSL.Location = new System.Drawing.Point(18, 14);
            this.radioADSL.Name = "radioADSL";
            this.radioADSL.Size = new System.Drawing.Size(47, 16);
            this.radioADSL.TabIndex = 0;
            this.radioADSL.TabStop = true;
            this.radioADSL.Text = "ADSL";
            this.radioADSL.UseVisualStyleBackColor = true;
            this.radioADSL.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // panelNet
            // 
            this.panelNet.Location = new System.Drawing.Point(3, 60);
            this.panelNet.Name = "panelNet";
            this.panelNet.Size = new System.Drawing.Size(370, 153);
            this.panelNet.TabIndex = 55;
            // 
            // UcNetSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panelNet);
            this.Controls.Add(this.chkReconnect);
            this.Controls.Add(this.groupRestartMode);
            this.DoubleBuffered = true;
            this.Name = "UcNetSwitch";
            this.Size = new System.Drawing.Size(378, 216);
            this.Load += new System.EventHandler(this.UcNetSwitch_Load);
            this.groupRestartMode.ResumeLayout(false);
            this.groupRestartMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkReconnect;
        private System.Windows.Forms.GroupBox groupRestartMode;
        private System.Windows.Forms.RadioButton radioVpn;
        private System.Windows.Forms.RadioButton radioRouter;
        private System.Windows.Forms.RadioButton radioADSL;
        private System.Windows.Forms.Panel panelNet;
    }
}
