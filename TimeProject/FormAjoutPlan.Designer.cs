namespace TimeProject
{
    partial class FormAjoutPlan
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
            this.buttonAnnulePlan = new System.Windows.Forms.Button();
            this.textBoxLibellePlan = new System.Windows.Forms.TextBox();
            this.textBoxNumeroPlan = new System.Windows.Forms.TextBox();
            this.labelLiebellePlan = new System.Windows.Forms.Label();
            this.labelNumeroPlan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonValiderPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAnnulePlan
            // 
            this.buttonAnnulePlan.BackColor = System.Drawing.Color.Navy;
            this.buttonAnnulePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAnnulePlan.ForeColor = System.Drawing.Color.White;
            this.buttonAnnulePlan.Location = new System.Drawing.Point(347, 285);
            this.buttonAnnulePlan.Name = "buttonAnnulePlan";
            this.buttonAnnulePlan.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnulePlan.TabIndex = 15;
            this.buttonAnnulePlan.Text = "Annuler";
            this.buttonAnnulePlan.UseVisualStyleBackColor = false;
            this.buttonAnnulePlan.Click += new System.EventHandler(this.buttonAnnulePlan_Click);
            // 
            // textBoxLibellePlan
            // 
            this.textBoxLibellePlan.Location = new System.Drawing.Point(324, 219);
            this.textBoxLibellePlan.Name = "textBoxLibellePlan";
            this.textBoxLibellePlan.Size = new System.Drawing.Size(170, 20);
            this.textBoxLibellePlan.TabIndex = 14;
            // 
            // textBoxNumeroPlan
            // 
            this.textBoxNumeroPlan.Location = new System.Drawing.Point(324, 170);
            this.textBoxNumeroPlan.Name = "textBoxNumeroPlan";
            this.textBoxNumeroPlan.Size = new System.Drawing.Size(170, 20);
            this.textBoxNumeroPlan.TabIndex = 13;
            // 
            // labelLiebellePlan
            // 
            this.labelLiebellePlan.AutoSize = true;
            this.labelLiebellePlan.Location = new System.Drawing.Point(155, 222);
            this.labelLiebellePlan.Name = "labelLiebellePlan";
            this.labelLiebellePlan.Size = new System.Drawing.Size(75, 13);
            this.labelLiebellePlan.TabIndex = 11;
            this.labelLiebellePlan.Text = "Libelle du plan";
            // 
            // labelNumeroPlan
            // 
            this.labelNumeroPlan.AutoSize = true;
            this.labelNumeroPlan.Location = new System.Drawing.Point(155, 173);
            this.labelNumeroPlan.Name = "labelNumeroPlan";
            this.labelNumeroPlan.Size = new System.Drawing.Size(82, 13);
            this.labelNumeroPlan.TabIndex = 10;
            this.labelNumeroPlan.Text = "Numéro du plan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Définition du plan à ajouter :";
            // 
            // buttonValiderPlan
            // 
            this.buttonValiderPlan.BackColor = System.Drawing.Color.Navy;
            this.buttonValiderPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonValiderPlan.ForeColor = System.Drawing.Color.White;
            this.buttonValiderPlan.Location = new System.Drawing.Point(186, 285);
            this.buttonValiderPlan.Name = "buttonValiderPlan";
            this.buttonValiderPlan.Size = new System.Drawing.Size(121, 45);
            this.buttonValiderPlan.TabIndex = 12;
            this.buttonValiderPlan.Text = "Valider";
            this.buttonValiderPlan.UseVisualStyleBackColor = false;
            this.buttonValiderPlan.Click += new System.EventHandler(this.buttonValiderPlan_Click);
            // 
            // FormAjoutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 443);
            this.Controls.Add(this.buttonAnnulePlan);
            this.Controls.Add(this.textBoxLibellePlan);
            this.Controls.Add(this.textBoxNumeroPlan);
            this.Controls.Add(this.labelLiebellePlan);
            this.Controls.Add(this.labelNumeroPlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonValiderPlan);
            this.Name = "FormAjoutPlan";
            this.Text = "Ajout d\'un plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnulePlan;
        private System.Windows.Forms.TextBox textBoxLibellePlan;
        private System.Windows.Forms.TextBox textBoxNumeroPlan;
        private System.Windows.Forms.Label labelLiebellePlan;
        private System.Windows.Forms.Label labelNumeroPlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonValiderPlan;
    }
}