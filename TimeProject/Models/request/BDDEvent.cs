﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using TimeProject.Models.Class;
using TimeProject.Models.request;
using TimeProject.Models;

namespace TimeProject
{
    static class BDDEvent
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;




        public static List<ActionProjet> getActionProjet(string codeProjet)
        {
            List<ActionProjet> lstAct = new List<ActionProjet>();
            User user;
            req = "select a.* from action a, eventprojet ep where ep.ID_EVENT = a.ID_EVENT AND ep.code_projet ='" + codeProjet + "' ORDER BY DT_EVENT DESC;";
            dataReader = DataBase.DBSelect(req);


            while (dataReader.Read())
            {
                ActionProjet act;

                act = new ActionProjet(dataReader[0].ToString(), dataReader[1].ToString(), Convert.ToDateTime(dataReader[2]), dataReader[3].ToString(),Convert.ToInt32(dataReader[4]));
                user = BDDPerson.getUser(dataReader[5].ToString());
                act.user = user;
                lstAct.Add(act);

            }

            DataBase.FermeDataReader(dataReader);
            return lstAct;

        }

        public static List<Information> getInfoProjet(string codeProjet)
        {
            List<Information> lstInfo = new List<Information>();

            req = "select i.* from information i, eventprojet ep where ep.ID_EVENT = i.ID_EVENT AND ep.code_projet ='" + codeProjet + "' ORDER BY DT_EVENT DESC;";
            dataReader = DataBase.DBSelect(req);

            User user;
            while (dataReader.Read())
            {
                Information act;

                act = new Information(dataReader[0].ToString(), Convert.ToDateTime(dataReader[1]), dataReader[2].ToString());
                user = BDDPerson.getUser(dataReader[3].ToString());
                act.user = user;
                
                lstInfo.Add(act);
            }

            DataBase.FermeDataReader(dataReader);
            return lstInfo;
        }


        public static void insertAction()
        {

        }

    }
}
