
namespace iMiner
{
    partial class GamePlayGallery
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.pbSlide = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbLang = new System.Windows.Forms.Label();
            this.languageChoose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BG = new System.Windows.Forms.ToolStripMenuItem();
            this.EN = new System.Windows.Forms.ToolStripMenuItem();
            this.linkMorePatterns = new System.Windows.Forms.LinkLabel();
            this.btnSlide1 = new System.Windows.Forms.Button();
            this.btnSlide2 = new System.Windows.Forms.Button();
            this.btnSlide3 = new System.Windows.Forms.Button();
            this.btnSlide4 = new System.Windows.Forms.Button();
            this.pbGlobe = new System.Windows.Forms.PictureBox();
            this.panLang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).BeginInit();
            this.languageChoose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobe)).BeginInit();
            this.panLang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrev.Location = new System.Drawing.Point(35, 250);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 71);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.GoBack);
            // 
            // pbSlide
            // 
            this.pbSlide.Location = new System.Drawing.Point(87, 74);
            this.pbSlide.Name = "pbSlide";
            this.pbSlide.Size = new System.Drawing.Size(872, 374);
            this.pbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSlide.TabIndex = 4;
            this.pbSlide.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("SimSun-ExtB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(979, 250);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 71);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.GoForward);
            // 
            // lbLang
            // 
            this.lbLang.AutoSize = true;
            this.lbLang.ContextMenuStrip = this.languageChoose;
            this.lbLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbLang.Location = new System.Drawing.Point(41, 12);
            this.lbLang.Name = "lbLang";
            this.lbLang.Size = new System.Drawing.Size(28, 20);
            this.lbLang.TabIndex = 3;
            this.lbLang.Text = "BG";
            this.lbLang.Click += new System.EventHandler(this.ShowMenu);
            // 
            // languageChoose
            // 
            this.languageChoose.BackColor = System.Drawing.SystemColors.Control;
            this.languageChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.languageChoose.Font = new System.Drawing.Font("SimSun-ExtB", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.languageChoose.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.languageChoose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BG,
            this.EN});
            this.languageChoose.Name = "languageChoose";
            this.languageChoose.Size = new System.Drawing.Size(162, 56);
            this.languageChoose.Opening += new System.ComponentModel.CancelEventHandler(this.SetActiveLang);
            // 
            // BG
            // 
            this.BG.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BG.BackColor = System.Drawing.Color.Lavender;
            this.BG.Image = global::iMiner.Properties.Resources._BG;
            this.BG.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(161, 26);
            this.BG.Text = "Bulgarian";
            this.BG.Click += new System.EventHandler(this.ChangeLang);
            // 
            // EN
            // 
            this.EN.BackColor = System.Drawing.SystemColors.Control;
            this.EN.Image = global::iMiner.Properties.Resources._EN;
            this.EN.Name = "EN";
            this.EN.Size = new System.Drawing.Size(161, 26);
            this.EN.Text = "English";
            this.EN.Click += new System.EventHandler(this.ChangeLang);
            // 
            // linkMorePatterns
            // 
            this.linkMorePatterns.AutoSize = true;
            this.linkMorePatterns.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMorePatterns.Location = new System.Drawing.Point(431, 508);
            this.linkMorePatterns.Name = "linkMorePatterns";
            this.linkMorePatterns.Size = new System.Drawing.Size(161, 20);
            this.linkMorePatterns.TabIndex = 11;
            this.linkMorePatterns.TabStop = true;
            this.linkMorePatterns.Text = "See more Patterns here";
            this.linkMorePatterns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenWeb);
            // 
            // btnSlide1
            // 
            this.btnSlide1.BackColor = System.Drawing.Color.Lavender;
            this.btnSlide1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide1.FlatAppearance.BorderSize = 0;
            this.btnSlide1.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSlide1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSlide1.Location = new System.Drawing.Point(446, 458);
            this.btnSlide1.Name = "btnSlide1";
            this.btnSlide1.Size = new System.Drawing.Size(32, 36);
            this.btnSlide1.TabIndex = 7;
            this.btnSlide1.Text = "1";
            this.btnSlide1.UseVisualStyleBackColor = false;
            this.btnSlide1.Click += new System.EventHandler(this.GoTo);
            // 
            // btnSlide2
            // 
            this.btnSlide2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide2.FlatAppearance.BorderSize = 0;
            this.btnSlide2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide2.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSlide2.Location = new System.Drawing.Point(484, 458);
            this.btnSlide2.Name = "btnSlide2";
            this.btnSlide2.Size = new System.Drawing.Size(32, 36);
            this.btnSlide2.TabIndex = 8;
            this.btnSlide2.Text = "2";
            this.btnSlide2.UseVisualStyleBackColor = true;
            this.btnSlide2.Click += new System.EventHandler(this.GoTo);
            // 
            // btnSlide3
            // 
            this.btnSlide3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide3.FlatAppearance.BorderSize = 0;
            this.btnSlide3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide3.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSlide3.Location = new System.Drawing.Point(522, 458);
            this.btnSlide3.Name = "btnSlide3";
            this.btnSlide3.Size = new System.Drawing.Size(32, 36);
            this.btnSlide3.TabIndex = 9;
            this.btnSlide3.Text = "3";
            this.btnSlide3.UseVisualStyleBackColor = true;
            this.btnSlide3.Click += new System.EventHandler(this.GoTo);
            // 
            // btnSlide4
            // 
            this.btnSlide4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSlide4.FlatAppearance.BorderSize = 0;
            this.btnSlide4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlide4.Font = new System.Drawing.Font("SimSun-ExtB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSlide4.Location = new System.Drawing.Point(560, 458);
            this.btnSlide4.Name = "btnSlide4";
            this.btnSlide4.Size = new System.Drawing.Size(32, 36);
            this.btnSlide4.TabIndex = 10;
            this.btnSlide4.Text = "4";
            this.btnSlide4.UseVisualStyleBackColor = true;
            this.btnSlide4.Click += new System.EventHandler(this.GoTo);
            // 
            // pbGlobe
            // 
            this.pbGlobe.ContextMenuStrip = this.languageChoose;
            this.pbGlobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGlobe.Image = global::iMiner.Properties.Resources.globe;
            this.pbGlobe.Location = new System.Drawing.Point(3, 6);
            this.pbGlobe.Name = "pbGlobe";
            this.pbGlobe.Size = new System.Drawing.Size(34, 31);
            this.pbGlobe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGlobe.TabIndex = 2;
            this.pbGlobe.TabStop = false;
            this.pbGlobe.Click += new System.EventHandler(this.ShowMenu);
            // 
            // panLang
            // 
            this.panLang.BackColor = System.Drawing.SystemColors.Control;
            this.panLang.ContextMenuStrip = this.languageChoose;
            this.panLang.Controls.Add(this.pbGlobe);
            this.panLang.Controls.Add(this.lbLang);
            this.panLang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panLang.Location = new System.Drawing.Point(887, 13);
            this.panLang.Name = "panLang";
            this.panLang.Size = new System.Drawing.Size(72, 44);
            this.panLang.TabIndex = 1;
            this.panLang.Click += new System.EventHandler(this.ShowMenu);
            // 
            // GamePlayGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSlide4);
            this.Controls.Add(this.btnSlide3);
            this.Controls.Add(this.btnSlide2);
            this.Controls.Add(this.btnSlide1);
            this.Controls.Add(this.linkMorePatterns);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pbSlide);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panLang);
            this.Name = "GamePlayGallery";
            this.Size = new System.Drawing.Size(1054, 559);
            this.Load += new System.EventHandler(this.GamePlayGallery_Load);
            this.Leave += new System.EventHandler(this.GamePlayGallery_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlide)).EndInit();
            this.languageChoose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGlobe)).EndInit();
            this.panLang.ResumeLayout(false);
            this.panLang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.PictureBox pbSlide;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbLang;
        private System.Windows.Forms.LinkLabel linkMorePatterns;
        private System.Windows.Forms.Button btnSlide1;
        private System.Windows.Forms.Button btnSlide2;
        private System.Windows.Forms.Button btnSlide3;
        private System.Windows.Forms.Button btnSlide4;
        private System.Windows.Forms.PictureBox pbGlobe;
        private System.Windows.Forms.ContextMenuStrip languageChoose;
        private System.Windows.Forms.ToolStripMenuItem BG;
        private System.Windows.Forms.ToolStripMenuItem EN;
        private System.Windows.Forms.Panel panLang;
    }
}
