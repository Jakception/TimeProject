using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;
using TimeProject.Models.Class;

namespace TimeProject.Models.request
{
    public static class Authentification
    {
        private static DbDataReader dataReader { get; set; }

        public static User AuthentificationApp (string identifiant, string mdp)
        {
            User user;

            DataBase.ConnexionToDataBase();
            dataReader = DataBase.DBSelect("SELECT * FROM User WHERE MAIL = '" + identifiant + "' AND PWD = '" + mdp + "'");
            if (dataReader.Read())
            {
                user = new User(Convert.ToInt32(dataReader[0]), dataReader[1].ToString(), dataReader[2].ToString(), dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
                DataBase.FermeDataReader(dataReader);
            }
            else
            {
                user = null;
            }

            return user;
        }
    }
}
