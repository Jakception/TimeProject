using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeProject.Models.request;
using TimeProject.Models.Class;
using TimeProject.Models.Utilitaire;

namespace TimeProject
{
    public partial class FormAdresseBordereau : Form
    {
        private BordereauEnvoi bordereau;

        public FormAdresseBordereau(BordereauEnvoi b)
        {
            bordereau = b;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label_addr1 = new System.Windows.Forms.Label();
            this.label_addr2 = new System.Windows.Forms.Label();
            this.label_addr3 = new System.Windows.Forms.Label();
            this.label_CPVille = new System.Windows.Forms.Label();
            this.txtBox_adr1 = new System.Windows.Forms.TextBox();
            this.txtBox_adr2 = new System.Windows.Forms.TextBox();
            this.txtBox_adr3 = new System.Windows.Forms.TextBox();
            this.txtBox_CPVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(58, 200);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 0;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(168, 200);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 1;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label_addr1
            // 
            this.label_addr1.AutoSize = true;
            this.label_addr1.Location = new System.Drawing.Point(55, 37);
            this.label_addr1.Name = "label_addr1";
            this.label_addr1.Size = new System.Drawing.Size(49, 13);
            this.label_addr1.TabIndex = 2;
            this.label_addr1.Text = "Adresse*";
            // 
            // label_addr2
            // 
            this.label_addr2.AutoSize = true;
            this.label_addr2.Location = new System.Drawing.Point(55, 74);
            this.label_addr2.Name = "label_addr2";
            this.label_addr2.Size = new System.Drawing.Size(39, 13);
            this.label_addr2.TabIndex = 3;
            this.label_addr2.Text = "Adr. 2*";
            // 
            // label_addr3
            // 
            this.label_addr3.AutoSize = true;
            this.label_addr3.Location = new System.Drawing.Point(55, 113);
            this.label_addr3.Name = "label_addr3";
            this.label_addr3.Size = new System.Drawing.Size(35, 13);
            this.label_addr3.TabIndex = 4;
            this.label_addr3.Text = "Adr. 3";
            // 
            // label_CPVille
            // 
            this.label_CPVille.AutoSize = true;
            this.label_CPVille.Location = new System.Drawing.Point(55, 149);
            this.label_CPVille.Name = "label_CPVille";
            this.label_CPVille.Size = new System.Drawing.Size(56, 13);
            this.label_CPVille.TabIndex = 5;
            this.label_CPVille.Text = "CP + Ville*";
            // 
            // txtBox_adr1
            // 
            this.txtBox_adr1.Location = new System.Drawing.Point(143, 30);
            this.txtBox_adr1.Name = "txtBox_adr1";
            this.txtBox_adr1.Size = new System.Drawing.Size(151, 20);
            this.txtBox_adr1.TabIndex = 6;
            // 
            // txtBox_adr2
            // 
            this.txtBox_adr2.Location = new System.Drawing.Point(143, 67);
            this.txtBox_adr2.Name = "txtBox_adr2";
            this.txtBox_adr2.Size = new System.Drawing.Size(151, 20);
            this.txtBox_adr2.TabIndex = 7;
            // 
            // txtBox_adr3
            // 
            this.txtBox_adr3.Location = new System.Drawing.Point(143, 106);
            this.txtBox_adr3.Name = "txtBox_adr3";
            this.txtBox_adr3.Size = new System.Drawing.Size(151, 20);
            this.txtBox_adr3.TabIndex = 8;
            // 
            // txtBox_CPVille
            // 
            this.txtBox_CPVille.Location = new System.Drawing.Point(143, 142);
            this.txtBox_CPVille.Name = "txtBox_CPVille";
            this.txtBox_CPVille.Size = new System.Drawing.Size(151, 20);
            this.txtBox_CPVille.TabIndex = 9;
            // 
            // FormAdresseBordereau
            // 
            this.ClientSize = new System.Drawing.Size(347, 281);
            this.Controls.Add(this.txtBox_CPVille);
            this.Controls.Add(this.txtBox_adr3);
            this.Controls.Add(this.txtBox_adr2);
            this.Controls.Add(this.txtBox_adr1);
            this.Controls.Add(this.label_CPVille);
            this.Controls.Add(this.label_addr3);
            this.Controls.Add(this.label_addr2);
            this.Controls.Add(this.label_addr1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_annuler);
            this.Name = "FormAdresseBordereau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if(txtBox_adr1.Text != "" && txtBox_adr2.Text != "" && txtBox_CPVille.Text != "")
            {
                Form1 f1 = new Form1();
                f1.createBordereau(bordereau, txtBox_adr1.Text, txtBox_adr2.Text, txtBox_adr3.Text, txtBox_CPVille.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs avec * !");
            }
        }
    }
}
