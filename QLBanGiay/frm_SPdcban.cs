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
    public partial class frm_SPdcban : Form
    {
        public frm_SPdcban()
        {
            InitializeComponent();
        }

        private void frm_SPTonKho_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "Select * from SANPHAM";
            grid_sp.DataSource = k.load_bang(sql);
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            grid_sp.RefreshDataSource();
            if(rdb_spbanchay.Checked==true)
            {
                KetNoi k = new KetNoi();
                string sql = "Select top(1) SANPHAM.MaSP,SANPHAM.TenSP,SANPHAM.NSX,SANPHAM.Gia,SANPHAM.SoLuong,SUM(SANPHAM.SoLuong) as Tong_SL_Ban ";
                sql += "from SANPHAM,CTBANHANG ";
                sql += "where SANPHAM.MaSP=CTBANHANG.MaSP ";
                sql += "Group by SANPHAM.MaSP,SANPHAM.TenSP,SANPHAM.NSX,SANPHAM.Gia,SANPHAM.SoLuong Order by SUM(SANPHAM.SoLuong) desc";
                grid_sp.DataSource = k.load_bang(sql);
            }
            else if(rdb_spbancham.Checked==true)
            {
                KetNoi k = new KetNoi();
                string sql = "Select top(1) SANPHAM.MaSP,SANPHAM.TenSP,SANPHAM.NSX,SANPHAM.Gia,SANPHAM.SoLuong,SUM(SANPHAM.SoLuong) as Tong_SL_Ban ";
                sql += "from SANPHAM,CTBANHANG ";
                sql += "where SANPHAM.MaSP=CTBANHANG.MaSP ";
                sql += "Group by SANPHAM.MaSP,SANPHAM.TenSP,SANPHAM.NSX,SANPHAM.Gia,SANPHAM.SoLuong Order by SUM(SANPHAM.SoLuong) asc";
                grid_sp.DataSource = k.load_bang(sql);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_sp.ShowPrintPreview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
       
    }
}
