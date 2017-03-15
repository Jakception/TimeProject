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
                    System.Windows.Forms.MessageBox.Show(p.ToString());
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
    }
}
