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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCreaProjet
            // 
            this.btCreaProjet.Location = new System.Drawing.Point(371, 40);
            this.btCreaProjet.Name = "btCreaProjet";
            this.btCreaProjet.Size = new System.Drawing.Size(95, 49);
            this.btCreaProjet.TabIndex = 0;
            this.btCreaProjet.Text = "Créer projet";
            this.btCreaProjet.UseVisualStyleBackColor = true;
            // 
            // lstBoxProjet
            // 
            this.lstBoxProjet.FormattingEnabled = true;
            this.lstBoxProjet.Location = new System.Drawing.Point(34, 40);
            this.lstBoxProjet.Name = "lstBoxProjet";
            this.lstBoxProjet.ScrollAlwaysVisible = true;
            this.lstBoxProjet.Size = new System.Drawing.Size(276, 394);
            this.lstBoxProjet.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Clore projet";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormGestionProjet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(849, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBoxProjet);
            this.Controls.Add(this.btCreaProjet);
            this.Name = "FormGestionProjet";
            this.Text = "FormGestionProjet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreaProjet;
        private System.Windows.Forms.ListBox lstBoxProjet;
        private System.Windows.Forms.Button button1;
    }
}