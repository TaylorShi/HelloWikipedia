using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wikipedia
{
    public partial class WikiSearchPage: UserControl
    {
        int LeftCount;

        string Keyword => txbSearch.Text?.Trim();

        public event EventHandler<SearchEventArgs> InvokeSearch;

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
            LeftCount = 10;
            labLeftCount.Text = string.Format(labLeftCount.Text, LeftCount);
            // 初始化本机浏览器仿真设置
            new BrowserEnvHelper().InitLocalBrowserEmulation();
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

        }
    }
}
