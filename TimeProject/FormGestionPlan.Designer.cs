﻿namespace TimeProject
{
    partial class FormGestionPlan
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
            this.lstBoxPlan = new System.Windows.Forms.ListBox();
            this.lblGestionPlan = new System.Windows.Forms.Label();
            this.btn_AjoutPlan = new System.Windows.Forms.Button();
            this.btn_EditionPDF = new System.Windows.Forms.Button();
            this.btn_ListeDernierIndice = new System.Windows.Forms.Button();
            this.btn_SuppressionPlan = new System.Windows.Forms.Button();
            this.btn_ModificationPlan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxPlan
            // 
            this.lstBoxPlan.FormattingEnabled = true;
            this.lstBoxPlan.Location = new System.Drawing.Point(293, 104);
            this.lstBoxPlan.Name = "lstBoxPlan";
            this.lstBoxPlan.ScrollAlwaysVisible = true;
            this.lstBoxPlan.Size = new System.Drawing.Size(713, 420);
            this.lstBoxPlan.TabIndex = 2;
            // 
            // lblGestionPlan
            // 
            this.lblGestionPlan.AutoSize = true;
            this.lblGestionPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGestionPlan.Location = new System.Drawing.Point(287, 37);
            this.lblGestionPlan.Name = "lblGestionPlan";
            this.lblGestionPlan.Size = new System.Drawing.Size(231, 31);
            this.lblGestionPlan.TabIndex = 24;
            this.lblGestionPlan.Text = "Gestion des plans";
            // 
            // btn_AjoutPlan
            // 
            this.btn_AjoutPlan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_AjoutPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AjoutPlan.ForeColor = System.Drawing.Color.White;
            this.btn_AjoutPlan.Location = new System.Drawing.Point(41, 104);
            this.btn_AjoutPlan.Name = "btn_AjoutPlan";
            this.btn_AjoutPlan.Size = new System.Drawing.Size(195, 61);
            this.btn_AjoutPlan.TabIndex = 29;
            this.btn_AjoutPlan.Text = "Ajout";
            this.btn_AjoutPlan.UseVisualStyleBackColor = false;
            this.btn_AjoutPlan.Click += new System.EventHandler(this.btn_AjoutPlan_Click);
            // 
            // btn_EditionPDF
            // 
            this.btn_EditionPDF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EditionPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditionPDF.ForeColor = System.Drawing.Color.White;
            this.btn_EditionPDF.Location = new System.Drawing.Point(41, 463);
            this.btn_EditionPDF.Name = "btn_EditionPDF";
            this.btn_EditionPDF.Size = new System.Drawing.Size(195, 61);
            this.btn_EditionPDF.TabIndex = 28;
            this.btn_EditionPDF.Text = "Edition PDF";
            this.btn_EditionPDF.UseVisualStyleBackColor = false;
            this.btn_EditionPDF.Click += new System.EventHandler(this.btn_EditionPDF_Click);
            // 
            // btn_ListeDernierIndice
            // 
            this.btn_ListeDernierIndice.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ListeDernierIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListeDernierIndice.ForeColor = System.Drawing.Color.White;
            this.btn_ListeDernierIndice.Location = new System.Drawing.Point(41, 371);
            this.btn_ListeDernierIndice.Name = "btn_ListeDernierIndice";
            this.btn_ListeDernierIndice.Size = new System.Drawing.Size(195, 61);
            this.btn_ListeDernierIndice.TabIndex = 27;
            this.btn_ListeDernierIndice.Text = "Liste dernier Indice";
            this.btn_ListeDernierIndice.UseVisualStyleBackColor = false;
            // 
            // btn_SuppressionPlan
            // 
            this.btn_SuppressionPlan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_SuppressionPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuppressionPlan.ForeColor = System.Drawing.Color.White;
            this.btn_SuppressionPlan.Location = new System.Drawing.Point(41, 285);
            this.btn_SuppressionPlan.Name = "btn_SuppressionPlan";
            this.btn_SuppressionPlan.Size = new System.Drawing.Size(195, 61);
            this.btn_SuppressionPlan.TabIndex = 26;
            this.btn_SuppressionPlan.Text = "Suprression";
            this.btn_SuppressionPlan.UseVisualStyleBackColor = false;
            this.btn_SuppressionPlan.Click += new System.EventHandler(this.btn_SuppressionPlan_Click);
            // 
            // btn_ModificationPlan
            // 
            this.btn_ModificationPlan.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ModificationPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificationPlan.ForeColor = System.Drawing.Color.White;
            this.btn_ModificationPlan.Location = new System.Drawing.Point(41, 195);
            this.btn_ModificationPlan.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ModificationPlan.Name = "btn_ModificationPlan";
            this.btn_ModificationPlan.Size = new System.Drawing.Size(195, 61);
            this.btn_ModificationPlan.TabIndex = 25;
            this.btn_ModificationPlan.Text = "Modification";
            this.btn_ModificationPlan.UseVisualStyleBackColor = false;
            this.btn_ModificationPlan.Click += new System.EventHandler(this.btn_ModificationPlan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1051, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AjoutPlan);
            this.Controls.Add(this.btn_EditionPDF);
            this.Controls.Add(this.btn_ListeDernierIndice);
            this.Controls.Add(this.btn_SuppressionPlan);
            this.Controls.Add(this.btn_ModificationPlan);
            this.Controls.Add(this.lblGestionPlan);
            this.Controls.Add(this.lstBoxPlan);
            this.Name = "FormGestionPlan";
            this.Text = "Gestion des plans";
            this.Load += new System.EventHandler(this.FormGestionPlan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPlan;
        private System.Windows.Forms.Label lblGestionPlan;
        private System.Windows.Forms.Button btn_AjoutPlan;
        private System.Windows.Forms.Button btn_EditionPDF;
        private System.Windows.Forms.Button btn_ListeDernierIndice;
        private System.Windows.Forms.Button btn_SuppressionPlan;
        private System.Windows.Forms.Button btn_ModificationPlan;
        private System.Windows.Forms.Button button1;
    }
}