﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeProject.Models.Class;


namespace TimeProject
{
    static class classAdministration
    {
        public static List<User> lstUser { get; set; }
        public static List<User> lstUserProjet { get; set; }
        
        public static Projet projetModif { get; set; }
    }
}
