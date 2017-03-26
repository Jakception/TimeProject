using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Information : Evenement
    {
        public string id_Event { get; set; }
        public DateTime dt_Event { get; set; }
        public string event_Corps { get; set; }
        public  User user { get; set; }
       
       // public virtual List<EventProjet> listEventProjet { get; set; }

        public Information(string id_event, DateTime dtEvent, string eventCorps)
        {
            this.id_Event = id_event;
            this.dt_Event = dtEvent;
            this.event_Corps = eventCorps;
         }

        public override string ToString()
        {
            return  this.event_Corps + "  par : " + user.nom + "  " + user.prenom;
        }
    }
}
