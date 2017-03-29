namespace TimeProject
{
    partial class FormModifProfile
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
            this.buttonValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMdp = new System.Windows.Forms.TextBox();
            this.textBoxConfirmMdp = new System.Windows.Forms.TextBox();
            this.buttonAnnulé = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.Navy;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(99, 359);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(121, 45);
            this.buttonValider.TabIndex = 5;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Changer votre mot de passe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nouveau mot de passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmation du mot de passe :";
            // 
            // textBoxMdp
            // 
            this.textBoxMdp.Location = new System.Drawing.Point(237, 165);
            this.textBoxMdp.Name = "textBoxMdp";
            this.textBoxMdp.Size = new System.Drawing.Size(170, 20);
            this.textBoxMdp.TabIndex = 6;
            // 
            // textBoxConfirmMdp
            // 
            this.textBoxConfirmMdp.Location = new System.Drawing.Point(237, 268);
            this.textBoxConfirmMdp.Name = "textBoxConfirmMdp";
            this.textBoxConfirmMdp.Size = new System.Drawing.Size(170, 20);
            this.textBoxConfirmMdp.TabIndex = 7;
            // 
            // buttonAnnulé
            // 
            this.buttonAnnulé.BackColor = System.Drawing.Color.Navy;
            this.buttonAnnulé.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAnnulé.ForeColor = System.Drawing.Color.White;
            this.buttonAnnulé.Location = new System.Drawing.Point(260, 359);
            this.buttonAnnulé.Name = "buttonAnnulé";
            this.buttonAnnulé.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnulé.TabIndex = 8;
            this.buttonAnnulé.Text = "Annuler";
            this.buttonAnnulé.UseVisualStyleBackColor = false;
            this.buttonAnnulé.Click += new System.EventHandler(this.buttonAnnulé_Click);
            // 
            // FormModifProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 430);
            this.Controls.Add(this.buttonAnnulé);
            this.Controls.Add(this.textBoxConfirmMdp);
            this.Controls.Add(this.textBoxMdp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonValider);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormModifProfile";
            this.Text = "FormModifProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMdp;
        private System.Windows.Forms.TextBox textBoxConfirmMdp;
        private System.Windows.Forms.Button buttonAnnulé;
    }
}