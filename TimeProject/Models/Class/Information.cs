using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Information : Evenement
    {
        public int id_Event { get; set; }
        public DateTime dt_Event { get; set; }
        public string event_Corps { get; set; }
        public virtual User user { get; set; }
        public virtual List<User> listUserEvent { get; set; }
       // public virtual List<EventProjet> listEventProjet { get; set; }


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
            return getUserConcerne() + "   " + this.event_Corps + "  par : " + user.nom + "  " + user.prenom;
        }
    }
}
