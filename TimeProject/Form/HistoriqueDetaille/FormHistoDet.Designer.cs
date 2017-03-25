namespace TimeProject
{
    partial class FormHistoDet
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
            this.lstBoxTache = new System.Windows.Forms.ListBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblHisto = new System.Windows.Forms.Label();
            this.btAjoutEvent = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBoxTache
            // 
            this.lstBoxTache.FormattingEnabled = true;
            this.lstBoxTache.Location = new System.Drawing.Point(302, 255);
            this.lstBoxTache.Name = "lstBoxTache";
            this.lstBoxTache.Size = new System.Drawing.Size(734, 628);
            this.lstBoxTache.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(119, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(753, 33);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date de début : xx/xx/XXXX - Objectif de fin : xx/xx/XXXX";
            // 
            // lblTitre
            // 
            this.lblTitre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(426, 18);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(134, 45);
            this.lblTitre.TabIndex = 20;
            this.lblTitre.Text = "PROJET";
            // 
            // lblHisto
            // 
            this.lblHisto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHisto.AutoSize = true;
            this.lblHisto.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHisto.Location = new System.Drawing.Point(537, 167);
            this.lblHisto.Name = "lblHisto";
            this.lblHisto.Size = new System.Drawing.Size(291, 45);
            this.lblHisto.TabIndex = 22;
            this.lblHisto.Text = "Historique détaillé";
            // 
            // btAjoutEvent
            // 
            this.btAjoutEvent.BackColor = System.Drawing.Color.Navy;
            this.btAjoutEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutEvent.ForeColor = System.Drawing.Color.White;
            this.btAjoutEvent.Location = new System.Drawing.Point(37, 269);
            this.btAjoutEvent.Name = "btAjoutEvent";
            this.btAjoutEvent.Size = new System.Drawing.Size(195, 61);
            this.btAjoutEvent.TabIndex = 23;
            this.btAjoutEvent.Text = "Ajout Evenement";
            this.btAjoutEvent.UseVisualStyleBackColor = false;
            this.btAjoutEvent.Click += new System.EventHandler(this.btAjoutEvent_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(37, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 61);
            this.button2.TabIndex = 24;
            this.button2.Text = "Suppression Evenement";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(37, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 61);
            this.button3.TabIndex = 25;
            this.button3.Text = "Classement Importance";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(37, 586);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 61);
            this.button4.TabIndex = 26;
            this.button4.Text = "Validation Action Attente";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Navy;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(37, 710);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 61);
            this.button5.TabIndex = 27;
            this.button5.Text = "Rendus";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FormHistoDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1058, 893);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btAjoutEvent);
            this.Controls.Add(this.lblHisto);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lstBoxTache);
            this.MaximumSize = new System.Drawing.Size(1074, 932);
            this.Name = "FormHistoDet";
            this.Load += new System.EventHandler(this.FormHistoDet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxTache;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblHisto;
        private System.Windows.Forms.Button btAjoutEvent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}