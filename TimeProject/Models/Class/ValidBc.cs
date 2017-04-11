using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class ValidBc
    {

        private DateTime dt_Rep_Bc;
        private int num_Courrir_Bc;
        private string rep_Bc;

        public DateTime Dt_Rep_Bc
        {
            get
            {
                return dt_Rep_Bc;
            }

            set
            {
                dt_Rep_Bc = value;
            }
        }

        public int Num_Courrir_Bc
        {
            get
            {
                return num_Courrir_Bc;
            }

            set
            {
                num_Courrir_Bc = value;
            }
        }

        public string Rep_Bc
        {
            get
            {
                return rep_Bc;
            }

            set
            {
                rep_Bc = value;
            }
        }

        public ValidBc(DateTime dt_Rep_Bc, int num_Courrir_Bc, string rep_Bc)
        {
            this.Dt_Rep_Bc = dt_Rep_Bc;
            this.Num_Courrir_Bc = num_Courrir_Bc;
            this.Rep_Bc = rep_Bc;
        }
    }
}
