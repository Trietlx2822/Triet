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
    
    public partial class frm_InPhieuChuyen : Form
    {
        public string sophieuchuyen;//dùng để nhận số hóa đơn từ from Hóa Đơn
        public frm_InPhieuChuyen()
        {
            InitializeComponent();
        }

        private void frm_InPhieuChuyen_Load(object sender, EventArgs e)
        {
            KetNoi k = new KetNoi();
            string sql = "select distinct PHIEUCHUYEN.SoPhieuChuyen,TinhTrangChuyen,NgayChuyen,PHIEUCHUYEN.MaNV,PHIEUCHUYEN.SoHD,KHACHHANG.TenKH,KHACHHANG.DCKH,KHACHHANG.SDT,SANPHAM.MaSP,TenSP,SANPHAM.TGBaoHanh,NSX,SANPHAM.SoLuong,Gia,SANPHAM.SoLuong*Gia as ThanhTien from PHIEUCHUYEN,CT_PhieuChuyen,SANPHAM,KHACHHANG ";
            //Where PHIEUCHUYEN.SoPhieuChuyen=CT_PhieuChuyen.SoPhieuChuyen and SANPHAM.MaSP=CT_PhieuChuyen.MaSP and PHIEUCHUYEN.SoPhieuChuyen='"+sophieuchuyen+"'";
            DataTable dt_hd = k.load_bang(sql);
            //Gọi thanh Process của window
            reportViewer_PC.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo cho reportviewr
            reportViewer_PC.LocalReport.ReportPath = "rpt_phieuchuyen.rdlc";
            //Lấy nguồn dữ liệu cho report
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet_CTPC";
            rds.Value = dt_hd;
            reportViewer_PC.LocalReport.DataSources.Clear();
            //Add dữ liệu vào báo cáo
            reportViewer_PC.LocalReport.DataSources.Add(rds);       
            this.reportViewer_PC.RefreshReport();
        }
    }
}
