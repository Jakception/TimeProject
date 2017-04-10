using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    public class BordPlan
    {
        public BordereauEnvoi bordereau { get; set; }
        public  List<Plan> lstPlan { get; set; }
    }
}
