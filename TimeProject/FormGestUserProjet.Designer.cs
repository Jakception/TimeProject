namespace TimeProject
{
    partial class FormGestUserProjet
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
            this.checkListUserOnProjet = new System.Windows.Forms.CheckedListBox();
            this.checkListUser = new System.Windows.Forms.CheckedListBox();
            this.lblUserProjet = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNomProjet = new System.Windows.Forms.Label();
            this.btDelUser = new System.Windows.Forms.Button();
            this.btAjouterPersonne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkListUserOnProjet
            // 
            this.checkListUserOnProjet.FormattingEnabled = true;
            this.checkListUserOnProjet.Location = new System.Drawing.Point(617, 152);
            this.checkListUserOnProjet.Name = "checkListUserOnProjet";
            this.checkListUserOnProjet.Size = new System.Drawing.Size(258, 364);
            this.checkListUserOnProjet.TabIndex = 0;
            // 
            // checkListUser
            // 
            this.checkListUser.FormattingEnabled = true;
            this.checkListUser.Location = new System.Drawing.Point(24, 152);
            this.checkListUser.Name = "checkListUser";
            this.checkListUser.Size = new System.Drawing.Size(258, 364);
            this.checkListUser.TabIndex = 1;
            // 
            // lblUserProjet
            // 
            this.lblUserProjet.AutoSize = true;
            this.lblUserProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProjet.Location = new System.Drawing.Point(661, 92);
            this.lblUserProjet.Name = "lblUserProjet";
            this.lblUserProjet.Size = new System.Drawing.Size(179, 20);
            this.lblUserProjet.TabIndex = 2;
            this.lblUserProjet.Text = "Personnes sur le projet :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(74, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(157, 20);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Liste des utilisateurs ";
            // 
            // lblNomProjet
            // 
            this.lblNomProjet.AutoSize = true;
            this.lblNomProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProjet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNomProjet.Location = new System.Drawing.Point(402, 29);
            this.lblNomProjet.Name = "lblNomProjet";
            this.lblNomProjet.Size = new System.Drawing.Size(85, 31);
            this.lblNomProjet.TabIndex = 4;
            this.lblNomProjet.Text = "Projet";
            // 
            // btDelUser
            // 
            this.btDelUser.BackColor = System.Drawing.Color.Navy;
            this.btDelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelUser.ForeColor = System.Drawing.Color.White;
            this.btDelUser.Location = new System.Drawing.Point(362, 329);
            this.btDelUser.Name = "btDelUser";
            this.btDelUser.Size = new System.Drawing.Size(161, 44);
            this.btDelUser.TabIndex = 5;
            this.btDelUser.Text = "Enlever personne(s)";
            this.btDelUser.UseVisualStyleBackColor = false;
            this.btDelUser.Click += new System.EventHandler(this.btDelUser_Click);
            // 
            // btAjouterPersonne
            // 
            this.btAjouterPersonne.BackColor = System.Drawing.Color.Navy;
            this.btAjouterPersonne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjouterPersonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjouterPersonne.ForeColor = System.Drawing.Color.White;
            this.btAjouterPersonne.Location = new System.Drawing.Point(362, 233);
            this.btAjouterPersonne.Name = "btAjouterPersonne";
            this.btAjouterPersonne.Size = new System.Drawing.Size(161, 44);
            this.btAjouterPersonne.TabIndex = 6;
            this.btAjouterPersonne.Text = "Ajouter personne(s)";
            this.btAjouterPersonne.UseVisualStyleBackColor = false;
            this.btAjouterPersonne.Click += new System.EventHandler(this.btAjouterPersonne_Click);
            // 
            // FormGestUserProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(887, 528);
            this.Controls.Add(this.btAjouterPersonne);
            this.Controls.Add(this.btDelUser);
            this.Controls.Add(this.lblNomProjet);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserProjet);
            this.Controls.Add(this.checkListUser);
            this.Controls.Add(this.checkListUserOnProjet);
            this.MaximumSize = new System.Drawing.Size(903, 567);
            this.MinimumSize = new System.Drawing.Size(903, 567);
            this.Name = "FormGestUserProjet";
            this.Text = "FormGestUserProjet";
            this.Load += new System.EventHandler(this.FormGestUserProjet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkListUserOnProjet;
        private System.Windows.Forms.CheckedListBox checkListUser;
        private System.Windows.Forms.Label lblUserProjet;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNomProjet;
        private System.Windows.Forms.Button btDelUser;
        private System.Windows.Forms.Button btAjouterPersonne;
    }
}