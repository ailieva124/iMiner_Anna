using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMiner
{
    class Field
    {
        private bool[][] MineMap { get; }
        private int Row { get; set; }
        private int Col { get; set; }
        private int Mines { get; set; }
        internal HashSet<int> Discovered { get; }
        internal HashSet<int> Flagged { get; }

        public Field(int row, int col, int mines)
        {
            Row = row;
            Col = col;
            Mines = mines;

            MineMap = new bool[row][];
            for (int i = 0; i < row; i++)
                MineMap[i] = new bool[col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    MineMap[i][j] = false;

            Discovered = new HashSet<int>();
            Flagged = new HashSet<int>();
        }

        internal void Initialize(int startX, int startY)
        {
            HashSet<int> mines = new HashSet<int>();
            Random rand = new Random();

            for (int cnt = 0; cnt < Mines;)
            {
                int i = rand.Next(Row);
                int j = rand.Next(Col);
                if (mines.Contains(i * Col + j)) continue;
                if (Math.Abs(i - startX) < 2 &&
                    Math.Abs(j - startY) < 2) continue;

                MineMap[i][j] = true;
                mines.Add(i * Col + j);
                cnt++;
            }
        }

        internal bool IsMine(int i, int j) => MineMap[i][j];

        internal bool Win() => Discovered.Count == (Row * Col) - Mines;

        internal int CountMines(int x, int y)
        {
            int count = 0;
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, Row - 1); i++)
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                    if (MineMap[i][j])
                        count++;
            return count;
        }

        public HashSet<int> GetNeighbors(int x, int y)
        {
            HashSet<int> cells = new HashSet<int>();
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, Row - 1); i++)
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                    if (i != x || j != y)
                        cells.Add(i * Col + j);
            return cells;
        }

        internal HashSet<int> GetSafeCells(int x, int y)
        {
            bool[][] visited = new bool[Row][];
            for (int i = 0; i < Row; i++)
                visited[i] = new bool[Col];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Col; j++)
                    visited[i][j] = false;
            visited[x][y] = true;

            HashSet<int> safeCells = new HashSet<int>();
            Queue<int> checking = new Queue<int>();
            checking.Enqueue(x * Col + y);
            while (checking.Count > 0)
            {
                int d = checking.Dequeue();
                safeCells.Add(d);
                Discovered.Add(d);
                if (CountMines(d / Col, d % Col) != 0) continue;

                foreach (int cell in GetNeighbors(d / Col, d % Col))
                    if (!visited[cell / Col][cell % Col])
                    {
                        visited[cell / Col][cell % Col] = true;
                        checking.Enqueue(cell);
                    }
            }
            return safeCells;
        }

        internal HashSet<int> GetAllMines()
        {
            HashSet<int> mines = new HashSet<int>();

            for (int cnt = 0; cnt < (Row * Col - Flagged.Count);)
            {
                for (int i = 0; i < Row; i++)
                    for (int j = 0; j < Col; j++)
                        if (cnt >= (Row * Col - Flagged.Count)) break;
                        else if (MineMap[i][j] && !Flagged.Contains(i * Col + j))
                        {
                            mines.Add(i * Col + j);
                            cnt++;
                        }
            }

            return mines;
        }
    }
}
