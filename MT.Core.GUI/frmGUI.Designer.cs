namespace MT.Core.GUI
{
    partial class frmGUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtRemainCount = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtUnknowCount = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtFailedCount = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSuccessCount = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtProcessedCount = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotalCount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labSeconds = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSpend = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnStopSound = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPaused = new System.Windows.Forms.Button();
            this.skinTabPage2 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.ucNetSwitch1 = new MT.Core.Lib.UcNetSwitch();
            this.panel1.SuspendLayout();
            this.groupControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.skinTabPage1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(709, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 557);
            this.panel1.TabIndex = 22;
            // 
            // groupControl
            // 
            this.groupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl.Controls.Add(this.label23);
            this.groupControl.Controls.Add(this.txtRemainCount);
            this.groupControl.Controls.Add(this.label29);
            this.groupControl.Controls.Add(this.label34);
            this.groupControl.Controls.Add(this.txtUnknowCount);
            this.groupControl.Controls.Add(this.label36);
            this.groupControl.Controls.Add(this.label31);
            this.groupControl.Controls.Add(this.txtFailedCount);
            this.groupControl.Controls.Add(this.label33);
            this.groupControl.Controls.Add(this.label28);
            this.groupControl.Controls.Add(this.txtSuccessCount);
            this.groupControl.Controls.Add(this.label30);
            this.groupControl.Controls.Add(this.label25);
            this.groupControl.Controls.Add(this.txtProcessedCount);
            this.groupControl.Controls.Add(this.label27);
            this.groupControl.Controls.Add(this.label22);
            this.groupControl.Controls.Add(this.txtTotalCount);
            this.groupControl.Controls.Add(this.label24);
            this.groupControl.Controls.Add(this.label13);
            this.groupControl.Controls.Add(this.labSeconds);
            this.groupControl.Controls.Add(this.label11);
            this.groupControl.Controls.Add(this.groupBox1);
            this.groupControl.Controls.Add(this.groupBox2);
            this.groupControl.Controls.Add(this.groupBox3);
            this.groupControl.Location = new System.Drawing.Point(124, 10);
            this.groupControl.Name = "groupControl";
            this.groupControl.Size = new System.Drawing.Size(114, 543);
            this.groupControl.TabIndex = 19;
            this.groupControl.TabStop = false;
            this.groupControl.Text = "数据栏";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(73, 251);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(17, 12);
            this.label23.TabIndex = 39;
            this.label23.Text = "条";
            // 
            // txtRemainCount
            // 
            this.txtRemainCount.AutoSize = true;
            this.txtRemainCount.ForeColor = System.Drawing.Color.Red;
            this.txtRemainCount.Location = new System.Drawing.Point(24, 251);
            this.txtRemainCount.Name = "txtRemainCount";
            this.txtRemainCount.Size = new System.Drawing.Size(11, 12);
            this.txtRemainCount.TabIndex = 38;
            this.txtRemainCount.Text = "0";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(17, 229);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 12);
            this.label29.TabIndex = 37;
            this.label29.Text = "剩余数：";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.Black;
            this.label34.Location = new System.Drawing.Point(73, 429);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(17, 12);
            this.label34.TabIndex = 33;
            this.label34.Text = "条";
            // 
            // txtUnknowCount
            // 
            this.txtUnknowCount.AutoSize = true;
            this.txtUnknowCount.Location = new System.Drawing.Point(26, 429);
            this.txtUnknowCount.Name = "txtUnknowCount";
            this.txtUnknowCount.Size = new System.Drawing.Size(11, 12);
            this.txtUnknowCount.TabIndex = 32;
            this.txtUnknowCount.Text = "0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(17, 410);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 12);
            this.label36.TabIndex = 31;
            this.label36.Text = "未知数：";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(73, 392);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 12);
            this.label31.TabIndex = 30;
            this.label31.Text = "条";
            // 
            // txtFailedCount
            // 
            this.txtFailedCount.AutoSize = true;
            this.txtFailedCount.Location = new System.Drawing.Point(24, 392);
            this.txtFailedCount.Name = "txtFailedCount";
            this.txtFailedCount.Size = new System.Drawing.Size(11, 12);
            this.txtFailedCount.TabIndex = 29;
            this.txtFailedCount.Text = "0";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(17, 373);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(53, 12);
            this.label33.TabIndex = 28;
            this.label33.Text = "失败数：";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(73, 353);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 12);
            this.label28.TabIndex = 27;
            this.label28.Text = "条";
            // 
            // txtSuccessCount
            // 
            this.txtSuccessCount.AutoSize = true;
            this.txtSuccessCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSuccessCount.ForeColor = System.Drawing.Color.Red;
            this.txtSuccessCount.Location = new System.Drawing.Point(24, 353);
            this.txtSuccessCount.Name = "txtSuccessCount";
            this.txtSuccessCount.Size = new System.Drawing.Size(12, 12);
            this.txtSuccessCount.TabIndex = 26;
            this.txtSuccessCount.Text = "0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 334);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 25;
            this.label30.Text = "成功数：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(73, 210);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 12);
            this.label25.TabIndex = 24;
            this.label25.Text = "条";
            // 
            // txtProcessedCount
            // 
            this.txtProcessedCount.AutoSize = true;
            this.txtProcessedCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtProcessedCount.ForeColor = System.Drawing.Color.Red;
            this.txtProcessedCount.Location = new System.Drawing.Point(24, 210);
            this.txtProcessedCount.Name = "txtProcessedCount";
            this.txtProcessedCount.Size = new System.Drawing.Size(12, 12);
            this.txtProcessedCount.TabIndex = 23;
            this.txtProcessedCount.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(17, 188);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(65, 12);
            this.label27.TabIndex = 22;
            this.label27.Text = "已处理数：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(72, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 12);
            this.label22.TabIndex = 21;
            this.label22.Text = "条";
            // 
            // txtTotalCount
            // 
            this.txtTotalCount.AutoSize = true;
            this.txtTotalCount.ForeColor = System.Drawing.Color.Red;
            this.txtTotalCount.Location = new System.Drawing.Point(24, 168);
            this.txtTotalCount.Name = "txtTotalCount";
            this.txtTotalCount.Size = new System.Drawing.Size(11, 12);
            this.txtTotalCount.TabIndex = 20;
            this.txtTotalCount.Text = "0";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 146);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 19;
            this.label24.Text = "数据总数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(71, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "秒";
            // 
            // labSeconds
            // 
            this.labSeconds.AutoSize = true;
            this.labSeconds.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSeconds.ForeColor = System.Drawing.Color.MediumBlue;
            this.labSeconds.Location = new System.Drawing.Point(18, 98);
            this.labSeconds.Name = "labSeconds";
            this.labSeconds.Size = new System.Drawing.Size(15, 14);
            this.labSeconds.TabIndex = 15;
            this.labSeconds.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "重连用时：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpend);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(93, 108);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // txtSpend
            // 
            this.txtSpend.AutoSize = true;
            this.txtSpend.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSpend.ForeColor = System.Drawing.Color.MediumBlue;
            this.txtSpend.Location = new System.Drawing.Point(7, 38);
            this.txtSpend.Name = "txtSpend";
            this.txtSpend.Size = new System.Drawing.Size(15, 14);
            this.txtSpend.TabIndex = 18;
            this.txtSpend.Text = "0";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 16);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 12);
            this.label38.TabIndex = 17;
            this.label38.Text = "总用时：";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(11, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 187);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(11, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(93, 174);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnStopSound);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btnStart);
            this.groupBox4.Controls.Add(this.btnStop);
            this.groupBox4.Controls.Add(this.btnPaused);
            this.groupBox4.Location = new System.Drawing.Point(15, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(92, 542);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "控制栏";
            // 
            // btnStopSound
            // 
            this.btnStopSound.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopSound.Location = new System.Drawing.Point(6, 230);
            this.btnStopSound.Name = "btnStopSound";
            this.btnStopSound.Size = new System.Drawing.Size(75, 23);
            this.btnStopSound.TabIndex = 20;
            this.btnStopSound.Text = "静音";
            this.btnStopSound.UseVisualStyleBackColor = true;
            this.btnStopSound.Click += new System.EventHandler(this.btnStopSound_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(6, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "清缓存";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(6, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Location = new System.Drawing.Point(6, 124);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnPaused
            // 
            this.btnPaused.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaused.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPaused.ForeColor = System.Drawing.Color.Black;
            this.btnPaused.Location = new System.Drawing.Point(6, 84);
            this.btnPaused.Name = "btnPaused";
            this.btnPaused.Size = new System.Drawing.Size(75, 23);
            this.btnPaused.TabIndex = 18;
            this.btnPaused.Text = "暂停";
            this.btnPaused.UseVisualStyleBackColor = true;
            // 
            // skinTabPage2
            // 
            this.skinTabPage2.BackColor = System.Drawing.Color.White;
            this.skinTabPage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage2.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage2.Name = "skinTabPage2";
            this.skinTabPage2.Size = new System.Drawing.Size(699, 515);
            this.skinTabPage2.TabIndex = 1;
            this.skinTabPage2.TabItemImage = null;
            this.skinTabPage2.Text = "日志";
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.White;
            this.skinTabPage1.Controls.Add(this.ucNetSwitch1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.Location = new System.Drawing.Point(0, 36);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(699, 515);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "参数配置";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Controls.Add(this.skinTabPage2);
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(7, 35);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageArrowPalace = true;
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(699, 551);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // ucNetSwitch1
            // 
            this.ucNetSwitch1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNetSwitch1.Location = new System.Drawing.Point(27, 21);
            this.ucNetSwitch1.Name = "ucNetSwitch1";
            this.ucNetSwitch1.Size = new System.Drawing.Size(380, 238);
            this.ucNetSwitch1.TabIndex = 0;
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.skinTabControl1);
            this.MaximizeBox = false;
            this.Name = "frmGUI";
            this.ShadowWidth = 10;
            this.ShowDrawIcon = false;
            this.Text = "框架型处理";
            this.panel1.ResumeLayout(false);
            this.groupControl.ResumeLayout(false);
            this.groupControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupControl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label txtRemainCount;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label txtUnknowCount;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label txtFailedCount;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label txtSuccessCount;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label txtProcessedCount;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txtTotalCount;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labSeconds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtSpend;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnStopSound;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPaused;
        private CCWin.SkinControl.SkinTabPage skinTabPage2;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private Lib.UcNetSwitch ucNetSwitch1;
    }
}