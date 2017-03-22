using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeProject.Models.Class;

namespace TimeProject
{
    static class sessionUser
    {
        static private User utilisateur;
        static private List<Projet> lstProjetUSer;
        static public Projet projetModif { get; set; }

        static public void loadUser(User user)
        {
            utilisateur = user;
        }

        static public string getNomPrenom()
        {
            return utilisateur.nom + " - " + utilisateur.prenom;
        }
        static public string getTpProfil()
        {
            return utilisateur.code_Tp_Profil;
        }

        static public string getID()
        {
            return utilisateur.id_User;
        }

        public static void setListProj(List<Projet> lstProj)
        {
            lstProjetUSer = lstProj;
        }
        public static List<Projet> getListProj()
        {
            return lstProjetUSer;
        }
    }
}
