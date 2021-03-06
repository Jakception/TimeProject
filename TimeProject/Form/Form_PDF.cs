﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using TimeProject.Models.Class;
using TimeProject.Models.request;
using TimeProject.Models.Utilitaire;



namespace TimeProject
{
    public partial class Form1 : Form
    {
        private static String referentAffaire;
        private static String refDossier;
        private static String PDFTitle;
        private static String PDFname;

        public Form1()
        {
           // (String dossier, String title, String name)
            referentAffaire = "CALISTE JANVRE";
           // refDossier = dossier;
            PDFname = "..\\PDF\\Liste_plans.pdf"; //name
           // PDFTitle = title;
            InitializeComponent();
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {   

        }

        public void createLPpdf(string codeProjet)
        {
            List<Plan> plans = BDDPlan.getAllPlan(codeProjet);
            if (plans.Count > 0)
            {
                try
                {
                    label_Affairesuivie.Text = "Affaire suivie par : " + referentAffaire;
                    label_signature.Text = referentAffaire;

                    FileStream fs = new FileStream("..\\PDF\\Liste_plans.pdf", FileMode.Create);

                    Document doc = new Document(PageSize.A4.Rotate());
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    

                    doc.Open();
                    /* document.AddAuthor("Micke Blomquist");
                   document.AddCreator("Sample application using iTextSharp");
                   document.AddKeywords("PDF tutorial education");
                   document.AddSubject("Document subject - Describing the steps creating a PDF document");
                   document.AddTitle("Liste des plans");*/

                    PdfContentByte cb = writer.DirectContent;
                    BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.SetFontAndSize(f_cb, 14);

                    float matrixY = 0f;

                    // LOGO
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(global::TimeProject.Properties.Resources.logo, BaseColor.WHITE);
                    img.ScalePercent(80);
                    matrixY = doc.PageSize.Height - img.Height + 30;
                    img.SetAbsolutePosition(10, matrixY);
                    cb.AddImage(img);
                    matrixY -= 30;

                    // TEXTE
                    cb.BeginText();

                    // PERSONNE EN CHARGE DU DOSSIER
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_Affairesuivie.Text);
                    matrixY -= 20;

                    //REFERENCE DU DOSSIER -> Adresse client, afficher boite dialogue pour récupérer addr
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_refDossier.Text);
                    matrixY -= 40;

                    // TITRE DE LA TABLE
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_listePlans.Width / 2), matrixY);
                    cb.ShowText(label_listePlans.Text);

                    // INFOS DE CONTACT
                    cb.SetFontAndSize(f_cb, 10);
                    float contactY = doc.PageSize.Height - (doc.PageSize.Height - (label_contact1.Height + label_contact2.Height
                        + label_contact3.Height + label_contact4.Height + label_contact5.Height)) + 5;

                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact1.Width / 2), contactY);
                    cb.ShowText(label_contact1.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact2.Width / 2), contactY);
                    cb.ShowText(label_contact2.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact3.Width / 2), contactY);
                    cb.ShowText(label_contact3.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact4.Width / 2), contactY);
                    cb.ShowText(label_contact4.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact5.Width / 2), contactY);
                    cb.ShowText(label_contact5.Text);
                    contactY -= 10;

                    doc.Add(new Paragraph(" "));

                    float[] largeurs = {5,45,35,15};
                    PdfPTable tableau = new PdfPTable(4);
                    tableau.SetWidths(largeurs);
                    
                    PdfPCell celluleTitre1 = new PdfPCell(new Paragraph("N°"));
                    celluleTitre1.Colspan = 1;
                    tableau.AddCell(celluleTitre1);

                    PdfPCell celluleTitre2 = new PdfPCell(new Paragraph("DESIGNATION"));
                    celluleTitre2.Colspan = 1;
                    tableau.AddCell(celluleTitre2);

                    PdfPCell celluleTitre3 = new PdfPCell(new Paragraph("DATE"));
                    celluleTitre3.Colspan = 1;
                    tableau.AddCell(celluleTitre3);

                    PdfPCell celluleTitre4 = new PdfPCell(new Paragraph("INDICE"));
                    celluleTitre4.Colspan = 1;
                    tableau.AddCell(celluleTitre4);
                    

                    plans.ForEach (delegate(Plan p){
                        tableau.AddCell(p.Numero_Plan.ToString());
                        tableau.AddCell(p.Designation);
                        tableau.AddCell(p.Dt_Plan.ToShortDateString());
                        tableau.AddCell(p.Indice.ToString());
                    });

                    tableau.SpacingBefore = doc.PageSize.Height - matrixY - 30;
                    tableau.SpacingAfter = 30;
                    doc.Add(tableau);
                    cb.SetTextMatrix(doc.PageSize.Width - label_signature.Width - 40, doc.PageSize.Height - tableau.TotalHeight + 20);
                    cb.ShowText(label_signature.Text);

                    cb.EndText();
                    doc.Close();
                    writer.Close();
                    fs.Close();
                    MessageBox.Show("Fichier créé !");
                }
                catch (IOException e)
                {
                    MessageBox.Show("Une erreur est survenue, le fichier n'a pas été créé !");
                    Console.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Aucun plan à imprimer !");
            } 
                }

        public void createCRpdf(){
            
                try
                {
                    label_Affairesuivie.Text = "Affaire suivie par : " + referentAffaire;

                    FileStream fs = new FileStream("..\\PDF\\Compte_Rendu.pdf", FileMode.Create);

                    Document doc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    /* document.AddAuthor("Micke Blomquist");
                   document.AddCreator("Sample application using iTextSharp");
                   document.AddKeywords("PDF tutorial education");
                   document.AddSubject("Document subject - Describing the steps creating a PDF document");
                   document.AddTitle("Liste des plans");*/

                    PdfContentByte cb = writer.DirectContent;
                    BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.SetFontAndSize(f_cb, 14);
                    float matrixY = 0f;

                    // LOGO
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(global::TimeProject.Properties.Resources.logo, BaseColor.WHITE);
                    img.ScalePercent(80);
                    matrixY = doc.PageSize.Height - img.Height + 30;
                    img.SetAbsolutePosition(10, matrixY);
                    cb.AddImage(img);
                    matrixY -= 30;

                    // TEXTE
                    cb.BeginText();

                    //DATE
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_date.Text);
                    matrixY -= 20;

                    // PERSONNE EN CHARGE DU DOSSIER
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_Affairesuivie.Text);
                    matrixY -= 20;

                    //REFERENCE DU DOSSIER
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_refDossier.Text);
                    matrixY -= 40;

                    // TITRE DE LA TABLE
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_listePlans.Width / 2), matrixY);
                    cb.ShowText("Compte rendu");

                    // INFOS DE CONTACT
                    cb.SetFontAndSize(f_cb, 10);
                    float contactY = doc.PageSize.Height - (doc.PageSize.Height - (label_contact1.Height + label_contact2.Height
                        + label_contact3.Height + label_contact4.Height + label_contact5.Height)) + 5;

                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact1.Width / 2), contactY);
                    cb.ShowText(label_contact1.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact2.Width / 2), contactY);
                    cb.ShowText(label_contact2.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact3.Width / 2), contactY);
                    cb.ShowText(label_contact3.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact4.Width / 2), contactY);
                    cb.ShowText(label_contact4.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact5.Width / 2), contactY);
                    cb.ShowText(label_contact5.Text);
                    contactY -= 10;

                    doc.Add(new Paragraph(" "));

                    PdfPTable tableau = new PdfPTable(3);
                    PdfPCell celluleTitre1 = new PdfPCell(new Paragraph("POLE"));
                    celluleTitre1.Colspan = 1;
                    tableau.AddCell(celluleTitre1);

                    PdfPCell celluleTitre2 = new PdfPCell(new Paragraph("DESIGNATION"));
                    celluleTitre2.Colspan = 1;
                    tableau.AddCell(celluleTitre2);

                    PdfPCell celluleTitre3 = new PdfPCell(new Paragraph("CONCERNE"));
                    celluleTitre3.Colspan = 1;
                    tableau.AddCell(celluleTitre3);
                    
                    tableau.AddCell("1.1");
                    tableau.AddCell("1.2");
                    tableau.AddCell("1.3");

                    tableau.SpacingBefore = doc.PageSize.Height - matrixY - 30;
                    tableau.SpacingAfter = 30;
                    doc.Add(tableau);

                    cb.SetTextMatrix(doc.PageSize.Width - label_signature.Width - 40, doc.PageSize.Height - tableau.TotalHeight + 20);
                    cb.ShowText(label_signature.Text);

                    cb.EndText();
                    doc.Close();
                    writer.Close();
                    fs.Close();
                    MessageBox.Show("Fichier créé !");

                }
                catch (IOException e)
                {
                    MessageBox.Show("Une erreur est survenue, le fichier n'a pas été créé !");
                    Console.WriteLine(e);
                }
        }
        
        public void createBordereau(BordereauEnvoi bordereau, String ad1, String ad2, String ad3, String ad4)
        {
            label_adr1.Text = "";
            label_adr2.Text = "";
            label_adr3.Text = "";
            label_adr4.Text = "";
            label_Affairesuivie.Text = "";
            label_date.Text = "";
            label_signature.Text = "";

            if (bordereau != null)
            {
                label_adr1.Text = ad1;
                label_adr2.Text = ad2;
                if(ad3 != "") { label_adr3.Text = ad3; } else { label_adr3.Text = ""; }
                label_adr4.Text = ad4;
                label_Affairesuivie.Text = "Affaire suivie par : " + referentAffaire;
                label_date.Text = DateTime.Now.ToShortDateString();
                label_signature.Text = referentAffaire;

                try
                {
                    FileStream fs = new FileStream("..\\PDF\\Bordereau.pdf", FileMode.Create);
                    Document doc = new Document(PageSize.A4);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();
                    /* document.AddAuthor("Micke Blomquist");
                   document.AddCreator("Sample application using iTextSharp");
                   document.AddKeywords("PDF tutorial education");
                   document.AddSubject("Document subject - Describing the steps creating a PDF document");
                   document.AddTitle("Liste des plans");*/

                    PdfContentByte cb = writer.DirectContent;
                    BaseFont f_cb = BaseFont.CreateFont("c:\\windows\\fonts\\calibrib.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    cb.SetFontAndSize(f_cb, 14);


                    // LOGO
                    float contactY = 0f;
                    float matrixY = 0f;
                    float adrY = 0f;

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(global::TimeProject.Properties.Resources.logo, BaseColor.WHITE);
                    img.ScalePercent(80);
                    matrixY = doc.PageSize.Height - img.Height + 30;
                    img.SetAbsolutePosition(10, matrixY);
                    cb.AddImage(img);
                    matrixY -= 30;

                    // TEXTE
                    cb.BeginText();
                    adrY = matrixY;
                    matrixY -= 20;

                    //DATE
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_date.Text);
                    matrixY -= 20;

                    // PERSONNE EN CHARGE DU DOSSIER
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_Affairesuivie.Text);
                    matrixY -= 20;

                    //  ADRESSE
                    cb.SetTextMatrix(doc.PageSize.Width - label_adr1.Width - 30, adrY);
                    cb.ShowText(label_adr1.Text);
                    adrY -= 20;
                    cb.SetTextMatrix(doc.PageSize.Width - label_adr2.Width - 30, adrY);
                    cb.ShowText(label_adr2.Text);
                    adrY -= 20;
                    if (label_adr3.Text != "")
                    {
                        cb.SetTextMatrix(doc.PageSize.Width - label_adr3.Width - 30, adrY);
                        cb.ShowText(label_adr3.Text);
                        adrY -= 20;
                    }
                    cb.SetTextMatrix(doc.PageSize.Width - label_adr4.Width - 30, adrY);
                    cb.ShowText(label_adr4.Text);

                    //REFERENCE DU DOSSIER
                    cb.SetTextMatrix(30, matrixY);
                    cb.ShowText(label_refDossier.Text);
                    matrixY -= 40;

                    // TITRE DU DOCUMENT / DE LA TABLE
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_listePlans.Width / 2), matrixY);
                    cb.ShowText("Bordereau d'envoi");

                    // INFOS DE CONTACT
                    cb.SetFontAndSize(f_cb, 10);
                    contactY = doc.PageSize.Height - (doc.PageSize.Height - (label_contact1.Height + label_contact2.Height
                        + label_contact3.Height + label_contact4.Height + label_contact5.Height)) + 5;

                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact1.Width / 2), contactY);
                    cb.ShowText(label_contact1.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact2.Width / 2), contactY);
                    cb.ShowText(label_contact2.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact3.Width / 2), contactY);
                    cb.ShowText(label_contact3.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact4.Width / 2), contactY);
                    cb.ShowText(label_contact4.Text);
                    contactY -= 10;
                    cb.SetTextMatrix((doc.PageSize.Width / 2) - (label_contact5.Width / 2), contactY);
                    cb.ShowText(label_contact5.Text);
                    contactY -= 10;

                    doc.Add(new Paragraph(" "));

                    // TABLE DES INFOS
                    float[] largeurs = {10, 40, 20, 15, 15};
                    PdfPTable tableau = new PdfPTable(5);
                    tableau.TotalWidth = doc.PageSize.Width - 50;
                    tableau.LockedWidth = true;
                    tableau.SetWidths(largeurs);

                    PdfPCell celluleTitre1 = new PdfPCell(new Paragraph("N°")); // N° plan
                    celluleTitre1.Colspan = 1;
                    tableau.AddCell(celluleTitre1);

                    PdfPCell celluleTitre2 = new PdfPCell(new Paragraph("DESGINATION")); // Desgination du plan
                    celluleTitre2.Colspan = 1;
                    tableau.AddCell(celluleTitre2);

                    PdfPCell celluleTitre3 = new PdfPCell(new Paragraph("EXEMPLAIRE")); // Indice du plan
                    celluleTitre3.Colspan = 1;
                    tableau.AddCell(celluleTitre3);

                    PdfPCell celluleTitre4 = new PdfPCell(new Paragraph("VERSION PDF")); // Vide
                    celluleTitre4.Colspan = 1;
                    tableau.AddCell(celluleTitre4);

                    PdfPCell celluleTitre5 = new PdfPCell(new Paragraph("VERSION PAPIER")); // Vide
                    celluleTitre5.Colspan = 1;
                    tableau.AddCell(celluleTitre5);

                    
                    List<Plan> listPlan = bordereau.ListPlan;
                    listPlan.ForEach(delegate (Plan p)
                     {
                         tableau.AddCell(p.Numero_Plan.ToString());
                         tableau.AddCell(p.Designation);
                         tableau.AddCell(p.Indice.ToString());
                         tableau.AddCell("");
                         tableau.AddCell("");
                     });
                     
                    tableau.SpacingBefore = doc.PageSize.Height - matrixY - 30;
                    tableau.SpacingAfter = 30;
                    doc.Add(tableau);

                    cb.SetTextMatrix(doc.PageSize.Width - label_signature.Width - 40, doc.PageSize.Height - tableau.TotalHeight + 20);
                    cb.ShowText(label_signature.Text);

                    cb.EndText();
                    doc.Close();
                    writer.Close();
                    fs.Close();
                    MessageBox.Show("Fichier créé !");

                }
                catch (IOException e)
                {
                    MessageBox.Show("Une erreur est survenue, le fichier n'a pas été créé !");
                    Console.WriteLine(e);
                }
            }
            else
            {
                MessageBox.Show("Pas de bordereau à exporter !");
            }

        }

    }
}
