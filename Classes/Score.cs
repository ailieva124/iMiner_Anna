using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMiner
{
    public class Score
    {
        public String Player;
        public int Result;

        public Score(string name, int score)
        {
            Player = name; Result = score;
        }

        public static String GetResult(Score sc)
        {
            int sec = sc.Result / 60;
            int min = sc.Result % 60;
            return $"{sec:D2}:{min:D2}";
        }
        public static String GetResult(int time)
        {
            int sec = time / 60;
            int min = time % 60;
            return $"{sec:D2}:{min:D2}";
        }
    }
}
