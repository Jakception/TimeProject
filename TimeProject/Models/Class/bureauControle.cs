using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class BureauControle
    {
        private int id_Bc { get; set; }
        private string nom_Bc { get; set; }
        private string adresse_Bc { get; set; }
        private string cp_Bc { get; set; }
        private string ville_Bc { get; set; }
        public virtual List<ValidBc> listValidBc { get; set; }
        public virtual List<Projet> projet { get; set; }
    }
}
