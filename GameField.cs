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
        private readonly PictureBox[][] Grid;

        internal int GameStatus = NotStarted;
        private int ElapsedSeconds;

        public GameField() => InitializeComponent();
        public GameField(int row, int col, int mines, int size, String bestScore) : this()
        {
            lbBombs.Text = mines.ToString();
            lbBest.Text = $"Best: {bestScore}";

            Fields = new Field(row, col, mines);

            Grid = new PictureBox[row][];
            for (int i = 0; i < row; i++)
                Grid[i] = new PictureBox[col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {
                    Grid[i][j] = new PictureBox()
                    {
                        Name = i + "," + j,
                        BackColor = Color.White,
                        Size = new Size(size, size),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(size * j, size * i)
                    };
                    Grid[i][j].MouseUp += new MouseEventHandler(Grid_MouseUp);

                    panFields.Size = new Size(col * size, row * size);
                    panFields.Controls.Add(Grid[i][j]);
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
                    if (Grid[pbX][pbY].Image == (Image)Properties.Resources.mine)
                        return; // To-do

                    if (Fields.IsMine(pbX, pbY))
                        EndGame(LooseGame);

                    if (Fields.Discovered.Contains(pbX * Grid[0].Length + pbY))
                    {
                        int mines = Fields.CountMines(pbX, pbY);
                        int temps = int.Parse(Grid[pbX][pbY].Tag.ToString());
                        if (mines == temps)
                            DrawSafeCells(pbX, pbY);

                    }
                    else DrawSafeCells(pbX, pbY);

                    if (Fields.Win()) EndGame(WinGame);
                    break;
                case MouseButtons.Right:
                    if (Fields.Flagged.Contains(pbX * Grid[0].Length + pbY))
                    {
                        pb.BackColor = Color.White;
                        pb.Image = null;
                        Fields.Flagged.Remove(pbX * Grid[0].Length + pbY);
                        lbBombs.Text = (int.Parse(lbBombs.Text) + 1).ToString();
                    }
                    else
                    {
                        pb.BackColor = Color.Green;
                        pb.Image = Properties.Resources.mine;
                        Fields.Flagged.Add(pbX * Grid[0].Length + pbY);
                        lbBombs.Text = (int.Parse(lbBombs.Text) - 1).ToString();
                    }
                    break;
            }
        }
        private void DrawSafeCells(int pbX, int pbY)
        {
            foreach (int safeCell in Fields.GetSafeCells(pbX, pbY))
            {
                int i = safeCell / Grid[0].Length;
                int j = safeCell % Grid[0].Length;
                Grid[i][j].BackColor = Color.LightGray;
                int minesCnt = Fields.CountMines(i, j);
                if (minesCnt > 0)
                {
                    Grid[i][j].Tag = minesCnt;
                    Grid[i][j].Image = (Image)Properties.Resources.ResourceManager.GetObject($"number{minesCnt}");
                }
                else
                    Grid[i][j].Enabled = false;
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
                Menu.AddRecordToList(Menu.ModeEasy, new Score("Player1", ElapsedSeconds));
                MessageBox.Show("You discovered all safe squares!", "Victory");
            }
            else
            {
                foreach (int mine in Fields.GetAllMines())
                {
                    int i = mine / Grid[0].Length;
                    int j = mine % Grid[0].Length;
                    Grid[i][j].BackColor = Color.Red;
                    Grid[i][j].Image = (Image)Properties.Resources.mine;
                }
                MessageBox.Show("You clicked on a mine!", "Game Over");
            }
            GameStatus = Ended;
        }
    }
}
