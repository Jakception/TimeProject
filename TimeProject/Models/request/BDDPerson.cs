using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeProject.Models.Class;
using System.Data.Common;
using TimeProject.Models.request;


namespace TimeProject.Models.request
{
    static class BDDPerson
    {

        private static DbDataReader dataReader { get; set; }
        private static string req;


        static public List<User> getAllUser()
        {
            List<User> lstUsers = new List<User>();
            DataBase.ConnexionToDataBase();
            req = "select * from user;";

            dataReader = DataBase.DBSelect(req);
           
                while (dataReader.Read())
                {
                    User u;

                    u = new User(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
                   
                    lstUsers.Add(u);
                }

          
            DataBase.FermeDataReader(dataReader);
            return lstUsers;
        }
        //Recupere les projets si Admin

            static public User getUser(string id_user)
        {
            User use = new User();
            DataBase.ConnexionToDataBase();
            req = "select * from user where id_user ='" + id_user +"';";

            dataReader = DataBase.DBSelect(req);

            while (dataReader.Read())
            {

                User u;
                u = new User(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
                use = u;
                
            }
         

            DataBase.FermeDataReader(dataReader);
            return use;
        }
        //Créer un user
        public static int CreateUser(string codeTpProfil, string initial, string nomUser, string prenomUser, string mail)
        {
            int nbLigne = 0;

            req = "INSERT INTO `user`(`ID_USER`, `CODE_TP_PROFIL`, `INIT_USER`, `NOM_USER`, `PRENOM_USER`, `MAIL`, `PWD`) VALUES ('" + GenerateIDUser(nomUser, prenomUser) + "', '" + codeTpProfil + "', '" + initial + "', '" + nomUser + "', '" + prenomUser + "', '" + mail + "', '" + GeneratePWD() + "')";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne; 
        }
        // Génére l'id de l'utilisateur
        public static string GenerateIDUser(string nomUser, string prenomUser)
        {
            string idUser = "";
            Random rnd = new Random();

            idUser = nomUser[0].ToString() + nomUser[1].ToString() + prenomUser[0].ToString() + prenomUser[1].ToString() + rnd.Next(1,10).ToString() + rnd.Next(1, 10).ToString() + rnd.Next(1, 10).ToString();

            return idUser;
        }
        // Génére un mot de passe
        public static string GeneratePWD()
        {
            string pwd = "";
            Random rnd = new Random();
            string[] tabChiffre = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] tabLettre = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "x", "y", "w", "z" };

            for (int i = 0; i < 6; i++)
            {
                if(rnd.Next(1, 3) == 1)
                {
                    pwd += tabChiffre[rnd.Next(0, tabChiffre.Length)];
                }
                else
                {
                    pwd += tabLettre[rnd.Next(0, tabLettre.Length)];
                }
                
            }

            return pwd;
        }
        // Vérifie si user déjà existant
        public static User DejaExisteUser(string nomUser, string prenomUser)
        {
            User user;

            DataBase.ConnexionToDataBase();
            dataReader = DataBase.DBSelect("SELECT * FROM User WHERE NOM_USER = '" + nomUser + "' AND PRENOM_USER = '" + prenomUser + "'");
            if (dataReader.Read())
            {
                user = new User(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
            }
            else
            {
                user = null;
            }

            DataBase.FermeDataReader(dataReader);

            return user;
        }
        // Vérifie mot de passe
        public static User VerifieEmail(string mail)
        {
            User user;

            DataBase.ConnexionToDataBase();
            dataReader = DataBase.DBSelect("SELECT * FROM User WHERE MAIL = '" + mail + "';");
            if (dataReader.Read())
            {
                user = new User(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
            }
            else
            {
                user = null;
            }

            DataBase.FermeDataReader(dataReader);

            return user;
        }
        public static string RecupereMdp(string idUser, string mail)
        {
            User user;
            string mdp;

            DataBase.ConnexionToDataBase();
            dataReader = DataBase.DBSelect("SELECT * FROM User WHERE ID_USER = '" + idUser + "' AND MAIL = '" + mail + "';");
            if (dataReader.Read())
            {
                user = new User(dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
                mdp = user.pwd;
            }
            else
            {
                user = null;
                mdp = "";
            }

            DataBase.FermeDataReader(dataReader);

            return mdp;
        }
        // Mise à jour du PWD de l'utilisateur
        public static int MajMdpUser(string idUser, string mail)
        {
            int nbLigne = 0;

            req = "UPDATE User SET PWD = '" + GeneratePWD() + "' WHERE ID_USER = '" + idUser + "' AND MAIL = '" + mail + "';";

            nbLigne = DataBase.DBUpdate(req);

            return nbLigne;
        }
        public static int ChangerMdpUser(string idUser, string mdp)
        {
            int nbLigne = 0;

            req = "UPDATE User SET PWD = '" + mdp + "' WHERE ID_USER = '" + idUser + "';";

            nbLigne = DataBase.DBUpdate(req);

            return nbLigne;
        }
        // Supprime l'utilisateur
        public static int DeleteUser(string idUser)
        {
            int nbLigne = 0;

            req = "DELETE FROM Cr_user WHERE ID_USER = '" + idUser + "'; \n"
                + " DELETE FROM User_event WHERE ID_USER = '" + idUser + "'; \n"
                + " DELETE FROM User_pole WHERE ID_USER = '" + idUser + "'; \n"
                + " DELETE FROM User_projet WHERE ID_USER = '" + idUser + "'; \n"
                + " DELETE FROM User WHERE ID_USER = '" + idUser + "';";

            nbLigne = DataBase.DBDelete(req);

            return nbLigne;
        }

    }
}
