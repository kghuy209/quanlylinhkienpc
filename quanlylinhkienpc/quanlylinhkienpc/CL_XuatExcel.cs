using System;

using System.Data;
using System.Linq;

using Microsoft.Office.Interop.Excel;

namespace quanlylinhkienpc
{
    class CL_XuatExcel
    {
        private static CL_XuatExcel instance;

        public static CL_XuatExcel Instance
        {
            get { if (instance == null) instance = new CL_XuatExcel(); return CL_XuatExcel.instance; }
            private set { CL_XuatExcel.instance = value; }
        }
        public void XuatHoaDonBan(System.Data.DataTable dt, string sheetName, string title,string ngay, string ten, string sdt, string tongtien, string diachi)
        {

            //Tạo các đối tượng Excel

            Application oExcel = new Application();

            Workbooks oBooks;

            Sheets oSheets;

            Workbook oBook;

            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Range head = oSheet.get_Range("A5", "H5");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Range Ngaylam = oSheet.get_Range("A1", "D1");

            Ngaylam.MergeCells = true;

            Ngaylam.Value2 = "Ngày:" + DateTime.Now.ToShortDateString();

            Ngaylam.Font.Bold = true;

            Ngaylam.Font.Name = "Tahoma";

            Ngaylam.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            Range cl1 = oSheet.get_Range("A7", "A7");

            cl1.Value2 = "Mã linh kiện";

            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B7", "B7");

            cl2.Value2 = "Tên linh kiện";

            cl2.ColumnWidth = 10.0;

            Range cl3 = oSheet.get_Range("C7", "C7");

            cl3.Value2 = "Loại";

            cl3.ColumnWidth = 5.0;
            Range cl4 = oSheet.get_Range("D7", "D7");

            cl4.Value2 = "Quy cách";

            cl4.ColumnWidth = 40.0;

            Range cl5 = oSheet.get_Range("E7", "E7");

            cl5.Value2 = "Chất lượng";

            cl5.ColumnWidth = 15.0;

            Range cl6 = oSheet.get_Range("F7", "F7");
            cl6.Value2 = "Giá thành";
            cl6.ColumnWidth = 20.0;


            Range cl7 = oSheet.get_Range("G7", "G7");
            cl7.Value2 = "Số lượng";
            cl7.ColumnWidth = 20.0;

            Range rowHead = oSheet.get_Range("A7", "G7");
            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 8;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột STT

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range tenex = oSheet.get_Range("D" + (rowEnd + 2).ToString(), "D" + (rowEnd + 2).ToString());
            tenex.Value2 = "Khách hàng: " + ten;
            tenex.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            Range diachiex = oSheet.get_Range("D" + (rowEnd + 3).ToString(), "D" + (rowEnd + 3).ToString());
            diachiex.Value2 = "Diachi: " + diachi;
            diachiex.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range sdtex = oSheet.get_Range("D" + (rowEnd + 4).ToString(), "D" + (rowEnd + 4).ToString());
            sdtex.Value2 = "sdt: " + diachi;
            sdtex.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range Thoigian = oSheet.get_Range("D" + (rowEnd + 5).ToString(), "D" + (rowEnd + 5).ToString());
            Thoigian.Value2 = "Ngày thanh toán: " + ngay;
            Thoigian.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range tien = oSheet.get_Range("D" + (rowEnd + 6).ToString(), "D" + (rowEnd + 6).ToString());
            tien.Value2 = "Tổng tiền phải trả: " + tongtien;
            tien.HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }

        public void XuatHoaDonNhap(System.Data.DataTable dt, string sheetName, string title, string ngay, string ten, string sdt, string tongtien, string diachi)
        {

            //Tạo các đối tượng Excel

            Application oExcel = new Application();

            Workbooks oBooks;

            Sheets oSheets;

            Workbook oBook;

            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Range head = oSheet.get_Range("A5", "H5");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Range Ngaylam = oSheet.get_Range("A1", "D1");

            Ngaylam.MergeCells = true;

            Ngaylam.Value2 = "Ngày:" + DateTime.Now.ToShortDateString();

            Ngaylam.Font.Bold = true;

            Ngaylam.Font.Name = "Tahoma";

            Ngaylam.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            Range xahoi = oSheet.get_Range("A2", "H2");

            xahoi.MergeCells = true;

            xahoi.Value2 = "Cộng hòa xã hội chủ nghĩa việt nam";

            xahoi.Font.Bold = true;

            xahoi.Font.Name = "Tahoma";

            xahoi.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range DoclP = oSheet.get_Range("A3", "H3");

            DoclP.MergeCells = true;

            DoclP.Value2 = "Độc lập tự do hạnh phúc";

            DoclP.Font.Bold = true;

            DoclP.Font.Name = "Tahoma";

            DoclP.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range cl1 = oSheet.get_Range("A7", "A7");

            cl1.Value2 = "Mã linh kiện";

            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B7", "B7");

            cl2.Value2 = "Tên linh kiện";

            cl2.ColumnWidth = 14.0;

            Range cl3 = oSheet.get_Range("C7", "C7");

            cl3.Value2 = "Loại";

            cl3.ColumnWidth = 5.0;
            Range cl4 = oSheet.get_Range("D7", "D7");

            cl4.Value2 = "Quy cách";

            cl4.ColumnWidth = 40.0;

            Range cl5 = oSheet.get_Range("E7", "E7");

            cl5.Value2 = "Chất lượng";

            cl5.ColumnWidth = 15.0;

            Range cl6 = oSheet.get_Range("F7", "F7");
            cl6.Value2 = "Giá Nhập";
            cl6.ColumnWidth = 20.0;


            Range cl7 = oSheet.get_Range("G7", "G7");
            cl7.Value2 = "Số lượng";
            cl7.ColumnWidth = 20.0;

            Range rowHead = oSheet.get_Range("A7", "G7");
            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 8;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột STT

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;

             Range tenex = oSheet.get_Range("D"+(rowEnd+2).ToString(), "D"+(rowEnd+2).ToString());
            tenex.Value2 = "Khách hàng: "+ten;
            tenex.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            Range diachiex = oSheet.get_Range("D" + (rowEnd + 3).ToString(), "D" + (rowEnd + 3).ToString());
            diachiex.Value2 = "Diachi: " + diachi;
            diachiex.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range sdtex = oSheet.get_Range("D" + (rowEnd + 4).ToString(), "D" + (rowEnd + 4).ToString());
            sdtex.Value2 = "sdt: " + diachi;
            sdtex.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range Thoigian = oSheet.get_Range("D" + (rowEnd + 5).ToString(), "D" + (rowEnd + 5).ToString());
            Thoigian.Value2 = "Ngày thanh toán: " + ngay;
            Thoigian.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range tien = oSheet.get_Range("D" + (rowEnd + 6).ToString(), "D" + (rowEnd + 6).ToString());
            tien.Value2 = "Tổng tiền phải trả: " + tongtien;
            tien.HorizontalAlignment = XlHAlign.xlHAlignCenter;


        }
        public void XuatLichsu(System.Data.DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Application oExcel = new Application();

            Workbooks oBooks;

            Sheets oSheets;

            Workbook oBook;

            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Range head = oSheet.get_Range("A5", "H5");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 
            Range Ngaylam = oSheet.get_Range("A1", "D1");

            Ngaylam.MergeCells = true;

            Ngaylam.Value2 = "Ngày:" + DateTime.Now.ToShortDateString();

            Ngaylam.Font.Bold = true;

            Ngaylam.Font.Name = "Tahoma";

            Ngaylam.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            Range xahoi = oSheet.get_Range("E2", "H2");

            xahoi.MergeCells = true;

            xahoi.Value2 = "Cộng hòa xã hội chủ nghĩa việt nam";

            xahoi.Font.Bold = true;

            xahoi.Font.Name = "Tahoma";

            xahoi.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range DoclP = oSheet.get_Range("E3", "H3");

            DoclP.MergeCells = true;

            DoclP.Value2 = "Độc lập tự do hạnh phúc";

            DoclP.Font.Bold = true;

            DoclP.Font.Name = "Tahoma";

            DoclP.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            Range cl1 = oSheet.get_Range("A7", "A7");

            cl1.Value2 = "Mã Khách hàng";

            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B7", "B7");

            cl2.Value2 = "Ngày thanh toán";

            cl2.ColumnWidth = 40.0;
             
            Range cl3 = oSheet.get_Range("C7", "C7");

            cl3.Value2 = "Họ tên";

            cl3.ColumnWidth = 30.0;
            Range cl4 = oSheet.get_Range("D7", "D7");

            cl4.Value2 = "Địa chỉ";
            cl4.ColumnWidth = 40.0;

            Range cl5 = oSheet.get_Range("E7", "E7");

            cl5.Value2 = "Sdt";

            cl5.ColumnWidth = 15.0;

            Range cl6 = oSheet.get_Range("F7", "F7");
            cl6.Value2 = "Tổng tiền";
            cl6.ColumnWidth = 20.0;


            Range cl7 = oSheet.get_Range("G7", "G7");
            cl7.Value2 = "Hành động";
            cl7.ColumnWidth = 20.0;

            Range rowHead = oSheet.get_Range("A7", "G7");
            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 8;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột STT

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }
        public void XuatThongke(System.Data.DataTable dt, string sheetName, string title)
        {

            //Tạo các đối tượng Excel

            Application oExcel = new Application();

            Workbooks oBooks;

            Sheets oSheets;

            Workbook oBook;

            Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Visible = true;

            oExcel.DisplayAlerts = false;

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần đầu nếu muốn

            Range head = oSheet.get_Range("A5", "N5");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Tahoma";

            head.Font.Size = "18";

            head.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            Range Ngaylam = oSheet.get_Range("A1", "D1");

            Ngaylam.MergeCells = true;

            Ngaylam.Value2 ="Ngày:"+ DateTime.Now.ToShortDateString();

            Ngaylam.Font.Bold = true;

            Ngaylam.Font.Name = "Tahoma";

            Ngaylam.HorizontalAlignment = XlHAlign.xlHAlignCenter;


            Range xahoi = oSheet.get_Range("E2", "H2");

            xahoi.MergeCells = true;

            xahoi.Value2 = "Cộng hòa xã hội chủ nghĩa việt nam";

            xahoi.Font.Bold = true;

            xahoi.Font.Name = "Tahoma";

            xahoi.HorizontalAlignment = XlHAlign.xlHAlignCenter;

             Range DoclP = oSheet.get_Range("E3", "H3");

            DoclP.MergeCells = true;

            DoclP.Value2 = "Độc lập tự do hạnh phúc";

            DoclP.Font.Bold = true;

            DoclP.Font.Name = "Tahoma";

            DoclP.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Range cl1 = oSheet.get_Range("A7", "A7");

            cl1.Value2 = "Mã linh kiện";

            cl1.ColumnWidth = 13.5;

            Range cl2 = oSheet.get_Range("B7", "B7");

            cl2.Value2 = "Tên linh kiện";

            cl2.ColumnWidth = 10.0;

            Range cl3 = oSheet.get_Range("C7", "C7");

            cl3.Value2 = "Loại";

            cl3.ColumnWidth = 5.0;
            Range cl4 = oSheet.get_Range("D7", "D7");

            cl4.Value2 = "Chất lượng";
            cl4.ColumnWidth = 10.0;

            Range cl5 = oSheet.get_Range("E7", "E7");

            cl5.Value2 = "Bảo hành";

            cl5.ColumnWidth = 10.0;

            Range cl6 = oSheet.get_Range("F7", "F7");
            cl6.Value2 = "Số lượng đã nhập";
            cl6.ColumnWidth = 15.0;


            Range cl7 = oSheet.get_Range("G7", "G7");
            cl7.Value2 = "Số lượng đã bán";
            cl7.ColumnWidth = 15.0;
          //  Range cl8 = oSheet.get_Range("G8", "G8");
          //  cl8.Value2 = "Số lượng đã bán";
          //  cl8.ColumnWidth = 15.0;
            Range cl9 = oSheet.get_Range("H7", "H7");
            cl9.Value2 = "Còn lại";
            cl9.ColumnWidth = 15.0;
            Range cl10 = oSheet.get_Range("I7", "I7");
            cl10.Value2 = "Giá nhập";
            cl10.ColumnWidth = 15.0;
            Range cl11 = oSheet.get_Range("J7", "J7");
            cl11.Value2 = "Giá bán";
            cl11.ColumnWidth = 15.0;
            Range cl12 = oSheet.get_Range("K7", "K7");
            cl12.Value2 = "vốn";
            cl12.ColumnWidth = 15.0;
            Range cl13 = oSheet.get_Range("L7", "L7");
            cl13.Value2 = "Thu lại";
            cl13.ColumnWidth = 15.0;
            Range cl14 = oSheet.get_Range("M7", "M7");
            cl14.Value2 = "lãi";
            cl14.ColumnWidth = 15.0;
            Range cl15 = oSheet.get_Range("M7", "M7");
            cl15.Value2 = "Vốn";
            cl15.ColumnWidth = 15.0;
            Range cl16 = oSheet.get_Range("N7", "N7");
            cl16.Value2 = "Hồi vốn";
            cl16.ColumnWidth = 15.0;
            Range rowHead = oSheet.get_Range("A7", "N7");
            rowHead.Font.Bold = true;
           // rowHead.Height = 10.0;
            // Kẻ viền

            rowHead.Borders.LineStyle = Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 15;

            rowHead.HorizontalAlignment = XlHAlign.xlHAlignCenter;

            // Tạo mẳng đối tượng để lưu dữ toàn bồ dữ liệu trong DataTable,

            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.

            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int r = 0; r < dt.Rows.Count; r++)

            {

                DataRow dr = dt.Rows[r];

                for (int c = 0; c < dt.Columns.Count; c++)

                {
                    arr[r, c] = dr[c];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 8;

            int columnStart = 1;

            int rowEnd = rowStart + dt.Rows.Count - 1;

            int columnEnd = dt.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Range c1 = (Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Range c2 = (Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Constants.xlSolid;

            // Căn giữa cột STT

            Range c3 = (Range)oSheet.Cells[rowEnd, columnStart];

            Range c4 = oSheet.get_Range(c1, c3);

            oSheet.get_Range(c3, c4).HorizontalAlignment = XlHAlign.xlHAlignCenter;
        }


    }
}
