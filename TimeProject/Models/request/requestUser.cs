using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Common;

namespace TimeProject.Models.request
{
    static class requestUser
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static int GetMaxIdUser()
        {
            int maxID = 0;

            req = "SELECT MAX(ID_USER) FROM User;";
            dataReader = DataBase.DBSelect(req);

            if (dataReader.Read())
            {
                maxID = Convert.ToInt32(dataReader[0]);
            }

            DataBase.FermeDataReader(dataReader);

            return maxID;
        }

        public static int CreateUser(int idUser, string typeProfil, string initial, )
        {
            int nbLigne = 0;

            return nbLigne;
        }
    }
}
