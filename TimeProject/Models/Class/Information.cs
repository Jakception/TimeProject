using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class Information : Evenement
    {
        private int id_Event { get; set; }
        private DateTime dt_Event { get; set; }
        private string event_Corps { get; set; }
        public virtual User user { get; set; }
        public virtual List<UserEvent> listUserEvent { get; set; }
        public virtual List<EventProjet> listEventProjet { get; set; }
    }
}
