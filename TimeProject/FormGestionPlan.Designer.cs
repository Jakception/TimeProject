namespace TimeProject
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
            this.txtBoxCodeProjet = new System.Windows.Forms.TextBox();
            this.txtBoxIndice = new System.Windows.Forms.TextBox();
            this.txtBoxCodePlan = new System.Windows.Forms.TextBox();
            this.lblIndice = new System.Windows.Forms.Label();
            this.lblCodePlan = new System.Windows.Forms.Label();
            this.btSupprimerPlan = new System.Windows.Forms.Button();
            this.btCreaPlan = new System.Windows.Forms.Button();
            this.lblGestionPlan = new System.Windows.Forms.Label();
            this.labelCodeProjet = new System.Windows.Forms.Label();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.txtBoxDesignationPlan = new System.Windows.Forms.TextBox();
            this.txtBoxLibellePlan = new System.Windows.Forms.TextBox();
            this.txtBoxNumPlan = new System.Windows.Forms.TextBox();
            this.labelLibelle = new System.Windows.Forms.Label();
            this.labelNumPlan = new System.Windows.Forms.Label();
            this.dtPickPlan = new System.Windows.Forms.DateTimePicker();
            this.labelDtPlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxPlan
            // 
            this.lstBoxPlan.FormattingEnabled = true;
            this.lstBoxPlan.Location = new System.Drawing.Point(25, 95);
            this.lstBoxPlan.Name = "lstBoxPlan";
            this.lstBoxPlan.ScrollAlwaysVisible = true;
            this.lstBoxPlan.Size = new System.Drawing.Size(276, 420);
            this.lstBoxPlan.TabIndex = 2;
            // 
            // txtBoxCodeProjet
            // 
            this.txtBoxCodeProjet.Location = new System.Drawing.Point(500, 222);
            this.txtBoxCodeProjet.Name = "txtBoxCodeProjet";
            this.txtBoxCodeProjet.Size = new System.Drawing.Size(273, 20);
            this.txtBoxCodeProjet.TabIndex = 21;
            // 
            // txtBoxIndice
            // 
            this.txtBoxIndice.Location = new System.Drawing.Point(499, 172);
            this.txtBoxIndice.Name = "txtBoxIndice";
            this.txtBoxIndice.Size = new System.Drawing.Size(273, 20);
            this.txtBoxIndice.TabIndex = 20;
            // 
            // txtBoxCodePlan
            // 
            this.txtBoxCodePlan.Location = new System.Drawing.Point(499, 122);
            this.txtBoxCodePlan.Name = "txtBoxCodePlan";
            this.txtBoxCodePlan.Size = new System.Drawing.Size(273, 20);
            this.txtBoxCodePlan.TabIndex = 19;
            // 
            // lblIndice
            // 
            this.lblIndice.AutoSize = true;
            this.lblIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndice.Location = new System.Drawing.Point(496, 145);
            this.lblIndice.Name = "lblIndice";
            this.lblIndice.Size = new System.Drawing.Size(61, 24);
            this.lblIndice.TabIndex = 17;
            this.lblIndice.Text = "Indice";
            // 
            // lblCodePlan
            // 
            this.lblCodePlan.AutoSize = true;
            this.lblCodePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePlan.Location = new System.Drawing.Point(496, 95);
            this.lblCodePlan.Name = "lblCodePlan";
            this.lblCodePlan.Size = new System.Drawing.Size(97, 24);
            this.lblCodePlan.TabIndex = 15;
            this.lblCodePlan.Text = "Code plan";
            // 
            // btSupprimerPlan
            // 
            this.btSupprimerPlan.Location = new System.Drawing.Point(340, 287);
            this.btSupprimerPlan.Name = "btSupprimerPlan";
            this.btSupprimerPlan.Size = new System.Drawing.Size(112, 61);
            this.btSupprimerPlan.TabIndex = 14;
            this.btSupprimerPlan.Text = "Supprimer";
            this.btSupprimerPlan.UseVisualStyleBackColor = true;
            this.btSupprimerPlan.Click += new System.EventHandler(this.btSupprimerPlan_Click);
            // 
            // btCreaPlan
            // 
            this.btCreaPlan.Location = new System.Drawing.Point(340, 157);
            this.btCreaPlan.Name = "btCreaPlan";
            this.btCreaPlan.Size = new System.Drawing.Size(112, 61);
            this.btCreaPlan.TabIndex = 13;
            this.btCreaPlan.Text = "Créer";
            this.btCreaPlan.UseVisualStyleBackColor = true;
            this.btCreaPlan.Click += new System.EventHandler(this.btCreaPlan_Click);
            // 
            // lblGestionPlan
            // 
            this.lblGestionPlan.AutoSize = true;
            this.lblGestionPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPlan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGestionPlan.Location = new System.Drawing.Point(287, 33);
            this.lblGestionPlan.Name = "lblGestionPlan";
            this.lblGestionPlan.Size = new System.Drawing.Size(231, 31);
            this.lblGestionPlan.TabIndex = 24;
            this.lblGestionPlan.Text = "Gestion des plans";
            // 
            // labelCodeProjet
            // 
            this.labelCodeProjet.AutoSize = true;
            this.labelCodeProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeProjet.Location = new System.Drawing.Point(496, 195);
            this.labelCodeProjet.Name = "labelCodeProjet";
            this.labelCodeProjet.Size = new System.Drawing.Size(135, 24);
            this.labelCodeProjet.TabIndex = 25;
            this.labelCodeProjet.Text = "Code du projet";
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDesignation.Location = new System.Drawing.Point(496, 345);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(109, 24);
            this.labelDesignation.TabIndex = 31;
            this.labelDesignation.Text = "Désignation";
            // 
            // txtBoxDesignationPlan
            // 
            this.txtBoxDesignationPlan.Location = new System.Drawing.Point(500, 372);
            this.txtBoxDesignationPlan.Name = "txtBoxDesignationPlan";
            this.txtBoxDesignationPlan.Size = new System.Drawing.Size(273, 20);
            this.txtBoxDesignationPlan.TabIndex = 30;
            // 
            // txtBoxLibellePlan
            // 
            this.txtBoxLibellePlan.Location = new System.Drawing.Point(499, 322);
            this.txtBoxLibellePlan.Name = "txtBoxLibellePlan";
            this.txtBoxLibellePlan.Size = new System.Drawing.Size(273, 20);
            this.txtBoxLibellePlan.TabIndex = 29;
            // 
            // txtBoxNumPlan
            // 
            this.txtBoxNumPlan.Location = new System.Drawing.Point(499, 272);
            this.txtBoxNumPlan.Name = "txtBoxNumPlan";
            this.txtBoxNumPlan.Size = new System.Drawing.Size(273, 20);
            this.txtBoxNumPlan.TabIndex = 28;
            // 
            // labelLibelle
            // 
            this.labelLibelle.AutoSize = true;
            this.labelLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibelle.Location = new System.Drawing.Point(496, 295);
            this.labelLibelle.Name = "labelLibelle";
            this.labelLibelle.Size = new System.Drawing.Size(65, 24);
            this.labelLibelle.TabIndex = 27;
            this.labelLibelle.Text = "Libelle";
            // 
            // labelNumPlan
            // 
            this.labelNumPlan.AutoSize = true;
            this.labelNumPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumPlan.Location = new System.Drawing.Point(496, 245);
            this.labelNumPlan.Name = "labelNumPlan";
            this.labelNumPlan.Size = new System.Drawing.Size(120, 24);
            this.labelNumPlan.TabIndex = 26;
            this.labelNumPlan.Text = "Numéro plan";
            // 
            // dtPickPlan
            // 
            this.dtPickPlan.Location = new System.Drawing.Point(499, 422);
            this.dtPickPlan.Name = "dtPickPlan";
            this.dtPickPlan.Size = new System.Drawing.Size(273, 20);
            this.dtPickPlan.TabIndex = 32;
            // 
            // labelDtPlan
            // 
            this.labelDtPlan.AutoSize = true;
            this.labelDtPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDtPlan.Location = new System.Drawing.Point(496, 395);
            this.labelDtPlan.Name = "labelDtPlan";
            this.labelDtPlan.Size = new System.Drawing.Size(116, 24);
            this.labelDtPlan.TabIndex = 33;
            this.labelDtPlan.Text = "Date du plan";
            // 
            // FormGestionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(798, 558);
            this.Controls.Add(this.labelDtPlan);
            this.Controls.Add(this.dtPickPlan);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.txtBoxDesignationPlan);
            this.Controls.Add(this.txtBoxLibellePlan);
            this.Controls.Add(this.txtBoxNumPlan);
            this.Controls.Add(this.labelLibelle);
            this.Controls.Add(this.labelNumPlan);
            this.Controls.Add(this.labelCodeProjet);
            this.Controls.Add(this.lblGestionPlan);
            this.Controls.Add(this.txtBoxCodeProjet);
            this.Controls.Add(this.txtBoxIndice);
            this.Controls.Add(this.txtBoxCodePlan);
            this.Controls.Add(this.lblIndice);
            this.Controls.Add(this.lblCodePlan);
            this.Controls.Add(this.btSupprimerPlan);
            this.Controls.Add(this.btCreaPlan);
            this.Controls.Add(this.lstBoxPlan);
            this.Name = "FormGestionPlan";
            this.Text = "FormGestionPlan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxPlan;
        private System.Windows.Forms.TextBox txtBoxCodeProjet;
        private System.Windows.Forms.TextBox txtBoxIndice;
        private System.Windows.Forms.TextBox txtBoxCodePlan;
        private System.Windows.Forms.Label lblIndice;
        private System.Windows.Forms.Label lblCodePlan;
        private System.Windows.Forms.Button btSupprimerPlan;
        private System.Windows.Forms.Button btCreaPlan;
        private System.Windows.Forms.Label lblGestionPlan;
        private System.Windows.Forms.Label labelCodeProjet;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.TextBox txtBoxDesignationPlan;
        private System.Windows.Forms.TextBox txtBoxLibellePlan;
        private System.Windows.Forms.TextBox txtBoxNumPlan;
        private System.Windows.Forms.Label labelLibelle;
        private System.Windows.Forms.Label labelNumPlan;
        private System.Windows.Forms.DateTimePicker dtPickPlan;
        private System.Windows.Forms.Label labelDtPlan;
    }
}