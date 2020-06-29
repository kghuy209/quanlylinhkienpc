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
    public partial class Flogin : Form
    {
        public Flogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if(userName==""||passWord=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else if (Login(userName, passWord))
            {
               // Account loginAccount = Account.Instance.GetAccountByUserName(userName);
                //fTableManager f = new fTableManager(loginAccount);
                fmuaban ht = new fmuaban(userName);
                this.Hide();
                ht.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {
            return Account.Instance.Login(userName, passWord);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn thoát không? ","Cảnh Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(thongbao==DialogResult.OK)
            {
                Application.Exit();
            }


        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Flogin_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
