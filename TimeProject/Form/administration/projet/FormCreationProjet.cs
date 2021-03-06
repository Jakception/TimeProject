﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeProject.Models.Class;
using TimeProject.Models.request;
namespace TimeProject
{
    public partial class FormCreationProjet : Form
    {

        private List<User> lstUser = new List<User>();
        public FormCreationProjet()
        {
            InitializeComponent();
            

            

            
            //charge la list de tous les users
        }

        private void btCreaProjet_Click(object sender, EventArgs e)
        {
            string codeProjet;
            string nomProjet;
            string nomClient, adresseClient, villeClient;
            DateTime dtDeb, dtFinPrev;
            User chefProjet;
            string messErreur;

            messErreur = "";

            codeProjet = txtChefProjet.Text;
            nomProjet = txtNomProjet.Text;
            nomClient = txtNomClient.Text;
            adresseClient = txtAdresseClient.Text;
            villeClient = txtVilleClient.Text;
            dtDeb = dtPickDeb.Value;
            dtFinPrev = dtPickFinPrev.Value;
            chefProjet = (User)lstBoxChefProjet.SelectedItem;


            if (codeProjet == "")
            {
                messErreur = messErreur + ((char)13) + " Le code Projet doit être renseigné";
            }
            if (nomProjet == "")
            {
                messErreur = messErreur + ((char)13) + " Le nom du projet doit être renseigné.";
            }
            if (nomClient == "" || adresseClient == "" || villeClient == "")
            {
                messErreur = messErreur + ((char)13)+ "Les informations clients doivent être renseignées";
            }
            if (dtDeb >= dtFinPrev)
            {
                messErreur = messErreur + ((char)13) + "La date de début doit être inférieur à la date de fin";
            }

            if (messErreur == "")
            {
                List<User> lstUserProj = new List<User>();

                foreach (var item in checkListUserProjet.CheckedItems)
                {
                    lstUserProj.Add((User)item);
                }
                nomProjet = txtNomProjet.Text;
                // Création du projet
                BDDProjet.creationProjet(codeProjet, nomProjet, chefProjet.id_User.ToString(), nomClient, adresseClient, villeClient, dtDeb, dtFinPrev);

                Projet p = new Projet(codeProjet, chefProjet.id_User, nomProjet,nomClient,adresseClient, villeClient,dtDeb,dtFinPrev);
                sessionUser.AddProj(p);
                // Enregistrement dans la table userprojet

                User u;
                foreach (var item in checkListUserProjet.CheckedItems)
                {
                    u = (User)item;
                   
                    BDDProjet.setUserProjet(u.id_User.ToString(), codeProjet);
                }
                
                    //remise des champs a vide 

                    txtChefProjet.Text = "";
                    txtNomProjet.Text = "";
                    txtNomClient.Text = "";
                    txtVilleClient.Text = "";
                    txtAdresseClient.Text = "";
                 
            }
            else
            {
                MessageBox.Show(messErreur);
            }

            classAdministration.lstUser = BDDPerson.getAllUser();


        }

        private void FormCreationProjet_Load(object sender, EventArgs e)
        {
            lstUser = classAdministration.lstUser;
            lstBoxChefProjet.DataSource = null;
            lstBoxChefProjet.DataSource = lstUser;

            foreach (var item in lstUser)
            {
                checkListUserProjet.Items.Add(item);
            }
        }
    }
}
