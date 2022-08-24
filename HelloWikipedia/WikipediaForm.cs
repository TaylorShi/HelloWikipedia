using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wikipedia;
using Wikipedia.WikiSearch.Model;

namespace HelloWikipedia
{
    public partial class WikipediaForm : Form
    {
        private IWikiSearchService wikiSearchService;

        public WikipediaForm()
        {
            InitializeComponent();
            wikiSearchService = new WikiSearchService();
        }

        private void wikiSearchPage_InvokeSearch(object sender, Wikipedia.SearchEventArgs e)
        {
            var wikiLanguage = wikiSearchService.ConvertLanguage("CHS");
            var wikiSearchVo = new WikiSearchVo
            {
                Language = wikiLanguage,
                Keyword = e.Keyword,
            };
            wikiSearchService.Search(wikiSearchVo);

            wikiSearchPage.Navigate(e.Keyword);
        }
    }
}
