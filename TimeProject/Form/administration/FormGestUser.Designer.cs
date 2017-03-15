namespace TimeProject
{
    partial class FormGestUser
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
            this.btDelUser = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblInit = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxInit = new System.Windows.Forms.TextBox();
            this.txtBoxMail = new System.Windows.Forms.TextBox();
            this.checkBoxAdm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxUser
            // 
            this.lstBoxUser.FormattingEnabled = true;
            this.lstBoxUser.Location = new System.Drawing.Point(12, 25);
            this.lstBoxUser.Name = "lstBoxUser";
            this.lstBoxUser.Size = new System.Drawing.Size(221, 576);
            this.lstBoxUser.TabIndex = 0;
            // 
            // btCreaUser
            // 
            this.btCreaUser.Location = new System.Drawing.Point(291, 152);
            this.btCreaUser.Name = "btCreaUser";
            this.btCreaUser.Size = new System.Drawing.Size(112, 61);
            this.btCreaUser.TabIndex = 1;
            this.btCreaUser.Text = "Créer";
            this.btCreaUser.UseVisualStyleBackColor = true;
            this.btCreaUser.Click += new System.EventHandler(this.btCreaUser_Click);
            // 
            // btDelUser
            // 
            this.btDelUser.Location = new System.Drawing.Point(291, 282);
            this.btDelUser.Name = "btDelUser";
            this.btDelUser.Size = new System.Drawing.Size(112, 61);
            this.btDelUser.TabIndex = 2;
            this.btDelUser.Text = "Supprimer";
            this.btDelUser.UseVisualStyleBackColor = true;
            this.btDelUser.Click += new System.EventHandler(this.btDelUser_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(488, 90);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(51, 24);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom";
            // 
            // lblInit
            // 
            this.lblInit.AutoSize = true;
            this.lblInit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInit.Location = new System.Drawing.Point(488, 282);
            this.lblInit.Name = "lblInit";
            this.lblInit.Size = new System.Drawing.Size(67, 24);
            this.lblInit.TabIndex = 4;
            this.lblInit.Text = "Initiale:";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(488, 189);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(77, 24);
            this.lblPrenom.TabIndex = 5;
            this.lblPrenom.Text = "Prenom";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(488, 364);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(59, 24);
            this.lblMail.TabIndex = 6;
            this.lblMail.Text = "Mail : ";
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(491, 138);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(273, 20);
            this.txtBoxNom.TabIndex = 7;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(491, 225);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(273, 20);
            this.txtBoxPrenom.TabIndex = 8;
            // 
            // txtBoxInit
            // 
            this.txtBoxInit.Location = new System.Drawing.Point(491, 303);
            this.txtBoxInit.Name = "txtBoxInit";
            this.txtBoxInit.Size = new System.Drawing.Size(273, 20);
            this.txtBoxInit.TabIndex = 9;
            // 
            // txtBoxMail
            // 
            this.txtBoxMail.Location = new System.Drawing.Point(376, 393);
            this.txtBoxMail.Name = "txtBoxMail";
            this.txtBoxMail.Size = new System.Drawing.Size(388, 20);
            this.txtBoxMail.TabIndex = 10;
            // 
            // checkBoxAdm
            // 
            this.checkBoxAdm.AutoSize = true;
            this.checkBoxAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdm.Location = new System.Drawing.Point(498, 464);
            this.checkBoxAdm.Name = "checkBoxAdm";
            this.checkBoxAdm.Size = new System.Drawing.Size(89, 28);
            this.checkBoxAdm.TabIndex = 11;
            this.checkBoxAdm.Text = "ADMIN";
            this.checkBoxAdm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestion des utilisateurs";
            // 
            // FormGestUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(776, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxAdm);
            this.Controls.Add(this.txtBoxMail);
            this.Controls.Add(this.txtBoxInit);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblInit);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btDelUser);
            this.Controls.Add(this.btCreaUser);
            this.Controls.Add(this.lstBoxUser);
            this.MaximumSize = new System.Drawing.Size(792, 661);
            this.MinimumSize = new System.Drawing.Size(792, 661);
            this.Name = "FormGestUser";
            this.Text = "FormGestUser";
            this.Load += new System.EventHandler(this.FormGestUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxUser;
        private System.Windows.Forms.Button btCreaUser;
        private System.Windows.Forms.Button btDelUser;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblInit;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxInit;
        private System.Windows.Forms.TextBox txtBoxMail;
        private System.Windows.Forms.CheckBox checkBoxAdm;
        private System.Windows.Forms.Label label1;
    }
}