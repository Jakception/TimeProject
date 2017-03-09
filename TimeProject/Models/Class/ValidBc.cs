using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class ValidBc
    {
        private int id_Bc { get; set; }
        private int code_Plan { get; set; }
        private int indice { get; set; }
        private DateTime dt_Rep_Bc { get; set; }
        private int num_Courrir_Bc { get; set; }
        private string rep_Bc { get; set; }
        public virtual BureauControle bureauControle { get; set; }
        public virtual Plan plan { get; set; }
    }
}
