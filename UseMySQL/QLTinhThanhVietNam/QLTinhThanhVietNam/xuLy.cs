using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace QLTinhThanhVietNam
{
    public class xuLy
    {
        // Kết nối CSDL ----------------------------------------------------------------------
        MySqlConnection con = new MySqlConnection("Server = localhost; " +
            "Database = qltinhthanhvietnam; UId = root; Pwd = giabao04; Pooling=false;" +
            "Character Set=utf8");

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

        // Load dữ liệu lên combobox ---------------------------------------------------------
        public List<string> loadTinh()
        {
            List<string> ds = new List<string>();

            try
            {
                // Mở kết nối
                openConnection();
                // Tạo câu lệnh
                string sql = "call qltinhthanhvietnam.showTinh()";
                // Xây dựng command truy vấn
                MySqlCommand cmd = new MySqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                MySqlDataReader rd = cmd.ExecuteReader();
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
                string sql = "call qltinhthanhvietnam.showQHuyen('" + tenTinh + "')";
                // Xây dựng command truy vấn
                MySqlCommand cmd = new MySqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                MySqlDataReader rd = cmd.ExecuteReader();
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
            List<string> ds = new List<string>();

            try
            {
                // Mở kết nối
                openConnection();
                // Tạo câu lệnh
                string sql = "call qltinhthanhvietnam.showXPhuong('" + tenQH + "')";
                // Xây dựng command truy vấn
                MySqlCommand cmd = new MySqlCommand(sql, con);
                // Gọi phương thức truy vấn dạng hiển thị dữ liệu
                MySqlDataReader rd = cmd.ExecuteReader();
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
        public object tongDVHChinh(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "call qltinhthanhvietnam.countXPTTran('" + tenQH + "')";
            // Xây dựng command truy vấn
            MySqlCommand cmd = new MySqlCommand(sql, con);
            // Trả về 1 số
            object k = (object)cmd.ExecuteScalar(); // Thực thi câu lệnh executeScalar là trả về 1 số
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public object tongXa(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "call qltinhthanhvietnam.countXa('" + tenQH + "')";
            // Xây dựng command truy vấn
            MySqlCommand cmd = new MySqlCommand(sql, con);
            // Trả về 1 số
            object k = (object)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public object tongPhuong(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "call qltinhthanhvietnam.countPhuong('" + tenQH + "')";
            // Xây dựng command truy vấn
            MySqlCommand cmd = new MySqlCommand(sql, con);
            // Trả về 1 số
            object k = (object)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }

        public object tongTTran(string tenQH)
        {
            // Mở kết nối
            openConnection();
            // Tạo câu lệnh
            string sql = "call qltinhthanhvietnam.countTTran('" + tenQH + "')";
            // Xây dựng command truy vấn
            MySqlCommand cmd = new MySqlCommand(sql, con);
            // Trả về 1 số
            object k = (object)cmd.ExecuteScalar();
            // Đóng kết nối
            closeConnection();
            // Trả về số lượng
            return k;
        }
    }
}