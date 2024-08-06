
namespace iMiner
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGamePlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.panControls = new System.Windows.Forms.Panel();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnFame = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnEasy = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuGame,
            this.menuRecords,
            this.menuFormInfo});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(996, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSettings,
            this.menuAbout,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuSettings
            // 
            this.menuSettings.Name = "menuSettings";
            this.menuSettings.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuSettings.Size = new System.Drawing.Size(203, 26);
            this.menuSettings.Text = "Settings";
            this.menuSettings.Click += new System.EventHandler(this.ShowSettings);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAbout.Size = new System.Drawing.Size(203, 26);
            this.menuAbout.Text = "About iMiner";
            this.menuAbout.Click += new System.EventHandler(this.AboutGame);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuExit.Size = new System.Drawing.Size(203, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.ExitGame);
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuGamePlay});
            this.menuGame.Name = "menuGame";
            this.menuGame.Size = new System.Drawing.Size(62, 24);
            this.menuGame.Text = "Game";
            // 
            // menuNew
            // 
            this.menuNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEasy,
            this.menuMedium,
            this.menuHard});
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(218, 26);
            this.menuNew.Text = "New Game";
            // 
            // menuEasy
            // 
            this.menuEasy.Name = "menuEasy";
            this.menuEasy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEasy.Size = new System.Drawing.Size(202, 26);
            this.menuEasy.Text = "Easy";
            this.menuEasy.Click += new System.EventHandler(this.StartGame);
            // 
            // menuMedium
            // 
            this.menuMedium.Name = "menuMedium";
            this.menuMedium.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuMedium.Size = new System.Drawing.Size(202, 26);
            this.menuMedium.Text = "Medium";
            this.menuMedium.Click += new System.EventHandler(this.StartGame);
            // 
            // menuHard
            // 
            this.menuHard.Name = "menuHard";
            this.menuHard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuHard.Size = new System.Drawing.Size(202, 26);
            this.menuHard.Text = "Hard";
            this.menuHard.Click += new System.EventHandler(this.StartGame);
            // 
            // menuGamePlay
            // 
            this.menuGamePlay.Name = "menuGamePlay";
            this.menuGamePlay.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuGamePlay.Size = new System.Drawing.Size(218, 26);
            this.menuGamePlay.Text = "GamePlay";
            this.menuGamePlay.Click += new System.EventHandler(this.GamePlayInfo);
            // 
            // menuRecords
            // 
            this.menuRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRecShow,
            this.menuRecExport,
            this.menuRecImport});
            this.menuRecords.Name = "menuRecords";
            this.menuRecords.Size = new System.Drawing.Size(76, 24);
            this.menuRecords.Text = "Records";
            // 
            // menuRecShow
            // 
            this.menuRecShow.Name = "menuRecShow";
            this.menuRecShow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRecShow.Size = new System.Drawing.Size(255, 26);
            this.menuRecShow.Text = "Show Log";
            this.menuRecShow.Click += new System.EventHandler(this.ShowRecords);
            // 
            // menuRecExport
            // 
            this.menuRecExport.Name = "menuRecExport";
            this.menuRecExport.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuRecExport.Size = new System.Drawing.Size(255, 26);
            this.menuRecExport.Text = "Export Log";
            this.menuRecExport.Click += new System.EventHandler(this.LogExport);
            // 
            // menuRecImport
            // 
            this.menuRecImport.Name = "menuRecImport";
            this.menuRecImport.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.menuRecImport.Size = new System.Drawing.Size(255, 26);
            this.menuRecImport.Text = "Import Log";
            this.menuRecImport.Click += new System.EventHandler(this.LogImport);
            // 
            // menuFormInfo
            // 
            this.menuFormInfo.Name = "menuFormInfo";
            this.menuFormInfo.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuFormInfo.Size = new System.Drawing.Size(105, 24);
            this.menuFormInfo.Text = "GetThisSizes";
            this.menuFormInfo.Click += new System.EventHandler(this.GetWindowSize);
            // 
            // panControls
            // 
            this.panControls.Controls.Add(this.btnHard);
            this.panControls.Controls.Add(this.btnFame);
            this.panControls.Controls.Add(this.btnMedium);
            this.panControls.Controls.Add(this.btnEasy);
            this.panControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControls.Location = new System.Drawing.Point(0, 28);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(996, 871);
            this.panControls.TabIndex = 2;
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.SystemColors.Info;
            this.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHard.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnHard.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHard.Location = new System.Drawing.Point(339, 451);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(324, 71);
            this.btnHard.TabIndex = 7;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Visible = false;
            // 
            // btnFame
            // 
            this.btnFame.BackColor = System.Drawing.SystemColors.Info;
            this.btnFame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFame.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFame.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnFame.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFame.Location = new System.Drawing.Point(340, 525);
            this.btnFame.Name = "btnFame";
            this.btnFame.Size = new System.Drawing.Size(324, 71);
            this.btnFame.TabIndex = 8;
            this.btnFame.Text = "Records";
            this.btnFame.UseVisualStyleBackColor = false;
            this.btnFame.Visible = false;
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.SystemColors.Info;
            this.btnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMedium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMedium.ForeColor = System.Drawing.Color.Tomato;
            this.btnMedium.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMedium.Location = new System.Drawing.Point(339, 378);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(324, 71);
            this.btnMedium.TabIndex = 6;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Visible = false;
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.SystemColors.Info;
            this.btnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEasy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEasy.ForeColor = System.Drawing.Color.Teal;
            this.btnEasy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEasy.Location = new System.Drawing.Point(339, 305);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(324, 71);
            this.btnEasy.TabIndex = 5;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Visible = false;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Location = new System.Drawing.Point(965, 4);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(16, 20);
            this.lbClose.TabIndex = 3;
            this.lbClose.Text = "x";
            this.lbClose.Visible = false;
            this.lbClose.Click += new System.EventHandler(this.ReturnToHome);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 899);
            this.Controls.Add(this.lbClose);
            this.Controls.Add(this.panControls);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(832, 525);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMiner";
            this.ClientSizeChanged += new System.EventHandler(this.Menu_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuSettings;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuEasy;
        private System.Windows.Forms.ToolStripMenuItem menuMedium;
        private System.Windows.Forms.ToolStripMenuItem menuHard;
        private System.Windows.Forms.ToolStripMenuItem menuGamePlay;
        private System.Windows.Forms.ToolStripMenuItem menuRecords;
        private System.Windows.Forms.ToolStripMenuItem menuRecShow;
        private System.Windows.Forms.ToolStripMenuItem menuRecExport;
        private System.Windows.Forms.ToolStripMenuItem menuRecImport;
        private System.Windows.Forms.ToolStripMenuItem menuFormInfo;

        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Button btnFame;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnMedium;
    }
}

