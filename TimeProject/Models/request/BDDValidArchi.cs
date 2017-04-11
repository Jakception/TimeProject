using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeProject.Models.Class;
using System.Data.Common;
using TimeProject.Models.request;

namespace TimeProject.Models.request
{
    public static class BDDValidArchi
    {
        private static DbDataReader dataReader { get; set; }
        private static string req;
    }
}
