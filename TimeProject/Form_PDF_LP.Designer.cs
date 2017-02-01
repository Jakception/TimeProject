namespace TimeProject
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Affairesuivie = new System.Windows.Forms.Label();
            this.label_refDossier = new System.Windows.Forms.Label();
            this.label_listePlans = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Col_nb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_design = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_Affairesuivie
            // 
            this.label_Affairesuivie.AutoSize = true;
            this.label_Affairesuivie.Location = new System.Drawing.Point(22, 124);
            this.label_Affairesuivie.Name = "label_Affairesuivie";
            this.label_Affairesuivie.Size = new System.Drawing.Size(91, 13);
            this.label_Affairesuivie.TabIndex = 1;
            this.label_Affairesuivie.Text = "Affaire suivie par :";
            // 
            // label_refDossier
            // 
            this.label_refDossier.AutoSize = true;
            this.label_refDossier.Location = new System.Drawing.Point(22, 152);
            this.label_refDossier.Name = "label_refDossier";
            this.label_refDossier.Size = new System.Drawing.Size(99, 13);
            this.label_refDossier.TabIndex = 2;
            this.label_refDossier.Text = "Référence dossier :";
            // 
            // label_listePlans
            // 
            this.label_listePlans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_listePlans.AutoSize = true;
            this.label_listePlans.Location = new System.Drawing.Point(345, 177);
            this.label_listePlans.Name = "label_listePlans";
            this.label_listePlans.Size = new System.Drawing.Size(100, 13);
            this.label_listePlans.TabIndex = 3;
            this.label_listePlans.Text = "LISTE DES PLANS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nb,
            this.col_design,
            this.col_date,
            this.col_indice});
            this.dataGridView1.Location = new System.Drawing.Point(25, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(754, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // Col_nb
            // 
            this.Col_nb.HeaderText = "N°";
            this.Col_nb.Name = "Col_nb";
            // 
            // col_design
            // 
            this.col_design.HeaderText = "DESIGNATION";
            this.col_design.Name = "col_design";
            // 
            // col_date
            // 
            this.col_date.HeaderText = "DATE";
            this.col_date.Name = "col_date";
            // 
            // col_indice
            // 
            this.col_indice.HeaderText = "INDICE";
            this.col_indice.Name = "col_indice";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(22, 100);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 5;
            this.label_date.Text = "Date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 429);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_listePlans);
            this.Controls.Add(this.label_refDossier);
            this.Controls.Add(this.label_Affairesuivie);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Affairesuivie;
        private System.Windows.Forms.Label label_refDossier;
        private System.Windows.Forms.Label label_listePlans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_design;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_indice;
        private System.Windows.Forms.Label label_date;
    }
}