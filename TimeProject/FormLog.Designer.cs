namespace TimeProject
{
    partial class FormLog
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_valIdentification = new System.Windows.Forms.Button();
            this.textBox_Identifiant = new System.Windows.Forms.TextBox();
            this.textBox_pwd = new System.Windows.Forms.TextBox();
            this.lab_Identif = new System.Windows.Forms.Label();
            this.lab_pwdIdentif = new System.Windows.Forms.Label();
            this.lab_TitleIdentif = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valIdentification
            // 
            this.btn_valIdentification.AccessibleName = "";
            this.btn_valIdentification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(181)))), ((int)(((byte)(193)))));
            this.btn_valIdentification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(181)))), ((int)(((byte)(193)))));
            this.btn_valIdentification.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.btn_valIdentification.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.btn_valIdentification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valIdentification.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valIdentification.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_valIdentification.Location = new System.Drawing.Point(467, 399);
            this.btn_valIdentification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_valIdentification.Name = "btn_valIdentification";
            this.btn_valIdentification.Size = new System.Drawing.Size(112, 35);
            this.btn_valIdentification.TabIndex = 0;
            this.btn_valIdentification.Text = "Valider";
            this.btn_valIdentification.UseVisualStyleBackColor = false;
            this.btn_valIdentification.Click += new System.EventHandler(this.btn_valIdentification_Click);
            // 
            // textBox_Identifiant
            // 
            this.textBox_Identifiant.Location = new System.Drawing.Point(467, 218);
            this.textBox_Identifiant.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Identifiant.Name = "textBox_Identifiant";
            this.textBox_Identifiant.Size = new System.Drawing.Size(242, 26);
            this.textBox_Identifiant.TabIndex = 1;
            // 
            // textBox_pwd
            // 
            this.textBox_pwd.Location = new System.Drawing.Point(467, 297);
            this.textBox_pwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pwd.Name = "textBox_pwd";
            this.textBox_pwd.Size = new System.Drawing.Size(242, 26);
            this.textBox_pwd.TabIndex = 2;
            // 
            // lab_Identif
            // 
            this.lab_Identif.AccessibleName = "";
            this.lab_Identif.AutoSize = true;
            this.lab_Identif.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Identif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.lab_Identif.Location = new System.Drawing.Point(288, 218);
            this.lab_Identif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Identif.Name = "lab_Identif";
            this.lab_Identif.Size = new System.Drawing.Size(109, 24);
            this.lab_Identif.TabIndex = 3;
            this.lab_Identif.Text = "Identifiant";
            // 
            // lab_pwdIdentif
            // 
            this.lab_pwdIdentif.AccessibleName = "";
            this.lab_pwdIdentif.AutoSize = true;
            this.lab_pwdIdentif.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pwdIdentif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.lab_pwdIdentif.Location = new System.Drawing.Point(288, 297);
            this.lab_pwdIdentif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pwdIdentif.Name = "lab_pwdIdentif";
            this.lab_pwdIdentif.Size = new System.Drawing.Size(145, 24);
            this.lab_pwdIdentif.TabIndex = 4;
            this.lab_pwdIdentif.Text = "Mot de passe";
            // 
            // lab_TitleIdentif
            // 
            this.lab_TitleIdentif.AccessibleName = "lab_TitleIdentif";
            this.lab_TitleIdentif.AutoSize = true;
            this.lab_TitleIdentif.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_TitleIdentif.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(165)))));
            this.lab_TitleIdentif.Location = new System.Drawing.Point(335, 49);
            this.lab_TitleIdentif.Name = "lab_TitleIdentif";
            this.lab_TitleIdentif.Size = new System.Drawing.Size(323, 29);
            this.lab_TitleIdentif.TabIndex = 5;
            this.lab_TitleIdentif.Text = "TimeProject - Identification";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(968, 741);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lab_TitleIdentif);
            this.Controls.Add(this.lab_pwdIdentif);
            this.Controls.Add(this.lab_Identif);
            this.Controls.Add(this.textBox_pwd);
            this.Controls.Add(this.textBox_Identifiant);
            this.Controls.Add(this.btn_valIdentification);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormLog";
            this.Text = "Identification";
            this.Load += new System.EventHandler(this.FormLog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valIdentification;
        private System.Windows.Forms.TextBox textBox_Identifiant;
        private System.Windows.Forms.TextBox textBox_pwd;
        private System.Windows.Forms.Label lab_Identif;
        private System.Windows.Forms.Label lab_pwdIdentif;
        private System.Windows.Forms.Label lab_TitleIdentif;
        private System.Windows.Forms.Button button1;
    }
}

