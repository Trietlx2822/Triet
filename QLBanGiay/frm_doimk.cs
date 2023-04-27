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
    public partial class frm_doimk : Form
    {
        public frm_doimk()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MINH-TRIET;Initial Catalog=QLShopGiay;Integrated Security=True");
        private void btn_doi_Click(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter("Select count (*) From User_ID Where TenDN='" + txt_tendndoimk.Text + "'and MatKhau='" + txt_mkcu.Text + "'",conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
            {
                if(txt_mkmoi.Text==txt_nhaplai.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("Update User_ID set MatKhau=N'"+txt_mkmoi.Text+"'Where TenDN=N'"+txt_tendndoimk.Text+"'and MatKhau=N'"+txt_mkcu.Text+"'",conn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công!","Thông Báo!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }    
                else 
                {
                    errorProvider.SetError(txt_mkmoi, "Bạn chưa điền mật khẩu!");
                    errorProvider.SetError(txt_nhaplai, "Mật khẩu nhập lại chưa đúng!");
                }
            }
                else
                {
                errorProvider.SetError(txt_tendndoimk,"Tên người dùng không đúng!");
                errorProvider.SetError(txt_mkcu,"Mật khẩu cũ không đúng!");
                }
                
            }

        private void frm_doimk_Load(object sender, EventArgs e)
        {

        }
            
        }
    }

