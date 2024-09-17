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
    public partial class NewRecord : Form
    {
        bool isNameValid, isSubmiting;
        public bool isFirstRecord;
        public readonly Record playerRecord = new Record();

        const int minChars = 3, maxChars = 18;
        static string lastUsedName = "I_AM_MINER";
        static AutoCompleteStringCollection listNames = new AutoCompleteStringCollection();

        public int Score
        {
            get { return playerRecord.Result; }
            set { playerRecord.Result = value; }
        }
        private string PlayerName
        {
            set
            {
                if (value.Length >= minChars && value.Length <= maxChars)
                {
                    playerRecord.plName = value;
                    isNameValid = true;
                }
                else
                {
                    MsgWrongData();
                    isNameValid = false;
                    tbNameInput.Focus();
                }
            }
        }

        public NewRecord()
        {
            InitializeComponent();
            tbNameInput.MaxLength = maxChars;
            tbNameInput.AutoCompleteCustomSource = listNames;
            listNames.Add(lastUsedName);
        }

        private void On_Load(object sender, EventArgs e)
        {
            if (isFirstRecord)
                this.Text = "First record for this category!";
            tbNameInput.Text = lastUsedName;
        }

        private void MsgWrongData()
        {
            MessageBox.Show($"Please use from {minChars} to {maxChars} letters", "Invalid Player Name!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Input_FirstClick(object sender, EventArgs e)
        {
            tbNameInput.Text = "";
            tbNameInput.TabStop = true;
            tbNameInput.Click -= Input_FirstClick;
        }
        private void Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Submit(sender, e);
        }

        private void Submit(object sender, EventArgs e)
        {
            PlayerName = tbNameInput.Text;
            isSubmiting = true;
            this.Close();
        }

        private void On_Close(object sender, FormClosingEventArgs e)
        {
            if (isSubmiting)
            {
                if (!isNameValid)
                    e.Cancel = true;
                else
                {
                    lastUsedName = playerRecord.plName;
                    listNames.Add(lastUsedName);
                }
                isSubmiting = false;
            }
        }
    }
}