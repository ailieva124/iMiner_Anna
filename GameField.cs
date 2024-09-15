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
    public partial class GameField : UserControl
    {
        private const int WinGame = 1, LooseGame = 0;
        internal const int NotStarted = 0, Running = 1, Paused = 2, Ended = -1;

        private readonly Field Fields;
        private readonly PictureBox[,] Grid;
        private Panel PannelInPause;
        private Menu MenuWnd;

        internal int GameStatus = NotStarted;
        private int ElapsedSeconds;

        public GameField(Menu menu)
        {
            InitializeComponent();
            MenuWnd = menu;
        }
        public GameField(Menu menu, int row, int col, int mines, int size, String bestScore) : this(menu)
        {
            lbBombs.Text = mines.ToString();
            lbBest.Text = $"Best: {bestScore}";

            Fields = new Field(row, col, mines);
            Grid = new PictureBox[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Grid[i,j] = new PictureBox()
                    {
                        Name = i + "," + j,
                        BackColor = Color.White,
                        Size = new Size(size, size),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(size * j, size * i)
                    };
                    Grid[i,j].MouseUp += new MouseEventHandler(Grid_MouseUp);

                    panFields.Size = new Size(col * size, row * size);
                    panFields.Controls.Add(Grid[i,j]);
                }

            this.ClientSize = new Size(col * size, panInfo.Height + panFields.Height);
            this.MinimumSize = this.Size;
            pbHelper.Location = new Point(panInfo.Width / 2, pbHelper.Location.Y);
        }

        private void GetHint(object sender, EventArgs e)
        {
            Random rand = new Random();
            do
            {
                int x = rand.Next(Grid.GetLength(0));
                int y = rand.Next(Grid.GetLength(1));

                if (Fields.IsMine(x, y))
                    continue;
                else if (Fields.IsFlagged(x, y))
                    continue;
                else if (Fields.IsDiscoveredSafeCell(x, y))
                    continue;
                else
                {
                    int minesCnt = Fields.CountMines(x, y);
                    if (minesCnt > 0)
                    {
                        Grid[x, y].BackColor = Color.LightGray;
                        Grid[x, y].Tag = minesCnt;
                        Grid[x, y].Image = (Image)Properties.Resources.ResourceManager.GetObject($"number{minesCnt}");
                        Fields.Discovered.Add(x * Grid.GetLength(1) + y);
                        if (Fields.IsWin())
                            EndGame(WinGame);
                        break;
                    }
                    else
                        continue;
                }
            } while (true);

        }
        private void Grid_MouseUp(object sender, MouseEventArgs e)
        {

            PictureBox pb = (PictureBox)sender;
            int pbSeparator = pb.Name.IndexOf(",");
            int pbX = int.Parse(pb.Name.Substring(0, pbSeparator));
            int pbY = int.Parse(pb.Name.Substring(pbSeparator + 1));

            if (GameStatus == NotStarted)
            {
                tClock.Start();
                GameStatus = Running;
                Fields.Initialize(pbX, pbY);
                DrawSafeCells(pbX, pbY);
                pbHelper.Visible = true;
                return;
            }
            else if (GameStatus == Ended)
                return;

            switch (e.Button)
            {
                // Click for dig
                case MouseButtons.Left:
                    if (Fields.IsFlagged(pbX,pbY))
                        break;
                    else if (Fields.IsMine(pbX, pbY))
                        EndGame(LooseGame);
                    else if (Fields.IsDiscoveredSafeCell(pbX, pbY))
                    {
                        HashSet<int> flagged;
                        int flagsCnt = Fields.CountFlags(pbX, pbY, out flagged);
                        int minesCnt = int.Parse(Grid[pbX, pbY].Tag.ToString());
                        if (flagsCnt == minesCnt)
                        {
                            foreach (int flag in flagged)
                                if (!Fields.IsMine(flag / Grid.GetLength(1), flag % Grid.GetLength(1)))
                                    return;

                            HashSet<int> safeCells = Fields.GetSafeNeighbors(pbX, pbY);
                            foreach( int cell in safeCells )
                            {
                                int x = cell / Grid.GetLength(1);
                                int y = cell % Grid.GetLength(1);
                                if(Fields.CountMines(x, y) == 0)
                                    DrawSafeCells(x, y);
                                else
                                {
                                    if(!Fields.IsDiscoveredSafeCell(x,y))
                                        Fields.Discovered.Add(cell);
                                    Grid[x, y].BackColor = Color.LightGray;
                                    minesCnt = Fields.CountMines(x, y);
                                    Grid[x, y].Tag = minesCnt;
                                    Grid[x, y].Image = (Image)Properties.Resources.ResourceManager.GetObject($"number{minesCnt}");
                                }
                            }
                        }
                    }
                    else DrawSafeCells(pbX, pbY);

                    if (Fields.IsWin()) EndGame(WinGame);
                    break;

                // Click for flag
                case MouseButtons.Right:
                    if(Fields.IsDiscoveredSafeCell(pbX, pbY))
                        break;

                    if (Fields.IsFlagged(pbX, pbY))
                    {
                        pb.BackColor = Color.White;
                        pb.Image = null;
                        Fields.Flagged.Remove(pbX * Grid.GetLength(1) + pbY);
                        lbBombs.Text = (int.Parse(lbBombs.Text) + 1).ToString();
                    }
                    else
                    {
                        pb.BackColor = Color.Green;
                        pb.Image = Properties.Resources.flag;
                        Fields.Flagged.Add(pbX * Grid.GetLength(1) + pbY);
                        lbBombs.Text = (int.Parse(lbBombs.Text) - 1).ToString();
                        if (int.Parse(lbBombs.Text) < 0)
                            lbBombs.ForeColor = Color.Red;
                    }
                    break;
            }
        }
        private void DrawSafeCells(int pbX, int pbY)
        {
            foreach (int safeCell in Fields.GetSafeIslind(pbX, pbY))
            {
                int i = safeCell / Grid.GetLength(1);
                int j = safeCell % Grid.GetLength(1);
                Grid[i,j].BackColor = Color.LightGray;
                int minesCnt = Fields.CountMines(i, j);
                if (minesCnt > 0)
                {
                    Grid[i,j].Tag = minesCnt;
                    Grid[i,j].Image = (Image)Properties.Resources.ResourceManager.GetObject($"number{minesCnt}");
                }
                else
                    Grid[i,j].Enabled = false;
            }
        }
        internal void Game_Pause(object sender, EventArgs e)
        {
            tClock.Stop();
            if (GameStatus == Running)
            {
                if (PannelInPause == null)
                {
                    PannelInPause = new Panel()
                    {
                        Dock = DockStyle.Fill,
                        BackColor = Color.FromArgb(128, 0, 0, 0)
                    };

                    PictureBox pbPause = new PictureBox()
                    {
                        Cursor = Cursors.Hand,
                        Size = new Size(300, 300),
                        BackColor = Color.Transparent,
                        Image = Properties.Resources.pause,
                        SizeMode = PictureBoxSizeMode.Zoom
                    };
                    pbPause.Click += Game_Resume;
                    PannelInPause.Controls.Add(pbPause);
                    panFields.Controls.Add(PannelInPause);
                    pbPause.Location = new Point((PannelInPause.Width - pbPause.Width) / 2, (PannelInPause.Height - pbPause.Height) / 2);
                    PannelInPause.BringToFront();
                }
                else
                    PannelInPause.Visible = true;
                GameStatus = Paused;
            }
        }
        internal void Game_Resume(object sender, EventArgs e)
        {
            if (PannelInPause != null)
            {
                GameStatus = Running;
                PannelInPause.Visible = false;
                tClock.Start();
            }
        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            ElapsedSeconds++;
            int min = ElapsedSeconds / 60;
            int sec = ElapsedSeconds % 60;
            lbTime.Text = $"{min:D2}:{sec:D2}";
        }
        private void EndGame(int exitCode)
        {
            tClock.Stop();
            if (exitCode == WinGame)
            {
                if(MenuWnd.AddRecordToList(Menu.GameMode, ElapsedSeconds))
                    this.lbBest.Text = $"Best: {Record.GetResult(ElapsedSeconds)}";
            }
            else
            {
                foreach (int mine in Fields.GetAllMines())
                {
                    int i = mine / Grid.GetLength(1);
                    int j = mine % Grid.GetLength(1);
                    Grid[i,j].BackColor = Color.Red;
                    Grid[i,j].Image = Properties.Resources.mine;
                }
            }
            GameStatus = Ended;
        }
        private void GameField_Leave(object sender, EventArgs e)
        {
            MenuWnd.Focus();
        }
    }
}
