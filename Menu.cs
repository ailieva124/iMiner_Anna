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
        static readonly string AppTitle = "iMiner";
        internal static List<Record> RecordsEasy = new List<Record>(10);
        internal static List<Record> RecordsMedium = new List<Record>(10);
        internal static List<Record> RecordsHard = new List<Record>(10);
        internal static int HiScore_Easy = 0, HiScore_Medium = 0, HiScore_Hard = 0;

        internal static int GameMode = ModeMenu;
        internal const int ModeMenu = 0, ModeEasy = 1, ModeMedium = 2, ModeHard = 3, ModeRecords = 4, ModeLogData = 5, ModeGameplay = 6;

        PictureBox pbLogo;
        Button btnEasy, btnMedium, btnHard, btnRecords;

        GamePlayGallery gallery;
        LogExporter gameLog;
        GameField gameField;

        public Menu()
        {
            InitializeComponent();
            HomeScreenLoad();
            gameLog = new LogExporter(this);
            gallery = new GamePlayGallery(this);
            gameField = new GameField(this);
        }

        private void HomeScreenLoad()
        {
            pbLogo = new PictureBox()
            {
                BackgroundImageLayout = ImageLayout.None,
                Image = Properties.Resources.logo_2,
                Size = panControls.Size,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            btnEasy = DrawHomeBtns("Easy", Color.Teal);
            btnMedium = DrawHomeBtns("Medium", Color.Tomato);
            btnHard = DrawHomeBtns("Hard", Color.MediumVioletRed);
            btnRecords = DrawHomeBtns("Records", Color.SteelBlue);

            int i = 0;
            CenterX_PanControls((btnEasy), 256 + (90 * i++));
            CenterX_PanControls((btnMedium), 256 + (90 * i++));
            CenterX_PanControls((btnHard), 256 + (90 * i++));
            CenterX_PanControls((btnRecords), 256 + (90 * i++));

            panControls.Controls.Add(btnEasy);
            panControls.Controls.Add(btnMedium);
            panControls.Controls.Add(btnHard);
            panControls.Controls.Add(btnRecords);
            panControls.Controls.Add(pbLogo);
        }
        private Button DrawHomeBtns(string title, Color foreColor)
        {

            Button btn = new Button()
            {
                Text = title,
                Name = $"btn{title}",
                ForeColor = foreColor,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,
                BackColor = SystemColors.Info,
                Size = new Size(246, 71),
                ImeMode = ImeMode.NoControl,
                UseVisualStyleBackColor = false,
                BackgroundImageLayout = ImageLayout.None,
                Font = new Font("Snap ITC", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
            };
            btn.Click += new EventHandler(this.HomeBtns_Click);

            return btn;
        }
        public bool AddRecordToList(int levelType, int newRecord)
        {
            switch (levelType)
            {
                case ModeEasy:
                    return AddRecord(newRecord, RecordsEasy, ref HiScore_Easy);
                case ModeMedium:
                    return AddRecord(newRecord, RecordsMedium, ref HiScore_Medium);
                case ModeHard:
                    return AddRecord(newRecord, RecordsHard, ref HiScore_Hard);
                default:
                    return false;
            }
        }
        public bool AddRecord(int newScore, List<Record> listScores, ref int bestScore)
        {
            NewRecord askForName = new NewRecord();
            bool doAdd = false;

            if (bestScore == 0)
            {
                askForName.isFirstRecord = true;
                if (askForName.ShowDialog() == DialogResult.OK)
                    doAdd = true;
            }
            else if (newScore < bestScore)
                if (askForName.ShowDialog() == DialogResult.OK)
                    doAdd = true;

            if (doAdd)
            {
                bestScore = newScore;
                askForName.Score = newScore;
                listScores.Add(askForName.playerRecord);
                if (listScores.Count > 1)
                    listScores.Sort(delegate (Record c1, Record c2) { return c1.Result.CompareTo(c2.Result); });
                gameLog.doAskForExport = true;
            }

            return doAdd;
        }
        private bool doExitRunningGame(string msgTitle = "Exit")
        {
            bool modeRunning = (gameField.GameStatus == GameField.Running);
            bool modePaused = (gameField.GameStatus == GameField.Paused);
            if (modeRunning || modePaused)
            {
                if (modeRunning)
                    gameField.Game_Pause(null, null);
                DialogResult question = MessageBox.Show("Game proccess will be lost!\nDo you want to continue?",
                    msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.No)
                {
                    if (!modePaused) // if it was running, go back to running
                        gameField.Game_Resume(null, null);
                    return false; // Game still running
                }
                gameField.GameStatus = GameField.Ended;
            }
            return true; // Game is ended or not started
        }
        private void CenterX_PanControls(object control, int right = 0)
        {
            Control c = (Control)control;
            int x = (panControls.Width - c.Width) / 2;
            if (right != 0)
                x += 350;
            c.Location = new Point(x, right);
        }
        private void HomeBtns_Click(object sender, EventArgs e)
        {
            Button levelType = (Button)sender;
            switch (levelType.Text)
            {
                case "Easy":
                case "Medium":
                case "Hard":
                    NewGame_InitialiseWindow(levelType.Text);
                    break;
                case "Records":
                    ShowRecords(sender, e);
                    break;
            }
        }

        // MenuStrip Events
        private void ReturnToHome(object sender, EventArgs e)
        {
            if (GameMode != ModeMenu)
            {
                if (!doExitRunningGame()) return;
                panControls.Controls.Clear();
                HomeScreenLoad();
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
        private void NewGame(object sender, EventArgs e)
        {
            ToolStripMenuItem tsOption = (ToolStripMenuItem)sender;

            if (!doExitRunningGame("New game")) return;
            NewGame_InitialiseWindow(tsOption.Text);

        }
        private void NewGame_InitialiseWindow(string difficulty)
        {
            int row = 0, col = 0, bombs = 0, bestScore = 0;
            switch (difficulty)
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
            gameField = new GameField(this, row, col, bombs, size, Record.GetResult(bestScore));
            CenterX_PanControls(gameField);

            lbClose.Visible = true;
            panControls.Controls.Clear();
            panControls.Controls.Add(gameField);
            this.Text = AppTitle + " - " + difficulty;
        }
        private void GamePlayInfo(object sender, EventArgs e)
        {
            if (!doExitRunningGame()) return;

            GameMode = ModeGameplay;
            lbClose.Visible = true;
            CenterX_PanControls(gallery);
            panControls.Controls.Clear();
            panControls.Controls.Add(gallery);
            this.Text = AppTitle + " - Gameplay";
        }
        private void PauseGame(object sender, EventArgs e)
        {
            if (gameField.GameStatus == GameField.Paused)
                gameField.Game_Resume(sender, e);
            else
                gameField.Game_Pause(sender, e);
        }
        private void ShowRecords(object sender, EventArgs e)
        {
            if (GameMode == ModeRecords) return;
            else if (!doExitRunningGame()) return;

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
        public static ListView SetListView(List<Record> listData)
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
                Record record = listData.ElementAt(i);
                lvItems[i] = new ListViewItem(new string[] { "#" + (i + 1), record.plName, Record.GetResult(record) });
            }
            lvRecords.Items.AddRange(lvItems);

            return lvRecords;
        }
        private void Log_Export_Import(object sender, EventArgs e)
        {
            if (!doExitRunningGame()) return;
            CenterX_PanControls(gameLog);
            gameLog.GetActualLogData(null, null);

            if (gameLog.doExit)
            {
                gameLog.Copy(sender, e);
                MessageBox.Show("The data is in your clipboard!", "Export done!");
            }
            else
            {
                lbClose.Visible = true;
                GameMode = ModeLogData;
                panControls.Controls.Clear();
                panControls.Controls.Add(gameLog);
                this.Text = AppTitle + " - Log Exporter";
            }
        }
        private void Exit_iMiner(object sender, EventArgs e) => this.Close();

        // Menu Events
        private void Menu_Resize(object sender, EventArgs e)
        {
            if (GameMode == ModeMenu)
            {
                CenterX_PanControls(pbLogo);
                int i = 0;
                CenterX_PanControls((btnEasy), 256 + (90 * i++));
                CenterX_PanControls((btnMedium), 256 + (90 * i++));
                CenterX_PanControls((btnHard), 256 + (90 * i++));
                CenterX_PanControls((btnRecords), 256 + (90 * i++));
            }
            else if (GameMode == ModeEasy || GameMode == ModeMedium || GameMode == ModeHard)
                CenterX_PanControls(gameField);
            else if (GameMode == ModeLogData)
                CenterX_PanControls(gameLog);
            else if (GameMode == ModeGameplay)
                CenterX_PanControls(gallery);

            lbClose.Location = new Point(this.Width - 55, 5);
        }
        private void Menu_Closing(object sender, FormClosingEventArgs e)
        {
            if (!doExitRunningGame())
            {
                e.Cancel = true;
                return;
            }
            if (!gameLog.doAskForExport) return;
            switch (MessageBox.Show("To prevent loosing all of your data\nwhould you like to export the records log?",
                "Export log", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    gameLog.doExit = true;
                    Log_Export_Import(sender, e);
                    return;
                case DialogResult.Cancel:
                    ReturnToHome(sender, e);
                    e.Cancel = true;
                    return;
            }
        }
    }
}
