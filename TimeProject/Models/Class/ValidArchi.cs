using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class ValidArchi
    {
        private int code_Plan { get; set; }
        private int indice { get; set; }
        private int id_Archi { get; set; }
        private DateTime dt_Rep_Archi { get; set; }
        private int num_Cour_Archi { get; set; }
        private int rep_Archi { get; set; }
        public virtual Architecte architecte { get; set; }
        public virtual Plan plan { get; set; }
    }
}
