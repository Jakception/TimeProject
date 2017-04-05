namespace TimeProject
{
    partial class FormHistoDet
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblHisto = new System.Windows.Forms.Label();
            this.btAjoutEvent = new System.Windows.Forms.Button();
            this.btDelEvent = new System.Windows.Forms.Button();
            this.btClassementImp = new System.Windows.Forms.Button();
            this.btValAction = new System.Windows.Forms.Button();
            this.btRendu = new System.Windows.Forms.Button();
            this.dataAction = new System.Windows.Forms.ListBox();
            this.dataInfo = new System.Windows.Forms.ListBox();
            this.dataRendu = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(119, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(753, 33);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date de début : xx/xx/XXXX - Objectif de fin : xx/xx/XXXX";
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(417, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(134, 45);
            this.lblTitre.TabIndex = 20;
            this.lblTitre.Text = "PROJET";
            // 
            // lblHisto
            // 
            this.lblHisto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHisto.AutoSize = true;
            this.lblHisto.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHisto.Location = new System.Drawing.Point(528, 167);
            this.lblHisto.Name = "lblHisto";
            this.lblHisto.Size = new System.Drawing.Size(291, 45);
            this.lblHisto.TabIndex = 22;
            this.lblHisto.Text = "Historique détaillé";
            // 
            // btAjoutEvent
            // 
            this.btAjoutEvent.BackColor = System.Drawing.Color.Navy;
            this.btAjoutEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutEvent.ForeColor = System.Drawing.Color.White;
            this.btAjoutEvent.Location = new System.Drawing.Point(37, 269);
            this.btAjoutEvent.Name = "btAjoutEvent";
            this.btAjoutEvent.Size = new System.Drawing.Size(195, 61);
            this.btAjoutEvent.TabIndex = 23;
            this.btAjoutEvent.Text = "Ajout Evenement";
            this.btAjoutEvent.UseVisualStyleBackColor = false;
            this.btAjoutEvent.Click += new System.EventHandler(this.btAjoutEvent_Click);
            // 
            // btDelEvent
            // 
            this.btDelEvent.BackColor = System.Drawing.Color.Navy;
            this.btDelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelEvent.ForeColor = System.Drawing.Color.White;
            this.btDelEvent.Location = new System.Drawing.Point(37, 370);
            this.btDelEvent.Name = "btDelEvent";
            this.btDelEvent.Size = new System.Drawing.Size(195, 61);
            this.btDelEvent.TabIndex = 24;
            this.btDelEvent.Text = "Suppression Evenement";
            this.btDelEvent.UseVisualStyleBackColor = false;
            this.btDelEvent.Click += new System.EventHandler(this.btDelEvent_Click);
            // 
            // btClassementImp
            // 
            this.btClassementImp.BackColor = System.Drawing.Color.Navy;
            this.btClassementImp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClassementImp.ForeColor = System.Drawing.Color.White;
            this.btClassementImp.Location = new System.Drawing.Point(37, 476);
            this.btClassementImp.Name = "btClassementImp";
            this.btClassementImp.Size = new System.Drawing.Size(195, 61);
            this.btClassementImp.TabIndex = 25;
            this.btClassementImp.Text = "Classement Importance";
            this.btClassementImp.UseVisualStyleBackColor = false;
            // 
            // btValAction
            // 
            this.btValAction.BackColor = System.Drawing.Color.Navy;
            this.btValAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValAction.ForeColor = System.Drawing.Color.White;
            this.btValAction.Location = new System.Drawing.Point(37, 586);
            this.btValAction.Name = "btValAction";
            this.btValAction.Size = new System.Drawing.Size(195, 61);
            this.btValAction.TabIndex = 26;
            this.btValAction.Text = "Validation Action Attente";
            this.btValAction.UseVisualStyleBackColor = false;
            // 
            // btRendu
            // 
            this.btRendu.BackColor = System.Drawing.Color.Navy;
            this.btRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRendu.ForeColor = System.Drawing.Color.White;
            this.btRendu.Location = new System.Drawing.Point(37, 710);
            this.btRendu.Name = "btRendu";
            this.btRendu.Size = new System.Drawing.Size(195, 61);
            this.btRendu.TabIndex = 27;
            this.btRendu.Text = "Rendus";
            this.btRendu.UseVisualStyleBackColor = false;
            // 
            // dataAction
            // 
            this.dataAction.FormattingEnabled = true;
            this.dataAction.Location = new System.Drawing.Point(249, 267);
            this.dataAction.Name = "dataAction";
            this.dataAction.ScrollAlwaysVisible = true;
            this.dataAction.Size = new System.Drawing.Size(767, 225);
            this.dataAction.TabIndex = 31;
            // 
            // dataInfo
            // 
            this.dataInfo.FormattingEnabled = true;
            this.dataInfo.Location = new System.Drawing.Point(249, 517);
            this.dataInfo.Name = "dataInfo";
            this.dataInfo.ScrollAlwaysVisible = true;
            this.dataInfo.Size = new System.Drawing.Size(767, 225);
            this.dataInfo.TabIndex = 32;
            // 
            // dataRendu
            // 
            this.dataRendu.FormattingEnabled = true;
            this.dataRendu.Location = new System.Drawing.Point(249, 758);
            this.dataRendu.Name = "dataRendu";
            this.dataRendu.ScrollAlwaysVisible = true;
            this.dataRendu.Size = new System.Drawing.Size(767, 225);
            this.dataRendu.TabIndex = 33;
            // 
            // FormHistoDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1058, 995);
            this.Controls.Add(this.dataRendu);
            this.Controls.Add(this.dataInfo);
            this.Controls.Add(this.dataAction);
            this.Controls.Add(this.btRendu);
            this.Controls.Add(this.btValAction);
            this.Controls.Add(this.btClassementImp);
            this.Controls.Add(this.btDelEvent);
            this.Controls.Add(this.btAjoutEvent);
            this.Controls.Add(this.lblHisto);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitre);
            this.MaximumSize = new System.Drawing.Size(1074, 1092);
            this.Name = "FormHistoDet";
            this.Load += new System.EventHandler(this.FormHistoDet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblHisto;
        private System.Windows.Forms.Button btAjoutEvent;
        private System.Windows.Forms.Button btDelEvent;
        private System.Windows.Forms.Button btClassementImp;
        private System.Windows.Forms.Button btValAction;
        private System.Windows.Forms.Button btRendu;
        private System.Windows.Forms.ListBox dataRendu;
        private System.Windows.Forms.ListBox dataInfo;
        private System.Windows.Forms.ListBox dataAction;
    }
}