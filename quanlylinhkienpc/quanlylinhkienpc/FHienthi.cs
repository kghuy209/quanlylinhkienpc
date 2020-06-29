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
   
    public partial class FHienthi : Form
    {
        public FHienthi()
        {
            InitializeComponent();

            List<CL_Loaihienthi> cbb = new List<CL_Loaihienthi>();
            cbb.Add(new CL_Loaihienthi("Tất cả", "select * from selectmuaban "));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo thứ tự tăng dần", "select *  from selectmuaban order by[loại],[tên linh kiện]"));
            cbb.Add(new CL_Loaihienthi("Các linh kiện bảo hành lớn hơn 12 tháng", "select *  from selectmuaban where[bảo hành] > 12"));
            cbb.Add(new CL_Loaihienthi("Sắp xếp theo năm sản xuất", "select *  from selectmuaban order by[năm sản xuất] DESC"));
            cbb.Add(new CL_Loaihienthi("Linh kiện có giá cao nhất", "select top 1 *  from selectmuaban order by[giá bán] DESC"));
            cbbhienthi.DataSource = cbb;
            cbbhienthi.DisplayMember = "Ten";
            cbbhienthi.ValueMember = "Query";
            hienthilinkien(" select * from selectmuaban");
        }

        void hienthilinkien(string query)
        {
            dgvtaikhoan.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void cbbhienthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbhienthi.Focus())
            {
                hienthilinkien(cbbhienthi.SelectedValue.ToString());
            }
        }

        private void FHienthi_Load(object sender, EventArgs e)
        {

        }
    }
}
