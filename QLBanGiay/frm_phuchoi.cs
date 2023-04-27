using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QLBanGiay
{
    public partial class frm_phuchoi : Form
    {
        public frm_phuchoi()
        {
            InitializeComponent();
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Backup File|*.bak";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txt_chonteptin.Text = openFileDialog1.FileName;
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            try
            {
                if(txt_chonteptin.Text!="")
                {
                    string file_path = txt_chonteptin.Text;
                    string sql = "use master restore database QLShopGiay from disk='" + file_path + "' with REPLACE";
                    k.thuc_thi(sql);
                    MessageBox.Show("Phục hồi thành công!", "Thông báo");
                    txt_chonteptin.ResetText();
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
