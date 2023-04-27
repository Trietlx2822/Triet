using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QLBanGiay
{
    public partial class frm_Giaodien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Giaodien()
        {
            InitializeComponent();
        }

        //Hàm dùng load from con, kiểm tra from con xem có được mở hay không?
        public void load_form(Form frmload)
        {
            //Kiểm tra xem có form con đang mở mà không phải form đc gọi thì đóng lại
            foreach(Form child in MdiChildren)
            {
                child.Close();
            }
            bool isLoaded = false;
            //Kiểm tra form đang gọi coi có đc mở hay chưa, nếu đã mở thì chỉ cần Acrive fomr, còn chưa thì tạo from con mới
            //Thể hiện mới và hiển thị form
            foreach(Form child in MdiChildren)
            {
                if(child.Text == frmload.Text)
                {
                    isLoaded = true;
                    frmload = child;
                    break;
                }
            }

            if(!isLoaded)
            {
                frmload.MdiParent = this;
                frmload.Location = new Point(0, 0);
                frmload.WindowState = FormWindowState.Normal;
                frmload.Show();
                frmload.Activate();
            }
            else
            {
                frmload.Activate();
            }
            
        }

        /*public void QL_menu(bool trangthai)
        {
            
            if(trangthai)
            {
               
                
                
                    ribbon_hethong.Visible = trangthai;
                    ribbon_danhmuc.Visible = !trangthai;
                    ribbon_banhang.Visible = !trangthai;
                    ribbon_baocaothongke.Visible = !trangthai;
                    ribbon_trogiup.Visible = trangthai;
                
                
            }
                
            else 
            {
                
                    ribbon_hethong.Visible = !trangthai;
                    ribbon_danhmuc.Visible = !trangthai;
                    ribbon_banhang.Visible = !trangthai;
                    ribbon_baocaothongke.Visible = !trangthai;
                    ribbon_trogiup.Visible = !trangthai;
                
            }
        }*/

        public void QL_menu(string vaitro)
        {
            if(vaitro=="1")
            {
                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = true;
                ribbon_banhang.Visible = true;
                ribbon_baocaothongke.Visible = true;
                ribbon_trogiup.Visible = true;
            }
            else if(vaitro=="2")
            {
               
                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = false;
                ribbon_banhang.Visible = true;
                ribbon_baocaothongke.Visible = true;
                ribbon_trogiup.Visible = true;
            }
            else if(vaitro=="0")
            {
                ribbon_hethong.Visible = true;
                ribbon_danhmuc.Visible = false;
                ribbon_banhang.Visible = false;
                ribbon_baocaothongke.Visible = false;
                ribbon_trogiup.Visible = true;
            }
            else if(vaitro=="")
            {
                ribbon_hethong.Visible = false;
                ribbon_danhmuc.Visible = false;
                ribbon_baocaothongke.Visible = false;
                ribbon_trogiup.Visible = true;
            }
        }

        private void btn_themnguoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_themnguoi());

        }

        private void btn_doimatkhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_doimk());
        }

        private void btn_thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_dangnhap());
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frm_Giaodien_Load(object sender, EventArgs e)
        {
            QL_menu("0");
        }

        private void frm_Giaodien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btn_saoluu_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_saoluu());
        }

        private void btn_phuchoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_phuchoi());
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_updateSP());
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_UpdateNhanVien());
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_UpdateKhachhang());
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_HoaDon());
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_PhieuChuyen());
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_thongkedoanhthu());
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            load_form(new frm_SPdcban());
        }

        private void btn_dangxuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Đăng xuát
            foreach(Form frm in this.MdiChildren)
            {
                if(!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
            frm_Giaodien_Load(sender, e);
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Hiển thị help
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            load_form(new frm_lienhe());
        }
    }
}