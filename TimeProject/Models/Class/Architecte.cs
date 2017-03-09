using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class Architecte
    {
        private int id_Archi { get; set; }
        private string nom_Archi { get; set; }
        private string adresse_Archi { get; set; }
        private string cp_Archi { get; set; }
        private string ville_Archi { get; set; }
        public virtual List<ValidArchi> listValidArchi { get; set; }
        public virtual List<Projet> listProjet { get; set; }
    }
}
