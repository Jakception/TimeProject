﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class Pole
    {
        private int code_Pole { get; set; }
        private string nom_Pole { get; set; }
        public virtual List<CrPole> listCrPole { get; set; }
        public virtual List<UserPole> listUserPole { get; set; }
    }
}
