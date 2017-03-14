namespace TimeProject
{
    partial class FormGestionUser
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
            this.lstBoxUser = new System.Windows.Forms.ListBox();
            this.btCreaUser = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlCreaUser = new System.Windows.Forms.Panel();
            this.lblIniti = new System.Windows.Forms.Label();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.chBoxAdmin = new System.Windows.Forms.CheckBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblInitiale = new System.Windows.Forms.Label();
            this.btClosePnlCrea = new System.Windows.Forms.Button();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlCreaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxUser
            // 
            this.lstBoxUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstBoxUser.FormattingEnabled = true;
            this.lstBoxUser.Location = new System.Drawing.Point(28, 64);
            this.lstBoxUser.Name = "lstBoxUser";
            this.lstBoxUser.Size = new System.Drawing.Size(250, 485);
            this.lstBoxUser.TabIndex = 0;
            // 
            // btCreaUser
            // 
            this.btCreaUser.Location = new System.Drawing.Point(310, 78);
            this.btCreaUser.Name = "btCreaUser";
            this.btCreaUser.Size = new System.Drawing.Size(138, 52);
            this.btCreaUser.TabIndex = 1;
            this.btCreaUser.Text = "Créer Utilisateur";
            this.btCreaUser.UseVisualStyleBackColor = true;
            this.btCreaUser.Click += new System.EventHandler(this.btCreaUser_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier Utilisateur";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 402);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer Utilisateur";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnlCreaUser
            // 
            this.pnlCreaUser.BackColor = System.Drawing.Color.Yellow;
            this.pnlCreaUser.Controls.Add(this.lblIniti);
            this.pnlCreaUser.Controls.Add(this.txtBoxMail);
            this.pnlCreaUser.Controls.Add(this.txtBoxPrenom);
            this.pnlCreaUser.Controls.Add(this.txtBoxNom);
            this.pnlCreaUser.Controls.Add(this.chBoxAdmin);
            this.pnlCreaUser.Controls.Add(this.lblMail);
            this.pnlCreaUser.Controls.Add(this.lblInitiale);
            this.pnlCreaUser.Controls.Add(this.btClosePnlCrea);
            this.pnlCreaUser.Controls.Add(this.lblPrenom);
            this.pnlCreaUser.Controls.Add(this.lblNom);
            this.pnlCreaUser.Location = new System.Drawing.Point(-5, 1);
            this.pnlCreaUser.Name = "pnlCreaUser";
            this.pnlCreaUser.Size = new System.Drawing.Size(665, 619);
            this.pnlCreaUser.TabIndex = 4;
            // 
            // lblIniti
            // 
            this.lblIniti.AutoSize = true;
            this.lblIniti.Location = new System.Drawing.Point(40, 267);
            this.lblIniti.Name = "lblIniti";
            this.lblIniti.Size = new System.Drawing.Size(43, 13);
            this.lblIniti.TabIndex = 10;
            this.lblIniti.Text = "Prenom";
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(289, 109);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(351, 20);
            this.txtBoxMail.TabIndex = 9;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(43, 203);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrenom.TabIndex = 8;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(43, 109);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNom.TabIndex = 6;
            this.txtBoxNom.TextChanged += new System.EventHandler(this.txtBoxNom_TextChanged);
            // 
            // chBoxAdmin
            // 
            this.chBoxAdmin.AutoSize = true;
            this.chBoxAdmin.Location = new System.Drawing.Point(289, 203);
            this.chBoxAdmin.Name = "chBoxAdmin";
            this.chBoxAdmin.Size = new System.Drawing.Size(54, 17);
            this.chBoxAdmin.TabIndex = 5;
            this.chBoxAdmin.Text = "admin";
            this.chBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(286, 63);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 4;
            this.lblMail.Text = "Mail";
            // 
            // lblInitiale
            // 
            this.lblInitiale.AutoSize = true;
            this.lblInitiale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitiale.Location = new System.Drawing.Point(39, 307);
            this.lblInitiale.Name = "lblInitiale";
            this.lblInitiale.Size = new System.Drawing.Size(63, 20);
            this.lblInitiale.TabIndex = 3;
            this.lblInitiale.Text = "Initiale";
            // 
            // btClosePnlCrea
            // 
            this.btClosePnlCrea.Location = new System.Drawing.Point(617, 0);
            this.btClosePnlCrea.Name = "btClosePnlCrea";
            this.btClosePnlCrea.Size = new System.Drawing.Size(48, 46);
            this.btClosePnlCrea.TabIndex = 2;
            this.btClosePnlCrea.Text = "x";
            this.btClosePnlCrea.UseVisualStyleBackColor = true;
            this.btClosePnlCrea.Click += new System.EventHandler(this.btClosePnlCrea_Click);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(40, 157);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(40, 71);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // FormGestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(659, 601);
            this.Controls.Add(this.pnlCreaUser);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstBoxUser);
            this.Controls.Add(this.btCreaUser);
            this.Controls.Add(this.button3);
            this.Name = "FormGestionUser";
            this.Text = "FormGestionUser";
            this.Load += new System.EventHandler(this.FormGestionUser_Load);
            this.pnlCreaUser.ResumeLayout(false);
            this.pnlCreaUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxUser;
        private System.Windows.Forms.Button btCreaUser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlCreaUser;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btClosePnlCrea;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.CheckBox chBoxAdmin;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblInitiale;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.Label lblIniti;
    }
}