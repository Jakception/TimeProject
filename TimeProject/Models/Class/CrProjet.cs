﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class CrProjet
    {
        private int code_Projet { get; set; }
        private int code_Cr { get; set; }
        public virtual CompteRendu compteRendu { get; set; }
        public virtual Projet projet { get; set; }
    }
}
