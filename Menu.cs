using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iMiner
{
    public partial class Menu : Form
    {
        static readonly String AppTitle = "iMiner";
        static readonly List<Score> RecordsEasy = new List<Score>(10);
        static readonly List<Score> RecordsMedium = new List<Score>(10);
        static readonly List<Score> RecordsHard = new List<Score>(10);
        static int HiScore_Easy = 0, HiScore_Medium = 0, HiScore_Hard = 0;

        internal static int GameMode = ModeMenu;
        internal const int ModeMenu = 0, ModeEasy = 1, ModeMedium = 2, ModeHard = 3, ModeRecords = 4;

        PictureBox pbLogo;
        GameField gameField = new GameField();

        public Menu()
        {
            InitializeComponent();
            HomeLogoLoad();
            AddRecordToList(ModeEasy, new Score("Clery", 500));
            AddRecordToList(ModeEasy, new Score("Sasha", 400));
            AddRecordToList(ModeEasy, new Score("Lila", 300));
            AddRecordToList(ModeEasy, new Score("Misha", 200));
            AddRecordToList(ModeEasy, new Score("Clear", 110));
            AddRecordToList(ModeEasy, new Score("Samanta", 10));
            
            AddRecordToList(ModeMedium, new Score("Sasha", 400));
            AddRecordToList(ModeMedium, new Score("Misha", 200));
            AddRecordToList(ModeMedium, new Score("Martina", 100));
            AddRecordToList(ModeMedium, new Score("Samanta", 10));
            
            AddRecordToList(ModeHard, new Score("Clear", 500));
            AddRecordToList(ModeHard, new Score("Lila", 300));
        }

        private void HomeLogoLoad()
        {
            pbLogo = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.None,
                Image = Properties.Resources.logo,
                Location = new Point(0, 0),
                Size = panControls.Size,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            this.panControls.Controls.Add(pbLogo);
        }
        public static bool AddRecordToList(int levelType, Score newRecord)
        {
            bool isNewBestAdded = false;
            int scoreInSeconds = newRecord.Result;

            switch (levelType)
            {
                case ModeEasy:
                    if (HiScore_Easy == 0) HiScore_Easy = scoreInSeconds;
                    if (scoreInSeconds <= HiScore_Easy)
                    {
                        RecordsEasy.Add(newRecord);
                        if (RecordsEasy.Count > 1)
                            RecordsEasy.Sort(delegate (Score c1, Score c2) { return c1.Result.CompareTo(c2.Result); });
                        HiScore_Easy = scoreInSeconds;
                        isNewBestAdded = true;
                    }
                    break;
                case ModeMedium:
                    if (HiScore_Medium == 0) HiScore_Medium = scoreInSeconds;
                    if (scoreInSeconds <= HiScore_Medium)
                    {
                        RecordsMedium.Add(newRecord);
                        if (RecordsMedium.Count > 1)
                            RecordsMedium.Sort(delegate (Score c1, Score c2) { return c1.Result.CompareTo(c2.Result); });
                        HiScore_Medium = scoreInSeconds;
                        isNewBestAdded = true;
                    }
                    break;
                case ModeHard:
                    if (HiScore_Hard == 0) HiScore_Hard = scoreInSeconds;
                    if (scoreInSeconds <= HiScore_Hard)
                    {
                        RecordsHard.Add(newRecord);
                        if (RecordsHard.Count > 1)
                            RecordsHard.Sort(delegate (Score c1, Score c2) { return c1.Result.CompareTo(c2.Result); });
                        HiScore_Hard = scoreInSeconds;
                        isNewBestAdded = true;
                    }
                    break;
            }

            return isNewBestAdded;
        }
        private bool doExitRunningGame(string msgTitle = "Exit")
        {
            if (gameField.GameStatus == GameField.Running || gameField.GameStatus == GameField.Paused)
            {
                if(gameField.GameStatus == GameField.Running)
                    gameField.Game_Pause(null, null);
                DialogResult question = MessageBox.Show("Game proccess will be lost!\nDo you want to continue?",
                    msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.No)
                {
                    if(gameField.GameStatus != GameField.Paused)
                        gameField.Game_Resume(null, null);
                    return false; // Game still running
                }
                gameField.GameStatus = GameField.Ended;
            }
            return true; // Game is ended or not started
        }

        // MenuStrip Events
        private void ReturnToHome(object sender, EventArgs e)
        {
            if (GameMode != ModeMenu)
            {
                if (!doExitRunningGame()) return;
                panControls.Controls.Clear();
                HomeLogoLoad();
                lbClose.Visible = false;
                GameMode = ModeMenu;
                this.Text = AppTitle;
            }
        }
        private void About_iMiner(object sender, EventArgs e)
        {
            About info = new About();
            info.ShowDialog();
        }
        private void Exit_iMiner(object sender, EventArgs e)
        {
            if (!doExitRunningGame()) return;
            this.Close(); // Menu_Closing is asking for Log Export
        }
        private void StartGame(object sender, EventArgs e)
        {
            ToolStripMenuItem tsOption = (ToolStripMenuItem)sender;
            
            if(!doExitRunningGame("New game")) return;

            int row = 0, col = 0, bombs = 0, bestScore = 0;
            switch (tsOption.Text)
            {
                case "Easy":
                    GameMode = ModeEasy;
                    row = col = 16;
                    bombs = 13;
                    bestScore = HiScore_Easy;
                    break;
                case "Medium":
                    GameMode = ModeMedium;
                    row = col = 18;
                    bombs = 28;
                    bestScore = HiScore_Medium;
                    break;
                case "Hard":
                    GameMode = ModeHard;
                    row = col = 20;
                    bombs = 50;
                    bestScore = HiScore_Hard;
                    break;
            }
            int size = Math.Min(40, 1000 / Math.Max(row, col));
            gameField = new GameField(row, col, bombs, size, Score.GetResult(bestScore));
            gameField.Location = new Point((panControls.Width - gameField.Width) / 2, 0);

            lbClose.Visible = true;
            panControls.Controls.Clear();
            panControls.Controls.Add(gameField);
            this.Text = AppTitle + " - " + tsOption.Text;
        }
        private void GamePlayInfo(object sender, EventArgs e)
        {
            // To-do
        }
        private void PauseGame(object sender, EventArgs e)
        {
            gameField.Game_Pause(sender, e);
        }
        private void ShowRecords(object sender, EventArgs e)
        {
            if (GameMode == ModeRecords) return;
            else if(!doExitRunningGame()) return;

            GameMode = ModeRecords;
            lbClose.Visible = true;
            TabControl tcRecords = new TabControl();
            TabPage tpEasy = new TabPage("Easy"),
                tpMedium = new TabPage("Medium"),
                tpHard = new TabPage("Hard");

            tpEasy.Controls.Add(SetListView(RecordsEasy));
            tpMedium.Controls.Add(SetListView(RecordsMedium));
            tpHard.Controls.Add(SetListView(RecordsHard));

            tcRecords.TabPages.Add(tpEasy);
            tcRecords.TabPages.Add(tpMedium);
            tcRecords.TabPages.Add(tpHard);

            tcRecords.Dock = DockStyle.Fill;
            tcRecords.Alignment = TabAlignment.Bottom;
            panControls.Controls.Clear();
            panControls.Controls.Add(tcRecords);
            this.Text = AppTitle + " - Records";
        }
        public ListView SetListView(List<Score> listData)
        {
            ListView lvRecords = new ListView
            {
                BackColor = SystemColors.Info,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Historic", 13.8F),
                ForeColor = SystemColors.InfoText,
                FullRowSelect = true,
                View = View.Details
            };

            lvRecords.Columns.AddRange(new ColumnHeader[] {
                new ColumnHeader { Text = "", Width = 100 },
                new ColumnHeader { Text = "Name", Width = 400 },
                new ColumnHeader { Text = "Score", Width = 100 }
            });

            ListViewItem[] lvItems = new ListViewItem[listData.Count];
            for (int i = 0; i < listData.Count; i++)
            {
                Score record = listData.ElementAt(i);
                lvItems[i] = new ListViewItem(new string[] { "#" + (i + 1), record.Player, Score.GetResult(record) });
            }
            lvRecords.Items.AddRange(lvItems);

            return lvRecords;
        }
        private void LogExport(object sender, EventArgs e)
        {
            ToolStripMenuItem tsOption = (ToolStripMenuItem)sender;

            Clipboard.SetText("No data still!"); // To-do
            if (tsOption.Text != "Exit")
                MessageBox.Show("The data is in your clipboard!", "Export done");
            else
            {
                MessageBox.Show("The data is in your clipboard!\nWish you all the best!", "Export done");
                this.Close();
            }
        }
        private void LogImport(object sender, EventArgs e)
        {
            bool isValidData = false;
            DialogResult result = MessageBox.Show("Please, coppy the data you want to import,\nthen click \"Ok\"",
                "Importing", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                // To-do: isValidData logic for true

                if (isValidData)
                    MessageBox.Show(Clipboard.GetText(), "Ready!");
                else
                {
                    result = MessageBox.Show("No proper data!", "Error occured",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Retry)
                        LogImport(sender, e);
                }
            }
        }

        // Menu Events
        private void Menu_Resize(object sender, EventArgs e)
        {
            if (GameMode == ModeMenu)
                pbLogo.Size = panControls.Size;
            else if (GameMode == ModeEasy || GameMode == ModeMedium || GameMode == ModeHard)
                gameField.Location = new Point((panControls.Width - gameField.Width) / 2, 0);
            lbClose.Location = new Point(this.Width - 55, 5);
        }
        private void Menu_Closing(object sender, FormClosingEventArgs e)
        {
            if (!doExitRunningGame())
            {
                e.Cancel = true;
                return;
            }
            switch (MessageBox.Show("To prevent loosing all of your data\nwhould you like to export the records log?",
                "Export log", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    LogExport(sender, e);
                    return;
                case DialogResult.Cancel:
                    ReturnToHome(sender, e);
                    e.Cancel = true;
                    return;
            }
        }
    }
}
