﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class BordProjet
    {
        private int code_Bordereau { get; set; }
        private int code_Projet { get; set; }
        public virtual BordereauEnvoi bordereau_Envoi { get; set; }
        public virtual Projet projet { get; set; }
    }
}
