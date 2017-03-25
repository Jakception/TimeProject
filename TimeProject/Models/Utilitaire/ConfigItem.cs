using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeProject.Models.Class;

namespace TimeProject
{
    static class ConfigItem
    {
        private static List<status> lstStatus = new List<status>();

        private static List<status> lstImportance = new List<status>();
        public static void initListeStatus()
        {
            status stat1, stat3, stat4;
            int cpt = lstStatus.Count;

            for (int i = 0; i <cpt ; i++)
            {
                lstStatus.RemoveAt(0);
            }
            

            stat1 = new status(1, "A faire");
            stat3 = new status(2, "En attente");
            stat4 = new status(3, "Validé");

            lstStatus.Add(stat1);
            lstStatus.Add(stat3);
            lstStatus.Add(stat4);

        }

        public static List<status> getListStatus()
        {
            return lstStatus;
        }

        public static void initListImportance()
        {

            status stat , stat2, stat3;
            stat = new status(1, "Forte");
            stat2 = new status(2, "Moyenne");
            stat3 = new status(3, "Faible");

            lstImportance.Add(stat);
            lstImportance.Add(stat2);
            lstImportance.Add(stat3);
        }

        public static List<status> getImportance()
        {
            return lstImportance;
        }
    }
}
