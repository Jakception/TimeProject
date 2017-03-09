namespace TimeProject
{
    partial class FormAdmininistration
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
            this.btPersonne = new System.Windows.Forms.Button();
            this.btProjet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPersonne
            // 
            this.btPersonne.BackColor = System.Drawing.Color.Navy;
            this.btPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPersonne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPersonne.Location = new System.Drawing.Point(31, 94);
            this.btPersonne.Name = "btPersonne";
            this.btPersonne.Size = new System.Drawing.Size(241, 110);
            this.btPersonne.TabIndex = 0;
            this.btPersonne.Text = "Gérer les utilisateurs";
            this.btPersonne.UseVisualStyleBackColor = false;
            this.btPersonne.Click += new System.EventHandler(this.btPersonne_Click);
            // 
            // btProjet
            // 
            this.btProjet.BackColor = System.Drawing.Color.Navy;
            this.btProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProjet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btProjet.Location = new System.Drawing.Point(560, 94);
            this.btProjet.Name = "btProjet";
            this.btProjet.Size = new System.Drawing.Size(241, 110);
            this.btProjet.TabIndex = 1;
            this.btProjet.Text = "Gérer les projets";
            this.btProjet.UseVisualStyleBackColor = false;
            // 
            // FormAdmininistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(925, 551);
            this.Controls.Add(this.btProjet);
            this.Controls.Add(this.btPersonne);
            this.Name = "FormAdmininistration";
            this.Text = "FormAdmininistration";
            this.Load += new System.EventHandler(this.FormAdmininistration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPersonne;
        private System.Windows.Forms.Button btProjet;
    }
}