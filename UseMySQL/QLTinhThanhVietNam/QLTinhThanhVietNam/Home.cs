using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QLTinhThanhVietNam
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        xuLy xl = new xuLy();

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }

        // Load form ------------------------------------------------------------------------------------
        private void Home_Load(object sender, EventArgs e)
        {
            txtDVHC.Enabled = false;
            txtPhuong.Enabled = false;
            txtXa.Enabled = false;
            txtTTran.Enabled = false;

            // Căn giữa chữ trong textbox
            txtDVHC.TextAlign = HorizontalAlignment.Center;
            txtPhuong.TextAlign = HorizontalAlignment.Center;
            txtTTran.TextAlign = HorizontalAlignment.Center;
            txtXa.TextAlign = HorizontalAlignment.Center;

            // Load dữ liệu lên combobox
            cbbTinh.DataSource = xl.loadTinh();
        }

        // Đóng form ------------------------------------------------------------------------------------
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        // Hiển thị quận huyện theo tỉnh thành ----------------------------------------------------------
        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu trước đó trong combobox
            cbbQHuyen.Items.Clear();

            List<string> ds = new List<string>();

            // Load dữ liệu lên combobox
            ds = xl.loadQHuyen(cbbTinh.SelectedItem.ToString());
            foreach (string s in ds)
            {
                cbbQHuyen.Items.Add(s);
            }
        }

        // Hiển thị xã phường theo quận huyện -----------------------------------------------------------
        private void cbbQHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu trước đó trong combobox
            cbbXPhuong.Items.Clear();

            List<string> ds = new List<string>();

            // Load dữ liệu lên combobox
            ds = xl.loadXPhuong(cbbQHuyen.SelectedItem.ToString());
            foreach (string s in ds) 
            {
                cbbXPhuong.Items.Add(s);
            }

            // Hiển thị dữ liệu lên textbox
            txtDVHC.Text = xl.tongDVHChinh(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtXa.Text = xl.tongXa(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtPhuong.Text = xl.tongPhuong(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtTTran.Text = xl.tongTTran(cbbQHuyen.SelectedItem.ToString()).ToString();
        }
    }
}