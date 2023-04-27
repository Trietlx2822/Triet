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
    public partial class frm_updateSP : Form
    {
        public frm_updateSP()
        {
            InitializeComponent();
        }

        public void load_dssp()
        {
            KetNoi k = new KetNoi();
            string sql = "Select * From SANPHAM";
            binding_sp.DataSource = k.load_bang(sql);
            grid_sp.DataSource = binding_sp;
            //Clear sp
            //txt_maSP.Clear();
            txt_maSP.DataBindings.Clear();
            txt_tenSP.DataBindings.Clear();
            txt_nsx.DataBindings.Clear();
            txt_sl.DataBindings.Clear();
            txt_gia.DataBindings.Clear();
            cmb_tgbaohanh.DataBindings.Clear();
            //Đỗ dữ liệu lên textbox
            txt_maSP.DataBindings.Add("Text", binding_sp, "MaSP");
            txt_tenSP.DataBindings.Add("Text", binding_sp, "TenSP");
            txt_nsx.DataBindings.Add("Text", binding_sp, "NSX");
            txt_sl.DataBindings.Add("Text", binding_sp, "SoLuong");
            txt_gia.DataBindings.Add("Text", binding_sp, "Gia");
            cmb_tgbaohanh.DataBindings.Add("Text", binding_sp, "TGBaoHanh");
        }

        private void frm_updateSP_Load(object sender, EventArgs e)
        {
            load_dssp();
            load_TGBaoHanh();
        }

        private void navigationPane1_SelectedPageIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void load_TGBaoHanh()
        {
            KetNoi k = new KetNoi();
            cmb_tgbaohanh.DataSource = k.load_bang("Select distinct TGBaoHanh from SANPHAM");
            cmb_tgbaohanh.ValueMember = "TGBaoHanh";
            cmb_tgbaohanh.DisplayMember = "TGBaoHanh";
        }
        public string tao_masp()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from SANPHAM";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "0" + so.ToString();
            return ma;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_maSP.Text = tao_masp();
            txt_tenSP.ResetText();
            txt_nsx.ResetText();
            txt_sl.ResetText();
            txt_gia.ResetText();
            
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "insert into SANPHAM values(N'" + txt_maSP.Text + "',N'" + txt_tenSP.Text + "','" + cmb_tgbaohanh.SelectedValue + "',N'" + txt_nsx.Text + "',N'" + txt_sl.Text + "',N'" + txt_gia.Text + "')";
            DialogResult traloi = MessageBox.Show("Bạn muốn thêm sản phẩm này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí lưu  dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("Bạn thêm sản phẩm thành công", "thông báo");
                    load_dssp();
                }
                else
                    MessageBox.Show("Thêm sản phẩm không thành công", "thông báo");
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "update SANPHAM set TenSP=N'" + txt_tenSP.Text + "', TGBaoHanh='" +cmb_tgbaohanh.SelectedValue+ "', NSX=N'" + txt_nsx.Text + "',SoLuong='" + txt_sl.Text + "',Gia='" + txt_gia.Text + "' where MaSP='" + txt_maSP.Text + "'";
            
            DialogResult traloi = MessageBox.Show("bạn muốn sửa thông tin sản phẩm này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn sửa dữ liệu thành công", "thông báo");
                    load_dssp();
                }
                else
                    MessageBox.Show("Sửa dữ liệu không thành công", "thông báo");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "delete from SANPHAM where MaSP='" + txt_maSP.Text + "'";

            DialogResult traloi = MessageBox.Show("bạn thực sự muốn xóa sản phẩm này ?", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (traloi == DialogResult.OK)
            {
                //xử lí xóa dữ liệu 
                int sd = k.thuc_thi(sql);
                if (sd > 0)
                {
                    MessageBox.Show("bạn xóa dữ liệu thành công", "thông báo");
                    load_dssp();
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

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_sp.ShowPrintPreview();
        }
    }
}
