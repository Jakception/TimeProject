using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class UserProjet
    {
        private int code_Projet { get; set; }
        private int id_User { get; set; }
        public virtual Projet projet { get; set; }
        public virtual User user { get; set; }
    }
}
