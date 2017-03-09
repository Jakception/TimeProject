using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class BordereauEnvoi
    {
        private int code_Bordereau { get; set; }
        private int numero_Bordereau { get; set; }
        private string  designation { get; set; }
        private string exemplaire { get; set; }
        private string version { get; set; }
        private int etat { get; set; }
        public virtual List<BordPlan> listBordPlan { get; set; }
        public virtual List<BordProjet> listBordProjet { get; set; }
    }
}
