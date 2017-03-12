using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class CrUser
    {
        private int code_Cr { get; set; }
        private int id_User { get; set; }
        public virtual CompteRendu compteRendu { get; set; }
        public virtual User user { get; set; }
    }
}
