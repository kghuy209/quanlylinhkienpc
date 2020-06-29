using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlylinhkienpc
{
    class Account
    {
        private static Account instance;
        public static Account Instance
        {
            get { if (instance == null) instance = new Account(); return instance; }
            private set { instance = value; }
        }
        public bool Login(string userName, string passWord)
        {

            string query = "dbo.dangnhap @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});

            return result.Rows.Count > 0;
        }

        public DataTable selectTK(string userName, string passWord)
        {

            string query = "dbo.dangnhap @userName , @passWord";

             DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord /*list*/});
            return result;
        }

        public void inserttaikhoan(string name, string pass, string level)
        {
            string query = "dbo.inserttaikhoan @username , @password , @level";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, pass, level });
        }
        public void updatetaikhoan(string id, string name, string pass, string level)
        {
            string query = "dbo.updatetaikhoan @id , @username , @password , @level";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, pass, level });
        }

        public void deletetaikhoan(string id)
        {
            string query = "dbo.deletetaikhoan @id";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }

    }
}
