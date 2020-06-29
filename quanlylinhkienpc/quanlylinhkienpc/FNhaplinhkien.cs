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
    public partial class FNhaplinhkien : Form
    {
        DataTable viewlinhkien = new DataTable();

        int indexaction=11;
        DataTable dulieu = new DataTable();
        public FNhaplinhkien()
        {
            InitializeComponent();
           
            hienthilinkien();
            viewtodgv();
            indexaction = dgvtaikhoan.ColumnCount-1;
        }

        void hienthilinkien()
        {
           // viewlinhkien = DataProvider.Instance.ExecuteQuery("select *,'Delete' AS [Delete] from selectnhaplinhkien");
        }
        DataTable currow()
        {
            return DataProvider.Instance.ExecuteQuery("select *,'Delete' AS [Action] from selectnhaplinhkien");
        }
        void viewtodgv()
        {
            dulieu = DataProvider.Instance.ExecuteQuery("select *,'Delete' AS [Action] from selectnhaplinhkien");
            dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery("select *,'Delete' AS [Action] from selectnhaplinhkien"); ;
            for (int i=0;i<dulieu.Rows.Count;i++)
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
                        if (MessageBox.Show("Xóa linh kiện đồng nghĩa với việc bạn sẽ xóa toàn bộ thông tin mua bán số lượng của linh kiện \nBạn có chắc chắn muốn xóa nó?", "Đang xóa...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                            string malinhkien = dgvtaikhoan.Rows[e.RowIndex].Cells["Mã linh kiện"].Value.ToString();
                            Dataquery.Instance.deletelinhkien(malinhkien);
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

         void action (int indexrow, string hanhdong)
        {
           
            string malinhkien = dgvtaikhoan.Rows[indexrow].Cells["Mã Linh Kiện"].Value.ToString();
            string tenlinhkien = dgvtaikhoan.Rows[indexrow].Cells["Tên Linh Kiện"].Value.ToString();
            string loai = dgvtaikhoan.Rows[indexrow].Cells["Loại"].Value.ToString();
            string quycach = dgvtaikhoan.Rows[indexrow].Cells["Quy Cách"].Value.ToString();
            string xuatsu = dgvtaikhoan.Rows[indexrow].Cells["Xuất Sứ"].Value.ToString();
            string namsanxuat = dgvtaikhoan.Rows[indexrow].Cells["Năm Sản Xuất"].Value.ToString();
            string namsx = "";
            if (namsanxuat!="")
            namsx =Convert.ToDateTime(namsanxuat).ToString("yyyy/MM/dd");
            string baohanh = dgvtaikhoan.Rows[indexrow].Cells["Bảo Hành"].Value.ToString();
            string chatluong = dgvtaikhoan.Rows[indexrow].Cells["Chất Lượng"].Value.ToString();
            string gianhap = dgvtaikhoan.Rows[indexrow].Cells["Giá Nhập"].Value.ToString();
            string giaban = dgvtaikhoan.Rows[indexrow].Cells["Giá Bán"].Value.ToString();
            string danhap = dgvtaikhoan.Rows[indexrow].Cells["Đã Nhập"].Value.ToString();
            string daban = dgvtaikhoan.Rows[indexrow].Cells["Đã Bán"].Value.ToString();
            if(malinhkien==""|| tenlinhkien==""|| loai==""||quycach==""||xuatsu==""||namsanxuat==""||baohanh==""||
                chatluong==""||giaban==""||giaban==""||daban==""||danhap=="")
            {
                MessageBox.Show("Thông tin linh kiện cần phải đầy đủ");
                return;
            }
            if (float.Parse(giaban)<float.Parse(gianhap))
            {
                MessageBox.Show("Giá nhập không thể lớn hơn giá bán vui lòng nhập lại !!");
                return;
            }
            if(int.Parse(danhap)<int.Parse(daban))
            {
                MessageBox.Show("Số linh kiện đã bán không thể lớn hơn số linh kiện đã nhập vui lòng nhập lại !!");
                return;
            }
            if(hanhdong=="Insert")
            {
                try
                {
                    for (int i = 0; i < currow().Rows.Count; i++)
                    {
                        if (i == indexrow)
                            continue;
                        if (currow().Rows[i].ItemArray[1].ToString() == malinhkien)
                        {
                            MessageBox.Show("Mã linh kiện không được trùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            viewtodgv();
                            return;
                        };

                    }
                    //   Dataquery.Instance.nhaplinhkien(malinhkien, tenlinhkien, loai, quycach, xuatsu, namsx, baohanh, chatluong, gianhap, giaban, danhap, daban);
                    Dataquery.Instance.insertlinhkien( malinhkien, tenlinhkien, loai, quycach, xuatsu, namsx, baohanh);
                    Dataquery.Instance.insertmuaban( malinhkien, chatluong, gianhap, giaban);
                    Dataquery.Instance.insertsoluong( malinhkien, danhap, daban);
                    Dataquery.Instance.insertthunhap( malinhkien);
                    
                    MessageBox.Show("Đã thêm thành công linh kiện " + malinhkien + ": " + tenlinhkien, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Lỗi");
                }
            }
            else if (hanhdong=="Update")
            {
                try
                {
                    string id = currow().Rows[indexrow].ItemArray[0].ToString();
                    string mlk = currow().Rows[indexrow].ItemArray[1].ToString();
                   for(int i=0; i<currow().Rows.Count;i++)
                    {
                        if (i == indexrow)
                            continue;
                        if (currow().Rows[i].ItemArray[1].ToString() == malinhkien)
                        {
                            MessageBox.Show("Mã linh kiện không được trùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            viewtodgv();
                            return;
                        };
                        
                    }
                   
                    if (malinhkien != mlk)
                    {
                        Dataquery.Instance.insertlinhkien(malinhkien, tenlinhkien, loai, quycach, xuatsu, namsx, baohanh);
                        Dataquery.Instance.updatemuaban(id, malinhkien, chatluong, gianhap, giaban);
                        Dataquery.Instance.updatesoluong(id, malinhkien, danhap, daban);
                        Dataquery.Instance.updatethunhap(id, malinhkien);
                        Dataquery.Instance.deletelinhkien(mlk);
                        
                    }
                    else
                    {
                        Dataquery.Instance.updatemuaban(id, malinhkien, chatluong, gianhap, giaban);
                        Dataquery.Instance.updatesoluong(id, malinhkien, danhap, daban);
                        Dataquery.Instance.updatethunhap(id, malinhkien);
                        Dataquery.Instance.updatelinhkien(id, malinhkien, tenlinhkien, loai, quycach, xuatsu, namsx, baohanh);
                    }
                    
                    MessageBox.Show("Update Thông Tin Linh Kiện Thành Công");
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


        private void btnCapnhat_Click(object sender, EventArgs e)
        {
            viewtodgv();
        }

        private void btnHuongdan_Click(object sender, EventArgs e)
        {
            FHuongdannhap huongdan =new  FHuongdannhap();
            huongdan.ShowDialog();
        }

        private void FNhaplinhkien_Load(object sender, EventArgs e)
        {

        }
    }
}
