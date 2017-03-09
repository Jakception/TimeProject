using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class Bord_Plan
    {
        private int code_Bordereau { get; set; }
        private int code_Plan { get; set; }
        private int indice { get; set; }
        public virtual Bordereau_Envoi bordereau_Envoi { get; set; }
        public virtual Plan plan { get; set; }
    }
}
