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
    public partial class fmuaban : Form
    {
        int indexaction = 0;
        public fmuaban()
        {
            InitializeComponent();
            loaddatamuaban();
     
        }
        string uname = "";
        int sorow = 0;
        public fmuaban( string nameuser)
        {
            InitializeComponent();
            tablemuaban();
            uname = nameuser;
            tsmitaikhoan.Text += " " + nameuser;
            if (DataProvider.Instance.ExecuteQuery("select level from taikhoan where username='" + nameuser + "'").Rows[0].ItemArray[0].ToString()=="1")
            {
                tsmitemNhaplinhkien.Visible = true;
                tsmithongke.Visible = true;
                tsmiHienthitimkiem.Visible = true;
                tsmiLichsumuaban.Visible = true;
                
            }
        }
        void tablemuaban()
        {

            string query = "select * from selectmuaban";
            dgvMuaban.DataSource = DataProvider.Instance.ExecuteQuery(query);
            indexaction = dgvMuaban.ColumnCount - 1;
            sorow = dgvMuaban.Rows.Count;
            //      for (int i = 0; i < sorow; i++)
            //   {
            //     DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
            //     DataGridViewLinkCell linkCell2 = new DataGridViewLinkCell();
            //     dgvMuaban[indexaction, i] = linkCell;
            //     dgvMuaban[indexaction - 1, i] = linkCell2;
            // }
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgvMuaban.Columns.Add(chk);
            chk.HeaderText = "Check Data";
            chk.Name = "chk";
        }
        void loaddatamuaban()
        {
            
            string query = "select * from selectmuaban";
            dgvMuaban.DataSource = DataProvider.Instance.ExecuteQuery(query);
            indexaction = dgvMuaban.ColumnCount - 1;
            sorow=dgvMuaban.Rows.Count;
      //      for (int i = 0; i < sorow; i++)
         //   {
           //     DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
           //     DataGridViewLinkCell linkCell2 = new DataGridViewLinkCell();
           //     dgvMuaban[indexaction, i] = linkCell;
           //     dgvMuaban[indexaction - 1, i] = linkCell2;
           // }
        }

        private void tsmitemNhaplinhkien_Click_1(object sender, EventArgs e)
        {
            FNhaplinhkien nhaplk = new FNhaplinhkien();
            nhaplk.ShowDialog();
            loaddatamuaban();
        }

        private void tsmiHienthitimkiem_Click(object sender, EventArgs e)
        {
            FHienthi hienthi = new FHienthi();
            hienthi.ShowDialog();
        }

        private void tsmithongke_Click(object sender, EventArgs e)
        {
            FThongke thongke = new FThongke();
            thongke.ShowDialog();
        }
    

        private void tsmitaikhoan_Click(object sender, EventArgs e)
        {
         
        }
        string getmalinhkien()
        {
            string danhsachlinhkien = "(";

            for (int i = 0; i < sorow; i++)
            {
                if (dgvMuaban.Rows[i].Cells[0].Value != null)
                {
                    danhsachlinhkien += "'" + dgvMuaban.Rows[i].Cells[1].Value.ToString() + "',";
                }
            }
            danhsachlinhkien = danhsachlinhkien.TrimEnd(',');
            danhsachlinhkien += ")";
            if(danhsachlinhkien=="()")
            {
                MessageBox.Show("không có linh kiện nào được chọn");
                return "('')";
            }
            return danhsachlinhkien;
        }
        private void btnBanra_Click(object sender, EventArgs e)
        {           

        Fbanra ban = new Fbanra(getmalinhkien());
            ban.ShowDialog();
            loaddatamuaban();
        }

        private void btnNhapvao_Click(object sender, EventArgs e)
        {
            Fnhapvao nhap = new Fnhapvao(getmalinhkien());
            nhap.ShowDialog();
            loaddatamuaban();
        }


        private void dgvMuaban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0 && e.RowIndex > -1)
                {
                    
                    if (dgvMuaban.Rows[e.RowIndex].Cells[0].Value == null)
                        dgvMuaban.Rows[e.RowIndex].Cells[0].Value = true;
                    else
                    {
                        dgvMuaban.Rows[e.RowIndex].Cells[0].Value = null;
                    }
                }
                if (e.ColumnIndex == 0 && e.RowIndex==-1)
                {
                    if (dgvMuaban.Rows[1].Cells[0].Value == null)
                    {
                        
                        for (int i = 0; i < sorow; i++)
                        {
                            dgvMuaban.Rows[i].Cells[0].Value = true;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < sorow; i++)
                        {
                            dgvMuaban.Rows[i].Cells[0].Value = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExecuteQuery("select level from taikhoan where username='" + uname + "'").Rows[0].ItemArray[0].ToString() == "1")
            {
                FtkAdmin ad = new FtkAdmin();
                ad.ShowDialog();
            }
            else
            {
                FTkNhanvien nv = new FTkNhanvien(uname);
                nv.ShowDialog();
            }
        }

        private void liênHệToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string lh;
            lh = "Phần Mềm: Quản Lý Linh Kiện Máy Tính PC";
            lh += "\n Version: 29.06.2020 \n";
            lh += "\n";
            lh += "Môn lập trình cơ sở dữ liệu \n";
            lh += "CopyRight @ năm 2020\n\n";
            lh += "Tác giả: \n";
            lh += "\t- Khổng Gia Huy (MSSV: 117000529) \n";
            lh += "\t- Phạm Khang Bình (MSSV: 117000040) \n";
            lh += "\t- Phạm Duy (MSSV: 117000915) \n";
            
            MessageBox.Show((lh), "Liên Hệ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FMuaban_Load(object sender, EventArgs e)
        {

        }

        private void tsmiLichsumuaban_Click(object sender, EventArgs e)
        {
            FLichsuMuaban lichsu = new FLichsuMuaban();
            lichsu.ShowDialog();
        }

        
    }
}
