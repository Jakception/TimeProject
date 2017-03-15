using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Projet
    {
        private string code_Projet { get; set; }
        private int id_Bc { get; set; }
        private int id_Archi { get; set; }
        private string id_chefProjet { get; set; }
        private string nom_Projet { get; set; }
        private string nom_Client { get; set; }
        private string adresse_Client { get; set; }
        private string ville_Client { get; set; }
        private DateTime dt_Deb_Projet { get; set; }
        private DateTime dt_Obj_Fin { get; set; }
        private DateTime dt_Fin_Reel { get; set; }

        private List<User> lstSalarieProjet { get; set; }

        public virtual User user { get; set; }
        public virtual BureauControle bureauControle { get; set; }
        public virtual Architecte architecte { get; set; }
        public virtual List<UserProjet> listUserProjet { get; set; }
        public virtual List<Plan> listPlan { get; set; }
        public virtual List<BordProjet> listBordProjet { get; set; }
        public virtual List<CrProjet> listCrProjet { get; set; }
        public virtual List<EventProjet> listEventProjet { get; set; }

    public Projet(string code_Projet, int id_Bc, int id_Archi, string id_User, string nom_Projet, string nom_Client, string adresse_Client, string ville_Client, DateTime dt_Deb_Projet, DateTime dt_Obj_Fin, DateTime dt_Fin_Reel, List<User> lstSalProjet)
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

        public Projet(string cdProj,string id_chef, string name, string clientName, string adresseClient, string villeClient, DateTime dtDeb, DateTime dtFinObj)
        {
            this.code_Projet = cdProj;
            this.id_chefProjet = id_chef;
            this.nom_Projet = name;
            this.nom_Client = clientName;
            this.adresse_Client = adresseClient;
            this.ville_Client = villeClient;
            this.dt_Deb_Projet = dtDeb;
            this.dt_Obj_Fin = dtFinObj;

        }
    }
}
