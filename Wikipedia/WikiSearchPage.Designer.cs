namespace Wikipedia
{
    partial class WikiSearchPage
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
            this.pnlSpace2 = new System.Windows.Forms.Panel();
            this.pnlResultAction = new System.Windows.Forms.Panel();
            this.btnCopyResult = new System.Windows.Forms.Button();
            this.pnlResultTip = new System.Windows.Forms.Panel();
            this.labLeftCount = new System.Windows.Forms.Label();
            this.pnlResultContent = new System.Windows.Forms.Panel();
            this.wbResultContent = new System.Windows.Forms.WebBrowser();
            this.pnlResultTitle = new System.Windows.Forms.Panel();
            this.labResultTitle = new System.Windows.Forms.Label();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.pnlActionSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlSpace = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.pnlResultAction.SuspendLayout();
            this.pnlResultTip.SuspendLayout();
            this.pnlResultContent.SuspendLayout();
            this.pnlResultTitle.SuspendLayout();
            this.pnlAction.SuspendLayout();
            this.pnlActionSearch.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSpace2
            // 
            this.pnlSpace2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSpace2.Location = new System.Drawing.Point(0, 630);
            this.pnlSpace2.MinimumSize = new System.Drawing.Size(0, 8);
            this.pnlSpace2.Name = "pnlSpace2";
            this.pnlSpace2.Size = new System.Drawing.Size(424, 8);
            this.pnlSpace2.TabIndex = 7;
            // 
            // pnlResultAction
            // 
            this.pnlResultAction.Controls.Add(this.btnCopyResult);
            this.pnlResultAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResultAction.Location = new System.Drawing.Point(0, 638);
            this.pnlResultAction.Name = "pnlResultAction";
            this.pnlResultAction.Size = new System.Drawing.Size(424, 32);
            this.pnlResultAction.TabIndex = 8;
            // 
            // btnCopyResult
            // 
            this.btnCopyResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCopyResult.Location = new System.Drawing.Point(0, 0);
            this.btnCopyResult.Name = "btnCopyResult";
            this.btnCopyResult.Size = new System.Drawing.Size(424, 32);
            this.btnCopyResult.TabIndex = 0;
            this.btnCopyResult.Text = "复制结果";
            this.btnCopyResult.UseVisualStyleBackColor = true;
            this.btnCopyResult.Click += new System.EventHandler(this.btnCopyResult_Click);
            // 
            // pnlResultTip
            // 
            this.pnlResultTip.Controls.Add(this.labLeftCount);
            this.pnlResultTip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResultTip.Location = new System.Drawing.Point(0, 670);
            this.pnlResultTip.Name = "pnlResultTip";
            this.pnlResultTip.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlResultTip.Size = new System.Drawing.Size(424, 32);
            this.pnlResultTip.TabIndex = 9;
            // 
            // labLeftCount
            // 
            this.labLeftCount.AutoSize = true;
            this.labLeftCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.labLeftCount.Location = new System.Drawing.Point(0, 10);
            this.labLeftCount.Name = "labLeftCount";
            this.labLeftCount.Size = new System.Drawing.Size(107, 12);
            this.labLeftCount.TabIndex = 0;
            this.labLeftCount.Text = "免费搜索次数: {0}";
            // 
            // pnlResultContent
            // 
            this.pnlResultContent.Controls.Add(this.wbResultContent);
            this.pnlResultContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResultContent.Location = new System.Drawing.Point(0, 104);
            this.pnlResultContent.Name = "pnlResultContent";
            this.pnlResultContent.Size = new System.Drawing.Size(424, 598);
            this.pnlResultContent.TabIndex = 10;
            // 
            // wbResultContent
            // 
            this.wbResultContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbResultContent.Location = new System.Drawing.Point(0, 0);
            this.wbResultContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbResultContent.Name = "wbResultContent";
            this.wbResultContent.Size = new System.Drawing.Size(424, 598);
            this.wbResultContent.TabIndex = 0;
            // 
            // pnlResultTitle
            // 
            this.pnlResultTitle.Controls.Add(this.labResultTitle);
            this.pnlResultTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlResultTitle.Location = new System.Drawing.Point(0, 72);
            this.pnlResultTitle.Name = "pnlResultTitle";
            this.pnlResultTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlResultTitle.Size = new System.Drawing.Size(424, 32);
            this.pnlResultTitle.TabIndex = 11;
            // 
            // labResultTitle
            // 
            this.labResultTitle.AutoSize = true;
            this.labResultTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labResultTitle.Location = new System.Drawing.Point(0, 10);
            this.labResultTitle.Name = "labResultTitle";
            this.labResultTitle.Size = new System.Drawing.Size(53, 12);
            this.labResultTitle.TabIndex = 0;
            this.labResultTitle.Text = "搜索结果";
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.pnlActionSearch);
            this.pnlAction.Controls.Add(this.btnClear);
            this.pnlAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAction.Location = new System.Drawing.Point(0, 40);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(424, 32);
            this.pnlAction.TabIndex = 12;
            // 
            // pnlActionSearch
            // 
            this.pnlActionSearch.Controls.Add(this.btnSearch);
            this.pnlActionSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActionSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlActionSearch.Name = "pnlActionSearch";
            this.pnlActionSearch.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.pnlActionSearch.Size = new System.Drawing.Size(349, 32);
            this.pnlActionSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.Location = new System.Drawing.Point(0, 0);
            this.btnSearch.MinimumSize = new System.Drawing.Size(0, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(341, 32);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(349, 0);
            this.btnClear.MinimumSize = new System.Drawing.Size(0, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlSpace
            // 
            this.pnlSpace.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSpace.Location = new System.Drawing.Point(0, 32);
            this.pnlSpace.MinimumSize = new System.Drawing.Size(0, 8);
            this.pnlSpace.Name = "pnlSpace";
            this.pnlSpace.Size = new System.Drawing.Size(424, 8);
            this.pnlSpace.TabIndex = 13;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearch.Controls.Add(this.txbSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(8, 8, 8, 2);
            this.pnlSearch.Size = new System.Drawing.Size(424, 32);
            this.pnlSearch.TabIndex = 14;
            // 
            // txbSearch
            // 
            this.txbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbSearch.Location = new System.Drawing.Point(8, 8);
            this.txbSearch.Multiline = true;
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(406, 20);
            this.txbSearch.TabIndex = 0;
            // 
            // WikiSearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlSpace2);
            this.Controls.Add(this.pnlResultAction);
            this.Controls.Add(this.pnlResultTip);
            this.Controls.Add(this.pnlResultContent);
            this.Controls.Add(this.pnlResultTitle);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.pnlSpace);
            this.Controls.Add(this.pnlSearch);
            this.Name = "WikiSearchPage";
            this.Size = new System.Drawing.Size(424, 702);
            this.pnlResultAction.ResumeLayout(false);
            this.pnlResultTip.ResumeLayout(false);
            this.pnlResultTip.PerformLayout();
            this.pnlResultContent.ResumeLayout(false);
            this.pnlResultTitle.ResumeLayout(false);
            this.pnlResultTitle.PerformLayout();
            this.pnlAction.ResumeLayout(false);
            this.pnlActionSearch.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpace2;
        private System.Windows.Forms.Panel pnlResultAction;
        private System.Windows.Forms.Button btnCopyResult;
        private System.Windows.Forms.Panel pnlResultTip;
        private System.Windows.Forms.Label labLeftCount;
        private System.Windows.Forms.Panel pnlResultContent;
        private System.Windows.Forms.WebBrowser wbResultContent;
        private System.Windows.Forms.Panel pnlResultTitle;
        private System.Windows.Forms.Label labResultTitle;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.Panel pnlActionSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlSpace;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.TextBox txbSearch;
    }
}
