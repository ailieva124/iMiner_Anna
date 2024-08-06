
namespace iMiner
{
    partial class GameField
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbBombs = new System.Windows.Forms.Label();
            this.pbBomb = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.pbClock = new System.Windows.Forms.PictureBox();
            this.panFields = new System.Windows.Forms.Panel();
            this.panGameInfo = new System.Windows.Forms.Panel();
            this.lbBest = new System.Windows.Forms.Label();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            this.panGameInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBombs
            // 
            this.lbBombs.AutoSize = true;
            this.lbBombs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBombs.Location = new System.Drawing.Point(167, 17);
            this.lbBombs.Name = "lbBombs";
            this.lbBombs.Size = new System.Drawing.Size(45, 28);
            this.lbBombs.TabIndex = 11;
            this.lbBombs.Text = "000";
            // 
            // pbBomb
            // 
            this.pbBomb.Image = global::iMiner.Properties.Resources.mine;
            this.pbBomb.Location = new System.Drawing.Point(123, 13);
            this.pbBomb.Name = "pbBomb";
            this.pbBomb.Size = new System.Drawing.Size(38, 35);
            this.pbBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBomb.TabIndex = 10;
            this.pbBomb.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(57, 17);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 28);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "00:00";
            // 
            // pbClock
            // 
            this.pbClock.Image = global::iMiner.Properties.Resources.clock;
            this.pbClock.Location = new System.Drawing.Point(13, 13);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(38, 35);
            this.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClock.TabIndex = 8;
            this.pbClock.TabStop = false;
            // 
            // panFields
            // 
            this.panFields.AutoScroll = true;
            this.panFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFields.Location = new System.Drawing.Point(0, 67);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(514, 390);
            this.panFields.TabIndex = 15;
            // 
            // panGameInfo
            // 
            this.panGameInfo.Controls.Add(this.lbBest);
            this.panGameInfo.Controls.Add(this.pbClock);
            this.panGameInfo.Controls.Add(this.lbTime);
            this.panGameInfo.Controls.Add(this.pbBomb);
            this.panGameInfo.Controls.Add(this.lbBombs);
            this.panGameInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panGameInfo.Location = new System.Drawing.Point(0, 0);
            this.panGameInfo.Name = "panGameInfo";
            this.panGameInfo.Size = new System.Drawing.Size(514, 69);
            this.panGameInfo.TabIndex = 9;
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBest.Location = new System.Drawing.Point(407, 17);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(90, 28);
            this.lbBest.TabIndex = 12;
            this.lbBest.Text = "Best: 000";
            // 
            // tClock
            // 
            this.tClock.Interval = 1000;
            this.tClock.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // GameField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panGameInfo);
            this.Controls.Add(this.panFields);
            this.Name = "GameField";
            this.Size = new System.Drawing.Size(514, 457);
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            this.panGameInfo.ResumeLayout(false);
            this.panGameInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbBombs;
        private System.Windows.Forms.PictureBox pbBomb;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbClock;
        private System.Windows.Forms.Panel panFields;
        private System.Windows.Forms.Panel panGameInfo;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.Label lbBest;
    }
}
