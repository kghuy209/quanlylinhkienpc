using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlylinhkienpc
{
    public partial class FThongke : Form
    {
        public FThongke()
        {
            InitializeComponent();
            List<CL_Loaihienthi> cbb = new List<CL_Loaihienthi>();
            cbb.Add(new CL_Loaihienthi("Tất cả", " select * from selectthongke"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo linh kiện bán được giảm dần", "select * from selectthongke  order by[số lượng bán] desc"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo linh kiện bán được tăng dần", "select * from selectthongke  order by[số lượng bán]"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo linh kiện còn lại giảm dần", "select * from selectthongke  order by [còn lại] desc"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo linh kiện còn lại tăng dần", "select * from selectthongke  order by [còn lại]"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo tiền lãi tăng dần", "select * from selectthongke  order by[lãi] "));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo tiền lãi giảm dần", "select * from selectthongke order by[lãi] desc"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo giá nhập tăng dần", "select * from selectthongke order by[giá nhập] "));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo giá nhập giảm dần", "select * from selectthongke order by[giá nhập] desc"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo thứ tự tiền thu được giảm dần", "select * from selectthongke order by [thu lại] desc"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo thứ tự tiền thu được tăng dần", "select * from selectthongke order by [thu lại] "));
            cbbhienthi.DataSource = cbb;
            cbbhienthi.DisplayMember = "Ten";
            cbbhienthi.ValueMember = "Query";
            hienthilinkien(" select * from selectthongke");
        }

        void hienthilinkien(string query)
        {
            dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void cbbhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbhienthi.Focus())
            {
                hienthilinkien(cbbhienthi.SelectedValue.ToString());
            }
        }

        private void FThongke_Load(object sender, EventArgs e)
        {
            
        }
    
           
        
            private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                hienthilinkien(" select * from selectthongke");
            }
            else
            {

                string query = "select * from linhkien where malinhkien like '" + textBox1.Text + "%' or ten like '" + textBox1.Text + "%'";
                dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);

            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from selectthongke where [Loại] like 'A'";
            List<int> arr = new List<int>();
            DataTable a = DataProvider.Instance.ExecuteQuery(query);
            for(int i=0;i<a.Rows.Count;i++)
            {
                arr.Add(int.Parse(a.Rows[i].ItemArray[0].ToString().Substring(1, 2)));
            }
            arr.Sort();
            string linhkienthieu = "";
            for (int i = 0; i < a.Rows.Count; i++)
            {
                
                if (!arr.Contains(i+1))
                {
                    linhkienthieu += "A" + (i + 1).ToString() + ", ";
                }
            }
            if(linhkienthieu!="")
            {
                linhkienthieu.TrimEnd(' ').TrimEnd(',');         
            }
            else
            {
                MessageBox.Show("có đủ 10 linh kiện loại a để ráp máy tính");
            }

            dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            CL_XuatExcel.Instance.XuatThongke((DataTable)dgvtaikhoan.DataSource, "Thongke", "Thống kê Nhập Xuất Linh Kiện");
        }

        private void btnxuatexcel12thang_Click(object sender, EventArgs e)
        {
            CL_XuatExcel.Instance.XuatThongke(DataProvider.Instance.ExecuteQuery("select * from selectthongke where [Bảo hành]>12"), "Thongkelinhkienbhhon12thang", "Thông tin danh sách các linh kiện có thời gian bảo hành lớn hơn 12 tháng");
        }
    }
}
