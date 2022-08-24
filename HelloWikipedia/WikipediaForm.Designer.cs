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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.wikiSearchPage = new Wikipedia.WikiSearchPage();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.wikiSearchPage);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.pnlContainer.Size = new System.Drawing.Size(424, 702);
            this.pnlContainer.TabIndex = 0;
            // 
            // wikiSearchPage
            // 
            this.wikiSearchPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wikiSearchPage.Location = new System.Drawing.Point(12, 8);
            this.wikiSearchPage.Name = "wikiSearchPage";
            this.wikiSearchPage.Size = new System.Drawing.Size(400, 686);
            this.wikiSearchPage.TabIndex = 0;
            this.wikiSearchPage.InvokeSearch += new System.EventHandler<Wikipedia.SearchEventArgs>(this.wikiSearchPage_InvokeSearch);
            // 
            // WikipediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 702);
            this.Controls.Add(this.pnlContainer);
            this.Name = "WikipediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WikipediaHelper";
            this.pnlContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private Wikipedia.WikiSearchPage wikiSearchPage;
    }
}

