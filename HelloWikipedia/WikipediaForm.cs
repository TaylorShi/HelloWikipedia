using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWikipedia
{
    public partial class WikipediaForm : Form
    {
        public WikipediaForm()
        {
            InitializeComponent();
        }

        private void wikiSearchPage_InvokeSearch(object sender, Wikipedia.SearchEventArgs e)
        {
            wikiSearchPage.Navigate(e.Keyword);
        }
    }
}
