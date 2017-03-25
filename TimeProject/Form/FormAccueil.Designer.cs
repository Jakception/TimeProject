namespace TimeProject
{
    partial class FormAccueil
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlProjet = new System.Windows.Forms.Panel();
            this.lblProjet = new System.Windows.Forms.Label();
            this.lstBoxProjet = new System.Windows.Forms.ListBox();
            this.lblRendu = new System.Windows.Forms.Panel();
            this.lstBoxRendu = new System.Windows.Forms.ListBox();
            this.lblRenduTitre = new System.Windows.Forms.Label();
            this.pnlTacheUrgente = new System.Windows.Forms.Panel();
            this.lstBoxTask = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_Info.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnl_Date.SuspendLayout();
            this.pnlProjet.SuspendLayout();
            this.lblRendu.SuspendLayout();
            this.pnlTacheUrgente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(614, 53);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(150, 45);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "ACCUEIL";
            // 
            // pnl_Info
            // 
            this.pnl_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnl_Info.Controls.Add(this.pnlAdmin);
            this.pnl_Info.Controls.Add(this.pnlUser);
            this.pnl_Info.Controls.Add(this.pnl_Date);
            this.pnl_Info.Location = new System.Drawing.Point(1150, 12);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(200, 143);
            this.pnl_Info.TabIndex = 1;
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlAdmin.Controls.Add(this.lblAdmin);
            this.pnlAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlAdmin.Location = new System.Drawing.Point(0, 104);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(200, 26);
            this.pnlAdmin.TabIndex = 1;
            this.pnlAdmin.Click += new System.EventHandler(this.pnlAdmin_Click);
            //this.pnlAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAdmin_Paint);
            this.pnlAdmin.MouseEnter += new System.EventHandler(this.pnlAdmin_MouseEnter);
            this.pnlAdmin.MouseLeave += new System.EventHandler(this.pnlAdmin_MouseLeave);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmin.Location = new System.Drawing.Point(23, 4);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(59, 20);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.Click += new System.EventHandler(this.lblAdmin_Click);
            this.lblAdmin.MouseEnter += new System.EventHandler(this.lblAdmin_MouseEnter);
            this.lblAdmin.MouseLeave += new System.EventHandler(this.lblAdmin_MouseLeave);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Location = new System.Drawing.Point(0, 19);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(200, 26);
            this.pnlUser.TabIndex = 1;
            this.pnlUser.MouseEnter += new System.EventHandler(this.pnlUser_MouseEnter);
            this.pnlUser.MouseLeave += new System.EventHandler(this.pnlUser_MouseLeave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(23, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            this.lblName.MouseEnter += new System.EventHandler(this.lblName_MouseEnter);
            this.lblName.MouseLeave += new System.EventHandler(this.lblName_MouseLeave);
            // 
            // pnl_Date
            // 
            this.pnl_Date.Controls.Add(this.lblDate);
            this.pnl_Date.Location = new System.Drawing.Point(0, 60);
            this.pnl_Date.Name = "pnl_Date";
            this.pnl_Date.Size = new System.Drawing.Size(200, 26);
            this.pnl_Date.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(23, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TimeProject.Properties.Resources.logo;
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 151);
            this.panel1.TabIndex = 2;
            // 
            // pnlProjet
            // 
            this.pnlProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlProjet.BackColor = System.Drawing.Color.Transparent;
            this.pnlProjet.Controls.Add(this.lblProjet);
            this.pnlProjet.Controls.Add(this.lstBoxProjet);
            this.pnlProjet.Location = new System.Drawing.Point(20, 199);
            this.pnlProjet.Name = "pnlProjet";
            this.pnlProjet.Size = new System.Drawing.Size(283, 530);
            this.pnlProjet.TabIndex = 3;
            // 
            // lblProjet
            // 
            this.lblProjet.AutoSize = true;
            this.lblProjet.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjet.ForeColor = System.Drawing.Color.Black;
            this.lblProjet.Location = new System.Drawing.Point(48, 23);
            this.lblProjet.Name = "lblProjet";
            this.lblProjet.Size = new System.Drawing.Size(189, 33);
            this.lblProjet.TabIndex = 1;
            this.lblProjet.Text = "Projets en cours";
            // 
            // lstBoxProjet
            // 
            this.lstBoxProjet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstBoxProjet.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxProjet.FormattingEnabled = true;
            this.lstBoxProjet.Location = new System.Drawing.Point(3, 76);
            this.lstBoxProjet.Name = "lstBoxProjet";
            this.lstBoxProjet.Size = new System.Drawing.Size(274, 433);
            this.lstBoxProjet.TabIndex = 0;
            this.lstBoxProjet.DoubleClick += new System.EventHandler(this.lstBoxProjet_DoubleClick);
            // 
            // lblRendu
            // 
            this.lblRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblRendu.Controls.Add(this.lstBoxRendu);
            this.lblRendu.Controls.Add(this.lblRenduTitre);
            this.lblRendu.Location = new System.Drawing.Point(381, 199);
            this.lblRendu.Name = "lblRendu";
            this.lblRendu.Size = new System.Drawing.Size(521, 530);
            this.lblRendu.TabIndex = 4;
            // 
            // lstBoxRendu
            // 
            this.lstBoxRendu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstBoxRendu.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxRendu.FormattingEnabled = true;
            this.lstBoxRendu.Location = new System.Drawing.Point(31, 80);
            this.lstBoxRendu.Name = "lstBoxRendu";
            this.lstBoxRendu.Size = new System.Drawing.Size(470, 433);
            this.lstBoxRendu.TabIndex = 2;
            // 
            // lblRenduTitre
            // 
            this.lblRenduTitre.AutoSize = true;
            this.lblRenduTitre.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenduTitre.ForeColor = System.Drawing.Color.Black;
            this.lblRenduTitre.Location = new System.Drawing.Point(187, 23);
            this.lblRenduTitre.Name = "lblRenduTitre";
            this.lblRenduTitre.Size = new System.Drawing.Size(168, 33);
            this.lblRenduTitre.TabIndex = 2;
            this.lblRenduTitre.Text = "Rendu du jour";
            // 
            // pnlTacheUrgente
            // 
            this.pnlTacheUrgente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlTacheUrgente.Controls.Add(this.lstBoxTask);
            this.pnlTacheUrgente.Controls.Add(this.label2);
            this.pnlTacheUrgente.Location = new System.Drawing.Point(909, 199);
            this.pnlTacheUrgente.Name = "pnlTacheUrgente";
            this.pnlTacheUrgente.Size = new System.Drawing.Size(441, 530);
            this.pnlTacheUrgente.TabIndex = 5;
            // 
            // lstBoxTask
            // 
            this.lstBoxTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.lstBoxTask.FormattingEnabled = true;
            this.lstBoxTask.Location = new System.Drawing.Point(29, 80);
            this.lstBoxTask.Name = "lstBoxTask";
            this.lstBoxTask.Size = new System.Drawing.Size(395, 433);
            this.lstBoxTask.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(82, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taches urgente en attente\r\n             d\'action";
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.pnlTacheUrgente);
            this.Controls.Add(this.lblRendu);
            this.Controls.Add(this.pnlProjet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.lblTitre);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.pnl_Info.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.pnlAdmin.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            this.pnlProjet.ResumeLayout(false);
            this.pnlProjet.PerformLayout();
            this.lblRendu.ResumeLayout(false);
            this.lblRendu.PerformLayout();
            this.pnlTacheUrgente.ResumeLayout(false);
            this.pnlTacheUrgente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_Date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlProjet;
        private System.Windows.Forms.Label lblProjet;
        private System.Windows.Forms.ListBox lstBoxProjet;
        private System.Windows.Forms.Panel lblRendu;
        private System.Windows.Forms.Label lblRenduTitre;
        private System.Windows.Forms.Panel pnlTacheUrgente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ListBox lstBoxRendu;
        private System.Windows.Forms.ListBox lstBoxTask;
    }
}