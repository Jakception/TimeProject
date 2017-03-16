using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeProject.Models.Class;
using System.Data.Common;

namespace TimeProject.Models.request
{
    static class requestProjet
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static void ProjetEncours()
        {
            List<Projet> lstProj = new List<Projet>();
            DataBase.ConnexionToDataBase();
            req = "SELECT p.* FROM projet p where DT_FIN_REEL is null;";

            dataReader = DataBase.DBSelect(req);

           
                while (dataReader.Read())
                {
                    Projet p;

                    p = new Projet(dataReader[0].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString(), dataReader[7].ToString(), Convert.ToDateTime(dataReader[8]), Convert.ToDateTime(dataReader[9].ToString()));
                    
                    lstProj.Add(p);
                }
            
                

          
            DataBase.FermeDataReader(dataReader);
            sessionUser.setListProj(lstProj);
        }


        static public void projetUser()
        {
            string req;

            req = req = "SELECT p.* FROM projet p, user_projet up WHERE p.CODE_PROJET = up.CODE_PROJET AND p.ID_USER = " + sessionUser.getID() + " OR up.ID_USER = " + sessionUser.getID() + ";";
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {

            }
            else
            {

            }

            DataBase.FermeDataReader(dataReader);

        }

        static public void clotureProjet(string date, string codeProjet)
        {
            int nbLigne;
            
            req = "UPDATE `projet` SET `DT_FIN_REEL`= '"+ date +"' WHERE `CODE_PROJET`= '"+ codeProjet +"';";
            

            nbLigne = DataBase.DBUpdate(req);
             if (nbLigne == 0)
             {
                 System.Windows.Forms.MessageBox.Show("Erreur à l'enregistrement");
             }
             else
             {
                 System.Windows.Forms.MessageBox.Show("Projet Clos");
             }
        }

        static public void creationProjet(string code, string nameProjet, string id_user, string nomClient, string adresseClient, string villeClient, DateTime dtDeb, DateTime dtFinPrev)
        {
            req = "INSERT INTO `projet`(`CODE_PROJET`,`ID_USER`, `NOM_PROJET`, `NOM_CLIENT`, `ADRESSE_CLIENT`, `VILLE_CLIENT`, `DT_DEB_PROJET`, `DT_OBJ_FIN`) VALUES ('" + code +"','" ;
            req = req + id_user + "','" + nameProjet + "','";
            req = req + nomClient + "','" + adresseClient +"','"+villeClient+ "','";
            req = req + dtDeb + "','" + dtFinPrev + "';";

            int nbligne;

            nbligne = DataBase.DBInsert(req);

            if (nbligne == 0)
            {
                System.Windows.Forms.MessageBox.Show("FAIL");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("ok");
            }

        }
    }
}
