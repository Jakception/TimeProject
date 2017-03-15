using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeProject.Models.Class;
using System.Data.Common;



namespace TimeProject.Models.request
{
    static class BDDPerson
    {

        private static DbDataReader dataReader { get; set; }


        //Recupere les projets si Admin

        static public List<Projet> projetAdmin()
        {

            string req;
            DataBase.ConnexionToDataBase();
            List<Projet> lstProj = new List<Projet>();

            req = "SELECT p.* FROM projet p";
            dataReader = DataBase.DBSelect(req);

            if (dataReader.Read())
            {
                
            }
            else
            {
                lstProj = null;  
            }

            return lstProj;
        } 


        static public void projetUser()
        {
            string req;

            req= req = "SELECT p.* FROM projet p, user_projet up WHERE p.CODE_PROJET = up.CODE_PROJET AND p.ID_USER = " +sessionUser.getID() +" OR up.ID_USER = " + sessionUser.getID() + ";" ;
            dataReader = DataBase.DBSelect(req);
            if (dataReader.Read())
            {

            }
            else
            {

            }

        }
    }
}
