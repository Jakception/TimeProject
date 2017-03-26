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
    public static class BDDPlan
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;


        static public List<Plan> getAllPlan()
        {
            List<Plan> lstPlans = new List<Plan>();
            DataBase.ConnexionToDataBase();
            req = "select * from plan;";

            dataReader = DataBase.DBSelect(req);

            while (dataReader.Read())
            {
                Plan p;

                p = new Plan(Convert.ToInt32(dataReader[0]), Convert.ToInt32(dataReader[1]), Convert.ToInt32(dataReader[2]), Convert.ToInt32(dataReader[3]), dataReader[4].ToString(), dataReader[5].ToString(), (DateTime)dataReader[6]);

                lstPlans.Add(p);
            }


            DataBase.FermeDataReader(dataReader);
            return lstPlans;
        }

        //public static Plan DejaExistePlan(int param1, int param2)
        //{

        //}
        //public static int CreatePlan()
        //{

        //}
    }
}
