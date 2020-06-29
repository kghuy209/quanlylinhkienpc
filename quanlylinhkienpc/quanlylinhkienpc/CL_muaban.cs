using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlylinhkienpc
{
    class CL_muaban
    {
        private static CL_muaban instance;
        public static CL_muaban Instance
        {
            get { if (instance == null) instance = new CL_muaban(); return CL_muaban.instance; }
            private set { CL_muaban.instance = value; }
        }
       // public DataTable getlinhkienmuaban

    }
}
