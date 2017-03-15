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


        static public void loadUser(User user)
        {
            utilisateur = user;
        }

        static public string getNomPrenom()
        {
            return utilisateur.nom + " - " + utilisateur.prenom;
        }
    }
}
