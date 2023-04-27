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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_taohoadon_Click(object sender, EventArgs e)
        {
            txt_soHD.Text = tao_HD();
           
            txt_slban.ResetText();
            //Đỗ dũ liệu lên combobox
            Fill_combobox("select * from NHANVIEN", cmb_maNV, "MaNV", "MaNV");
            Fill_combobox("select * from KHACHHANG", cmb_maKH, "MaKH", "MaKH");
            Fill_combobox("Select * from SANPHAM", cmb_maHang, "MaSP", "MaSP");
        }
        //Tạo số hóa đơn
        public string tao_HD()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from HOADON";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "HD00" + so.ToString();
            return ma;
        }
        //Tạo combobox mã nv kh
        public void Fill_combobox(string sql, ComboBox cmb, string ten, string ma)
        {
            KetNoi k = new KetNoi();
            cmb.DataSource = k.load_bang(sql);
            cmb.DisplayMember = ten;
            cmb.ValueMember = ma;
        }
        //Tạo mã sản phẩm combobox
        /* public void load_maSP()
         {
             KetNoi k = new KetNoi();
             cmb_maHang.DataSource = k.load_bang("Select distinct MaSP from SANPHAM");
             cmb_maHang.ValueMember = "MaSP";
             cmb_maHang.DisplayMember = "MaSP";
         }*/

        /* public void load_chitiet()
         {
             KetNoi k = new KetNoi();
             Grid_hoadon.Columns.Clear();
             string sql = "select SANPHAM.MaSP,TenSP,TGBaoHanh,NSX,SoLuong,Gia,Gia*SoLuong as ThanhTien";
             sql += "from CTBANHANG,SANPHAM Where CTBANHANG.MaSP=SANPHAM.MaSP and SoHD='"+txt_soHD.Text+"'";
             Grid_hoadon.DataSource = k.load_bang(sql);
             Grid_hoadon.Columns[0].HeaderText = "Mã Sản Phẩm";
             Grid_hoadon.Columns[1].HeaderText = "Tên Sản Phẩm";
             Grid_hoadon.Columns[2].HeaderText = "Thời Gian Bảo Hành";
             Grid_hoadon.Columns[3].HeaderText = "Nhà Sản Xuất";
             Grid_hoadon.Columns[4].HeaderText = "Số Lượng";
             Grid_hoadon.Columns[5].HeaderText = "Giá";
             Grid_hoadon.Columns[6].HeaderText = "Thành Tiền";
         }*/


        public void load_TGBaoHanh()
        {
            KetNoi k = new KetNoi();
            cmb_TGbaohanh.DataSource = k.load_bang("Select distinct ThoiGianBaoHanh from HOADON");
            cmb_TGbaohanh.ValueMember = "ThoiGianBaoHanh";
            cmb_TGbaohanh.DisplayMember = "ThoiGianBaoHanh";
        }
        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void frm_HoaDon_Load(object sender, EventArgs e)
        {

            load_TGBaoHanh();
            //load_maSP();

        }

        private void cmb_TGbaohanh_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_maNV_TextChanged(object sender, EventArgs e)
        {
            if (cmb_maNV.Text == "")
                txt_tenNV.Text = "";
            KetNoi k = new KetNoi();
            txt_tenNV.Text = k.load_field("select TenNV from NHANVIEN where MaNV='" + cmb_maNV.Text + "'");

        }

        private void cmb_maKH_TextChanged(object sender, EventArgs e)
        {
            if (cmb_maKH.Text == "")
                txt_tenKH.Text = "";
            txt_diachi.Text = "";
            txt_sdt.Text = "";
            KetNoi k = new KetNoi();
            txt_tenKH.Text = k.load_field("select TenKH from KHACHHANG where MaKH='" + cmb_maKH.Text + "'");
            txt_diachi.Text = k.load_field("select DCKH from KHACHHANG where MaKH='" + cmb_maKH.Text + "'");
            txt_sdt.Text = k.load_field("select SDT from KHACHHANG where MaKH='" + cmb_maKH.Text + "'");
        }

        private void cmb_maHang_TextChanged(object sender, EventArgs e)
        {
            if (cmb_maHang.Text == "")
                txt_tenHang.Text = "";
            txt_tgbaohanhSP.Text = "";
            txt_NSX.Text = "";
            txt_slban.Text = "";
            txt_dongia.Text = "";
            KetNoi k = new KetNoi();
            txt_tenHang.Text = k.load_field("select TenSP from SANPHAM where MaSP='" + cmb_maHang.Text + "'");
            txt_tgbaohanhSP.Text = k.load_field("select TGBaoHanh from SANPHAM where MaSP='" + cmb_maHang.Text + "'");
            txt_NSX.Text = k.load_field("select NSX from SANPHAM where MaSP='" + cmb_maHang.Text + "'");
            txt_dongia.Text = k.load_field("select Gia from SANPHAM where MaSP='" + cmb_maHang.Text + "'");

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if(txt_soHD.Text!="")
            {
                load_hoadon();
                load_cthoadon();
            }
        }

        public void load_hoadon()
        {
            KetNoi k = new KetNoi();
            cmb_maKH.Text = k.load_field("Select MaKH from HOADON where SoHD='" + txt_soHD.Text + "'");
            cmb_maNV.Text=k.load_field("Select MaNV from HOADON where SoHD='"+txt_soHD.Text+"'");
            date_ngaylap.Text = k.load_field("Select NgayLap from HOADON where SoHD='" + txt_soHD.Text + "'");
            date_ngaybatdauBH.Text = k.load_field("Select NgayBatDauBaoHanh from HOADON where SoHD='" + txt_soHD.Text + "'");
            
        }
        public void load_cthoadon()
        {
            string sql = "select SANPHAM.MaSP,TenSP,TGBaoHanh,NSX,SANPHAM.SoLuong,Gia,SANPHAM.SoLuong*Gia as ThanhTien ";
            sql+="from CTBANHANG,SANPHAM where CTBANHANG.MaSP=SANPHAM.MaSP and SoHD='"+txt_soHD.Text+"'";
            KetNoi k = new KetNoi();
            DataTable dt_hoadon = k.load_bang(sql);
            foreach (DataRow r in dt_hoadon.Rows)
            {
                ListViewItem l = new ListViewItem(r[0].ToString());
                l.SubItems.Add(r[1].ToString());
                l.SubItems.Add(r[2].ToString());
                l.SubItems.Add(r[3].ToString());
                l.SubItems.Add(r[4].ToString());
                l.SubItems.Add(r[5].ToString());
                list_sanpham.Items.Add(l);
            }

        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                //Xữ lý lưu hóa đơn
                bool trangthai;
                string sql = "insert into HOADON values('" + txt_soHD.Text + "','" + date_ngaylap.Value.ToString("MM/dd/yyyy") + "','" + txt_tenNV.Text + "','" + date_ngaybatdauBH.Value.ToString("MM/dd/yyyy") + "','" + cmb_TGbaohanh.SelectedValue + "','" + cmb_maKH.Text + "','" + cmb_maNV.Text + "')";
                
                KetNoi k = new KetNoi();
                int dong = k.thuc_thi(sql);
                if (dong > 0)
                {
                    trangthai = true;
                    //xữ lý thêm chi tiết hóa đơn
                    foreach (ListViewItem l in list_sanpham.Items)
                    {
                        KetNoi t = new KetNoi();
                        string sql1 = "insert into CTBANHANG values('" + l.SubItems[0].Text + "','" +txt_soHD.Text+ "','" + l.SubItems[4].Text + "')";
                        if (t.thuc_thi(sql1) > 0)
                            trangthai = true;
                        else
                            trangthai = false;                   
                    }
                }
                else
                    trangthai = false;
                if (trangthai == true)
                    MessageBox.Show("Lưu hóa đơn thành công!", "Thông Báo!");
                else
                    MessageBox.Show("Lưu hóa đơn thất bại!", "Thông Báo!");
            }
            catch(Exception exp)
            {
                MessageBox.Show("Lỗi SQL", exp.ToString());
            }
             
        }

        //thêm sản phẩm vào listview
        private void btn_themhang_Click(object sender, EventArgs e)
        {
            if (txt_slban.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo!");
                txt_slban.Focus();
            }
            else
            {
                bool kt = true;
                foreach (ListViewItem i in list_sanpham.Items)
                {
                    if (i.SubItems[0].Text == cmb_maHang.Text)
                    {
                        kt = false;
                        break;
                    }
                }
                if (kt == false)
                {
                    if(MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng! Bạn có muốn thêm số lượng","Thông báo!", MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        foreach(ListViewItem i in list_sanpham.Items)
                        {
                            if(i.SubItems[0].Text==cmb_maHang.Text)
                            {
                                int sl = Int32.Parse(i.SubItems[4].Text) + Int32.Parse(txt_slban.Text);
                                i.SubItems[4].Text = sl.ToString();
                                
                                //cập nhập thành tiền
                                double tongtien = Double.Parse(i.SubItems[5].Text) * Double.Parse(i.SubItems[6].Text);
                                i.SubItems[6].Text = tongtien.ToString();
                                
                            }
                        }
                    }                  
                }

                else
                {
                    ListViewItem item = new ListViewItem(cmb_maHang.Text);
                    item.SubItems.Add(txt_tenHang.Text);
                    item.SubItems.Add(txt_tgbaohanhSP.Text);
                    item.SubItems.Add(txt_NSX.Text);
                    item.SubItems.Add(txt_slban.Text);
                    item.SubItems.Add(txt_dongia.Text);
                    double thanhtien = Double.Parse(txt_slban.Text) * Double.Parse(txt_dongia.Text);
                    
                    item.SubItems.Add(thanhtien.ToString());
                    
                    list_sanpham.Items.Add(item);
                }
                double tt = 0;
                foreach (ListViewItem item in list_sanpham.Items)
                {
                    tt += Single.Parse(item.SubItems[6].Text);
                }
                txt_tthoadon.Text = tt.ToString();
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            list_sanpham.ResetText();
            txt_soHD.ResetText();
            date_ngaylap.Text = "";
            date_ngaybatdauBH.Text = "";
            cmb_TGbaohanh.ResetText();
            cmb_maNV.ResetText();
            //txt_tenNV.ResetText();
            cmb_maKH.ResetText();
            //txt_tenKH.ResetText();
            //txt_diachi.ResetText();
            //txt_sdt.ResetText();
            cmb_maHang.ResetText();
            txt_tthoadon.ResetText();


        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            frm_inHD f_in = new frm_inHD();
            f_in.sohoadon = txt_soHD.Text;// Lấy số hóa đơn từ Textbox
            f_in.ShowDialog();
        }
    }
}
