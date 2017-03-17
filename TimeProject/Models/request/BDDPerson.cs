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




    }
}
