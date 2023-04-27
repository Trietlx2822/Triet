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
    public partial class frm_PhieuChuyen : Form
    {
        public frm_PhieuChuyen()
        {
            InitializeComponent();
        }

        public string tao_PC()
        {
            KetNoi k = new KetNoi();
            string sql = "select * from PHIEUCHUYEN";
            DataTable dt = k.load_bang(sql);
            int so = dt.Rows.Count + 1;
            string ma = "PC0" + so.ToString();
            return ma;
        }
        //Tạo combobox mã nv 
        public void Fill_combobox(string sql, ComboBox cmb, string ten, string ma)
        {
            KetNoi k = new KetNoi();
            
            cmb.DisplayMember = ten;
            cmb.ValueMember = ma;
            cmb.DataSource = k.load_bang(sql);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            txt_sophieuchuyen.Text = tao_PC();
            
            //Đỗ dũ liệu lên combobox
            
            Fill_combobox("select * from NHANVIEN",cmb_manv,"MaNV", "MaNV");
            Fill_combobox("select * from KHACHHANG", cmb_maKH, "MaKH", "MaKH");
            Fill_combobox("select distinct TinhTrangChuyen from PHIEUCHUYEN", cmb_tinhtrang, "TinhTrangChuyen", "TinhTrangChuyen");
            Fill_combobox("select * from SANPHAM", cmb_maHang, "MaSP", "MaSP");
            
        }

        private void cmb_manv_TextChanged(object sender, EventArgs e)
        {
            if (cmb_manv.Text == "")
                txt_tenNV.Text = "";
            KetNoi k = new KetNoi();
            txt_tenNV.Text = k.load_field("select TenNV from NHANVIEN where MaNV='" + cmb_manv.Text + "'");
            txt_SoHD.Text = k.load_field("Select SoHD from HOADON where MaNV='" + cmb_manv.Text + "'");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                bool trangthai;
                string sql = "Insert into PHIEUCHUYEN values('" + txt_sophieuchuyen.Text + "','" + cmb_tinhtrang.Text + "','" + datetime_ngaychuyen.Value.ToString("MM/dd/yyyy") + "','" + cmb_manv.Text + "','" + txt_SoHD.Text + "')";
                
                KetNoi k = new KetNoi();
                int dong = k.thuc_thi(sql);
                if(dong>0)
                {
                    
                    trangthai = true;
                    //xữ lý thêm chi tiết phiếu chuyển
                    foreach (ListViewItem l in list_sanpham.Items)
                    {
                        KetNoi t = new KetNoi();
                        string sql1 = "insert into CT_PHIEUCHUYEN values('" + l.SubItems[0].Text + "','" + txt_sophieuchuyen.Text + "','" + l.SubItems[4].Text + "','" + l.SubItems[5].Text + "')";
                        MessageBox.Show(sql1);
                        if (t.thuc_thi(sql1) > 0)
                            trangthai = true;
                        else
                            trangthai = false;
                    }
                }
                 else
                    trangthai = false;
                if (trangthai == true)
                    MessageBox.Show("Lưu phiếu chuyển thành công!","Thông Báo");
                else
                    MessageBox.Show("Lưu phiếu chuyển thất bại!", "Thông báo");
                }
            
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        public void load_phieuchuyen()
        {
            KetNoi k = new KetNoi();
            //cmb_maKH.Text = k.load_field("Select PHIEUCHUYEN.MaKH from PHIEUCHUYEN where SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'");
            cmb_maHang.Text = k.load_field("select * from PHIEUCHUYEN where SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'");
            cmb_manv.Text = k.load_field("Select MaNV from PHIEUCHUYEN where SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'");
            cmb_tinhtrang.Text = k.load_field("Select TinhTrangChuyen from PHIEUCHUYEN where SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'");
            datetime_ngaychuyen.Text = k.load_field("Select NgayChuyen from PHIEUCHUYEN where SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'");
            
        }
        public void load_ctphieuchuyen()
        {
            string sql = "select SANPHAM.MaSP,TenSP,TGBaoHanh,NSX,SANPHAM.SoLuong,Gia,SANPHAM.SoLuong*Gia as ThanhTien ";
            sql += "from CT_PhieuChuyen,SANPHAM where CT_PhieuChuyen.MaSP=SANPHAM.MaSP and SoPhieuChuyen='" + txt_sophieuchuyen.Text + "'";
            KetNoi k = new KetNoi();
            DataTable dt_phieuchuyen = k.load_bang(sql);
            foreach (DataRow r in dt_phieuchuyen.Rows)
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
                    if (MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng! Bạn có muốn thêm số lượng", "Thông báo!", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        foreach (ListViewItem i in list_sanpham.Items)
                        {
                            if (i.SubItems[0].Text == cmb_maHang.Text)
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

        private void cmb_maKH_TextChanged(object sender, EventArgs e)
        {
            if (cmb_maKH.Text == "")
                txt_tenKH.Text = "";
                txt_sdt.Text="";
                txt_diachi.Text="";
            KetNoi k = new KetNoi();
            txt_tenKH.Text = k.load_field("select TenKH from KHACHHANG where MaKH='" + cmb_maKH.Text + "'");
            txt_sdt.Text=k.load_field("select SDT from KHACHHANG where MaKH='"+cmb_maKH.Text+"'");
            txt_diachi.Text=k.load_field("Select DCKH from KHACHHANG where MaKH='"+cmb_maKH.Text+"'");
        
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

        private void btn_huy_Click(object sender, EventArgs e)
        {
            list_sanpham.Clear();
            txt_sophieuchuyen.ResetText();
            datetime_ngaychuyen.Text = "";
            cmb_tinhtrang.Text = "";
            cmb_manv.ResetText();
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
            frm_InPhieuChuyen f_in = new frm_InPhieuChuyen();
            f_in.sophieuchuyen=txt_sophieuchuyen.Text;
            f_in.ShowDialog();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            if (txt_sophieuchuyen.Text != "")
            {
                load_phieuchuyen();
                load_ctphieuchuyen();
            }
        }

        private void frm_PhieuChuyen_Load(object sender, EventArgs e)
        {

        }

        
        

        
    }
}
