using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using Wikipedia;
using Wikipedia.WikiSearch.Model;

namespace HelloWikipedia
{
    public partial class WikipediaForm : Form
    {
        private IWikiSearchService wikiSearchService;

        private bool isSearching;
        public bool IsSearching
        {
            get { return isSearching; }
            set { isSearching = value;
                this.BeginInvoke(new Action(() => wikiSearchPage.SetSearchingStatus(value)));
            }
        }

        public WikipediaForm()
        {
            InitializeComponent();
            wikiSearchService = new WikiSearchService();
            AcceptButton = wikiSearchPage.AcceptButton;
        }

        private void wikiSearchPage_InvokeSearch(object sender, Wikipedia.SearchEventArgs e)
        {
            var wikiLanguage = wikiSearchService.ConvertLanguage(wikiSettingPage.ViewLanguage);
            var wikiSearchVo = new WikiSearchVo
            {
                Language = wikiLanguage,
                Keyword = e.Keyword,
            };
            var wikiSearchTask = wikiSearchService.Search(wikiSearchVo);
            wikiSearchTask.Completed += WikiSearchTask_Completed;
            wikiSearchPage.UsedLeftCount();
            wikiSearchTask.Start();
            IsSearching = true;
        }

        private void WikiSearchTask_Completed(object sender, SnowSpace.Extensions.AsyncTasks.TaskCompletedEventArgs e)
        {
            IsSearching = false;
            if (e.IsSuccessCompleted)
            {
                var naviAddress = wikiSearchService.SearchResult.FirstResultDto.PageMobileUrl.OriginalString;
                if (!string.IsNullOrEmpty(naviAddress))
                {
                    wikiSearchPage.Navigate(naviAddress);
                }
            }
        }

        private void wikiSearchPage_InvokeSetting(object sender, EventArgs e)
        {
            wikiSettingPage.Init();
            wikiSettingPage.Backup();
            pnlSearchPage.Visible = false;
            pnlSettingPage.Visible = true;
        }

        private void wikiSettingPage_InvokeSeted(object sender, EventArgs e)
        {
            pnlSearchPage.Visible = true;
            pnlSettingPage.Visible = false;
        }
    }
}
