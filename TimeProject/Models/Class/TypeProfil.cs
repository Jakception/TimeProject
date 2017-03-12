using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public  class TypeProfil
    {
        private int code_Tp_Profil { get; set; }
        private string libelle_Tp_Profil { get; set; }
        public virtual List<User> listUser { get; set; }
        public TypeProfil (int code_Tp_Profil, string libelle_Tp_Profil)
        {
            this.code_Tp_Profil = code_Tp_Profil;
            this.libelle_Tp_Profil = libelle_Tp_Profil;
        }
    }
}
