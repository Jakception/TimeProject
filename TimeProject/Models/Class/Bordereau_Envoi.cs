using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class Bordereau_Envoi
    {
        private int code_Bordereau { get; set; }
        private int numero_Bordereau { get; set; }
        private string  designation { get; set; }
        private string exemplaire { get; set; }
        private string version { get; set; }
        private int etat { get; set; }
        public virtual List<Bord_Plan> listBordPlan { get; set; }
        public virtual List<Bord_Projet> listBordProjet { get; set; }
    }
}
