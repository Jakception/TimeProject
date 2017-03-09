using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class CrPole
    {
        private int code_Pole { get; set; }
        private int code_Cr { get; set; }
        public virtual CompteRendu compteRendu { get; set; }
        public virtual Pole pole { get; set; }
    }
}
