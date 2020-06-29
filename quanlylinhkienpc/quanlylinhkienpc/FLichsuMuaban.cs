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
    public partial class FLichsuMuaban : Form
    {
        public FLichsuMuaban()
        {
            InitializeComponent();
        }

        private void FLichsuMuaban_Load(object sender, EventArgs e)
        {
            dgvNguoimua.DataSource = DataProvider.Instance.ExecuteQuery("select makhachhang as [mã khách hàng], ngaythanhtoan as[ngày thanh toán], hoten as[họ tên] ,diachi as[địa chỉ],sdt,tongtien as[tổng tiền],hanhdong as[hành động] from khachhang");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvNguoimua.DataSource = DataProvider.Instance.ExecuteQuery("select *  from khachhang where hoten like '%"+txbten.Text+"%' and sdt like '%"+txbsdt.Text+"'");
        }



        private void dgvNguoimua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dgvNguoimua.RowCount)
            {               
                string makhachhang = dgvNguoimua[0, e.RowIndex].Value.ToString();
                dgvDamua.DataSource = DataProvider.Instance.ExecuteQuery("select h.mahoadon as[mã hóa đơn],h.makhachhang as [mã khách hàng],h.soluong as[số lượng],h.gia as [giá],h.thanhtien as [thành tiền], lk.ten as [tên],lk.loai,lk.quycach as [quy cách],lk.noisanxuat as[nơi sản xuất],lk.thoigianbh as[bảo hành]  from hoadon as h,linhkien as lk where h.malinhkien=lk.malinhkien and makhachhang=" + makhachhang);
            }
        }

        private void dttngay_ValueChanged(object sender, EventArgs e)
        {
            dgvNguoimua.DataSource = DataProvider.Instance.ExecuteQuery("select * from khachhang where ngaythanhtoan >='"+ dttngay.Value.ToShortDateString() + "' and ngaythanhtoan<'"+dttngay.Value.AddDays(1).ToShortDateString()+ "'");
        }

        private void btnXuatBan_Click(object sender, EventArgs e)
        {
            DataTable dtxuat =new  DataTable();
            dtxuat = DataProvider.Instance.ExecuteQuery("select makhachhang as [mã khách hàng], convert(varchar, ngaythanhtoan)  as[ngày thanh toán], hoten as[họ tên] ,diachi as[địa chỉ],sdt,tongtien as[tổng tiền],hanhdong as [hành động] from khachhang where  hanhdong='Bán ra' ");

            CL_XuatExcel.Instance.XuatLichsu(dtxuat, "lichsuxuat", "Lịch sử đã bán ra");
        }

        private void btnXuatNhap_Click(object sender, EventArgs e)
        {
            DataTable dtxuat = new DataTable();
            dtxuat = DataProvider.Instance.ExecuteQuery("select makhachhang as [mã khách hàng], convert(varchar, ngaythanhtoan)  as[ngày thanh toán], hoten as[họ tên] ,diachi as[địa chỉ],sdt,tongtien as[tổng tiền],hanhdong as [hành động] from khachhang where  hanhdong='Nhập vào' ");

            CL_XuatExcel.Instance.XuatLichsu(dtxuat, "lichsuxuat", "Lịch sử đã nhập vào");
        }
    }
}
