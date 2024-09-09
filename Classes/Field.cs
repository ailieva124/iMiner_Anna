using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMiner
{
    class Field
    {
        private int Row, Col, Mines;
        private readonly bool[,] MineMap;
        internal readonly HashSet<int> Discovered, Flagged;

        public Field(int row, int col, int mines)
        {
            Row = row; Col = col; Mines = mines;
            MineMap = new bool[row, col];
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
                if (mines.Contains(i * Col + j) ||
                   (Math.Abs(i - startX) < 2 && Math.Abs(j - startY) < 2))
                    continue;

                MineMap[i,j] = true;
                mines.Add(i * Col + j);
                cnt++;
            }
        }

        // Булевите функции представляват абстракция, водят до яснота и преизползване на кода.
        internal bool IsMine(int x, int y) => MineMap[x,y];
        internal bool IsWin() => Discovered.Count == (Row * Col) - Mines;
        internal bool IsFlagged(int x, int y) => Flagged.Contains(x * Col + y);
        internal bool IsDiscoveredSafeCell(int x, int y) => Discovered.Contains(x * Col + y);

        internal int CountMines(int x, int y)
        {
            int count = 0;
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, Row - 1); i++)
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                    if (IsMine(i, j))
                        count++;
            return count;
        }
        internal int CountFlags(int x, int y, out HashSet<int> flagged)
        {
            flagged = new HashSet<int>();
            int count = 0;
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, Row - 1); i++)
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                    if (IsFlagged(i, j))
                    {
                        count++;
                        flagged.Add(i * Col + j);
                    }
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
        public HashSet<int> GetSafeNeighbors(int x, int y)
        {
            HashSet<int> cells = new HashSet<int>();
            for (int i = Math.Max(x - 1, 0); i <= Math.Min(x + 1, Row - 1); i++)
                for (int j = Math.Max(y - 1, 0); j <= Math.Min(y + 1, Col - 1); j++)
                    if (i != x || j != y)
                    {
                        if (!IsMine(i, j) && !IsDiscoveredSafeCell(i,j))
                            cells.Add(i * Col + j);
                    }
            return cells;
        }
        internal HashSet<int> GetSafeIslind(int x, int y)
        {
            bool[,] visited = new bool[Row,Col];
            visited[x,y] = true;

            HashSet<int> safeCells = new HashSet<int>();
            Queue<int> checking = new Queue<int>();
            checking.Enqueue(x * Col + y);
            while (checking.Count > 0)
            {
                int check = checking.Dequeue();
                safeCells.Add(check);
                Discovered.Add(check);
                if (CountMines(check / Col, check % Col) != 0) continue;

                foreach (int cell in GetNeighbors(check / Col, check % Col))
                    if (!visited[cell / Col, cell % Col])
                    {
                        visited[cell / Col, cell % Col] = true;
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
                        else if (MineMap[i,j] && !Flagged.Contains(i * Col + j))
                        {
                            mines.Add(i * Col + j);
                            cnt++;
                        }
            }

            return mines;
        }
    }
}
