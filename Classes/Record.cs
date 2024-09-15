using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMiner
{
    public class Record
    {
        public String plName = "";
        public int Result;

        public Record() { }

        public Record(string name, int score)
        {
            plName = name; Result = score;
        }
        
        public static int SetResult(string time)
        {
            int EllapsedSeconds = 0;

            if (Regex.IsMatch($"{time}", @"^\d{2}:\d{2}$"))
            {
                string[] parts = time.Split(":", StringSplitOptions.RemoveEmptyEntries);
                int minutes = int.Parse(parts[0].Trim());
                int sec = int.Parse(parts[1].Trim());
                EllapsedSeconds = sec + minutes * 60;
            }

            return EllapsedSeconds;
        }
        public static String GetResult(Record sc)
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
