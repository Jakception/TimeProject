namespace TimeProject
{
    partial class FormAjoutEvent
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
            this.cbBoxType = new System.Windows.Forms.ComboBox();
            this.lstBoxEtat = new System.Windows.Forms.ListBox();
            this.txtCorpsEvent = new System.Windows.Forms.TextBox();
            this.lstBoxImp = new System.Windows.Forms.ListBox();
            this.pnlAction = new System.Windows.Forms.Panel();
            this.dtAction = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblImportance = new System.Windows.Forms.Label();
            this.lblDtRendu = new System.Windows.Forms.Label();
            this.btCreaEvent = new System.Windows.Forms.Button();
            this.pnlAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbBoxType
            // 
            this.cbBoxType.FormattingEnabled = true;
            this.cbBoxType.Items.AddRange(new object[] {
            "Action",
            "Information"});
            this.cbBoxType.Location = new System.Drawing.Point(33, 58);
            this.cbBoxType.Name = "cbBoxType";
            this.cbBoxType.Size = new System.Drawing.Size(177, 21);
            this.cbBoxType.TabIndex = 0;
            this.cbBoxType.SelectedIndexChanged += new System.EventHandler(this.cbBoxType_SelectedIndexChanged);
            // 
            // lstBoxEtat
            // 
            this.lstBoxEtat.FormattingEnabled = true;
            this.lstBoxEtat.Location = new System.Drawing.Point(21, 48);
            this.lstBoxEtat.Name = "lstBoxEtat";
            this.lstBoxEtat.ScrollAlwaysVisible = true;
            this.lstBoxEtat.Size = new System.Drawing.Size(177, 43);
            this.lstBoxEtat.TabIndex = 1;
            // 
            // txtCorpsEvent
            // 
            this.txtCorpsEvent.Location = new System.Drawing.Point(257, 58);
            this.txtCorpsEvent.Multiline = true;
            this.txtCorpsEvent.Name = "txtCorpsEvent";
            this.txtCorpsEvent.Size = new System.Drawing.Size(389, 416);
            this.txtCorpsEvent.TabIndex = 2;
            // 
            // lstBoxImp
            // 
            this.lstBoxImp.FormattingEnabled = true;
            this.lstBoxImp.Location = new System.Drawing.Point(21, 141);
            this.lstBoxImp.Name = "lstBoxImp";
            this.lstBoxImp.ScrollAlwaysVisible = true;
            this.lstBoxImp.Size = new System.Drawing.Size(177, 43);
            this.lstBoxImp.TabIndex = 3;
            // 
            // pnlAction
            // 
            this.pnlAction.Controls.Add(this.lblDtRendu);
            this.pnlAction.Controls.Add(this.lblImportance);
            this.pnlAction.Controls.Add(this.lblStatus);
            this.pnlAction.Controls.Add(this.dtAction);
            this.pnlAction.Controls.Add(this.lstBoxEtat);
            this.pnlAction.Controls.Add(this.lstBoxImp);
            this.pnlAction.Location = new System.Drawing.Point(12, 90);
            this.pnlAction.Name = "pnlAction";
            this.pnlAction.Size = new System.Drawing.Size(228, 286);
            this.pnlAction.TabIndex = 4;
            // 
            // dtAction
            // 
            this.dtAction.Location = new System.Drawing.Point(16, 236);
            this.dtAction.Name = "dtAction";
            this.dtAction.Size = new System.Drawing.Size(200, 20);
            this.dtAction.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(62, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(86, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Statut de l\'action";
            // 
            // lblImportance
            // 
            this.lblImportance.AutoSize = true;
            this.lblImportance.Location = new System.Drawing.Point(62, 116);
            this.lblImportance.Name = "lblImportance";
            this.lblImportance.Size = new System.Drawing.Size(111, 13);
            this.lblImportance.TabIndex = 6;
            this.lblImportance.Text = "Importance de l\'action";
            // 
            // lblDtRendu
            // 
            this.lblDtRendu.AutoSize = true;
            this.lblDtRendu.Location = new System.Drawing.Point(62, 205);
            this.lblDtRendu.Name = "lblDtRendu";
            this.lblDtRendu.Size = new System.Drawing.Size(89, 13);
            this.lblDtRendu.TabIndex = 7;
            this.lblDtRendu.Text = "Date d\'échéance";
            // 
            // btCreaEvent
            // 
            this.btCreaEvent.BackColor = System.Drawing.Color.Navy;
            this.btCreaEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btCreaEvent.ForeColor = System.Drawing.Color.White;
            this.btCreaEvent.Location = new System.Drawing.Point(33, 404);
            this.btCreaEvent.Name = "btCreaEvent";
            this.btCreaEvent.Size = new System.Drawing.Size(177, 57);
            this.btCreaEvent.TabIndex = 5;
            this.btCreaEvent.Text = "Création de l\'evenement";
            this.btCreaEvent.UseVisualStyleBackColor = false;
            this.btCreaEvent.Click += new System.EventHandler(this.btCreaEvent_Click);
            // 
            // FormAjoutEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 499);
            this.Controls.Add(this.btCreaEvent);
            this.Controls.Add(this.pnlAction);
            this.Controls.Add(this.txtCorpsEvent);
            this.Controls.Add(this.cbBoxType);
            this.Name = "FormAjoutEvent";
            this.Text = "FormAjoutEvent";
            this.Load += new System.EventHandler(this.FormAjoutEvent_Load);
            this.pnlAction.ResumeLayout(false);
            this.pnlAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxType;
        private System.Windows.Forms.ListBox lstBoxEtat;
        private System.Windows.Forms.TextBox txtCorpsEvent;
        private System.Windows.Forms.ListBox lstBoxImp;
        private System.Windows.Forms.Panel pnlAction;
        private System.Windows.Forms.DateTimePicker dtAction;
        private System.Windows.Forms.Label lblDtRendu;
        private System.Windows.Forms.Label lblImportance;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btCreaEvent;
    }
}