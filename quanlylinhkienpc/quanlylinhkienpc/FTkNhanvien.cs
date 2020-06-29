using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylinhkienpc
{
    public partial class FTkNhanvien : Form
    {
        public FTkNhanvien()
        {
            InitializeComponent();
        }
        string uname = "";
        public FTkNhanvien(string name)
        {
            InitializeComponent();
            uname = name;
            txbUserName.Text = name;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            DataTable ac = Account.Instance.selectTK(userName, passWord);
            string id = ac.Rows[0].ItemArray[0].ToString();
            if (ac.Rows.Count>0)
            {
                if (txbNewPass.Text != txbReEnterPass.Text)
                {
                    MessageBox.Show("Mật khẩu mới không trùng khớp");
                }
                else
                {
                    Account.Instance.updatetaikhoan(id, userName, txbNewPass.Text, "0");
                    MessageBox.Show("Đã thay đổi mật khẩu thành công");
                    txbNewPass.Text = "";
                    txbPassWord.Text = "";
                    txbReEnterPass.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng");
                return;
            }
            
        }

        bool Login(string userName, string passWord)
        {
            return Account.Instance.Login(userName, passWord);

        }
    }
}
