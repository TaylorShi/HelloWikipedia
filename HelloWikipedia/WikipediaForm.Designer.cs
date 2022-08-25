namespace HelloWikipedia
{
    partial class WikipediaForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WikipediaForm));
            this.pnlSearchPage = new System.Windows.Forms.Panel();
            this.wikiSearchPage = new Wikipedia.WikiSearchPage();
            this.wikiSettingPage = new Wikipedia.WikiSettingPage();
            this.pnlSettingPage = new System.Windows.Forms.Panel();
            this.pnlSearchPage.SuspendLayout();
            this.pnlSettingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearchPage
            // 
            this.pnlSearchPage.Controls.Add(this.wikiSearchPage);
            this.pnlSearchPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearchPage.Location = new System.Drawing.Point(0, 0);
            this.pnlSearchPage.Name = "pnlSearchPage";
            this.pnlSearchPage.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlSearchPage.Size = new System.Drawing.Size(424, 702);
            this.pnlSearchPage.TabIndex = 0;
            // 
            // wikiSearchPage
            // 
            this.wikiSearchPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wikiSearchPage.Location = new System.Drawing.Point(12, 8);
            this.wikiSearchPage.Name = "wikiSearchPage";
            this.wikiSearchPage.Size = new System.Drawing.Size(400, 686);
            this.wikiSearchPage.TabIndex = 0;
            this.wikiSearchPage.InvokeSearch += new System.EventHandler<Wikipedia.SearchEventArgs>(this.wikiSearchPage_InvokeSearch);
            this.wikiSearchPage.InvokeSetting += new System.EventHandler(this.wikiSearchPage_InvokeSetting);
            // 
            // wikiSettingPage
            // 
            this.wikiSettingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wikiSettingPage.Location = new System.Drawing.Point(12, 8);
            this.wikiSettingPage.Name = "wikiSettingPage";
            this.wikiSettingPage.Size = new System.Drawing.Size(400, 686);
            this.wikiSettingPage.TabIndex = 1;
            this.wikiSettingPage.InvokeSeted += new System.EventHandler(this.wikiSettingPage_InvokeSeted);
            // 
            // pnlSettingPage
            // 
            this.pnlSettingPage.Controls.Add(this.wikiSettingPage);
            this.pnlSettingPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingPage.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingPage.Name = "pnlSettingPage";
            this.pnlSettingPage.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlSettingPage.Size = new System.Drawing.Size(424, 702);
            this.pnlSettingPage.TabIndex = 2;
            this.pnlSettingPage.Visible = false;
            // 
            // WikipediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 702);
            this.Controls.Add(this.pnlSearchPage);
            this.Controls.Add(this.pnlSettingPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WikipediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维基百科小助手";
            this.pnlSearchPage.ResumeLayout(false);
            this.pnlSettingPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearchPage;
        private Wikipedia.WikiSearchPage wikiSearchPage;
        private Wikipedia.WikiSettingPage wikiSettingPage;
        private System.Windows.Forms.Panel pnlSettingPage;
    }
}

