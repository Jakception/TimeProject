namespace TimeProject
{
    partial class FormGestionBE
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
            this.btn_CreationBE = new System.Windows.Forms.Button();
            this.btn_EditionPDF = new System.Windows.Forms.Button();
            this.btn_ValidationBE = new System.Windows.Forms.Button();
            this.btn_ModificationBE = new System.Windows.Forms.Button();
            this.dataGridViewBE = new System.Windows.Forms.DataGridView();
            this.Column_CodeBordereau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NumeroBordereau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NumeroPlans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Exemplaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Version = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBE)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionBE
            // 
            this.lblGestionBE.AutoSize = true;
            this.lblGestionBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionBE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblGestionBE.Location = new System.Drawing.Point(284, 40);
            this.lblGestionBE.Name = "lblGestionBE";
            this.lblGestionBE.Size = new System.Drawing.Size(408, 31);
            this.lblGestionBE.TabIndex = 24;
            this.lblGestionBE.Text = "Gestion des bordereaux d\'envois";
            // 
            // btn_CreationBE
            // 
            this.btn_CreationBE.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_CreationBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CreationBE.ForeColor = System.Drawing.Color.White;
            this.btn_CreationBE.Location = new System.Drawing.Point(41, 104);
            this.btn_CreationBE.Name = "btn_CreationBE";
            this.btn_CreationBE.Size = new System.Drawing.Size(195, 61);
            this.btn_CreationBE.TabIndex = 29;
            this.btn_CreationBE.Text = "Création";
            this.btn_CreationBE.UseVisualStyleBackColor = false;
            this.btn_CreationBE.Click += new System.EventHandler(this.btn_CreationBE_Click);
            // 
            // btn_EditionPDF
            // 
            this.btn_EditionPDF.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_EditionPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditionPDF.ForeColor = System.Drawing.Color.White;
            this.btn_EditionPDF.Location = new System.Drawing.Point(41, 376);
            this.btn_EditionPDF.Name = "btn_EditionPDF";
            this.btn_EditionPDF.Size = new System.Drawing.Size(195, 61);
            this.btn_EditionPDF.TabIndex = 28;
            this.btn_EditionPDF.Text = "Edition PDF";
            this.btn_EditionPDF.UseVisualStyleBackColor = false;
            this.btn_EditionPDF.Click += new System.EventHandler(this.btn_EditionPDF_Click);
            // 
            // btn_ValidationBE
            // 
            this.btn_ValidationBE.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ValidationBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValidationBE.ForeColor = System.Drawing.Color.White;
            this.btn_ValidationBE.Location = new System.Drawing.Point(41, 285);
            this.btn_ValidationBE.Name = "btn_ValidationBE";
            this.btn_ValidationBE.Size = new System.Drawing.Size(195, 61);
            this.btn_ValidationBE.TabIndex = 26;
            this.btn_ValidationBE.Text = "Validation";
            this.btn_ValidationBE.UseVisualStyleBackColor = false;
            this.btn_ValidationBE.Click += new System.EventHandler(this.btn_ValidationBE_Click);
            // 
            // btn_ModificationBE
            // 
            this.btn_ModificationBE.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ModificationBE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ModificationBE.ForeColor = System.Drawing.Color.White;
            this.btn_ModificationBE.Location = new System.Drawing.Point(41, 195);
            this.btn_ModificationBE.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ModificationBE.Name = "btn_ModificationBE";
            this.btn_ModificationBE.Size = new System.Drawing.Size(195, 61);
            this.btn_ModificationBE.TabIndex = 25;
            this.btn_ModificationBE.Text = "Modification";
            this.btn_ModificationBE.UseVisualStyleBackColor = false;
            this.btn_ModificationBE.Click += new System.EventHandler(this.btn_ModificationBE_Click);
            // 
            // dataGridViewBE
            // 
            this.dataGridViewBE.AllowUserToAddRows = false;
            this.dataGridViewBE.AllowUserToDeleteRows = false;
            this.dataGridViewBE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_CodeBordereau,
            this.Column_NumeroBordereau,
            this.Column_Designation,
            this.Column_NumeroPlans,
            this.Column_Exemplaire,
            this.Column_Version,
            this.Column_Etat});
            this.dataGridViewBE.Location = new System.Drawing.Point(290, 104);
            this.dataGridViewBE.MultiSelect = false;
            this.dataGridViewBE.Name = "dataGridViewBE";
            this.dataGridViewBE.ReadOnly = true;
            this.dataGridViewBE.Size = new System.Drawing.Size(713, 420);
            this.dataGridViewBE.TabIndex = 30;
            // 
            // Column_CodeBordereau
            // 
            this.Column_CodeBordereau.HeaderText = "Code bordereau";
            this.Column_CodeBordereau.Name = "Column_CodeBordereau";
            this.Column_CodeBordereau.ReadOnly = true;
            // 
            // Column_NumeroBordereau
            // 
            this.Column_NumeroBordereau.HeaderText = "Numéro";
            this.Column_NumeroBordereau.Name = "Column_NumeroBordereau";
            this.Column_NumeroBordereau.ReadOnly = true;
            // 
            // Column_Designation
            // 
            this.Column_Designation.HeaderText = "Désignation";
            this.Column_Designation.Name = "Column_Designation";
            this.Column_Designation.ReadOnly = true;
            // 
            // Column_NumeroPlans
            // 
            this.Column_NumeroPlans.HeaderText = "Numéro / Plan";
            this.Column_NumeroPlans.Name = "Column_NumeroPlans";
            this.Column_NumeroPlans.ReadOnly = true;
            // 
            // Column_Exemplaire
            // 
            this.Column_Exemplaire.HeaderText = "Exemplaire";
            this.Column_Exemplaire.Name = "Column_Exemplaire";
            this.Column_Exemplaire.ReadOnly = true;
            // 
            // Column_Version
            // 
            this.Column_Version.HeaderText = "Version";
            this.Column_Version.Name = "Column_Version";
            this.Column_Version.ReadOnly = true;
            // 
            // Column_Etat
            // 
            this.Column_Etat.HeaderText = "Etat";
            this.Column_Etat.Name = "Column_Etat";
            this.Column_Etat.ReadOnly = true;
            // 
            // FormGestionBE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1086, 558);
            this.Controls.Add(this.dataGridViewBE);
            this.Controls.Add(this.btn_CreationBE);
            this.Controls.Add(this.btn_EditionPDF);
            this.Controls.Add(this.btn_ValidationBE);
            this.Controls.Add(this.btn_ModificationBE);
            this.Controls.Add(this.lblGestionBE);
            this.Name = "FormGestionBE";
            this.Text = "Gestion des bordereaux d\'envois";
            this.Load += new System.EventHandler(this.FormGestionBE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGestionBE;
        private System.Windows.Forms.Button btn_CreationBE;
        private System.Windows.Forms.Button btn_EditionPDF;
        private System.Windows.Forms.Button btn_ValidationBE;
        private System.Windows.Forms.Button btn_ModificationBE;
        private System.Windows.Forms.DataGridView dataGridViewBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CodeBordereau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NumeroBordereau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NumeroPlans;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Exemplaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Version;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Etat;
    }
}