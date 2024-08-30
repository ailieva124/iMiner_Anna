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
        internal const int NotStarted = 0, Running = 1, Ended = -1;

        private readonly Field Fields;
        private readonly PictureBox[,] Grid;

        internal int GameStatus = NotStarted;
        private int ElapsedSeconds;

        public GameField() => InitializeComponent();
        public GameField(int row, int col, int mines, int size, String bestScore) : this()
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

            this.ClientSize = new Size(col * size, panGameInfo.Height + panFields.Height);
            this.MinimumSize = this.Size;
            panGameInfo.Location = new Point((this.ClientSize.Width - panGameInfo.Width) / 2, panGameInfo.Location.Y);
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
                return;
            }
            else if (GameStatus == Ended)
                return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (Fields.IsFlagged(pbX,pbY))
                        break;
                    else if (Fields.IsMine(pbX, pbY))
                        EndGame(LooseGame);
                    else if (Fields.IsDiscoveredSafeCell(pbX, pbY))
                    {
                        int flagsCnt = Fields.CountFlags(pbX, pbY);
                        int minesCnt = int.Parse(Grid[pbX, pbY].Tag.ToString());
                        if (flagsCnt == minesCnt)
                        {
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
                        pb.Image = Properties.Resources.mine;
                        Fields.Flagged.Add(pbX * Grid.GetLength(1) + pbY);
                        lbBombs.Text = (int.Parse(lbBombs.Text) - 1).ToString();
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
                if(Menu.AddRecordToList(Menu.GameMode, new Score("Player1", ElapsedSeconds)))
                    this.lbBest.Text = $"Best: {Score.GetResult(ElapsedSeconds)}";
                MessageBox.Show("You discovered all safe squares!", "Victory");
            }
            else
            {
                foreach (int mine in Fields.GetAllMines())
                {
                    int i = mine / Grid.GetLength(1);
                    int j = mine % Grid.GetLength(1);
                    Grid[i,j].BackColor = Color.Red;
                    Grid[i,j].Image = (Image)Properties.Resources.mine;
                }
                MessageBox.Show("You clicked on a mine!", "Game Over");
            }
            GameStatus = Ended;
        }
    }
}
