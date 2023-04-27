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
    public partial class frm_themnguoi : Form
    {
        public frm_themnguoi()
        {
            InitializeComponent();
        }
       
        public void load_phanquyen()
        {
            KetNoi k = new KetNoi();
            cmb_phanquyen.DataSource = k.load_bang("Select distinct Quyen from User_ID");
            cmb_phanquyen.ValueMember = "Quyen";
            cmb_phanquyen.DisplayMember = "Quyen";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            //Kiểm tra tài khoản có tôn tại chưa
            string caulenh = "select * from User_ID where TenDN='" + txt_tenDN.Text + "'";
            KetNoi h = new KetNoi();
            DataTable dt = h.load_bang(caulenh);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo");
                txt_tenDN.Text = "";
                txt_tenDN.Focus();
                txt_MK.Text = "";
            }
            else
            {
                string sql = "insert into User_ID values('" + txt_tenDN.Text + "','" + txt_MK.Text + "','"+cmb_phanquyen.SelectedValue+"')";
                try
                { 
                    KetNoi k = new KetNoi();
                    int dong= k.thuc_thi(sql);
                    if(dong>0)             
                    
                        MessageBox.Show("Bạn thêm người dùng thành công", "thông báo");
                    
                    else
                        MessageBox.Show("Thêm người dùng không thành công", "thông báo");
                }
                catch(Exception)
                {
                    MessageBox.Show("Lỗi SQL","Thông báo");
                }
            }
        }
        private void frm_themnguoi_Load(object sender, EventArgs e)
        {
            load_phanquyen();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
        }
    }

