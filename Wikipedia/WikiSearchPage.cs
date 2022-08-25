using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wikipedia.Helper;

namespace Wikipedia
{
    public partial class WikiSearchPage: UserControl
    {
        /// <summary>
        /// 回车按钮
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IButtonControl AcceptButton
        {
            get { return this.btnSearch; }
        }

        int LeftCount;

        bool IsDisableUse;

        int FreeLeftCount = 10;

        string Keyword => txbSearch.Text?.Trim();

        public event EventHandler<SearchEventArgs> InvokeSearch;

        public event EventHandler InvokeSetting;

        public void SetSearchingStatus(bool isSearching)
        {
            if (IsDisableUse)
            {
                return;
            }

            btnClear.Enabled = !isSearching;
            btnSearch.Enabled = !isSearching;
            btnCopyResult.Enabled = !isSearching;
            pgbSearching.Enabled = pgbSearching.Visible = isSearching;
        }

        public WikiSearchPage()
        {
            InitializeComponent();
            Init();
        }

        public void Navigate(string urlAddress)
        {
            wbResultContent.Navigate(urlAddress);
        }

        private void Init()
        {
            LeftCount = FreeLeftCount;
            UpdateLeftCount();
            // 初始化本机浏览器仿真设置
            new BrowserEnvHelper().InitLocalBrowserEmulation();
        }

        public void UsedLeftCount()
        {
            LeftCount--;
            UpdateLeftCount();
            if (LeftCount <= 0)
            {
                DisableUse();
            }
        }

        private void DisableUse()
        {
            IsDisableUse = true;
            btnClear.Enabled = false;
            btnSearch.Enabled = false;
        }

        private void UpdateLeftCount()
        {
            labLeftCount.Text = string.Format("免费搜索次数: {0}", LeftCount);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbSearch.Text = string.Empty;
            txbSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Keyword))
            {
                MessageBox.Show("请先输入搜索词","提示", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txbSearch.Focus();
                return;
            }
            InvokeSearch?.Invoke(sender, new SearchEventArgs(Keyword) );
        }

        private void btnCopyResult_Click(object sender, EventArgs e)
        {
            var docText = wbResultContent.Document.Body.OuterText;
            if (!string.IsNullOrEmpty(docText))
            {
                Clipboard.SetText(docText);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            InvokeSetting?.Invoke(sender, e);
        }
    }
}
