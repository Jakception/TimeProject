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
            this.textBoxDesignation = new System.Windows.Forms.TextBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.dateTimePickerDatePlan = new System.Windows.Forms.DateTimePicker();
            this.labelDatePlan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnulePlan
            // 
            this.buttonAnnulePlan.BackColor = System.Drawing.Color.Navy;
            this.buttonAnnulePlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAnnulePlan.ForeColor = System.Drawing.Color.White;
            this.buttonAnnulePlan.Location = new System.Drawing.Point(334, 395);
            this.buttonAnnulePlan.Name = "buttonAnnulePlan";
            this.buttonAnnulePlan.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnulePlan.TabIndex = 15;
            this.buttonAnnulePlan.Text = "Annuler";
            this.buttonAnnulePlan.UseVisualStyleBackColor = false;
            this.buttonAnnulePlan.Click += new System.EventHandler(this.buttonAnnulePlan_Click);
            // 
            // textBoxLibellePlan
            // 
            this.textBoxLibellePlan.Location = new System.Drawing.Point(324, 197);
            this.textBoxLibellePlan.Name = "textBoxLibellePlan";
            this.textBoxLibellePlan.Size = new System.Drawing.Size(200, 20);
            this.textBoxLibellePlan.TabIndex = 14;
            this.textBoxLibellePlan.TextChanged += new System.EventHandler(this.textBoxLibellePlan_TextChanged);
            // 
            // textBoxNumeroPlan
            // 
            this.textBoxNumeroPlan.Location = new System.Drawing.Point(324, 139);
            this.textBoxNumeroPlan.Name = "textBoxNumeroPlan";
            this.textBoxNumeroPlan.Size = new System.Drawing.Size(200, 20);
            this.textBoxNumeroPlan.TabIndex = 13;
            this.textBoxNumeroPlan.TextChanged += new System.EventHandler(this.textBoxNumeroPlan_TextChanged);
            // 
            // labelLiebellePlan
            // 
            this.labelLiebellePlan.AutoSize = true;
            this.labelLiebellePlan.Location = new System.Drawing.Point(155, 200);
            this.labelLiebellePlan.Name = "labelLiebellePlan";
            this.labelLiebellePlan.Size = new System.Drawing.Size(75, 13);
            this.labelLiebellePlan.TabIndex = 11;
            this.labelLiebellePlan.Text = "Libelle du plan";
            this.labelLiebellePlan.Click += new System.EventHandler(this.labelLiebellePlan_Click);
            // 
            // labelNumeroPlan
            // 
            this.labelNumeroPlan.AutoSize = true;
            this.labelNumeroPlan.Location = new System.Drawing.Point(155, 142);
            this.labelNumeroPlan.Name = "labelNumeroPlan";
            this.labelNumeroPlan.Size = new System.Drawing.Size(82, 13);
            this.labelNumeroPlan.TabIndex = 10;
            this.labelNumeroPlan.Text = "Numéro du plan";
            this.labelNumeroPlan.Click += new System.EventHandler(this.labelNumeroPlan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 52);
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
            this.buttonValiderPlan.Location = new System.Drawing.Point(173, 395);
            this.buttonValiderPlan.Name = "buttonValiderPlan";
            this.buttonValiderPlan.Size = new System.Drawing.Size(121, 45);
            this.buttonValiderPlan.TabIndex = 12;
            this.buttonValiderPlan.Text = "Valider";
            this.buttonValiderPlan.UseVisualStyleBackColor = false;
            this.buttonValiderPlan.Click += new System.EventHandler(this.buttonValiderPlan_Click);
            // 
            // textBoxDesignation
            // 
            this.textBoxDesignation.Location = new System.Drawing.Point(324, 253);
            this.textBoxDesignation.Name = "textBoxDesignation";
            this.textBoxDesignation.Size = new System.Drawing.Size(200, 20);
            this.textBoxDesignation.TabIndex = 17;
            this.textBoxDesignation.TextChanged += new System.EventHandler(this.textBoxDesignation_TextChanged);
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(155, 256);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 16;
            this.labelDesignation.Text = "Désignation";
            this.labelDesignation.Click += new System.EventHandler(this.labelDesignation_Click);
            // 
            // dateTimePickerDatePlan
            // 
            this.dateTimePickerDatePlan.Location = new System.Drawing.Point(324, 309);
            this.dateTimePickerDatePlan.Name = "dateTimePickerDatePlan";
            this.dateTimePickerDatePlan.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDatePlan.TabIndex = 18;
            this.dateTimePickerDatePlan.ValueChanged += new System.EventHandler(this.dateTimePickerDatePlan_ValueChanged);
            // 
            // labelDatePlan
            // 
            this.labelDatePlan.AutoSize = true;
            this.labelDatePlan.Location = new System.Drawing.Point(155, 315);
            this.labelDatePlan.Name = "labelDatePlan";
            this.labelDatePlan.Size = new System.Drawing.Size(95, 13);
            this.labelDatePlan.TabIndex = 19;
            this.labelDatePlan.Text = "Date de réalisation";
            this.labelDatePlan.Click += new System.EventHandler(this.labelDatePlan_Click);
            // 
            // FormAjoutPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(666, 466);
            this.Controls.Add(this.labelDatePlan);
            this.Controls.Add(this.dateTimePickerDatePlan);
            this.Controls.Add(this.textBoxDesignation);
            this.Controls.Add(this.labelDesignation);
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
        private System.Windows.Forms.TextBox textBoxDesignation;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatePlan;
        private System.Windows.Forms.Label labelDatePlan;
    }
}