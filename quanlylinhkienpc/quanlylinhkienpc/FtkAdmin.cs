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
    public partial class FtkAdmin : Form
    {
        DataTable viewlinhkien = new DataTable();

        int indexaction = 2;
        DataTable dulieu = new DataTable();
        public FtkAdmin()
        {
            InitializeComponent();
           // dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery("select username,password,level, 'Delete' AS [Action]  from taikhoan");
            viewtodgv();
            indexaction = dgvtaikhoan.ColumnCount - 1;
        }

      
        DataTable currow()
        {
            return DataProvider.Instance.ExecuteQuery("select *, 'Delete' AS [Action]  from taikhoan");
        }
        void viewtodgv()
        {
            dulieu = DataProvider.Instance.ExecuteQuery("select username,password,level, 'Delete' AS [Action]  from taikhoan");
            dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery("select username,password,level, 'Delete' AS [Action]  from taikhoan"); ;
            for (int i = 0; i < dulieu.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dgvtaikhoan[indexaction, i] = linkCell;
            }

        }

        private void dgvtaikhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == indexaction)
                {
                    string Task = dgvtaikhoan.Rows[e.RowIndex].Cells[indexaction].Value.ToString();
                    if (Task == "Delete")
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string idtk = currow().Rows[e.RowIndex].ItemArray[0].ToString();
                            Account.Instance.deletetaikhoan(idtk);
                            viewtodgv();
                        }
                    }
                    else if (Task == "Insert")
                    {
                        int row = dgvtaikhoan.Rows.Count - 2;
                        action(e.RowIndex, "Insert");
                    }
                    else if (Task == "Update")
                    {
                        //   int r = e.RowIndex;
                        action(e.RowIndex, "Update");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void action(int indexrow, string hanhdong)
        {
            

            string username = dgvtaikhoan.Rows[indexrow].Cells["username"].Value.ToString();
            string pass = dgvtaikhoan.Rows[indexrow].Cells["password"].Value.ToString();
            string level = dgvtaikhoan.Rows[indexrow].Cells["level"].Value.ToString();
           
            if (username == "" || pass == "" || level == "" )
            {
                MessageBox.Show("Thông tin tài khoản cần phải đầy đủ");
                return;
            }
            if (int.Parse(level)>1 || int.Parse(level)<0)
            {
                MessageBox.Show("Hãy nhập đúng level admin là 1 và nhân viên là 0");
                return;
            }
            
            if (hanhdong == "Insert")
            {
                try
                {
                    //   Dataquery.Instance.nhaplinhkien(malinhkien, tenlinhkien, loai, quycach, xuatsu, namsx, baohanh, chatluong, gianhap, giaban, danhap, daban);
                    Account.Instance.inserttaikhoan(username, pass, level);

                    MessageBox.Show("Đã thêm thành công tài khoản" + username , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (hanhdong == "Update")
            {
                try
                {
                    DialogResult tb = MessageBox.Show("Bạn có muốn câp nhật không ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (tb == DialogResult.OK)
                    {
                        string id = currow().Rows[indexrow].ItemArray[0].ToString();

                        Account.Instance.updatetaikhoan(id, username, pass, level);
                        MessageBox.Show("Update Thông Tin Tài Khoản Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi !!! ");

                }
            }

            viewtodgv();
        }

        private void dgvtaikhoan_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                int lastRow = dgvtaikhoan.Rows.Count - 2;
                DataGridViewRow nRow = dgvtaikhoan.Rows[lastRow];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dgvtaikhoan[indexaction, lastRow] = linkCell;
                nRow.Cells["Action"].Value = "Insert";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


     

        private void dgvtaikhoan_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            kiemtranhap(e.RowIndex);
        }

        void kiemtranhap(int row)
        {
            int rowcount = dgvtaikhoan.Rows.Count;
            for (int i = 0; i < rowcount - 1; i++)
            {
                if (row == i)
                    break;
                if (dgvtaikhoan[indexaction, i].Value.ToString() == "Update")
                {
                    if (MessageBox.Show("Bạn có muốn Cập nhật linh kiện này không ? !", "Cập nhật chưa hoàn tất !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        action(i, "Update");
                    else
                        viewtodgv();
                }
                if (dgvtaikhoan[indexaction, i].Value.ToString() == "Insert")
                {
                    if (MessageBox.Show("Bạn có muốn thêm linh kiện này không ?", "Thêm chưa hoàn tất !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        action(i, "Insert");
                    else
                        viewtodgv();
                }

            }
        }
        private void FNhaplinhkien_FormClosing(object sender, FormClosingEventArgs e)
        {
            //   e.Cancel = true;
            kiemtranhap(-1);
            // this.Close();
        }

       

        private void dgvtaikhoan_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvtaikhoan.Rows[e.RowIndex].Cells[indexaction].Value.ToString() == "Insert")
                    return;
                int lastRow = e.RowIndex;
                DataGridViewRow nRow = dgvtaikhoan.Rows[lastRow];
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dgvtaikhoan[indexaction, lastRow] = linkCell;
                nRow.Cells["Action"].Value = "Update";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
