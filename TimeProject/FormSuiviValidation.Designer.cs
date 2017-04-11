namespace TimeProject
{
    partial class FormSuiviValidation
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
            this.btValidArchi = new System.Windows.Forms.Button();
            this.btValidBC = new System.Windows.Forms.Button();
            this.dataGridViewValidation = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column_NumBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DateBE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NumPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DT_REP_ARCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NUM_COUR_ARCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_REP_ARCHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DT_REP_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NUM_COURR_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_REP_BC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidation)).BeginInit();
            this.SuspendLayout();
            // 
            // btValidArchi
            // 
            this.btValidArchi.BackColor = System.Drawing.Color.Navy;
            this.btValidArchi.ForeColor = System.Drawing.Color.White;
            this.btValidArchi.Location = new System.Drawing.Point(1086, 190);
            this.btValidArchi.Name = "btValidArchi";
            this.btValidArchi.Size = new System.Drawing.Size(177, 38);
            this.btValidArchi.TabIndex = 0;
            this.btValidArchi.Text = "Validation Archi";
            this.btValidArchi.UseVisualStyleBackColor = false;
            this.btValidArchi.Click += new System.EventHandler(this.btValidArchi_Click);
            // 
            // btValidBC
            // 
            this.btValidBC.BackColor = System.Drawing.Color.Navy;
            this.btValidBC.ForeColor = System.Drawing.Color.White;
            this.btValidBC.Location = new System.Drawing.Point(1086, 234);
            this.btValidBC.Name = "btValidBC";
            this.btValidBC.Size = new System.Drawing.Size(177, 38);
            this.btValidBC.TabIndex = 1;
            this.btValidBC.Text = "Validation BC";
            this.btValidBC.UseVisualStyleBackColor = false;
            this.btValidBC.Click += new System.EventHandler(this.btValidBC_Click);
            // 
            // dataGridViewValidation
            // 
            this.dataGridViewValidation.AllowUserToAddRows = false;
            this.dataGridViewValidation.AllowUserToDeleteRows = false;
            this.dataGridViewValidation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewValidation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NumBE,
            this.Column_DateBE,
            this.Column_NumPlan,
            this.Column_Indice,
            this.Column_DT_REP_ARCHI,
            this.Column_NUM_COUR_ARCHI,
            this.Column_REP_ARCHI,
            this.Column_DT_REP_BC,
            this.Column_NUM_COURR_BC,
            this.Column_REP_BC});
            this.dataGridViewValidation.Location = new System.Drawing.Point(36, 158);
            this.dataGridViewValidation.Name = "dataGridViewValidation";
            this.dataGridViewValidation.ReadOnly = true;
            this.dataGridViewValidation.Size = new System.Drawing.Size(1044, 343);
            this.dataGridViewValidation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suivi de validation";
            // 
            // Column_NumBE
            // 
            this.Column_NumBE.HeaderText = "Numéro bordereau";
            this.Column_NumBE.Name = "Column_NumBE";
            this.Column_NumBE.ReadOnly = true;
            // 
            // Column_DateBE
            // 
            this.Column_DateBE.HeaderText = "Date";
            this.Column_DateBE.Name = "Column_DateBE";
            this.Column_DateBE.ReadOnly = true;
            // 
            // Column_NumPlan
            // 
            this.Column_NumPlan.HeaderText = "N° / Plan";
            this.Column_NumPlan.Name = "Column_NumPlan";
            this.Column_NumPlan.ReadOnly = true;
            // 
            // Column_Indice
            // 
            this.Column_Indice.HeaderText = "Indice";
            this.Column_Indice.Name = "Column_Indice";
            this.Column_Indice.ReadOnly = true;
            // 
            // Column_DT_REP_ARCHI
            // 
            this.Column_DT_REP_ARCHI.HeaderText = "DT_REP_ARCHI";
            this.Column_DT_REP_ARCHI.Name = "Column_DT_REP_ARCHI";
            this.Column_DT_REP_ARCHI.ReadOnly = true;
            // 
            // Column_NUM_COUR_ARCHI
            // 
            this.Column_NUM_COUR_ARCHI.HeaderText = "NUM_COUR_ARCHI\t";
            this.Column_NUM_COUR_ARCHI.Name = "Column_NUM_COUR_ARCHI";
            this.Column_NUM_COUR_ARCHI.ReadOnly = true;
            // 
            // Column_REP_ARCHI
            // 
            this.Column_REP_ARCHI.HeaderText = "REP_ARCHI";
            this.Column_REP_ARCHI.Name = "Column_REP_ARCHI";
            this.Column_REP_ARCHI.ReadOnly = true;
            // 
            // Column_DT_REP_BC
            // 
            this.Column_DT_REP_BC.HeaderText = "DT_REP_BC";
            this.Column_DT_REP_BC.Name = "Column_DT_REP_BC";
            this.Column_DT_REP_BC.ReadOnly = true;
            // 
            // Column_NUM_COURR_BC
            // 
            this.Column_NUM_COURR_BC.HeaderText = "NUM_COURR_BC";
            this.Column_NUM_COURR_BC.Name = "Column_NUM_COURR_BC";
            this.Column_NUM_COURR_BC.ReadOnly = true;
            // 
            // Column_REP_BC
            // 
            this.Column_REP_BC.HeaderText = "REP_BC";
            this.Column_REP_BC.Name = "Column_REP_BC";
            this.Column_REP_BC.ReadOnly = true;
            // 
            // FormSuiviValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1299, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewValidation);
            this.Controls.Add(this.btValidBC);
            this.Controls.Add(this.btValidArchi);
            this.Name = "FormSuiviValidation";
            this.Text = "Suivi des validations";
            this.Load += new System.EventHandler(this.FormSuiviValidation_Onload);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewValidation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValidArchi;
        private System.Windows.Forms.Button btValidBC;
        private System.Windows.Forms.DataGridView dataGridViewValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NumBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DateBE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NumPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DT_REP_ARCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NUM_COUR_ARCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_REP_ARCHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DT_REP_BC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NUM_COURR_BC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_REP_BC;
    }
}