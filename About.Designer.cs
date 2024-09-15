
namespace iMiner
{
    partial class About
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDevEmail = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbDevName = new System.Windows.Forms.Label();
            this.lbRights = new System.Windows.Forms.Label();
            this.gbDevContact = new System.Windows.Forms.GroupBox();
            this.gbDevContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Snap ITC", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(129, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(163, 48);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "iMiner";
            // 
            // lbDevEmail
            // 
            this.lbDevEmail.AutoSize = true;
            this.lbDevEmail.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDevEmail.Location = new System.Drawing.Point(51, 66);
            this.lbDevEmail.Name = "lbDevEmail";
            this.lbDevEmail.Size = new System.Drawing.Size(155, 26);
            this.lbDevEmail.TabIndex = 1;
            this.lbDevEmail.Text = "222913@mgu.bg";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbVersion.Location = new System.Drawing.Point(135, 57);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(155, 29);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Version 0.0.1";
            // 
            // lbDevName
            // 
            this.lbDevName.AutoSize = true;
            this.lbDevName.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDevName.Location = new System.Drawing.Point(20, 40);
            this.lbDevName.Name = "lbDevName";
            this.lbDevName.Size = new System.Drawing.Size(214, 26);
            this.lbDevName.TabIndex = 4;
            this.lbDevName.Text = "Anna Yordanova Ilieva";
            // 
            // lbRights
            // 
            this.lbRights.AutoSize = true;
            this.lbRights.Font = new System.Drawing.Font("Sylfaen", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbRights.Location = new System.Drawing.Point(94, 86);
            this.lbRights.Name = "lbRights";
            this.lbRights.Size = new System.Drawing.Size(235, 29);
            this.lbRights.TabIndex = 5;
            this.lbRights.Text = "© All rights reserved";
            // 
            // gbDevContact
            // 
            this.gbDevContact.Controls.Add(this.lbDevName);
            this.gbDevContact.Controls.Add(this.lbDevEmail);
            this.gbDevContact.Location = new System.Drawing.Point(84, 145);
            this.gbDevContact.Name = "gbDevContact";
            this.gbDevContact.Size = new System.Drawing.Size(253, 125);
            this.gbDevContact.TabIndex = 6;
            this.gbDevContact.TabStop = false;
            this.gbDevContact.Text = "Developer contact";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 295);
            this.Controls.Add(this.gbDevContact);
            this.Controls.Add(this.lbRights);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About iMiner";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AboutEscape);
            this.gbDevContact.ResumeLayout(false);
            this.gbDevContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDevEmail;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbDevName;
        private System.Windows.Forms.Label lbRights;
        private System.Windows.Forms.GroupBox gbDevContact;
    }
}