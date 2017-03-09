using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class User
    {
        private int code { get; set; }
        private string grade { get; set; }
        private string nom { get; set; }
        private string prenom { get; set; }
        private string mail { get; set; }
        private string fixe { get; set; }
        private string port { get; set; }
        private int code_Tp_Profil { get; set; }

        private List<Projet> lstProjet { get; set; }

        public virtual TypeProfil typeProfil { get; set; }
        public virtual List<UserProjet> listUserProjet { get; set; }
        public virtual List<Projet> listProjet { get; set; }
        public virtual List<UserEvent> listUserEvent { get; set; }
        public virtual List<Evenement> listEvenement { get; set; }
        public virtual List<Action> listAction { get; set; }
        public virtual List<Information> listInformation { get; set; }
        public virtual List<CrUser> listCrUser { get; set; }
        public virtual List<UserPole> listUserPole { get; set; }

        public User(int id ,string level, string name, string surname, string mail, string tel, string mobile , List<Projet> lstProj)
        {
            this.code = id;
            this.grade = level;
            this.nom = name;
            this.prenom = surname;
            this.mail = mail;
            this.fixe = tel;
            this.port = mobile;
            this.lstProjet = lstProj;
        }



    }
}
