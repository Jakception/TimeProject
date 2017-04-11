using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class ValidArchi
    {
        private DateTime dT_REP_ARCHI;
        private int num_Cour_Arch;
        private int rep_Archi;

        public ValidArchi(DateTime dT_REP_ARCHI, int num_Cour_Archi, int rep_Archi)
        {
            this.dT_REP_ARCHI = dT_REP_ARCHI;
            this.Num_Cour_Arch = num_Cour_Archi;
            this.Rep_Archi = rep_Archi;
        }

        public DateTime DT_REP_ARCHI
        {
            get
            {
                return dT_REP_ARCHI;
            }

            set
            {
                dT_REP_ARCHI = value;
            }
        }

        public int Num_Cour_Arch
        {
            get
            {
                return num_Cour_Arch;
            }

            set
            {
                num_Cour_Arch = value;
            }
        }

        public int Rep_Archi
        {
            get
            {
                return rep_Archi;
            }

            set
            {
                rep_Archi = value;
            }
        }
    }
}
