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
    public partial class Fbanra : Form
    {
        //DataTable sanphamnhap = new DataTable();
        public Fbanra()
        {
            InitializeComponent();
            btnban.Visible = false;
            // Fbanra(malinhkien);
        }
        int row = 0;
        int lastcell = 0;
        string mlk = "";
        public Fbanra (string malinhkien)
        {
            InitializeComponent();
            btnban.Visible = false;
            mlk = malinhkien;
            string query = "select *,'' as [Nhập số Lượng]  from selectban where [Mã linh kiện] in " + malinhkien;
            dgvban.DataSource = DataProvider.Instance.ExecuteQuery(query);
           row = dgvban.Rows.Count;
            lastcell = dgvban.ColumnCount-1;
            txbThoigian.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Tiến hành thanh toán","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {

                if(txbTenkhachhang.Text==""||txbDiachi.Text==""||txbSdt.Text=="")
                    {
                        MessageBox.Show("Cần điền đầy đủ thông tin khách hàng");
                        return;
                    }
                int soluongban = 0;
                int soluongcon = 0;
                Dataquery.Instance.insertkhachhang(Convert.ToDateTime( txbThoigian.Text.Substring(0,10).Trim()), txbTenkhachhang.Text, txbDiachi.Text, txbSdt.Text, txbTongtien.Text, "Bán ra");
                string idkhachhang = Dataquery.Instance.getidkhachhang(txbSdt.Text, txbTenkhachhang.Text, Convert.ToDateTime(txbThoigian.Text.Substring(0, 10).Trim()));
                    for (int i = 0; i < row-1; i++)
                {
                    soluongban = Convert.ToInt32(dgvban[lastcell, i].Value.ToString());
                    soluongcon = Convert.ToInt32(dgvban["Còn Lại", i].Value.ToString());
                    double gia = double.Parse(dgvban["Giá Bán", i].Value.ToString());
                    string malinhkien = dgvban["Mã Linh Kiện", i].Value.ToString();
                    string idlinhkien = Dataquery.Instance.getidlinhkien(malinhkien);
                       DataTable soluong= DataProvider.Instance.ExecuteQuery("select * from soluong where malinhkien='" + malinhkien + "'");
                       Dataquery.Instance.updatesoluong(idlinhkien, soluong.Rows[0].ItemArray[1].ToString(), soluong.Rows[0].ItemArray[2].ToString(), ((int)soluong.Rows[0].ItemArray[3] + soluongban).ToString());
                       Dataquery.Instance.updatethunhap(idlinhkien, soluong.Rows[0].ItemArray[1].ToString());
                    Dataquery.Instance.inserthoadon(idkhachhang, malinhkien, dgvban["Giá Bán", i].Value.ToString(), soluongban.ToString(), dgvban["tinhtongtien", i].Value.ToString());
                      //  this.Close();
                   }
                if(MessageBox.Show("Bán thành công\n Xuất hóa đơn ra excel","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        DataTable dtxuat = new DataTable();
                        dtxuat = (DataTable)dgvban.DataSource;
                        dtxuat.Columns.Remove("Còn Lại");
                        CL_XuatExcel.Instance.XuatHoaDonBan(dtxuat, "hoadonmua", "Hóa đơn mua linh kiện", txbThoigian.Text.Substring(0, 10).Trim(), txbTenkhachhang.Text, txbSdt.Text, txbTongtien.Text, txbDiachi.Text);
                    }

            }
            this.Close();

        }
        private void btntinhtien_Click(object sender, EventArgs e)
        {
            int soluongban = 0;
            int soluongcon = 0;
            int tienthanhtoan = 0;
            for (int i = 0; i < row - 1; i++)
            {

                if (dgvban[7, i].Value.ToString() == "")
                {
                    MessageBox.Show("chưa nhập đủ số lượng");
                    return;
                }

            }
            for (int i = 0; i < row - 1; i++)
            {
                soluongban = Convert.ToInt32(dgvban[lastcell, i].Value.ToString());
                soluongcon = Convert.ToInt32(dgvban["Còn Lại", i].Value.ToString());
                if (soluongban <= 0)
                {
                    MessageBox.Show("Số lượng nhập không đúng");
                    return;
                }
                if (soluongban > soluongcon)
                {
                    MessageBox.Show("Link kiện: " + dgvban[i, 0].Value.ToString() + " không đủ số lượng để bán");
                    return;
                }
            }

            //  DataGridViewColumn tongtien = new DataGridViewColumn();
            if (!dgvban.Columns.Contains("tinhtongtien"))
            {
                DataGridViewTextBoxColumn tongtien = new DataGridViewTextBoxColumn();
                tongtien.HeaderText = "Tổng tiền";
                tongtien.Name = "tinhtongtien";
                dgvban.Columns.Add(tongtien);
            }
           
            for (int i = 0; i < row-1; i++)
            {

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                 soluongban  = Convert.ToInt32(dgvban[lastcell, i].Value.ToString());
                 int gia  = Convert.ToInt32(dgvban[lastcell - 2, i].Value.ToString());
                 int tong = gia * soluongban;
                    tienthanhtoan+=tong;
                dgvban.Rows[i].Cells["tinhtongtien"].Value = tong;
            }
            txbTongtien.Text = tienthanhtoan.ToString();
            btnban.Visible = true;
        }


        
    }
}
