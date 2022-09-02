using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTinhThanhVietNam
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        xuLy xl = new xuLy();

        // Khởi tạo ngày giờ của hệ thống ----------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy - hh:mm:ss");
        }

        // Load form -------------------------------------------------------------------------
        private void Home_Load(object sender, EventArgs e)
        {
            // Enabled textbox
            txtTongXP.Enabled = false;
            txtSLXa.Enabled = false;   
            txtSLPhuong.Enabled = false;
            txtSLThiTran.Enabled = false;

            // Căn giữa textbox 
            txtTongXP.TextAlign = HorizontalAlignment.Center;
            txtSLXa.TextAlign = HorizontalAlignment.Center;
            txtSLPhuong.TextAlign = HorizontalAlignment.Center;
            txtSLThiTran.TextAlign = HorizontalAlignment.Center;

            // Load dữ liệu lên combobox
            //cbbTinh.DataSource = xl.loadCbbTinh();
            //cbbTinh.DisplayMember = "tenTinh"; // Hiển thị
            //cbbTinh.ValueMember = "tenTinh"; // Lấy giá trị

            List<string> dsTinh = new List<string>();
            dsTinh = xl.loadTinh();
            foreach(string s in dsTinh)
            {
                cbbTinh.Items.Add(s);
            }
        }

        // Đóng form -------------------------------------------------------------------------
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dr == DialogResult.No)
                e.Cancel = true;
        }

        // Chọn 1 giá trị dữ liệu trong combobox tỉnh thành ----------------------------------
        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu trước đó trong combobox
            cbbQHuyen.Items.Clear();

            //cbbQHuyen.DataSource = xl.loadCbbQHuyen(cbbTinh.Text.ToString());
            //cbbQHuyen.DisplayMember = "tenQH"; // Hiển thị
            //cbbQHuyen.ValueMember = "tenQH"; // Lấy giá trị

            List<string> ds = new List<string>();

            ds = xl.loadQHuyen(cbbTinh.SelectedItem.ToString());
            foreach (string s in ds)
            {
                cbbQHuyen.Items.Add(s);
            }
        }

        // Chọn giá trị dữ liệu trong combobox quận huyện ------------------------------------
        private void cbbQHuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu trước đó trong combobox
            cbbXPhuong.Items.Clear();

            //cbbXPhuong.DataSource = xl.loadCbbXPhuong(cbbQHuyen.Text.ToString());
            //cbbXPhuong.DisplayMember = "tenXP";
            //cbbXPhuong.ValueMember = "tenXP";

            List<string> ds = new List<string>();

            ds = xl.loadXPhuong(cbbQHuyen.SelectedItem.ToString());
            foreach (string s in ds)
            {
                cbbXPhuong.Items.Add(s);
            }

            // Load dữ liệu lên textbox
            txtTongXP.Text = xl.tongDVHChinh(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtSLXa.Text = xl.tongXa(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtSLPhuong.Text = xl.tongPhuong(cbbQHuyen.SelectedItem.ToString()).ToString();
            txtSLThiTran.Text = xl.tongTTran(cbbQHuyen.SelectedItem.ToString()).ToString();
        }
    }
}