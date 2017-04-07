namespace TimeProject
{
    partial class FormCUBordereauEnvoi
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
            this.lblGestionBE = new System.Windows.Forms.Label();
            this.textBoxExemplaireBordereau = new System.Windows.Forms.TextBox();
            this.labelExemplaireBordereau = new System.Windows.Forms.Label();
            this.buttonAnnuleBE = new System.Windows.Forms.Button();
            this.textBoxDesignationBordereau = new System.Windows.Forms.TextBox();
            this.textBoxNumeroBordereau = new System.Windows.Forms.TextBox();
            this.labelLiebelleDesignationBordereau = new System.Windows.Forms.Label();
            this.labelNumeroBordereau = new System.Windows.Forms.Label();
            this.buttonValiderBE = new System.Windows.Forms.Button();
            this.textBoxEtatBordereau = new System.Windows.Forms.TextBox();
            this.labelEtatBordereau = new System.Windows.Forms.Label();
            this.textBoxVersionBordereau = new System.Windows.Forms.TextBox();
            this.labelVersionBordereau = new System.Windows.Forms.Label();
            this.dataGridViewPlan = new System.Windows.Forms.DataGridView();
            this.Column_CheckBoxPlan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_CodePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_CodeProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NumeroPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LibellePlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DtPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionBE
            // 
            this.lblGestionBE.AutoSize = true;
            this.lblGestionBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionBE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGestionBE.Location = new System.Drawing.Point(22, 26);
            this.lblGestionBE.Name = "lblGestionBE";
            this.lblGestionBE.Size = new System.Drawing.Size(408, 31);
            this.lblGestionBE.TabIndex = 25;
            this.lblGestionBE.Text = "Gestion des bordereaux d\'envois";
            // 
            // textBoxExemplaireBordereau
            // 
            this.textBoxExemplaireBordereau.Location = new System.Drawing.Point(210, 213);
            this.textBoxExemplaireBordereau.Name = "textBoxExemplaireBordereau";
            this.textBoxExemplaireBordereau.Size = new System.Drawing.Size(200, 20);
            this.textBoxExemplaireBordereau.TabIndex = 33;
            // 
            // labelExemplaireBordereau
            // 
            this.labelExemplaireBordereau.AutoSize = true;
            this.labelExemplaireBordereau.Location = new System.Drawing.Point(41, 216);
            this.labelExemplaireBordereau.Name = "labelExemplaireBordereau";
            this.labelExemplaireBordereau.Size = new System.Drawing.Size(58, 13);
            this.labelExemplaireBordereau.TabIndex = 32;
            this.labelExemplaireBordereau.Text = "Exemplaire";
            // 
            // buttonAnnuleBE
            // 
            this.buttonAnnuleBE.BackColor = System.Drawing.Color.Navy;
            this.buttonAnnuleBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAnnuleBE.ForeColor = System.Drawing.Color.White;
            this.buttonAnnuleBE.Location = new System.Drawing.Point(1175, 557);
            this.buttonAnnuleBE.Name = "buttonAnnuleBE";
            this.buttonAnnuleBE.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnuleBE.TabIndex = 31;
            this.buttonAnnuleBE.Text = "Annuler";
            this.buttonAnnuleBE.UseVisualStyleBackColor = false;
            this.buttonAnnuleBE.Click += new System.EventHandler(this.buttonAnnuleBE_Click);
            // 
            // textBoxDesignationBordereau
            // 
            this.textBoxDesignationBordereau.Location = new System.Drawing.Point(210, 156);
            this.textBoxDesignationBordereau.Name = "textBoxDesignationBordereau";
            this.textBoxDesignationBordereau.Size = new System.Drawing.Size(200, 20);
            this.textBoxDesignationBordereau.TabIndex = 30;
            // 
            // textBoxNumeroBordereau
            // 
            this.textBoxNumeroBordereau.Location = new System.Drawing.Point(210, 98);
            this.textBoxNumeroBordereau.Name = "textBoxNumeroBordereau";
            this.textBoxNumeroBordereau.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroBordereau.TabIndex = 29;
            // 
            // labelLiebelleDesignationBordereau
            // 
            this.labelLiebelleDesignationBordereau.AutoSize = true;
            this.labelLiebelleDesignationBordereau.Location = new System.Drawing.Point(41, 159);
            this.labelLiebelleDesignationBordereau.Name = "labelLiebelleDesignationBordereau";
            this.labelLiebelleDesignationBordereau.Size = new System.Drawing.Size(130, 13);
            this.labelLiebelleDesignationBordereau.TabIndex = 27;
            this.labelLiebelleDesignationBordereau.Text = "Désignation du Bordereau";
            // 
            // labelNumeroBordereau
            // 
            this.labelNumeroBordereau.AutoSize = true;
            this.labelNumeroBordereau.Location = new System.Drawing.Point(41, 101);
            this.labelNumeroBordereau.Name = "labelNumeroBordereau";
            this.labelNumeroBordereau.Size = new System.Drawing.Size(110, 13);
            this.labelNumeroBordereau.TabIndex = 26;
            this.labelNumeroBordereau.Text = "Numéro du bordereau";
            // 
            // buttonValiderBE
            // 
            this.buttonValiderBE.BackColor = System.Drawing.Color.Navy;
            this.buttonValiderBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonValiderBE.ForeColor = System.Drawing.Color.White;
            this.buttonValiderBE.Location = new System.Drawing.Point(1014, 557);
            this.buttonValiderBE.Name = "buttonValiderBE";
            this.buttonValiderBE.Size = new System.Drawing.Size(121, 45);
            this.buttonValiderBE.TabIndex = 28;
            this.buttonValiderBE.Text = "Valider";
            this.buttonValiderBE.UseVisualStyleBackColor = false;
            this.buttonValiderBE.Click += new System.EventHandler(this.buttonValiderBE_Click);
            // 
            // textBoxEtatBordereau
            // 
            this.textBoxEtatBordereau.Location = new System.Drawing.Point(210, 329);
            this.textBoxEtatBordereau.Name = "textBoxEtatBordereau";
            this.textBoxEtatBordereau.Size = new System.Drawing.Size(200, 20);
            this.textBoxEtatBordereau.TabIndex = 37;
            // 
            // labelEtatBordereau
            // 
            this.labelEtatBordereau.AutoSize = true;
            this.labelEtatBordereau.Location = new System.Drawing.Point(41, 332);
            this.labelEtatBordereau.Name = "labelEtatBordereau";
            this.labelEtatBordereau.Size = new System.Drawing.Size(26, 13);
            this.labelEtatBordereau.TabIndex = 36;
            this.labelEtatBordereau.Text = "Etat";
            // 
            // textBoxVersionBordereau
            // 
            this.textBoxVersionBordereau.Location = new System.Drawing.Point(210, 272);
            this.textBoxVersionBordereau.Name = "textBoxVersionBordereau";
            this.textBoxVersionBordereau.Size = new System.Drawing.Size(200, 20);
            this.textBoxVersionBordereau.TabIndex = 35;
            // 
            // labelVersionBordereau
            // 
            this.labelVersionBordereau.AutoSize = true;
            this.labelVersionBordereau.Location = new System.Drawing.Point(41, 275);
            this.labelVersionBordereau.Name = "labelVersionBordereau";
            this.labelVersionBordereau.Size = new System.Drawing.Size(42, 13);
            this.labelVersionBordereau.TabIndex = 34;
            this.labelVersionBordereau.Text = "Version";
            // 
            // dataGridViewPlan
            // 
            this.dataGridViewPlan.AllowUserToAddRows = false;
            this.dataGridViewPlan.AllowUserToDeleteRows = false;
            this.dataGridViewPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CheckBoxPlan,
            this.Column_CodePlan,
            this.Column_Indice,
            this.Column_CodeProjet,
            this.Column_NumeroPlan,
            this.Column_LibellePlan,
            this.Column_Designation,
            this.Column_DtPlan});
            this.dataGridViewPlan.Location = new System.Drawing.Point(458, 98);
            this.dataGridViewPlan.MultiSelect = false;
            this.dataGridViewPlan.Name = "dataGridViewPlan";
            this.dataGridViewPlan.ReadOnly = true;
            this.dataGridViewPlan.Size = new System.Drawing.Size(838, 420);
            this.dataGridViewPlan.TabIndex = 38;
            this.dataGridViewPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlan_CellContentClick);
            // 
            // Column_CheckBoxPlan
            // 
            this.Column_CheckBoxPlan.HeaderText = "";
            this.Column_CheckBoxPlan.Name = "Column_CheckBoxPlan";
            this.Column_CheckBoxPlan.ReadOnly = true;
            // 
            // Column_CodePlan
            // 
            this.Column_CodePlan.HeaderText = "Code plan";
            this.Column_CodePlan.Name = "Column_CodePlan";
            this.Column_CodePlan.ReadOnly = true;
            // 
            // Column_Indice
            // 
            this.Column_Indice.HeaderText = "Indice";
            this.Column_Indice.Name = "Column_Indice";
            this.Column_Indice.ReadOnly = true;
            // 
            // Column_CodeProjet
            // 
            this.Column_CodeProjet.HeaderText = "Code projet";
            this.Column_CodeProjet.Name = "Column_CodeProjet";
            this.Column_CodeProjet.ReadOnly = true;
            // 
            // Column_NumeroPlan
            // 
            this.Column_NumeroPlan.HeaderText = "Numéro du plan";
            this.Column_NumeroPlan.Name = "Column_NumeroPlan";
            this.Column_NumeroPlan.ReadOnly = true;
            // 
            // Column_LibellePlan
            // 
            this.Column_LibellePlan.HeaderText = "Libelle du plan";
            this.Column_LibellePlan.Name = "Column_LibellePlan";
            this.Column_LibellePlan.ReadOnly = true;
            // 
            // Column_Designation
            // 
            this.Column_Designation.HeaderText = "Désignation";
            this.Column_Designation.Name = "Column_Designation";
            this.Column_Designation.ReadOnly = true;
            // 
            // Column_DtPlan
            // 
            this.Column_DtPlan.HeaderText = "Date de création";
            this.Column_DtPlan.Name = "Column_DtPlan";
            this.Column_DtPlan.ReadOnly = true;
            // 
            // FormCUBordereauEnvoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1344, 614);
            this.Controls.Add(this.dataGridViewPlan);
            this.Controls.Add(this.textBoxEtatBordereau);
            this.Controls.Add(this.labelEtatBordereau);
            this.Controls.Add(this.textBoxVersionBordereau);
            this.Controls.Add(this.labelVersionBordereau);
            this.Controls.Add(this.textBoxExemplaireBordereau);
            this.Controls.Add(this.labelExemplaireBordereau);
            this.Controls.Add(this.buttonAnnuleBE);
            this.Controls.Add(this.textBoxDesignationBordereau);
            this.Controls.Add(this.textBoxNumeroBordereau);
            this.Controls.Add(this.labelLiebelleDesignationBordereau);
            this.Controls.Add(this.labelNumeroBordereau);
            this.Controls.Add(this.buttonValiderBE);
            this.Controls.Add(this.lblGestionBE);
            this.Name = "FormCUBordereauEnvoi";
            this.Text = "Gestion bordereau d\'envoi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionBE;
        private System.Windows.Forms.TextBox textBoxExemplaireBordereau;
        private System.Windows.Forms.Label labelExemplaireBordereau;
        private System.Windows.Forms.Button buttonAnnuleBE;
        private System.Windows.Forms.TextBox textBoxDesignationBordereau;
        private System.Windows.Forms.TextBox textBoxNumeroBordereau;
        private System.Windows.Forms.Label labelLiebelleDesignationBordereau;
        private System.Windows.Forms.Label labelNumeroBordereau;
        private System.Windows.Forms.Button buttonValiderBE;
        private System.Windows.Forms.TextBox textBoxEtatBordereau;
        private System.Windows.Forms.Label labelEtatBordereau;
        private System.Windows.Forms.TextBox textBoxVersionBordereau;
        private System.Windows.Forms.Label labelVersionBordereau;
        private System.Windows.Forms.DataGridView dataGridViewPlan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_CheckBoxPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CodePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CodeProjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NumeroPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LibellePlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DtPlan;
    }
}