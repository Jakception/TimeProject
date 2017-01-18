namespace TimeProject
{
    partial class FormAccueil
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnl_Date = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Info.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnl_Date.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(532, 53);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(150, 45);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "ACCUEIL";
            // 
            // pnl_Info
            // 
            this.pnl_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.pnl_Info.Controls.Add(this.pnlUser);
            this.pnl_Info.Controls.Add(this.pnl_Date);
            this.pnl_Info.Location = new System.Drawing.Point(986, 12);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(200, 100);
            this.pnl_Info.TabIndex = 1;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Location = new System.Drawing.Point(0, 19);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(200, 26);
            this.pnlUser.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(23, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(66, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "lblName";
            // 
            // pnl_Date
            // 
            this.pnl_Date.Controls.Add(this.lblDate);
            this.pnl_Date.Location = new System.Drawing.Point(0, 60);
            this.pnl_Date.Name = "pnl_Date";
            this.pnl_Date.Size = new System.Drawing.Size(200, 26);
            this.pnl_Date.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(23, 4);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(59, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "lblDate";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::TimeProject.Properties.Resources.logo;
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 151);
            this.panel1.TabIndex = 2;
            // 
            // FormAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1198, 751);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Info);
            this.Controls.Add(this.lblTitre);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "FormAccueil";
            this.Text = "FormAccueil";
            this.Load += new System.EventHandler(this.FormAccueil_Load);
            this.pnl_Info.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnl_Date.ResumeLayout(false);
            this.pnl_Date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Panel pnl_Date;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel panel1;
    }
}