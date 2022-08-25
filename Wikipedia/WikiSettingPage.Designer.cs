namespace Wikipedia
{
    partial class WikiSettingPage
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.labTitle = new System.Windows.Forms.Label();
            this.pnlLangSetting = new System.Windows.Forms.Panel();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottomLine = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.pnlLangSetting.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.labTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(400, 38);
            this.pnlTitle.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(3, 12);
            this.labTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(53, 12);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "搜索设置";
            // 
            // pnlLangSetting
            // 
            this.pnlLangSetting.Controls.Add(this.panel4);
            this.pnlLangSetting.Controls.Add(this.panel1);
            this.pnlLangSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLangSetting.Location = new System.Drawing.Point(0, 40);
            this.pnlLangSetting.Name = "pnlLangSetting";
            this.pnlLangSetting.Size = new System.Drawing.Size(400, 43);
            this.pnlLangSetting.TabIndex = 1;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(0, 10);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(324, 20);
            this.cmbLanguage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "语言设置：";
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.flowLayoutPanel1);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAction.Location = new System.Drawing.Point(0, 638);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.pnlAction.Size = new System.Drawing.Size(400, 48);
            this.pnlAction.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(85, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.MaximumSize = new System.Drawing.Size(75, 32);
            this.btnCancel.MinimumSize = new System.Drawing.Size(75, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(0, 0);
            this.btnApply.Margin = new System.Windows.Forms.Padding(0);
            this.btnApply.MaximumSize = new System.Drawing.Size(75, 32);
            this.btnApply.MinimumSize = new System.Drawing.Size(75, 32);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 32);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "保存";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnApply);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(236, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 32);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pnlBottomLine
            // 
            this.pnlBottomLine.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBottomLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomLine.Location = new System.Drawing.Point(0, 636);
            this.pnlBottomLine.MaximumSize = new System.Drawing.Size(0, 2);
            this.pnlBottomLine.MinimumSize = new System.Drawing.Size(0, 2);
            this.pnlBottomLine.Name = "pnlBottomLine";
            this.pnlBottomLine.Size = new System.Drawing.Size(400, 2);
            this.pnlBottomLine.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.panel1.Size = new System.Drawing.Size(76, 43);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbLanguage);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(76, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.panel4.Size = new System.Drawing.Size(324, 43);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.MaximumSize = new System.Drawing.Size(0, 2);
            this.panel2.MinimumSize = new System.Drawing.Size(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 2);
            this.panel2.TabIndex = 5;
            // 
            // WikiSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottomLine);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlLangSetting);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTitle);
            this.Name = "WikiSettingPage";
            this.Size = new System.Drawing.Size(400, 686);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlLangSetting.ResumeLayout(false);
            this.pnlAction.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Panel pnlLangSetting;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlBottomLine;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
