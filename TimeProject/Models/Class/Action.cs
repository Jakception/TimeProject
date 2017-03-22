using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Action : Evenement
    {
        public string etat { get; set; }
        public int importance { get; set; }
        public virtual User user { get; set; }
        public virtual List<UserEvent> listUserEvent { get; set; }
        public virtual List<EventProjet> listEventProjet { get; set; }
    }
}
