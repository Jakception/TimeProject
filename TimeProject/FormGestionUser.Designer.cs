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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btClosePnlCrea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pnlCreaUser.Controls.Add(this.checkBox1);
            this.pnlCreaUser.Controls.Add(this.label4);
            this.pnlCreaUser.Controls.Add(this.label3);
            this.pnlCreaUser.Controls.Add(this.btClosePnlCrea);
            this.pnlCreaUser.Controls.Add(this.label2);
            this.pnlCreaUser.Controls.Add(this.label1);
            this.pnlCreaUser.Location = new System.Drawing.Point(-5, 1);
            this.pnlCreaUser.Name = "pnlCreaUser";
            this.pnlCreaUser.Size = new System.Drawing.Size(665, 602);
            this.pnlCreaUser.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(340, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "admin";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Initiale";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btClosePnlCrea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}