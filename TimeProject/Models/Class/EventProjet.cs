using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class EventProjet
    {
        private int code_Projet { get; set; }
        private int id_Event { get; set; }
        public virtual Evenement evenement { get; set; }
        public virtual Projet projet { get; set; }
    }
}
