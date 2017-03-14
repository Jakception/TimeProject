using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class User
    {
        private int id_User { get; set; }
        private string code_Tp_Profil { get; set; }
        private string init_User { get; set; }
        private string nom { get; set; }
        private string prenom { get; set; }
        private string mail { get; set; }
        private string pwd { get; set; }
        private string grade { get; set; }
        private string fixe { get; set; }
        private string port { get; set; }
        

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

        public User(int id_User, string code_Tp_Profil, string init_User, string nom, string prenom, string mail, string pwd)
        {
            this.id_User = id_User;
            this.code_Tp_Profil = code_Tp_Profil;
            this.init_User = init_User;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.pwd = pwd;
        }

        public User(int id ,string level, string name, string surname, string mail, string tel, string mobile , List<Projet> lstProj)
        {
            this.id_User = id;
            this.grade = level;
            this.nom = name;
            this.prenom = surname;
            this.mail = mail;
            this.fixe = tel;
            this.port = mobile;
            this.lstProjet = lstProj;
        }

        public override string ToString()
        {
            return "Bonjour " + this.nom;
        }


    }
}
