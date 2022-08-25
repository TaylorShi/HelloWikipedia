using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wikipedia
{
    public partial class WikiSettingPage : UserControl
    {
        const string ViewDefaultLanguage = "CHS";
        public string ViewLanguage = ViewDefaultLanguage;
        string LastViewLanguage;

        public event EventHandler InvokeSeted;

        public Dictionary<string, string> LangDics = new Dictionary<string, string>()
        {
            {
                "CHS", "简体中文"
            },
            {
                "CHT", "繁体中文"
            },
            {
                "NLD", "Dutch"
            },
            {
                "ENG", "English"
            },
            {
                "FRA", "French"
            },
            {
                "DEU", "German"
            },
            {
                "ITA", "Italian"
            },
            {
                "JPN", "Japanese"
            },
            {
                "KOR", "Korean"
            },
            {
                "PTG", "Portuguese"
            },
            {
                "RUS", "Russian"
            },
            {
                "ESP", "Spanish"
            },
        };

        public WikiSettingPage()
        {
            InitializeComponent();
            cmbLanguage.SelectedIndexChanged += CmbLanguage_SelectedIndexChanged;
        }

        public void Backup()
        {
            LastViewLanguage = ViewLanguage;
        }

        void Restore()
        {
            ViewLanguage = LastViewLanguage;
        }

        public void Init()
        {
            cmbLanguage.SelectedItem = null;
            cmbLanguage.Items.Clear();
            foreach (var langdic in LangDics)
            {
                cmbLanguage.Items.Add(langdic.Value);
            }
            cmbLanguage.SelectedItem = LangDics.FirstOrDefault(x => Equals(x.Key, ViewLanguage)).Value;
        }

        private void CmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewLanguage = LangDics.FirstOrDefault(x => Equals(x.Value, cmbLanguage.SelectedItem)).Key; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Restore();
            InvokeSeted?.Invoke(sender, e);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            InvokeSeted?.Invoke(sender, e);
        }
    }
}
