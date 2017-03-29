using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject.Models.Class
{
    class status
    {
        public int codeStatus { get; set; }
        public string libelleStatus { get; set; }

        public status(int code, string libel)
        {
            this.codeStatus = code;
            this.libelleStatus = libel;
        }

        public override string ToString()
        {
            return libelleStatus;
        }
    }
}
