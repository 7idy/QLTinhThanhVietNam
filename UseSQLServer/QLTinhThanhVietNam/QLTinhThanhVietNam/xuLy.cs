using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTinhThanhVietNam
{
    public class xuLy
    {
        // Kết nối CSDL ----------------------------------------------------------------------
        SqlConnection con = new SqlConnection("Data Source = LAPTOP-PEPM7OTH;" +
            " Initial Catalog = QLTinhThanhVietNam; User ID = sa; Password = giabao04");

        // Mở kết nối ------------------------------------------------------------------------
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        // Đóng kết nối ----------------------------------------------------------------------
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        // Dataset
        DataSet qlTinhThanh = new DataSet();

        // SQL Adapter
        SqlDataAdapter da;

        // Load dữ liệu lên combobox ---------------------------------------------------------
        public DataTable loadCbbTinh()
        {
            // SQL Adapter
            da = new SqlDataAdapter("exec showTinh", con);
            // Đổ dữ liệu vào Dataset (Gọi ánh xạ bảng lên Dataset)
            da.Fill(qlTinhThanh, "TinhThanh");
            // Đặt khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = qlTinhThanh.Tables["TinhThanh"].Columns[0]; // Chọn column thứ 0
            qlTinhThanh.Tables["TinhThanh"].PrimaryKey = key; // Đặt khóa chính
            // Trả về danh sách
            return qlTinhThanh.Tables["TinhThanh"];
        }

        public DataTable loadCbbQHuyen(string tenQHuyen)
        {
            // SQL Adapter
            da = new SqlDataAdapter("exec showQuanHuyen N'" + tenQHuyen + "'", con);
            // Đổ dữ liệu vào Dataset (Gọi ánh xạ bảng lên Dataset)
            da.Fill(qlTinhThanh, "QHuyen");
            // Đặt khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = qlTinhThanh.Tables["QHuyen"].Columns[0]; // Chọn column thứ 0
            qlTinhThanh.Tables["QHuyen"].PrimaryKey = key; // Đặt khóa chính
            // Trả về danh sách
            return qlTinhThanh.Tables["QHuyen"];
        }

        public DataTable loadCbbXPhuong(string XPhuong)
        {
            // SQL Adapter
            da = new SqlDataAdapter("exec showXaPhuong N'" + XPhuong + "'", con);
            // Đổ dữ liệu vào Dataset (Gọi ánh xạ bảng lên Dataset)
            da.Fill(qlTinhThanh, "XPhuong");
            // Đặt khóa chính
            DataColumn[] key = new DataColumn[1];
            key[0] = qlTinhThanh.Tables["XPhuong"].Columns[0]; // Chọn column thứ 0
            qlTinhThanh.Tables["XPhuong"].PrimaryKey = key; // Đặt khóa chính
            // Trả về danh sách
            return qlTinhThanh.Tables["XPhuong"];
        }

        public List<string> loadTinh()
        {
            List<string> ds = new List<string>();

            try
            {
                // Mở kết nối
                openConnection();
                // Tạo câu lệnh
                string sql = "exec showTinh";
                // Xây dựng command truy vấn
                SqlCommand cmd = new SqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                SqlDataReader rd = cmd.ExecuteReader();
                // Hiển thị kết quả truy vấn
                while (rd.Read())
                {
                    string tenTinh = rd["tenTinh"].ToString();
                    ds.Add(tenTinh);
                }
                rd.Close();
                // Đóng kết nối
                closeConnection();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public List<string> loadQHuyen(string tenTinh)
        {
            List<string> ds = new List<string>();

            try
            {
                // Mở kết nối
                openConnection();
                // Tạo câu lệnh
                string sql = "exec showQuanHuyen N'" + tenTinh + "'";
                // Xây dựng command truy vấn
                SqlCommand cmd = new SqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                SqlDataReader rd = cmd.ExecuteReader();
                // Hiển thị kết quả truy vấn
                while (rd.Read())
                {
                    string tenQH = rd["tenQH"].ToString();
                    ds.Add(tenQH);
                }
                rd.Close();
                // Đóng kết nối
                closeConnection();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        public List<string> loadXPhuong(string tenQH)
        {
            List <string> ds = new List<string>();

            try
            {
                // Mở kết nối
                openConnection();
                // Tạo câu lệnh
                string sql = "exec showXaPhuong N'" + tenQH + "'";
                // Xây dựng command truy vấn
                SqlCommand cmd = new SqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                SqlDataReader rd = cmd.ExecuteReader();
                // Hiển thị kết quả truy vấn
                while (rd.Read())
                {
                    string tenXP = rd["tenXP"].ToString();
                    ds.Add(tenXP);
                }
                rd.Close();
                // Đóng kết nối
                closeConnection();
                return ds;
            }
            catch
            {
                return null;
            }
        }

        // Load dữ liệu lên textbox ----------------------------------------------------------
        public int tongDVHChinh(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "exec countXPTTran N'" + tenQH + "'";
            // Xây dựng command truy vấn
            SqlCommand cmd = new SqlCommand(sql, con);
            // Trả về 1 số
            int k = (int)cmd.ExecuteScalar(); // Thực thi câu lệnh executeScalar là trả về 1 số
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public int tongXa(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "exec countXa N'" + tenQH + "'";
            // Xây dựng command truy vấn
            SqlCommand cmd = new SqlCommand(sql, con);
            // Trả về 1 số
            int k = (int)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public int tongPhuong(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "exec countPhuong N'" + tenQH + "'";
            // Xây dựng command truy vấn
            SqlCommand cmd = new SqlCommand(sql, con);
            // Trả về 1 số
            int k = (int)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public int tongTTran(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "exec countThiTran N'" + tenQH + "'";
            // Xây dựng command truy vấn
            SqlCommand cmd = new SqlCommand(sql, con);
            // Trả về 1 số
            int k = (int)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }
    }
}