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
    public partial class Fnhapvao : Form
    {
        DataTable sanphamnhap = new DataTable();
        DataTable muaban = new DataTable();
        string tsoluong = "";
        int row = 0;
        int lastcell = 0;
        string mlk = "";
        public Fnhapvao()
        {
            InitializeComponent();
        }
        public Fnhapvao(string malinhkien)
        {
            InitializeComponent();
           
            string query = "select *,'' as [Nhập số Lượng]  from selectnhap where [Mã linh kiện] in " + malinhkien;
            sanphamnhap = DataProvider.Instance.ExecuteQuery(query);
            
            btnban.Visible = false;
            mlk = malinhkien;
             
            dgvban.DataSource = DataProvider.Instance.ExecuteQuery(query);
            row = dgvban.Rows.Count;
            lastcell = dgvban.ColumnCount - 1;
            txbThoigian.Text = DateTime.Now.ToString();
        }

        private void btnban_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tiến hành thanh toán", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbTenkhachhang.Text == "" || txbDiachi.Text == "" || txbSdt.Text == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin khách hàng");
                return;
            }
            int soluongban = 0;
            int soluongcon = 0;
            Dataquery.Instance.insertkhachhang(Convert.ToDateTime(txbThoigian.Text), txbTenkhachhang.Text, txbDiachi.Text, txbSdt.Text, txbTongtien.Text, "Nhập vào");
            string idkhachhang = Dataquery.Instance.getidkhachhang(txbSdt.Text, txbTenkhachhang.Text,Convert.ToDateTime( txbThoigian.Text));
            for (int i = 0; i < row - 1; i++)
            {
                soluongban = Convert.ToInt32(dgvban[lastcell, i].Value.ToString());
                soluongcon = Convert.ToInt32(dgvban["Còn Lại", i].Value.ToString());
                double gia = double.Parse(dgvban["Giá nhập", i].Value.ToString());
                string malinhkien = dgvban["Mã Linh Kiện", i].Value.ToString();
                string idlinhkien = Dataquery.Instance.getidlinhkien(malinhkien);
                DataTable soluong = DataProvider.Instance.ExecuteQuery("select * from soluong where malinhkien='" + malinhkien + "'");
                string tongnhap = (int.Parse(soluong.Rows[0].ItemArray[2].ToString()) + soluongban).ToString();
                Dataquery.Instance.updatesoluong(idlinhkien, malinhkien, (((int)soluong.Rows[0].ItemArray[2])+soluongban).ToString(), ((int)soluong.Rows[0].ItemArray[3]).ToString());
                Dataquery.Instance.inserthoadon(idkhachhang, malinhkien, dgvban["Giá nhập", i].Value.ToString(), soluongban.ToString(), dgvban["tinhtongtien", i].Value.ToString());
                //  this.Close();
            }
                if (MessageBox.Show("Nhập hàng thành công\n Xuất hóa đơn ra excel", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataTable dtxuat = new DataTable();
                    dtxuat = (DataTable)dgvban.DataSource;
                    dtxuat.Columns.Remove("Còn Lại");
                    CL_XuatExcel.Instance.XuatHoaDonNhap(dtxuat, "hoadonban", "Hóa đơn nhập linh kiện",txbThoigian.Text,txbTenkhachhang.Text ,txbSdt.Text, txbTongtien.Text,txbDiachi.Text);
                }

            }
            this.Close();
            //}

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
                
            }

            //  DataGridViewColumn tongtien = new DataGridViewColumn();
            if (!dgvban.Columns.Contains("tinhtongtien"))
            {
                DataGridViewTextBoxColumn tongtien = new DataGridViewTextBoxColumn();
                tongtien.HeaderText = "Tổng tiền";
                tongtien.Name = "tinhtongtien";
                dgvban.Columns.Add(tongtien);
            }

            for (int i = 0; i < row - 1; i++)
            {

                DataGridViewCell cell = new DataGridViewTextBoxCell();
                soluongban = Convert.ToInt32(dgvban[lastcell, i].Value.ToString());
                int gia = Convert.ToInt32(dgvban[lastcell - 2, i].Value.ToString());
                int tong = gia * soluongban;
                tienthanhtoan += tong;
                dgvban.Rows[i].Cells["tinhtongtien"].Value = tong;
            }
            txbTongtien.Text = tienthanhtoan.ToString();
            btnban.Visible = true;
        }


        private void txbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btnnhap_Click(object sender, EventArgs e)
        {
            
            DataTable soluong = DataProvider.Instance.ExecuteQuery("select * from soluong where malinhkien='" + sanphamnhap.Rows[0].ItemArray[0] + "'");
            int soluongmua = Convert.ToInt32(soluong);
            int soluongcon = Convert.ToInt32(sanphamnhap.Rows[0].ItemArray[9].ToString());
            muaban = DataProvider.Instance.ExecuteQuery("select * from muaban where malinhkien='" + sanphamnhap.Rows[0].ItemArray[0] + "'");
            double gia = double.Parse(muaban.Rows[0].ItemArray[3].ToString());
            double thanhtoan = gia * soluongmua;
            if (soluongmua <= 0)
            {
                MessageBox.Show("Số lượng nhập không đúng");
            }

            else
            {
                if (MessageBox.Show("Số tiền để mua linh kiện là: " + thanhtoan + " VNĐ\nTiến Hành Mua?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string idlinhkien = Dataquery.Instance.getidlinhkien(sanphamnhap.Rows[0].ItemArray[0].ToString());
                    string tongnhap = (int.Parse(soluong.Rows[0].ItemArray[2].ToString()) + soluongmua).ToString();
                    Dataquery.Instance.updatesoluong(idlinhkien, soluong.Rows[0].ItemArray[1].ToString(), tongnhap, ((int)soluong.Rows[0].ItemArray[3]).ToString());
                    MessageBox.Show("Mua Thành Công");
                    this.Close();
                }

            }
        }

        //private void txbsoluong_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}


    }
}
