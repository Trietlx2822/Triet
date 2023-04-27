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
    public partial class frm_saoluu : Form
    {
        public frm_saoluu()
        {
            InitializeComponent();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                txt_đuongdan.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            try
            {
                if(txt_đuongdan.Text!=""&&txt_teptin.Text!="")
                {
                    string file_path = txt_đuongdan.Text + "\\" + txt_teptin.Text + ".bak";
                    string sql = "backup database QLShopGiay to disk = '" + file_path + "'";
                    k.thuc_thi(sql);
                    MessageBox.Show("Sao lưu thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông tin");
                }
            }
            catch(Exception epx)
            {
                MessageBox.Show(epx.ToString(), "Lỗi SQL");
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();
        }
    }
}
