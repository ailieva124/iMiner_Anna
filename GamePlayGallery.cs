using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace iMiner
{
    public partial class GamePlayGallery : UserControl
    {
        private Menu MenuWnd;
        private Color ActiveColor = Color.Lavender;
        private Button BtnActiveSlide;
        internal static int GameplaySlide = 1;
        internal static string LangInfo = LangBG;
        internal const string LangBG = "BG", LangEN = "EN";

        public GamePlayGallery(Menu menu)
        {
            InitializeComponent();
            MenuWnd = menu;
        }

        private void GamePlayGallery_Load(object sender, EventArgs e)
        {
            this.Focus();
            lbLang.Text = LangInfo;
            BtnActiveSlide = btnSlide1;
            pbSlide.Image = (Image)Properties.Resources.ResourceManager.GetObject($"gameplay1_{LangInfo}");
        }

        private void ShowMenu(object sender, EventArgs e) => languageChoose.Show(lbLang, new Point(-90, 40));
        private void ChangeLang(object sender, EventArgs e)
        {
            ToolStripItem lang = (ToolStripItem)sender;
            if (lang.Name != LangInfo)
                ChangePhoto(lang.Name);
        }
        private void SetActiveLang(object sender, CancelEventArgs e)
        {
            if (LangInfo == LangEN)
            {
                EN.BackColor = ActiveColor;
                BG.BackColor = SystemColors.Control;
            }
            else
            {
                BG.BackColor = ActiveColor;
                EN.BackColor = SystemColors.Control;
            }
        }

        private void ChangePhoto(string NewLanguage = "")
        {
            if (NewLanguage != "")
            {
                LangInfo = NewLanguage;
                lbLang.Text = NewLanguage;
            }
            pbSlide.Image = (Image)Properties.Resources.ResourceManager.GetObject($"gameplay{GameplaySlide}_{LangInfo}");
            
            BtnActiveSlide.BackColor = SystemColors.Control;
            BtnActiveSlide.FlatStyle = FlatStyle.Flat;
            Control[] btns = this.Controls.Find($"btnSlide{GameplaySlide}", false);
            BtnActiveSlide = (Button)btns[0];
            BtnActiveSlide.BackColor = ActiveColor;
            BtnActiveSlide.FlatStyle = FlatStyle.Standard;
        }
        private void GoBack(object sender, EventArgs e)
        {
            GameplaySlide--;
            if (GameplaySlide < 1) GameplaySlide = 4;
            else if (GameplaySlide > 4) GameplaySlide = 1;
            ChangePhoto();
        }
        private void GoForward(object sender, EventArgs e)
        {
            GameplaySlide++;
            if (GameplaySlide < 1) GameplaySlide = 4;
            else if (GameplaySlide > 4) GameplaySlide = 1;
            ChangePhoto();
        }
        private void GoTo(object sender, EventArgs e)
        {
            Button slide = (Button)sender;
            GameplaySlide = int.Parse(slide.Text);
            ChangePhoto();
            pbSlide.Focus();
        }

        private void OpenWeb(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://minesweeper.online/help/patterns",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void GamePlayGallery_Leave(object sender, EventArgs e) => MenuWnd.Focus();
    }
}
