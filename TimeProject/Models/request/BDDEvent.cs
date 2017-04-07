using System;
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


        public static void insertAction(ActionProjet act)
        {
            string id,date;
            date = act.dt_Event.ToString("yy-MM-dd");
            id = act.id_Event + getKey(act.projet);

            act.id_Event = id;
            req = "INSERT INTO `action` VALUES ('" + id + "','" + act.etat + "','" +date + "','"+ act.event_Corps + "','" + act.importance  +"','"+ act.user.id_User +"');" ;
            DataBase.DBInsert(req);

            req = "INSERT INTO eventprojet VALUES ('" + act.projet.code_Projet + "','"+ id +"')";
            DataBase.DBInsert(req);

            
        }

        public static int getKey(Projet p)
        {
            int key;
            
            req = "SELECT Count(*) FROM `eventprojet` WHERE `CODE_PROJET` = '" + p.code_Projet + "';";
            dataReader = DataBase.DBSelect(req);
            key = 0;
            
            while (dataReader.Read())
            {
                key = Convert.ToInt32(dataReader[0]) +1;
            }

            DataBase.FermeDataReader(dataReader);
            return key;
        }

        public static void insertInfo(Information info)
        {
            string req,date;
            string id;

            id = info.id_Event + getKey(info.projet);
            System.Windows.Forms.MessageBox.Show(id);
            info.id_Event = id;
            date = info.dt_Event.ToString("yy-MM-dd");

            req = "INSERT INTO `information` VALUES ('" + id + "','"+ date + "','" + info.event_Corps  +"','"+ info.user.id_User + "');";
            DataBase.DBInsert(req);

            //req = "INSERT INTO eventprojet VALUES ('" + info.projet.code_Projet + "','" + id + "')";
            //DataBase.DBInsert(req);
        }

        public static void delAction(ActionProjet act)
        {
            string req;

            req = "DELETE FROM 'action' WHERE ID_EVENT ='"+ act.id_Event +"';";
            DataBase.DBDelete(req);
        }
        public static void delInfo(Information info)
        {
            string req;

            req = "DELETE FROM 'information' WHERE ID_EVENT ='" + info.id_Event + "';";
            DataBase.DBDelete(req);
        }

    }
}
