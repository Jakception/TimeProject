namespace TimeProject
{
    partial class FormValidation
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtTimeValidation = new System.Windows.Forms.DateTimePicker();
            this.buttonAnnule = new System.Windows.Forms.Button();
            this.buttonValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Favorable",
            "Rejete"});
            this.listBox1.Location = new System.Drawing.Point(32, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 30);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Avis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numéro courrier :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Validation";
            // 
            // dtTimeValidation
            // 
            this.dtTimeValidation.Location = new System.Drawing.Point(32, 38);
            this.dtTimeValidation.Name = "dtTimeValidation";
            this.dtTimeValidation.Size = new System.Drawing.Size(200, 20);
            this.dtTimeValidation.TabIndex = 5;
            // 
            // buttonAnnule
            // 
            this.buttonAnnule.BackColor = System.Drawing.Color.Navy;
            this.buttonAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonAnnule.ForeColor = System.Drawing.Color.White;
            this.buttonAnnule.Location = new System.Drawing.Point(336, 149);
            this.buttonAnnule.Name = "buttonAnnule";
            this.buttonAnnule.Size = new System.Drawing.Size(121, 45);
            this.buttonAnnule.TabIndex = 33;
            this.buttonAnnule.Text = "Annuler";
            this.buttonAnnule.UseVisualStyleBackColor = false;
            this.buttonAnnule.Click += new System.EventHandler(this.buttonAnnule_Click);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.Color.Navy;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonValider.ForeColor = System.Drawing.Color.White;
            this.buttonValider.Location = new System.Drawing.Point(336, 98);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(121, 45);
            this.buttonValider.TabIndex = 32;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // FormValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(469, 201);
            this.Controls.Add(this.buttonAnnule);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.dtTimeValidation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormValidation";
            this.Text = "Validation plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtTimeValidation;
        private System.Windows.Forms.Button buttonAnnule;
        private System.Windows.Forms.Button buttonValider;
    }
}