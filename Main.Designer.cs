namespace PictureDownTool
{
    partial class Main
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDwon = new System.Windows.Forms.Button();
            this.txtTxtPath = new System.Windows.Forms.TextBox();
            this.btnSelFile = new System.Windows.Forms.Button();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.txtDirPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSplit = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtColName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSheet = new System.Windows.Forms.TextBox();
            this.txtRowStart = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ckbPNGOrJPG = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDwon
            // 
            this.btnDwon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDwon.Location = new System.Drawing.Point(816, 85);
            this.btnDwon.Name = "btnDwon";
            this.btnDwon.Size = new System.Drawing.Size(90, 22);
            this.btnDwon.TabIndex = 11;
            this.btnDwon.Text = "下载";
            this.btnDwon.UseVisualStyleBackColor = true;
            this.btnDwon.Click += new System.EventHandler(this.btnDwon_Click);
            // 
            // txtTxtPath
            // 
            this.txtTxtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTxtPath.Location = new System.Drawing.Point(203, 12);
            this.txtTxtPath.Name = "txtTxtPath";
            this.txtTxtPath.ReadOnly = true;
            this.txtTxtPath.Size = new System.Drawing.Size(703, 21);
            this.txtTxtPath.TabIndex = 3;
            // 
            // btnSelFile
            // 
            this.btnSelFile.Location = new System.Drawing.Point(15, 12);
            this.btnSelFile.Name = "btnSelFile";
            this.btnSelFile.Size = new System.Drawing.Size(182, 23);
            this.btnSelFile.TabIndex = 2;
            this.btnSelFile.Text = "选择数据文件（*.txt|*.xlsx）";
            this.btnSelFile.UseVisualStyleBackColor = true;
            this.btnSelFile.Click += new System.EventHandler(this.btnSelFile_Click);
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(15, 44);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(182, 23);
            this.btnSelDir.TabIndex = 4;
            this.btnSelDir.Text = "选择生成图片文件夹";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // txtDirPath
            // 
            this.txtDirPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirPath.Location = new System.Drawing.Point(203, 44);
            this.txtDirPath.Name = "txtDirPath";
            this.txtDirPath.ReadOnly = true;
            this.txtDirPath.Size = new System.Drawing.Size(703, 21);
            this.txtDirPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "线程个数";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "15",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(84, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "文件名称分隔符";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSplit
            // 
            this.txtSplit.Location = new System.Drawing.Point(104, 17);
            this.txtSplit.MaxLength = 10;
            this.txtSplit.Name = "txtSplit";
            this.txtSplit.Size = new System.Drawing.Size(46, 21);
            this.txtSplit.TabIndex = 0;
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.Location = new System.Drawing.Point(15, 119);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(891, 340);
            this.txtMsg.TabIndex = 11;
            this.txtMsg.Text = resources.GetString("txtMsg.Text");
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(12, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(894, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "地址列";
            // 
            // txtColAddr
            // 
            this.txtColAddr.Location = new System.Drawing.Point(123, 17);
            this.txtColAddr.MaxLength = 10;
            this.txtColAddr.Name = "txtColAddr";
            this.txtColAddr.Size = new System.Drawing.Size(36, 21);
            this.txtColAddr.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "名称列";
            // 
            // txtColName
            // 
            this.txtColName.Location = new System.Drawing.Point(213, 17);
            this.txtColName.MaxLength = 10;
            this.txtColName.Name = "txtColName";
            this.txtColName.Size = new System.Drawing.Size(37, 21);
            this.txtColName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSheet);
            this.groupBox1.Controls.Add(this.txtRowStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtColName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtColAddr);
            this.groupBox1.Location = new System.Drawing.Point(379, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 44);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "Sheet";
            // 
            // txtSheet
            // 
            this.txtSheet.Location = new System.Drawing.Point(38, 16);
            this.txtSheet.MaxLength = 10;
            this.txtSheet.Name = "txtSheet";
            this.txtSheet.Size = new System.Drawing.Size(36, 21);
            this.txtSheet.TabIndex = 3;
            // 
            // txtRowStart
            // 
            this.txtRowStart.Location = new System.Drawing.Point(305, 17);
            this.txtRowStart.MaxLength = 10;
            this.txtRowStart.Name = "txtRowStart";
            this.txtRowStart.Size = new System.Drawing.Size(37, 21);
            this.txtRowStart.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "起始行";
            // 
            // ckbPNGOrJPG
            // 
            this.ckbPNGOrJPG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbPNGOrJPG.AutoSize = true;
            this.ckbPNGOrJPG.Location = new System.Drawing.Point(744, 87);
            this.ckbPNGOrJPG.Name = "ckbPNGOrJPG";
            this.ckbPNGOrJPG.Size = new System.Drawing.Size(66, 16);
            this.ckbPNGOrJPG.TabIndex = 10;
            this.ckbPNGOrJPG.Text = "PNG/JPG";
            this.ckbPNGOrJPG.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSplit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(203, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 44);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Txt";
            // 
            // txtProgress
            // 
            this.txtProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtProgress.AutoSize = true;
            this.txtProgress.Location = new System.Drawing.Point(460, 478);
            this.txtProgress.Name = "txtProgress";
            this.txtProgress.Size = new System.Drawing.Size(29, 12);
            this.txtProgress.TabIndex = 12;
            this.txtProgress.Text = "进度";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 507);
            this.Controls.Add(this.txtProgress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ckbPNGOrJPG);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirPath);
            this.Controls.Add(this.btnSelDir);
            this.Controls.Add(this.btnSelFile);
            this.Controls.Add(this.txtTxtPath);
            this.Controls.Add(this.btnDwon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(899, 546);
            this.Name = "Main";
            this.Text = "图片下载工具 2.3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDwon;
        private System.Windows.Forms.TextBox txtTxtPath;
        private System.Windows.Forms.Button btnSelFile;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.TextBox txtDirPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSplit;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtColName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRowStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbPNGOrJPG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSheet;
        private System.Windows.Forms.Label txtProgress;
    }
}

