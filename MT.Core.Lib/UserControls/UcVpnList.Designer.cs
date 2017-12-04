namespace MT.Core.Lib
{
    partial class UcVpnList
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
            this.label41 = new System.Windows.Forms.Label();
            this.btnTestVpn = new System.Windows.Forms.Button();
            this.groupVpn = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtVpnName = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupVpn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.ForeColor = System.Drawing.Color.Red;
            this.label41.Location = new System.Drawing.Point(7, 107);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(251, 12);
            this.label41.TabIndex = 51;
            this.label41.Text = "请先自建VPN连接测试，最好保证VPN支持Ping!";
            this.label41.Visible = false;
            // 
            // btnTestVpn
            // 
            this.btnTestVpn.ForeColor = System.Drawing.Color.Black;
            this.btnTestVpn.Location = new System.Drawing.Point(299, 21);
            this.btnTestVpn.Name = "btnTestVpn";
            this.btnTestVpn.Size = new System.Drawing.Size(43, 23);
            this.btnTestVpn.TabIndex = 53;
            this.btnTestVpn.Text = "测试";
            this.btnTestVpn.UseVisualStyleBackColor = true;
            this.btnTestVpn.Click += new System.EventHandler(this.btnTestVpn_Click);
            // 
            // groupVpn
            // 
            this.groupVpn.Controls.Add(this.label2);
            this.groupVpn.Controls.Add(this.label41);
            this.groupVpn.Controls.Add(this.btnOpen);
            this.groupVpn.Controls.Add(this.btnTestVpn);
            this.groupVpn.Controls.Add(this.txtFile);
            this.groupVpn.Controls.Add(this.label26);
            this.groupVpn.Controls.Add(this.txtVpnName);
            this.groupVpn.Controls.Add(this.label21);
            this.groupVpn.Location = new System.Drawing.Point(3, 3);
            this.groupVpn.Name = "groupVpn";
            this.groupVpn.Size = new System.Drawing.Size(364, 126);
            this.groupVpn.TabIndex = 52;
            this.groupVpn.TabStop = false;
            this.groupVpn.Text = "VPN参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(7, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 56;
            this.label2.Text = "数据格式：IP，用户名，密码";
            // 
            // btnOpen
            // 
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(299, 53);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(43, 23);
            this.btnOpen.TabIndex = 54;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(99, 54);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(194, 21);
            this.txtFile.TabIndex = 35;
            this.txtFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(71, 12);
            this.label26.TabIndex = 36;
            this.label26.Text = "VPN文件名：";
            // 
            // txtVpnName
            // 
            this.txtVpnName.Location = new System.Drawing.Point(99, 21);
            this.txtVpnName.Name = "txtVpnName";
            this.txtVpnName.Size = new System.Drawing.Size(194, 21);
            this.txtVpnName.TabIndex = 8;
            this.txtVpnName.Text = "VPN";
            this.txtVpnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 12);
            this.label21.TabIndex = 32;
            this.label21.Text = "VPN名称：";
            // 
            // UcVpnList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupVpn);
            this.Name = "UcVpnList";
            this.Size = new System.Drawing.Size(370, 133);
            this.groupVpn.ResumeLayout(false);
            this.groupVpn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnTestVpn;
        private System.Windows.Forms.GroupBox groupVpn;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtVpnName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label2;
    }
}
