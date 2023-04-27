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
    public partial class frm_thongkedoanhthu : Form
    {
        public frm_thongkedoanhthu()
        {
            InitializeComponent();
            for(int t=1; t<13; t++)
            {
                cmb_theothang.Items.Add(t);
            }
            for (int n = 1990; n < 2300;  n++)
            {
                cmb_theonam.Items.Add(n);
            }
        }

        private void rdb_theongay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_xemthongke_Click(object sender, EventArgs e)
        {
            if(rdb_theongay.Checked==true)
            {
                string sql ="select HOADON.SoHD,SANPHAM.MaSP,SANPHAM.TenSP,Gia,SANPHAM.SoLuong,SANPHAM.SoLuong*Gia As ThanhTien "; 
                sql += "from HOADON,CTBANHANG,SANPHAM ";
                sql += "where HOADON.SoHD=CTBANHANG.SoHD and CTBANHANG.MaSP=SANPHAM.MaSP and NgayLap='"+dateTime_theongay.Value.ToString("MM/dd/yyyy")+"'";
               
                KetNoi k = new KetNoi();
                grid_doanhthu.DataSource = k.load_bang(sql);
            }
            else if(rdb_theothang.Checked==true)
            {
                string sql = "select HOADON.SoHD,SANPHAM.MaSP,SANPHAM.TenSP,Gia,SANPHAM.SoLuong,SANPHAM.SoLuong*Gia As ThanhTien ";
                sql += "from HOADON,CTBANHANG,SANPHAM ";
                sql += "where HOADON.SoHD=CTBANHANG.SoHD and CTBANHANG.MaSP=SANPHAM.MaSP and Month(NgayLap)='"+cmb_theothang.Text+"' and Year(NgayLap)='"+cmb_theonam.Text+"'";
                
                KetNoi k = new KetNoi();
                grid_doanhthu.DataSource = k.load_bang(sql);
            }
            else if(rdb_tungay.Checked==true)
            {
                string sql = "select HOADON.SoHD,SANPHAM.MaSP,SANPHAM.TenSP,Gia,SANPHAM.SoLuong,SANPHAM.SoLuong*Gia As ThanhTien ";
                sql += "from HOADON,CTBANHANG,SANPHAM ";
                sql += "where HOADON.SoHD=CTBANHANG.SoHD and CTBANHANG.MaSP=SANPHAM.MaSP and NgayLap between'"+dateTime_tungay.Value.ToString("MM/dd/yyyy")+"' and '"+dateTime_denngay.Value.ToString("MM/dd/yyyy")+"'";
                
                KetNoi k = new KetNoi();
                grid_doanhthu.DataSource = k.load_bang(sql);
            }
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            grid_doanhthu.ShowPrintPreview();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không?", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_thongkedoanhthu_Load(object sender, EventArgs e)
        {

        }
    }
}
