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
    public partial class frm_UpdateKhachhang : Form
    {
        public frm_UpdateKhachhang()
        {
            InitializeComponent();
        }

        private void frm_UpdateKhachhang_Load(object sender, EventArgs e)
        {
            load_kh();
        }
        public void load_kh()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * From KHACHHANG";
            binding_kh.DataSource = k.load_bang(sql);
            grid_kh.DataSource = binding_kh;
            //clear data của các điều khiển
            txt_makh.DataBindings.Clear();
            txt_tenkh.DataBindings.Clear();
            txt_dc.DataBindings.Clear();
            txt_sdt.DataBindings.Clear();
            //Đổ dữ liệu lên textbox
            txt_makh.DataBindings.Add("Text", binding_kh, "MaKH");
            txt_tenkh.DataBindings.Add("Text", binding_kh, "TenKH");
            txt_dc.DataBindings.Add("Text", binding_kh, "DCKH");
            txt_sdt.DataBindings.Add("Text", binding_kh, "SDT");
        }
        public string tao_makh()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from KHACHHANG";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "KH0" + so.ToString();
            return ma;
        }
        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_makh.Text = tao_makh();
            txt_tenkh.ResetText();
            txt_dc.ResetText();
            txt_sdt.ResetText();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "insert into KHACHHANG values(N'" + txt_makh.Text + "',N'" + txt_tenkh.Text + "',N'" + txt_dc.Text + "',N'" + txt_sdt.Text + "')";
            DialogResult traloi = MessageBox.Show("Bạn muốn lưu khách hàng này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí lưu  dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn lưu khách hàng thành công", "thông báo");
                    load_kh();
                }
                else
                    MessageBox.Show("Lưu khách hàng không thành công", "thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "update KHACHHANG set TenKH=N'" + txt_tenkh.Text + "', DCKH=N'" + txt_dc.Text + "', SDT=N'" + txt_sdt.Text + "' where MaKH='" + txt_makh.Text + "'";

            DialogResult traloi = MessageBox.Show("bạn muốn sửa thông tin khách hàng này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn sửa dữ liệu thành công", "thông báo");
                    load_kh();
                }
                else
                    MessageBox.Show("Sửa dữ liệu không thành công", "thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "delete from KHACHHANG where MaKH='" + txt_makh.Text + "'";

            DialogResult traloi = MessageBox.Show("bạn thực sự muốn xóa khách hàng này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn xóa dữ liệu thành công", "thông báo");
                    load_kh();
                }
                else
                    MessageBox.Show("xóa dữ liệu không thành công", "thông báo");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_kh.ShowPrintPreview();
        }

    }
}
