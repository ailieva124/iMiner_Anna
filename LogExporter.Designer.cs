
namespace iMiner
{
    partial class LogExporter
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
            System.Windows.Forms.GroupBox gbErrors;
            System.Windows.Forms.GroupBox gbMessages;
            this.lbError = new System.Windows.Forms.Label();
            this.lbMessages = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPasteData = new System.Windows.Forms.Button();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            gbErrors = new System.Windows.Forms.GroupBox();
            gbMessages = new System.Windows.Forms.GroupBox();
            gbErrors.SuspendLayout();
            gbMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.AcceptsTab = true;
            this.tbData.Location = new System.Drawing.Point(57, 67);
            this.tbData.Multiline = true;
            this.tbData.Name = "tbData";
            this.tbData.PlaceholderText = "No data still";
            this.tbData.ReadOnly = true;
            this.tbData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbData.Size = new System.Drawing.Size(549, 441);
            this.tbData.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(665, 192);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(147, 29);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.GetActualLogData);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(665, 249);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(147, 29);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.Copy);
            // 
            // btnPasteData
            // 
            this.btnPasteData.Location = new System.Drawing.Point(665, 304);
            this.btnPasteData.Name = "btnPasteData";
            this.btnPasteData.Size = new System.Drawing.Size(147, 29);
            this.btnPasteData.TabIndex = 4;
            this.btnPasteData.Text = "Paste";
            this.btnPasteData.UseVisualStyleBackColor = true;
            this.btnPasteData.Click += new System.EventHandler(this.Paste);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(665, 358);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.UpdateData);
            // 
            // gbErrors
            // 
            gbErrors.Controls.Add(this.lbError);
            gbErrors.Location = new System.Drawing.Point(57, 539);
            gbErrors.Name = "gbErrors";
            gbErrors.Size = new System.Drawing.Size(401, 89);
            gbErrors.TabIndex = 6;
            gbErrors.TabStop = false;
            gbErrors.Text = "Errors";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.IndianRed;
            this.lbError.Location = new System.Drawing.Point(28, 38);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(71, 20);
            this.lbError.TabIndex = 7;
            this.lbError.Text = "No errors";
            // 
            // gbMessages
            // 
            gbMessages.Controls.Add(this.lbMessages);
            gbMessages.Location = new System.Drawing.Point(464, 539);
            gbMessages.Name = "gbMessages";
            gbMessages.Size = new System.Drawing.Size(348, 89);
            gbMessages.TabIndex = 8;
            gbMessages.TabStop = false;
            gbMessages.Text = "Messages";
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.ForeColor = System.Drawing.Color.OliveDrab;
            this.lbMessages.Location = new System.Drawing.Point(24, 38);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(97, 20);
            this.lbMessages.TabIndex = 9;
            this.lbMessages.Text = "No messages";
            // 
            // LogExporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(gbMessages);
            this.Controls.Add(gbErrors);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.btnPasteData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCopy);
            this.Name = "LogExporter";
            this.Size = new System.Drawing.Size(871, 648);
            this.Leave += new System.EventHandler(this.LogExporter_Leave);
            gbErrors.ResumeLayout(false);
            gbErrors.PerformLayout();
            gbMessages.ResumeLayout(false);
            gbMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPasteData;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.Button btnRefresh;
    }
}
