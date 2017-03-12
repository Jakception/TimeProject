using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Plan
    {
        private int code_Plan { get; set; }
        private int indice { get; set; }
        private int code_Porjet { get; set; }
        private int numero_Plan { get; set; }
        private string libelle_Plan { get; set; }
        private string designation { get; set; }
        private DateTime dt_Plan { get; set; }
        public virtual Projet projet { get; set; }
        public virtual List<ValidArchi> listValidArchi { get; set; }
        public virtual List<ValidBc> listValidBc { get; set; }
        public virtual List<BordPlan> listBordPlan { get; set; }

    }
}
