using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanGiay
{
    public partial class frm_dangnhap : Form
    {
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        public void load_phanquyen()
        {
            KetNoi k = new KetNoi();
            cmb_phanquyen.DataSource=k.load_bang("select distinct Quyen from User_ID");
            cmb_phanquyen.DisplayMember = "Quyen";
            cmb_phanquyen.ValueMember = "Quyen";
        }
        private void btnr_dangnhap_Click(object sender, EventArgs e)
        {
            if(txt_dangnhap.Text==""|| txt_matkhau.Text=="")
                MessageBox.Show("Bạn chưa nhập tên hoặc mật khẩu!", "Thông Báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                KetNoi k = new KetNoi();
                DataTable dt = k.load_bang("select * from User_ID where TenDN='"+txt_dangnhap.Text+"' and MatKhau='"+txt_matkhau.Text+"'");
                    if(dt.Rows.Count>0)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông Báo!");
                        txt_dangnhap.ResetText();
                        txt_matkhau.ResetText();
                        //Xữ lý quản lý menu
                        if(cmb_phanquyen.Text=="1")
                        {
                            frm_Giaodien frm = (frm_Giaodien)this.MdiParent;
                            frm.QL_menu("1");
                            MessageBox.Show("Đăng nhập thành công với quyền Admin!", "Thông Báo!");
                        }
                        else if(cmb_phanquyen.Text=="2")
                        {
                            frm_Giaodien frm = (frm_Giaodien)this.MdiParent;
                            frm.QL_menu("2");
                            MessageBox.Show("Đăng nhập thành công với quyền nhân viên!", "Thông Báo!");
                        }
                        frm_dangnhap f = new frm_dangnhap();
                        f.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại!","Thông Báo!");
                        txt_dangnhap.ResetText();
                        txt_matkhau.ResetText();
                        txt_dangnhap.Focus();

                        frm_Giaodien frm = (frm_Giaodien)this.MdiParent;
                        frm.QL_menu("0");
                    }
                    
            }
        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frm_themnguoi f = new frm_themnguoi();
            f.ShowDialog();
        }

        private void frm_dangnhap_Load(object sender, EventArgs e)
        {
            load_phanquyen();
        }
    }
}
