﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class UserPole
    {
        private int id_User { get; set; }
        private int code_Pole { get; set; }
        public virtual User user { get; set; }
        public virtual Pole pole { get; set; }
    }
}
