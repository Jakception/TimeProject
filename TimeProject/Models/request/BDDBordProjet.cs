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
    public static class BDDBordProjet
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;

        public static int CreateBordereauProjet(string codeProjet, string codeBordereau)
        {
            int nbLigne = 0;

            req = "INSERT INTO `bord_projet`(`CODE_BORDEREAU`, `CODE_PROJET`)  VALUES ('" + codeBordereau + "', '" + codeProjet + "');";

            nbLigne = DataBase.DBInsert(req);

            return nbLigne;
        }
    }
}
