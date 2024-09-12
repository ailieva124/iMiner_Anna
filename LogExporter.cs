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
    public partial class LogExporter : UserControl
    {
        private Menu MenuWnd;
        private StringBuilder LogData;
        bool isDataTheSame, isCheckedForSameData;
        static string EmptyHolder = "<<Empty>>";
        static string MsgsNo = "No messages", ErrorsNo = "No errors",
            MsgDataUpdated = "Data is successfully updated!", ErrorNoChanges = "No data changed!",
            ErrorDataWrong = "The data is not correct!\nPlease, do not edit it manually!";

        public LogExporter(Menu menu)
        {
            InitializeComponent();
            MenuWnd = menu;
            tbData.Text = $"Best Scores:\n" +
                $"Easy: 00:00\nMedium: 00:00\nHard: 00:00\n" +
                $"Records:\n{EmptyHolder}";
        }

        // Load Data
        public void GetActualLogData(object sender, EventArgs e)
        {
            lbMessages.Text = MsgsNo;
            lbError.Text = ErrorsNo;
            isCheckedForSameData = false;

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("Best Scores:");
            builder.AppendLine("========");
            builder.AppendLine($"Easy: {Score.GetResult(Menu.HiScore_Easy)}");
            builder.AppendLine($"Medium: {Score.GetResult(Menu.HiScore_Medium)}");
            builder.AppendLine($"Hard: {Score.GetResult(Menu.HiScore_Hard)}");
            builder.AppendLine();
            builder.AppendLine("Records:");
            builder.AppendLine("========");
            AppendRecords("Easy", Menu.RecordsEasy, builder);
            AppendRecords("Medium", Menu.RecordsMedium, builder);
            AppendRecords("Hard", Menu.RecordsHard, builder);

            LogData = builder;
            tbData.Text = LogData.ToString();
        }
        private static void AppendRecords(string title, List<Score> records, StringBuilder builder)
        {
            builder.AppendLine($"{title}:");
            if (records.Count == 0)
                builder.AppendLine($"   {EmptyHolder}");
            else
                foreach (Score record in records)
                    builder.AppendLine($" * {record.Player} - {Score.GetResult(record.Result)}");
        }

        // Buttons
        private void Copy(object sender, EventArgs e) => Clipboard.SetText(tbData.Text);
        private void Paste(object sender, EventArgs e)
        {
            tbData.Text = Clipboard.GetText();
            CheckForSameData();
        }
        private void UpdateData(object sender, EventArgs e)
        {
            if (!isCheckedForSameData) CheckForSameData();
            if (!isDataTheSame)
            {
                if (ValidateData(out int bestEasy, out int bestMedium, out int bestHard, out List<Score> easy, out List<Score> medium, out List<Score> hard))
                {
                    Menu.HiScore_Easy = bestEasy;
                    Menu.HiScore_Medium = bestMedium;
                    Menu.HiScore_Hard = bestHard;
                    Menu.RecordsEasy = easy;
                    Menu.RecordsMedium = medium;
                    Menu.RecordsHard = hard;
                    lbMessages.Text = MsgDataUpdated;
                    lbError.Text = ErrorsNo;
                }
                else
                {
                    lbMessages.Text = MsgsNo;
                    lbError.Text = ErrorDataWrong;
                }
            }
        }

        // Validations
        private void CheckForSameData() {
            isDataTheSame = LogData.Equals(tbData.Text);
            if (isDataTheSame)
            {
                lbMessages.Text = MsgsNo;
                lbError.Text = ErrorNoChanges;
            }
            else
            {
                lbMessages.Text = MsgsNo;
                lbError.Text = ErrorsNo;
                LogData = new StringBuilder(tbData.Text);
            }
            isCheckedForSameData = true;
        }
        private bool ValidateData(out int bestEasy, out int bestMedium, out int bestHard, out List<Score> easy, out List<Score> medium, out List<Score> hard)
        {
            bool hasFailed = false; int checkIndex = 0, refIndex = 7;
            bestEasy = 0; bestMedium = 0; bestHard = 0; easy = new List<Score>(); medium = easy; hard = easy;
            string[] lines = LogData.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            do
            {
                switch (checkIndex++)
                {
                    case 0:
                        hasFailed = !(lines[0] == "Best Scores:" || lines[1] == "========" || lines[5] == "Records:" || lines[6] == "========");
                        break;
                    case 1:
                        bestEasy = GetScore(lines[2], "Easy", out hasFailed);
                        break;
                    case 2:
                        bestMedium = GetScore(lines[3], "Medium", out hasFailed);
                        break;
                    case 3:
                        bestHard = GetScore(lines[4], "Hard", out hasFailed);
                        break;
                    case 4:
                        easy = GetListScores("Easy", lines, bestEasy, ref refIndex, out hasFailed);
                        break;
                    case 5:
                        medium = GetListScores("Medium", lines, bestMedium, ref refIndex, out hasFailed);
                        break;
                    case 6:
                        hard = GetListScores("Hard", lines, bestHard, ref refIndex, out hasFailed);
                        break;
                }
            }
            while ((checkIndex <= 6) && !hasFailed);
            return !hasFailed;
        }
        private int GetScore(string line, string level, out bool hasFailed)
        {
            hasFailed = false;
            int EllapsedSeconds = 0;
            string[] parts = line.Split(": ");
            if (parts.Length == 2 && parts[0].Trim() == level)
            {
                EllapsedSeconds = Score.SetResult(parts[1].Trim());
                if (EllapsedSeconds == 0)
                    hasFailed = true;
            }
            return EllapsedSeconds;
        }
        private List<Score> GetListScores(string difficulty, string[] lines, int best, ref int index, out bool hasFailed)
        {
            hasFailed = false;
            List<Score> records = new List<Score>();

            if (index < lines.Length - 1 && lines[index] == $"{difficulty}:") index++;
            if (lines[index].Contains(EmptyHolder) || lines[index].Equals("")) return records;
            while (index < lines.Length && lines[index].StartsWith(" * "))
            {
                string[] parts = lines[index++].Substring(3).Split('-', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                    records.Add(new Score(parts[0].Trim(), Score.SetResult(parts[1].Trim())));
            }
            if (best != 0 && records.Count == 0) hasFailed = true;

            return records;
        }

        // Leave Event
        private void LogExporter_Leave(object sender, EventArgs e) => MenuWnd.Focus();
    }
}
