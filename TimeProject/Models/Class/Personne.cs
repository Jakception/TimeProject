using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Class
{
    class Personne
    {
        private int code { get; set; }
        private string grade { get; set; }
        private string nom { get; set; }
        private string prenom { get; set; }
        private string mail { get; set; }
        private string fixe { get; set; }
        private string port { get; set; }


        public Personne (int id ,string level, string name, string surname, string mail, string tel, string mobile )
        {
            this.code = id;
            this.grade = level;
            this.nom = name;
            this.prenom = surname;
            this.mail = mail;
            this.fixe = tel;
            this.port = mobile;
        }



    }
}
