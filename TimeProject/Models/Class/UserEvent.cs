using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class UserEvent
    {
        private int id_Event { get; set; }
        private int id_User { get; set; }
        public virtual User user { get; set; }
        public virtual Evenement evenement { get; set; }
        public virtual Action action { get; set; }
        public virtual Information information { get; set; }
}
}
