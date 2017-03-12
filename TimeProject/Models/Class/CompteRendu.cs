using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class CompteRendu
    {
        private int code_Cr { get; set; }
        private string designation { get; set; }
        public virtual List<CrProjet> listCrprojet { get; set; }
        public virtual List<CrUser> listCrUser { get; set; }
        public virtual List<CrPole> listCrPole { get; set; }
    }
}
