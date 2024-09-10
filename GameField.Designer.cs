
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
            this.panInfo = new System.Windows.Forms.Panel();
            this.lbBest = new System.Windows.Forms.Label();
            this.pbHelper = new System.Windows.Forms.PictureBox();
            this.panInfoRight = new System.Windows.Forms.Panel();
            this.panInfoLeft = new System.Windows.Forms.Panel();
            this.tClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelper)).BeginInit();
            this.panInfo.SuspendLayout();
            this.panInfoRight.SuspendLayout();
            this.panInfoLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBombs
            // 
            this.lbBombs.AutoSize = true;
            this.lbBombs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBombs.Location = new System.Drawing.Point(153, 20);
            this.lbBombs.Name = "lbBombs";
            this.lbBombs.Size = new System.Drawing.Size(45, 28);
            this.lbBombs.TabIndex = 1;
            this.lbBombs.Text = "000";
            // 
            // pbBomb
            // 
            this.pbBomb.Image = global::iMiner.Properties.Resources.mine;
            this.pbBomb.Location = new System.Drawing.Point(112, 16);
            this.pbBomb.Name = "pbBomb";
            this.pbBomb.Size = new System.Drawing.Size(38, 35);
            this.pbBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBomb.TabIndex = 2;
            this.pbBomb.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(47, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(60, 28);
            this.lbTime.TabIndex = 3;
            this.lbTime.Text = "00:00";
            // 
            // pbClock
            // 
            this.pbClock.Image = global::iMiner.Properties.Resources.clock;
            this.pbClock.Location = new System.Drawing.Point(8, 16);
            this.pbClock.Name = "pbClock";
            this.pbClock.Size = new System.Drawing.Size(38, 35);
            this.pbClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClock.TabIndex = 4;
            this.pbClock.TabStop = false;
            // 
            // panFields
            // 
            this.panFields.AutoScroll = true;
            this.panFields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFields.Location = new System.Drawing.Point(0, 67);
            this.panFields.Name = "panFields";
            this.panFields.Size = new System.Drawing.Size(514, 390);
            this.panFields.TabIndex = 5;
            // 
            // panInfo
            // 
            this.panInfo.Controls.Add(this.pbHelper);
            this.panInfo.Controls.Add(this.panInfoRight);
            this.panInfo.Controls.Add(this.panInfoLeft);
            this.panInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panInfo.Location = new System.Drawing.Point(0, 0);
            this.panInfo.Name = "panInfo";
            this.panInfo.Size = new System.Drawing.Size(514, 69);
            this.panInfo.TabIndex = 6;
            // 
            // lbBest
            // 
            this.lbBest.AutoSize = true;
            this.lbBest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBest.Location = new System.Drawing.Point(12, 20);
            this.lbBest.Name = "lbBest";
            this.lbBest.Size = new System.Drawing.Size(90, 28);
            this.lbBest.TabIndex = 7;
            this.lbBest.Text = "Best: 000";
            // 
            // pbHelper
            // 
            this.pbHelper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbHelper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHelper.Image = global::iMiner.Properties.Resources.hint;
            this.pbHelper.Location = new System.Drawing.Point(298, 16);
            this.pbHelper.Name = "pbHelper";
            this.pbHelper.Size = new System.Drawing.Size(38, 35);
            this.pbHelper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelper.TabIndex = 8;
            this.pbHelper.TabStop = false;
            this.pbHelper.Visible = false;
            this.pbHelper.Click += new System.EventHandler(this.GetHint);
            // 
            // panInfoRight
            // 
            this.panInfoRight.Controls.Add(this.lbBest);
            this.panInfoRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panInfoRight.Location = new System.Drawing.Point(399, 0);
            this.panInfoRight.Name = "panInfoRight";
            this.panInfoRight.Size = new System.Drawing.Size(115, 69);
            this.panInfoRight.TabIndex = 9;
            // 
            // panInfoLeft
            // 
            this.panInfoLeft.Controls.Add(this.lbBombs);
            this.panInfoLeft.Controls.Add(this.pbClock);
            this.panInfoLeft.Controls.Add(this.lbTime);
            this.panInfoLeft.Controls.Add(this.pbBomb);
            this.panInfoLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panInfoLeft.Location = new System.Drawing.Point(0, 0);
            this.panInfoLeft.Name = "panInfoLeft";
            this.panInfoLeft.Size = new System.Drawing.Size(209, 69);
            this.panInfoLeft.TabIndex = 10;
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
            this.Controls.Add(this.panInfo);
            this.Controls.Add(this.panFields);
            this.Name = "GameField";
            this.Size = new System.Drawing.Size(514, 457);
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelper)).EndInit();
            this.panInfo.ResumeLayout(false);
            this.panInfoRight.ResumeLayout(false);
            this.panInfoRight.PerformLayout();
            this.panInfoLeft.ResumeLayout(false);
            this.panInfoLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbBombs;
        private System.Windows.Forms.PictureBox pbBomb;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbClock;
        private System.Windows.Forms.Panel panFields;
        private System.Windows.Forms.Panel panInfo;
        private System.Windows.Forms.Timer tClock;
        private System.Windows.Forms.Label lbBest;
        private System.Windows.Forms.Panel panInfoRight;
        private System.Windows.Forms.Panel panInfoLeft;
        private System.Windows.Forms.PictureBox pbHelper;
    }
}
