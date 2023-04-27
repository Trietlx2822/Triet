using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLBanGiay
{
    public partial class frm_inHD : Form
    {
        public string sohoadon;//dùng để nhận số hóa đơn từ from Hóa Đơn
        public frm_inHD()
        {
            InitializeComponent();
        }

        private void frm_inHD_Load(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "select HOADON.SoHD,NgayLap,NguoiLap,NgayBatDauBaoHanh,ThoiGianBaoHanh,MaKH,MaNV,SANPHAM.MaSP,TenSP,SANPHAM.TGBaoHanh,NSX,SANPHAM.SoLuong,Gia,SANPHAM.SoLuong*Gia as ThanhTien from HOADON,CTBANHANG,SANPHAM Where HOADON.SoHD=CTBANHANG.SoHD and SANPHAM.MaSP=CTBANHANG.MaSP and HOADON.SoHD='"+sohoadon+"'";
            DataTable dt_hd = k.load_bang(sql);       
            //Gọi thanh Process của window
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo cho reportviewr
            reportViewer1.LocalReport.ReportPath = "rpt_hoadon.rdlc";
            //Lấy nguồn dữ liệu cho report
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = dt_hd;
            reportViewer1.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer1.LocalReport.DataSources.Add(rds);          
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
