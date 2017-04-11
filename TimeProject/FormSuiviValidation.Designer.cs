namespace TimeProject
{
    partial class FormSuiviValidation
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
            this.btValidArchi = new System.Windows.Forms.Button();
            this.btValidBC = new System.Windows.Forms.Button();
            this.dataPlan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // btValidArchi
            // 
            this.btValidArchi.BackColor = System.Drawing.Color.Navy;
            this.btValidArchi.ForeColor = System.Drawing.Color.White;
            this.btValidArchi.Location = new System.Drawing.Point(846, 158);
            this.btValidArchi.Name = "btValidArchi";
            this.btValidArchi.Size = new System.Drawing.Size(93, 38);
            this.btValidArchi.TabIndex = 0;
            this.btValidArchi.Text = "Validation Archi";
            this.btValidArchi.UseVisualStyleBackColor = false;
            this.btValidArchi.Click += new System.EventHandler(this.btValidArchi_Click);
            // 
            // btValidBC
            // 
            this.btValidBC.BackColor = System.Drawing.Color.Navy;
            this.btValidBC.ForeColor = System.Drawing.Color.White;
            this.btValidBC.Location = new System.Drawing.Point(846, 233);
            this.btValidBC.Name = "btValidBC";
            this.btValidBC.Size = new System.Drawing.Size(93, 38);
            this.btValidBC.TabIndex = 1;
            this.btValidBC.Text = "Validation BC";
            this.btValidBC.UseVisualStyleBackColor = false;
            this.btValidBC.Click += new System.EventHandler(this.btValidBC_Click);
            // 
            // dataPlan
            // 
            this.dataPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPlan.Location = new System.Drawing.Point(36, 158);
            this.dataPlan.Name = "dataPlan";
            this.dataPlan.Size = new System.Drawing.Size(781, 343);
            this.dataPlan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suivi de validation";
            // 
            // FormSuiviValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1059, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataPlan);
            this.Controls.Add(this.btValidBC);
            this.Controls.Add(this.btValidArchi);
            this.Name = "FormSuiviValidation";
            this.Text = "Suivi des validations";
            ((System.ComponentModel.ISupportInitialize)(this.dataPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValidArchi;
        private System.Windows.Forms.Button btValidBC;
        private System.Windows.Forms.DataGridView dataPlan;
        private System.Windows.Forms.Label label1;
    }
}