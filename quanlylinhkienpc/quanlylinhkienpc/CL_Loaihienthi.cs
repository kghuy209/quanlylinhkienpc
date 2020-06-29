using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlylinhkienpc
{
    public class CL_Loaihienthi
    {
        
            private string ten;
            private string query;

            public string Ten
            {
                get
                {
                    return ten;
                }

                set
                {
                    ten = value;
                }
            }

            public string Query
            {
                get
                {
                    return query;
                }

                set
                {
                    query = value;
                }
            }
            public CL_Loaihienthi(string ten, string query)
            {
                this.Ten = ten;
                this.Query = query;
            }
        
    }
}
