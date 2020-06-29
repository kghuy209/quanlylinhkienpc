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
    public partial class FHuongdannhap : Form
    {
        public FHuongdannhap()
        {
            InitializeComponent();
        }

        private void FHuongdannhap_Load(object sender, EventArgs e)
        {
            string thongbao;

            thongbao = "* Thêm Linh Kiện:";
            thongbao += "\n-\t Cột ID Sẽ Tự Tăng Theo Thứ Tự.";
            thongbao += "\n-\t Nhập Thông tin Linh Kiện Sau đó Insert ở cột Action.";
            thongbao += "\n*  Sửa Thông Tin Linh Kiện.";
            thongbao += "\n-\t Chọn vị trí sửa và sửa trực tiếp trên Datagridview.";
            thongbao += "\n-\t Sau khi sửa xong chọn Update ở cột Action.";
            thongbao += "\n*  Xóa Thông Tin Linh Kiện.";
            thongbao += "\n-\t Chọn hàng cần xóa trên Datagridview.";
            thongbao += "\n-\t Chọn Delete  ở cột Action.";
            lbcachnhap.Text = thongbao;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
