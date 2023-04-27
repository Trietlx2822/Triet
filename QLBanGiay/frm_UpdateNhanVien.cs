using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanGiay
{
    public partial class frm_UpdateNhanVien : Form
    {
        public frm_UpdateNhanVien()
        {
            InitializeComponent();
        }

        private void navigationPane1_Click(object sender, EventArgs e)
        {

        }

        private void navigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateNhanVien_Load(object sender, EventArgs e)
        {
            load_dsnv();
           
        }
        //Tạo mã nhân viên tụ đông
        public string tao_manv()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from NHANVIEN";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "NV0" + so.ToString();
            return ma;
        }
        public void load_dsnv()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * From NHANVIEN";
            binding_nv.DataSource = k.load_bang(sql);
            grid_nhanvien.DataSource = binding_nv;
            //clear data của các điều khiển
            txt_manv.DataBindings.Clear();
            txt_tennv.DataBindings.Clear();
            txt_diachi.DataBindings.Clear();
            txt_dienthoai.DataBindings.Clear();
            //Đổ dữ liệu lên textbox
            txt_manv.DataBindings.Add("Text", binding_nv, "MaNV");
            txt_tennv.DataBindings.Add("Text", binding_nv, "TenNV");
            txt_diachi.DataBindings.Add("Text", binding_nv, "DCNV");
            txt_dienthoai.DataBindings.Add("Text", binding_nv, "SDTNV");
        }
        
        public void load_hoso()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from NHANVIEN";
            grid_hosoNV.DataSource = k.load_bang(sql);
        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            if (navigationPane1.SelectedPageIndex == 1)
            {
                load_hoso();
            }
            else if (navigationPane1.SelectedPageIndex == 0)
            {
                load_dsnv();
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            txt_manv.Text = tao_manv();
            txt_tennv.ResetText();
            txt_diachi.ResetText();
            txt_dienthoai.ResetText();
        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "update NHANVIEN set TenNV=N'" + txt_tennv.Text + "', DCNV=N'" + txt_diachi.Text + "', SDTNV=N'" + txt_dienthoai.Text + "' where MaNV='" + txt_manv.Text + "'";

            DialogResult traloi = MessageBox.Show("bạn muốn sửa thông tin nhân viên này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn sửa dữ liệu thành công", "thông báo");
                    load_dsnv();
                }
                else
                    MessageBox.Show("Sửa dữ liệu không thành công", "thông báo");
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "delete from NHANVIEN where MaNV='" + txt_manv.Text + "'";

            DialogResult traloi = MessageBox.Show("bạn thực sự muốn xóa NV này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn xóa dữ liệu thành công", "thông báo");
                    load_dsnv();
                }
                else
                    MessageBox.Show("xóa dữ liệu không thành công", "thông báo");
            }
        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "insert into NHANVIEN values(N'" + txt_manv.Text + "',N'" + txt_tennv.Text + "',N'" + txt_diachi.Text + "','" + txt_dienthoai.Text + "')";
            DialogResult traloi = MessageBox.Show("Bạn muốn lưu nhân viên này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí lưu  dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn lưu nhân viên thành công", "thông báo");
                    load_dsnv();
                }
                else
                    MessageBox.Show("Lưu nhân viên không thành công", "thông báo");
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_nhanvien.ShowPrintPreview();
        }
    }
}
