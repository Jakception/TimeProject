﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class ActionProjet : Evenement
    {
        public string id_Event { get; set; }
        public DateTime dt_Event { get; set; }
        public string event_Corps { get; set; }
        public string etat { get; set; }
        public int importance { get; set; }
        public virtual User user { get; set; }
        public Projet projet { get; set; }
       // public virtual List<EventProjet> listEventProjet { get; set; }


        public ActionProjet(string id_event, string etat, DateTime dt_event, string event_corps, int importance)
        {
            this.id_Event = id_event;
            this.dt_Event = dt_event;
            this.event_Corps = event_corps;
            this.etat = etat;
            this.importance = importance;
 
        }

        public string getUserConcerne()
        {
            string userconcerne;
            userconcerne = "";

         
            return userconcerne;
        }



        public override string ToString()
        {
            if (Convert.ToInt32(this.etat)  > 3)
            {
                return "RENDU " + projet.nom_Projet + ": " + this.event_Corps + " Prévu le : " + this.dt_Event.ToShortDateString() + " Crée par : " + this.user.init_User + "  " + ConfigItem.getStatus(Convert.ToInt32(this.etat));
            }
            else
            {
                return projet.getConcerne() + projet.nom_Projet + ": " + this.event_Corps + " Prévu le : " + this.dt_Event.ToShortDateString() + " Crée par : " + this.user.init_User + "  " + ConfigItem.getStatus(Convert.ToInt32(this.etat)); 
            }
            
        }


    }
}
