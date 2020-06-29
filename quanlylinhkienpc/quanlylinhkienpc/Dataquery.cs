using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlylinhkienpc
{
    public class Dataquery
    {
        private static Dataquery instance;

        public static Dataquery Instance
        {
            get { if (instance == null) instance = new Dataquery(); return Dataquery.instance; }
            private set { Dataquery.instance = value; }
        }
       public string getidkhachhang(string sodienthoai,string tenkhachhang,DateTime thoigian)
        {
            string query = "select * from khachhang where sdt='"+sodienthoai+ "' and hoten=N'" + tenkhachhang+ "' and ngaythanhtoan='"+ thoigian+"'";
            return DataProvider.Instance.ExecuteQuery(query).Rows[0].ItemArray[0].ToString();
           // DateTime.
        }
        string getidmuaban(string idlinhkien)
        {
            string query = "dbo.getidmuaban @idlinhkien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idlinhkien }).Rows[0].ItemArray[0].ToString();
        }
        string getidthunhap(string idlinhkien)
        {
            string query = "dbo.getidthunhap @idlinhkien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idlinhkien }).Rows[0].ItemArray[0].ToString();
        }
        public string getidlinhkien(string malinhkien)
        {
            string query = "dbo.getidlinhkien @malinhkien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { malinhkien }).Rows[0].ItemArray[0].ToString();
        }
        string getidsoluong(string idlinhkien)
        {
            string query = "dbo.getidsoluong @idlinhkien";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { idlinhkien }).Rows[0].ItemArray[0].ToString();
        }
        public void insertlinhkien(string malinhkien,string ten ,string loai, string quycach,string noisx,string namsx,string tgbaohanh)
        {
            string query = "dbo.insertlinhkien @malinhkien , @ten , @loai , @quycach ,  @noisanxuat , @namsanxuat , @thoigianbh";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien, ten, loai, quycach, noisx, namsx, tgbaohanh });

        }
        public void updatelinhkien(string id,string malinhkien, string ten,string loai, string quycach, string noisx, string namsx, string tgbaohanh)
        {
            string query = "dbo.updatelinhkien @id , @malinhkien , @ten , @loai , @quycach ,  @noisanxuat , @namsanxuat , @thoigianbh";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id,malinhkien, ten, loai, quycach, noisx, namsx, tgbaohanh });
        }
        public void insertmuaban(string malinhkien , string chatluong , string gianhap ,  string giaxuat)
        {
            string query = "dbo.insertmuaban @malinhkien , @chatluong , @gianhap , @giaxuat ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien, chatluong, gianhap, giaxuat });
        }
        public void updatemuaban(string idlinhkien,string malinhkien, string chatluong, string gianhap, string giaxuat)
        {
            string idmuaban = getidmuaban(idlinhkien);
            string query = "dbo.updatemuaban @idmuaban , @malinhkien , @chatluong , @gianhap , @giaxuat ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idmuaban, malinhkien, chatluong, gianhap, giaxuat });
        }
        public void insertsoluong(string malinhkien, string slnhap,string slxuat )
        {
            string query = "dbo.insertsoluong @malinhkien , @slnhap , @slxuat";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien, slnhap, slxuat });
        }
        public void updatesoluong(string idlinhkien,string malinhkien, string slnhap, string slxuat)
        {
            string idsoluong = getidsoluong(idlinhkien);
            string query = "dbo.updatesoluong @idsoluong , @malinhkien , @slnhap , @slxuat";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idsoluong, malinhkien,slnhap, slxuat });
        }

        public void insertthunhap(string malinhkien)
        {
            string query = "dbo.insertthunhap  @malinhkien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien});
        }
        public void updatethunhap(string idlinhkien,string malinhkien)
        {
            string idthunhap = getidthunhap(idlinhkien);
            string query = "dbo.updatethunhap  @idthunhap , @malinhkien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idthunhap , malinhkien });
        }
        public void nhaplinhkien(string malinhkien,string ten,string loai,string quycach,string noisanxuat,string namsanxuat,string thoigianbh,string chatluong,string gianhap,string giaxuat,string slnhap,string slxuat )

        {
            string query = "dbo.nhaplinhkien @malinhkien @ten , @loai , @quycach , @noisanxuat , @namsanxuat , @thoigianbh , @chatluong , @gianhap , @giaxuat , @slnhap";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien, ten, loai, quycach, noisanxuat, namsanxuat, thoigianbh, chatluong, gianhap, giaxuat, slnhap });
            insertthunhap(malinhkien);
        }
        public void updatelinhkien(string id,string malinhkien, string ten, string loai, string quycach, string noisanxuat, string namsanxuat, string thoigianbh, string chatluong, string gianhap, string giaxuat, string slnhap,string slxuat)
           
        {
            updatelinhkien(id, malinhkien, ten,loai, quycach, noisanxuat, namsanxuat, thoigianbh);
            updatesoluong(id, malinhkien, slnhap, slxuat);
            updatethunhap(id,malinhkien);
           
        }
        public void deletelinhkien(string malinhkien)
        {
            string query = "dbo.deletelinhkien @malinhkien";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { malinhkien });
        }

        public void insertkhachhang( DateTime ngaythanhtoan,string ten, string diachi, string sdt,string tongtien,string hanhdong)
        {
            string query = "dbo.inskhachhang @ngay , @ten , @diachi , @sdt , @tongtien , @hanhdong ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { ngaythanhtoan, ten, diachi, sdt, tongtien,hanhdong });
        }
        public void inserthoadon(string makh, string malinhkien,string gia, string soluong, string thanhtien)
        {
            string query = "dbo.inshoadon @makhachhang , @malinhkien , @gia , @soluong , @thanhtien ";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { makh,  malinhkien,  gia,  soluong,  thanhtien });
        }

    }
}
