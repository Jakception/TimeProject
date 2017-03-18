namespace TimeProject
{
    partial class FormGestionProjet
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
            this.btCreaProjet = new System.Windows.Forms.Button();
            this.lstBoxProjet = new System.Windows.Forms.ListBox();
            this.btCloreProjet = new System.Windows.Forms.Button();
            this.btGestionUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreaProjet
            // 
            this.btCreaProjet.Location = new System.Drawing.Point(327, 164);
            this.btCreaProjet.Name = "btCreaProjet";
            this.btCreaProjet.Size = new System.Drawing.Size(134, 49);
            this.btCreaProjet.TabIndex = 0;
            this.btCreaProjet.Text = "Créer projet";
            this.btCreaProjet.UseVisualStyleBackColor = true;
            this.btCreaProjet.Click += new System.EventHandler(this.btCreaProjet_Click);
            // 
            // lstBoxProjet
            // 
            this.lstBoxProjet.FormattingEnabled = true;
            this.lstBoxProjet.Location = new System.Drawing.Point(12, 107);
            this.lstBoxProjet.Name = "lstBoxProjet";
            this.lstBoxProjet.ScrollAlwaysVisible = true;
            this.lstBoxProjet.Size = new System.Drawing.Size(276, 394);
            this.lstBoxProjet.TabIndex = 1;
            // 
            // btCloreProjet
            // 
            this.btCloreProjet.Location = new System.Drawing.Point(327, 336);
            this.btCloreProjet.Name = "btCloreProjet";
            this.btCloreProjet.Size = new System.Drawing.Size(134, 49);
            this.btCloreProjet.TabIndex = 2;
            this.btCloreProjet.Text = "Clore projet";
            this.btCloreProjet.UseVisualStyleBackColor = true;
            this.btCloreProjet.Click += new System.EventHandler(this.btCloreProjet_Click);
            // 
            // btGestionUser
            // 
            this.btGestionUser.Location = new System.Drawing.Point(327, 254);
            this.btGestionUser.Name = "btGestionUser";
            this.btGestionUser.Size = new System.Drawing.Size(134, 49);
            this.btGestionUser.TabIndex = 3;
            this.btGestionUser.Text = "Gestion des personnes";
            this.btGestionUser.UseVisualStyleBackColor = true;
            this.btGestionUser.Click += new System.EventHandler(this.btGestionUser_Click);
            // 
            // FormGestionProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 542);
            this.Controls.Add(this.btGestionUser);
            this.Controls.Add(this.btCloreProjet);
            this.Controls.Add(this.lstBoxProjet);
            this.Controls.Add(this.btCreaProjet);
            this.MaximumSize = new System.Drawing.Size(508, 581);
            this.MinimumSize = new System.Drawing.Size(508, 581);
            this.Name = "FormGestionProjet";
            this.Text = "FormGestionProjet";
            this.Load += new System.EventHandler(this.FormGestionProjet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreaProjet;
        private System.Windows.Forms.ListBox lstBoxProjet;
        private System.Windows.Forms.Button btCloreProjet;
        private System.Windows.Forms.Button btGestionUser;
    }
}