
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPause = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGamePlay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecords = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecExport = new System.Windows.Forms.ToolStripMenuItem();
            this.panControls = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuGame,
            this.menuRecords});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(996, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout,
            this.menuHome,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuAbout.Size = new System.Drawing.Size(203, 26);
            this.menuAbout.Text = "About iMiner";
            this.menuAbout.Click += new System.EventHandler(this.About_iMiner);
            // 
            // menuHome
            // 
            this.menuHome.Name = "menuHome";
            this.menuHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuHome.Size = new System.Drawing.Size(203, 26);
            this.menuHome.Text = "Home";
            this.menuHome.Click += new System.EventHandler(this.ReturnToHome);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuExit.Size = new System.Drawing.Size(203, 26);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.Exit_iMiner);
            // 
            // menuGame
            // 
            this.menuGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuPause,
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
            this.menuNew.Size = new System.Drawing.Size(222, 26);
            this.menuNew.Text = "New Game";
            // 
            // menuEasy
            // 
            this.menuEasy.Name = "menuEasy";
            this.menuEasy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEasy.Size = new System.Drawing.Size(202, 26);
            this.menuEasy.Text = "Easy";
            this.menuEasy.Click += new System.EventHandler(this.NewGame);
            // 
            // menuMedium
            // 
            this.menuMedium.Name = "menuMedium";
            this.menuMedium.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuMedium.Size = new System.Drawing.Size(202, 26);
            this.menuMedium.Text = "Medium";
            this.menuMedium.Click += new System.EventHandler(this.NewGame);
            // 
            // menuHard
            // 
            this.menuHard.Name = "menuHard";
            this.menuHard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuHard.Size = new System.Drawing.Size(202, 26);
            this.menuHard.Text = "Hard";
            this.menuHard.Click += new System.EventHandler(this.NewGame);
            // 
            // menuPause
            // 
            this.menuPause.Name = "menuPause";
            this.menuPause.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuPause.Size = new System.Drawing.Size(222, 26);
            this.menuPause.Text = "Pause Game";
            this.menuPause.Click += new System.EventHandler(this.PauseGame);
            // 
            // menuGamePlay
            // 
            this.menuGamePlay.Name = "menuGamePlay";
            this.menuGamePlay.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuGamePlay.Size = new System.Drawing.Size(222, 26);
            this.menuGamePlay.Text = "GamePlay";
            this.menuGamePlay.Click += new System.EventHandler(this.GamePlayInfo);
            // 
            // menuRecords
            // 
            this.menuRecords.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRecShow,
            this.menuRecExport});
            this.menuRecords.Name = "menuRecords";
            this.menuRecords.Size = new System.Drawing.Size(76, 24);
            this.menuRecords.Text = "Records";
            // 
            // menuRecShow
            // 
            this.menuRecShow.Name = "menuRecShow";
            this.menuRecShow.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRecShow.Size = new System.Drawing.Size(306, 26);
            this.menuRecShow.Text = "Show Log";
            this.menuRecShow.Click += new System.EventHandler(this.ShowRecords);
            // 
            // menuRecExport
            // 
            this.menuRecExport.Name = "menuRecExport";
            this.menuRecExport.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.menuRecExport.Size = new System.Drawing.Size(306, 26);
            this.menuRecExport.Text = "Log Export/Import";
            this.menuRecExport.Click += new System.EventHandler(this.Log_Export_Import);
            // 
            // panControls
            // 
            this.panControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panControls.Location = new System.Drawing.Point(0, 28);
            this.panControls.Name = "panControls";
            this.panControls.Size = new System.Drawing.Size(996, 871);
            this.panControls.TabIndex = 2;
            // 
            // lbClose
            // 
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.Transparent;
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Location = new System.Drawing.Point(960, 4);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1014, 946);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iMiner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Closing);
            this.ClientSizeChanged += new System.EventHandler(this.Menu_Resize);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        // File
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuHome;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        // Game
        private System.Windows.Forms.ToolStripMenuItem menuGame;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuEasy;
        private System.Windows.Forms.ToolStripMenuItem menuMedium;
        private System.Windows.Forms.ToolStripMenuItem menuHard;
        private System.Windows.Forms.ToolStripMenuItem menuPause;
        private System.Windows.Forms.ToolStripMenuItem menuGamePlay;
        // Records
        private System.Windows.Forms.ToolStripMenuItem menuRecords;
        private System.Windows.Forms.ToolStripMenuItem menuRecShow;
        private System.Windows.Forms.ToolStripMenuItem menuRecExport;

        private System.Windows.Forms.Panel panControls;
        private System.Windows.Forms.Label lbClose;
    }
}

