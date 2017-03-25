using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class ActionProjet : Evenement
    {
        public int id_Event { get; set; }
        public DateTime dt_Event { get; set; }
        public string event_Corps { get; set; }
        public string etat { get; set; }
        public int importance { get; set; }
        public virtual User user { get; set; }
        public virtual List<User> listUserEvent { get; set; }
       // public virtual List<EventProjet> listEventProjet { get; set; }

        public ActionProjet( int id_event, DateTime dt_event, string event_corps, string etat, int importance, User userCrea, List<User> lstUserConcerne )
        {
            this.id_Event = id_event;
            this.dt_Event = dt_event;
            this.event_Corps = event_corps;
            this.etat = etat;
            this.importance = importance;
            this.user = userCrea;
            this.listUserEvent = lstUserConcerne;
        }

        public string getUserConcerne()
        {
            string userconcerne;
            userconcerne = "";

            foreach (var item in listUserEvent)
            {
                userconcerne = userconcerne + "/";
            }
            return userconcerne;
        }

        public override string ToString()
        {
            return getUserConcerne() + "   " + this.event_Corps + "  par : "+ user.nom +"  " + user.prenom;
        }
    }
}
