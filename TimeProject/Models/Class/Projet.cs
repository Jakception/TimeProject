using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeProject.Class;

namespace TimeProject.Models.Class
{
    class Projet
    {
        private int code_Projet { get; set; }
        private int id_Bc { get; set; }
        private int id_Archi { get; set; }
        private int id_chefProjet { get; set; }
        private string nom_Projet { get; set; }
        private string nom_Client { get; set; }
        private string adresse_Client { get; set; }
        private string ville_Client { get; set; }
        private DateTime dt_Deb_Projet { get; set; }
        private DateTime dt_Obj_Fin { get; set; }
        private DateTime dt_Fin_Reel { get; set; }

        private List<User> lstSalarieProjet { get; set; }

        public Projet(int code_Projet, int id_Bc, int id_Archi, int id_User, string nom_Projet, string nom_Client, string adresse_Client, string ville_Client, DateTime dt_Deb_Projet, DateTime dt_Obj_Fin, DateTime dt_Fin_Reel, List<User> lstSalProjet)
        {
            this.code_Projet = code_Projet;
            this.id_Bc = id_Bc;
            this.id_Archi = id_Archi;
            this.id_chefProjet = id_User;
            this.nom_Projet = nom_Projet;
            this.nom_Client = nom_Client;
            this.adresse_Client = adresse_Client;
            this.ville_Client = ville_Client;
            this.dt_Deb_Projet = dt_Deb_Projet;
            this.dt_Obj_Fin = dt_Obj_Fin;
            this.dt_Fin_Reel = dt_Fin_Reel;
            this.lstSalarieProjet = lstSalProjet;
        }
    }
}
