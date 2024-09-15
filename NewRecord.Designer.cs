
namespace iMiner
{
    partial class NewRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRecord));
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnSaveRecord = new System.Windows.Forms.Button();
            this.btnCancelRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNameInput
            // 
            this.tbNameInput.AllowDrop = true;
            this.tbNameInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbNameInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.tbNameInput, "tbNameInput");
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.TabStop = false;
            this.tbNameInput.Click += new System.EventHandler(this.Input_FirstClick);
            this.tbNameInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Input_KeyDown);
            // 
            // lbInfo
            // 
            resources.ApplyResources(this.lbInfo, "lbInfo");
            this.lbInfo.Name = "lbInfo";
            // 
            // btnSaveRecord
            // 
            this.btnSaveRecord.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnSaveRecord, "btnSaveRecord");
            this.btnSaveRecord.Name = "btnSaveRecord";
            this.btnSaveRecord.UseVisualStyleBackColor = true;
            this.btnSaveRecord.Click += new System.EventHandler(this.Submit);
            // 
            // btnCancelRecord
            // 
            this.btnCancelRecord.CausesValidation = false;
            this.btnCancelRecord.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancelRecord, "btnCancelRecord");
            this.btnCancelRecord.Name = "btnCancelRecord";
            this.btnCancelRecord.UseVisualStyleBackColor = true;
            // 
            // NewRecord
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelRecord;
            this.Controls.Add(this.btnCancelRecord);
            this.Controls.Add(this.btnSaveRecord);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbNameInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewRecord";
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.On_Close);
            this.Load += new System.EventHandler(this.On_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnSaveRecord;
        private System.Windows.Forms.Button btnCancelRecord;
    }
}