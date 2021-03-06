﻿namespace TimeProject
{
    partial class FormProjet
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
            this.btn_bordereau = new System.Windows.Forms.Button();
            this.btn_cptRendu = new System.Windows.Forms.Button();
            this.btn_listePlans = new System.Windows.Forms.Button();
            this.btn_suiviTH = new System.Windows.Forms.Button();
            this.btn_ficheLancement = new System.Windows.Forms.Button();
            this.btn_suiviValidations = new System.Windows.Forms.Button();
            this.btn_historique = new System.Windows.Forms.Button();
            this.lbl_histo = new System.Windows.Forms.Label();
            this.lbl_taches = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lstBoxHistorique = new System.Windows.Forms.ListBox();
            this.lstTaskImp = new System.Windows.Forms.ListBox();
            this.lstBoxInfo = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(645, 51);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(134, 45);
            this.lblTitre.TabIndex = 1;
            this.lblTitre.Text = "PROJET";
            this.lblTitre.Click += new System.EventHandler(this.lblTitre_Click);
            // 
            // btn_bordereau
            // 
            this.btn_bordereau.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_bordereau.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_bordereau.Location = new System.Drawing.Point(32, 361);
            this.btn_bordereau.Name = "btn_bordereau";
            this.btn_bordereau.Size = new System.Drawing.Size(180, 52);
            this.btn_bordereau.TabIndex = 11;
            this.btn_bordereau.Text = "Bordereau d\'envoi";
            this.btn_bordereau.UseVisualStyleBackColor = false;
            this.btn_bordereau.Click += new System.EventHandler(this.btn_bordereau_Click);
            // 
            // btn_cptRendu
            // 
            this.btn_cptRendu.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_cptRendu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cptRendu.Location = new System.Drawing.Point(32, 564);
            this.btn_cptRendu.Name = "btn_cptRendu";
            this.btn_cptRendu.Size = new System.Drawing.Size(180, 52);
            this.btn_cptRendu.TabIndex = 10;
            this.btn_cptRendu.Text = "Compte-rendu";
            this.btn_cptRendu.UseVisualStyleBackColor = false;
            this.btn_cptRendu.Click += new System.EventHandler(this.btn_cptRendu_Click);
            // 
            // btn_listePlans
            // 
            this.btn_listePlans.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_listePlans.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_listePlans.Location = new System.Drawing.Point(32, 294);
            this.btn_listePlans.Margin = new System.Windows.Forms.Padding(0);
            this.btn_listePlans.Name = "btn_listePlans";
            this.btn_listePlans.Size = new System.Drawing.Size(180, 52);
            this.btn_listePlans.TabIndex = 9;
            this.btn_listePlans.Text = "Liste des plans";
            this.btn_listePlans.UseVisualStyleBackColor = false;
            this.btn_listePlans.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_suiviTH
            // 
            this.btn_suiviTH.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_suiviTH.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_suiviTH.Location = new System.Drawing.Point(32, 488);
            this.btn_suiviTH.Name = "btn_suiviTH";
            this.btn_suiviTH.Size = new System.Drawing.Size(180, 52);
            this.btn_suiviTH.TabIndex = 12;
            this.btn_suiviTH.Text = "Suivi TH";
            this.btn_suiviTH.UseVisualStyleBackColor = false;
            // 
            // btn_ficheLancement
            // 
            this.btn_ficheLancement.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ficheLancement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ficheLancement.Location = new System.Drawing.Point(32, 635);
            this.btn_ficheLancement.Name = "btn_ficheLancement";
            this.btn_ficheLancement.Size = new System.Drawing.Size(180, 52);
            this.btn_ficheLancement.TabIndex = 13;
            this.btn_ficheLancement.Text = "Fiche de lancement";
            this.btn_ficheLancement.UseVisualStyleBackColor = false;
            // 
            // btn_suiviValidations
            // 
            this.btn_suiviValidations.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_suiviValidations.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_suiviValidations.Location = new System.Drawing.Point(32, 419);
            this.btn_suiviValidations.Name = "btn_suiviValidations";
            this.btn_suiviValidations.Size = new System.Drawing.Size(180, 52);
            this.btn_suiviValidations.TabIndex = 14;
            this.btn_suiviValidations.Text = "Suivi des validations";
            this.btn_suiviValidations.UseVisualStyleBackColor = false;
            this.btn_suiviValidations.Click += new System.EventHandler(this.btn_suiviValidations_Click);
            // 
            // btn_historique
            // 
            this.btn_historique.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_historique.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_historique.Location = new System.Drawing.Point(32, 237);
            this.btn_historique.Name = "btn_historique";
            this.btn_historique.Size = new System.Drawing.Size(180, 52);
            this.btn_historique.TabIndex = 15;
            this.btn_historique.Text = "Historique Détaillé";
            this.btn_historique.UseVisualStyleBackColor = false;
            this.btn_historique.Click += new System.EventHandler(this.btn_historique_Click);
            // 
            // lbl_histo
            // 
            this.lbl_histo.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbl_histo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_histo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_histo.Location = new System.Drawing.Point(301, 227);
            this.lbl_histo.Name = "lbl_histo";
            this.lbl_histo.Size = new System.Drawing.Size(371, 46);
            this.lbl_histo.TabIndex = 17;
            this.lbl_histo.Text = "Historique";
            this.lbl_histo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_taches
            // 
            this.lbl_taches.BackColor = System.Drawing.Color.MidnightBlue;
            this.lbl_taches.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_taches.Location = new System.Drawing.Point(860, 227);
            this.lbl_taches.Name = "lbl_taches";
            this.lbl_taches.Size = new System.Drawing.Size(411, 46);
            this.lbl_taches.TabIndex = 18;
            this.lbl_taches.Text = "Tâches urgentes en attente d\'action";
            this.lbl_taches.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(378, 108);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(753, 33);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Date de début : xx/xx/XXXX - Objectif de fin : xx/xx/XXXX";
            // 
            // lstBoxHistorique
            // 
            this.lstBoxHistorique.FormattingEnabled = true;
            this.lstBoxHistorique.HorizontalScrollbar = true;
            this.lstBoxHistorique.Location = new System.Drawing.Point(306, 294);
            this.lstBoxHistorique.Name = "lstBoxHistorique";
            this.lstBoxHistorique.ScrollAlwaysVisible = true;
            this.lstBoxHistorique.Size = new System.Drawing.Size(366, 186);
            this.lstBoxHistorique.TabIndex = 20;
            // 
            // lstTaskImp
            // 
            this.lstTaskImp.FormattingEnabled = true;
            this.lstTaskImp.HorizontalScrollbar = true;
            this.lstTaskImp.Location = new System.Drawing.Point(865, 294);
            this.lstTaskImp.Name = "lstTaskImp";
            this.lstTaskImp.ScrollAlwaysVisible = true;
            this.lstTaskImp.Size = new System.Drawing.Size(406, 433);
            this.lstTaskImp.TabIndex = 21;
            // 
            // lstBoxInfo
            // 
            this.lstBoxInfo.FormattingEnabled = true;
            this.lstBoxInfo.HorizontalScrollbar = true;
            this.lstBoxInfo.Location = new System.Drawing.Point(306, 513);
            this.lstBoxInfo.Name = "lstBoxInfo";
            this.lstBoxInfo.ScrollAlwaysVisible = true;
            this.lstBoxInfo.Size = new System.Drawing.Size(366, 186);
            this.lstBoxInfo.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TimeProject.Properties.Resources.logo;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 151);
            this.panel1.TabIndex = 3;
            // 
            // FormProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.lstBoxInfo);
            this.Controls.Add(this.lstTaskImp);
            this.Controls.Add(this.lstBoxHistorique);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl_taches);
            this.Controls.Add(this.lbl_histo);
            this.Controls.Add(this.btn_historique);
            this.Controls.Add(this.btn_suiviValidations);
            this.Controls.Add(this.btn_ficheLancement);
            this.Controls.Add(this.btn_suiviTH);
            this.Controls.Add(this.btn_bordereau);
            this.Controls.Add(this.btn_cptRendu);
            this.Controls.Add(this.btn_listePlans);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.panel1);
            this.Name = "FormProjet";
            this.Load += new System.EventHandler(this.FormProjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btn_bordereau;
        private System.Windows.Forms.Button btn_cptRendu;
        private System.Windows.Forms.Button btn_listePlans;
        private System.Windows.Forms.Button btn_suiviTH;
        private System.Windows.Forms.Button btn_ficheLancement;
        private System.Windows.Forms.Button btn_suiviValidations;
        private System.Windows.Forms.Button btn_historique;
        private System.Windows.Forms.Label lbl_histo;
        private System.Windows.Forms.Label lbl_taches;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox lstBoxHistorique;
        private System.Windows.Forms.ListBox lstTaskImp;
        private System.Windows.Forms.ListBox lstBoxInfo;
    }
}