using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class User
    {
        public int id_User { get; set; }
        public string code_Tp_Profil { get; set; }
        public string init_User { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string pwd { get; set; }
        public string grade { get; set; }
        public string fixe { get; set; }
        public string port { get; set; }
        

        public List<Projet> lstProjet { get; set; }

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

    }
}
