namespace QLBanGiay
{
    partial class frm_updateSP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_updateSP));
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.cmb_tgbaohanh = new System.Windows.Forms.ComboBox();
            this.btn_luu = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sua = new DevExpress.XtraEditors.SimpleButton();
            this.btn_them = new DevExpress.XtraEditors.SimpleButton();
            this.grid_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_sl = new System.Windows.Forms.TextBox();
            this.txt_nsx = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.txt_maSP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.grid_chitiet = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn7 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn8 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn9 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn10 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn11 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_gridColumn12 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.binding_sp = new System.Windows.Forms.BindingSource(this.components);
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitiet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(915, 604);
            this.navigationPane1.SelectedPage = this.navigationPage2;
            this.navigationPane1.SelectedPageIndex = 0;
            this.navigationPane1.Size = new System.Drawing.Size(915, 604);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "Chi Tiết Sản Phẩm";
            this.navigationPane1.SelectedPageIndexChanged += new System.EventHandler(this.navigationPane1_SelectedPageIndexChanged);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Cập nhập sản phẩm";
            this.navigationPage1.Controls.Add(this.cmb_tgbaohanh);
            this.navigationPage1.Controls.Add(this.btn_luu);
            this.navigationPage1.Controls.Add(this.btn_in);
            this.navigationPage1.Controls.Add(this.btn_thoat);
            this.navigationPage1.Controls.Add(this.btn_xoa);
            this.navigationPage1.Controls.Add(this.btn_sua);
            this.navigationPage1.Controls.Add(this.btn_them);
            this.navigationPage1.Controls.Add(this.grid_sp);
            this.navigationPage1.Controls.Add(this.txt_gia);
            this.navigationPage1.Controls.Add(this.txt_sl);
            this.navigationPage1.Controls.Add(this.txt_nsx);
            this.navigationPage1.Controls.Add(this.txt_tenSP);
            this.navigationPage1.Controls.Add(this.txt_maSP);
            this.navigationPage1.Controls.Add(this.label7);
            this.navigationPage1.Controls.Add(this.label4);
            this.navigationPage1.Controls.Add(this.label6);
            this.navigationPage1.Controls.Add(this.label3);
            this.navigationPage1.Controls.Add(this.label5);
            this.navigationPage1.Controls.Add(this.label2);
            this.navigationPage1.Controls.Add(this.label1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(750, 534);
            // 
            // cmb_tgbaohanh
            // 
            this.cmb_tgbaohanh.FormattingEnabled = true;
            this.cmb_tgbaohanh.Location = new System.Drawing.Point(179, 192);
            this.cmb_tgbaohanh.Name = "cmb_tgbaohanh";
            this.cmb_tgbaohanh.Size = new System.Drawing.Size(149, 24);
            this.cmb_tgbaohanh.TabIndex = 13;
            // 
            // btn_luu
            // 
            this.btn_luu.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu.Appearance.Options.UseFont = true;
            this.btn_luu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.Location = new System.Drawing.Point(148, 253);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(112, 62);
            this.btn_luu.TabIndex = 8;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_in
            // 
            this.btn_in.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_in.Appearance.Options.UseFont = true;
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.Location = new System.Drawing.Point(629, 253);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(100, 62);
            this.btn_in.TabIndex = 12;
            this.btn_in.Text = "In";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Appearance.Options.UseFont = true;
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(507, 253);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(105, 62);
            this.btn_thoat.TabIndex = 11;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Appearance.Options.UseFont = true;
            this.btn_xoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.Location = new System.Drawing.Point(391, 253);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(109, 62);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Appearance.Options.UseFont = true;
            this.btn_sua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.Location = new System.Drawing.Point(275, 253);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(108, 62);
            this.btn_sua.TabIndex = 9;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Appearance.Options.UseFont = true;
            this.btn_them.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.Location = new System.Drawing.Point(27, 253);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(108, 62);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // grid_sp
            // 
            this.grid_sp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid_sp.Location = new System.Drawing.Point(0, 334);
            this.grid_sp.MainView = this.gridView1;
            this.grid_sp.Name = "grid_sp";
            this.grid_sp.Size = new System.Drawing.Size(750, 200);
            this.grid_sp.TabIndex = 6;
            this.grid_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.grid_sp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfPageFooter = resources.GetString("gridView1.OptionsPrint.RtfPageFooter");
            this.gridView1.OptionsPrint.RtfPageHeader = resources.GetString("gridView1.OptionsPrint.RtfPageHeader");
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã sản phẩm";
            this.gridColumn1.FieldName = "MaSP";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên sản phẩm";
            this.gridColumn2.FieldName = "TenSP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian bảo hành";
            this.gridColumn3.FieldName = "TGBaoHanh";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Nhà sản xuất";
            this.gridColumn4.FieldName = "NSX";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Số lượng";
            this.gridColumn5.FieldName = "SoLuong";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Giá";
            this.gridColumn6.FieldName = "Gia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // txt_gia
            // 
            this.txt_gia.Location = new System.Drawing.Point(518, 194);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(147, 22);
            this.txt_gia.TabIndex = 6;
            // 
            // txt_sl
            // 
            this.txt_sl.Location = new System.Drawing.Point(518, 134);
            this.txt_sl.Name = "txt_sl";
            this.txt_sl.Size = new System.Drawing.Size(147, 22);
            this.txt_sl.TabIndex = 5;
            // 
            // txt_nsx
            // 
            this.txt_nsx.Location = new System.Drawing.Point(518, 77);
            this.txt_nsx.Name = "txt_nsx";
            this.txt_nsx.Size = new System.Drawing.Size(147, 22);
            this.txt_nsx.TabIndex = 4;
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Location = new System.Drawing.Point(179, 132);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(147, 22);
            this.txt_tenSP.TabIndex = 2;
            // 
            // txt_maSP
            // 
            this.txt_maSP.Location = new System.Drawing.Point(179, 75);
            this.txt_maSP.Name = "txt_maSP";
            this.txt_maSP.Size = new System.Drawing.Size(147, 22);
            this.txt_maSP.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(392, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(22, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thời gian bảo hành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(392, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(392, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(31, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(192, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN SẢN PHẨM";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Chi Tiết Sản Phẩm";
            this.navigationPage2.Controls.Add(this.grid_chitiet);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(750, 534);
            // 
            // grid_chitiet
            // 
            this.grid_chitiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_chitiet.Location = new System.Drawing.Point(0, 0);
            this.grid_chitiet.MainView = this.layoutView1;
            this.grid_chitiet.Name = "grid_chitiet";
            this.grid_chitiet.Size = new System.Drawing.Size(750, 534);
            this.grid_chitiet.TabIndex = 0;
            this.grid_chitiet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.layoutView1.GridControl = this.grid_chitiet;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard2;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Mã Sản Phẩm";
            this.gridColumn7.FieldName = "MaSP";
            this.gridColumn7.LayoutViewField = this.layoutViewField_gridColumn7;
            this.gridColumn7.Name = "gridColumn7";
            // 
            // layoutViewField_gridColumn7
            // 
            this.layoutViewField_gridColumn7.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn7.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_gridColumn7.Name = "layoutViewField_gridColumn7";
            this.layoutViewField_gridColumn7.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn7.TextSize = new System.Drawing.Size(124, 17);
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Tên Sản Phẩm";
            this.gridColumn8.FieldName = "TenSP";
            this.gridColumn8.LayoutViewField = this.layoutViewField_gridColumn8;
            this.gridColumn8.Name = "gridColumn8";
            // 
            // layoutViewField_gridColumn8
            // 
            this.layoutViewField_gridColumn8.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn8.Location = new System.Drawing.Point(0, 28);
            this.layoutViewField_gridColumn8.Name = "layoutViewField_gridColumn8";
            this.layoutViewField_gridColumn8.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn8.TextSize = new System.Drawing.Size(124, 17);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Thời Gian Bảo Hành";
            this.gridColumn9.FieldName = "TGBaoHanh";
            this.gridColumn9.LayoutViewField = this.layoutViewField_gridColumn9;
            this.gridColumn9.Name = "gridColumn9";
            // 
            // layoutViewField_gridColumn9
            // 
            this.layoutViewField_gridColumn9.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn9.Location = new System.Drawing.Point(0, 56);
            this.layoutViewField_gridColumn9.Name = "layoutViewField_gridColumn9";
            this.layoutViewField_gridColumn9.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn9.TextSize = new System.Drawing.Size(124, 17);
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Nhà Sản Xuất";
            this.gridColumn10.FieldName = "NSX";
            this.gridColumn10.LayoutViewField = this.layoutViewField_gridColumn10;
            this.gridColumn10.Name = "gridColumn10";
            // 
            // layoutViewField_gridColumn10
            // 
            this.layoutViewField_gridColumn10.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn10.Location = new System.Drawing.Point(0, 84);
            this.layoutViewField_gridColumn10.Name = "layoutViewField_gridColumn10";
            this.layoutViewField_gridColumn10.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn10.TextSize = new System.Drawing.Size(124, 17);
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Số Lượng";
            this.gridColumn11.FieldName = "SoLuong";
            this.gridColumn11.LayoutViewField = this.layoutViewField_gridColumn11;
            this.gridColumn11.Name = "gridColumn11";
            // 
            // layoutViewField_gridColumn11
            // 
            this.layoutViewField_gridColumn11.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn11.Location = new System.Drawing.Point(0, 112);
            this.layoutViewField_gridColumn11.Name = "layoutViewField_gridColumn11";
            this.layoutViewField_gridColumn11.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn11.TextSize = new System.Drawing.Size(124, 17);
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Giá";
            this.gridColumn12.FieldName = "Gia";
            this.gridColumn12.LayoutViewField = this.layoutViewField_gridColumn12;
            this.gridColumn12.Name = "gridColumn12";
            // 
            // layoutViewField_gridColumn12
            // 
            this.layoutViewField_gridColumn12.EditorPreferredWidth = 71;
            this.layoutViewField_gridColumn12.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_gridColumn12.Name = "layoutViewField_gridColumn12";
            this.layoutViewField_gridColumn12.Size = new System.Drawing.Size(206, 28);
            this.layoutViewField_gridColumn12.TextSize = new System.Drawing.Size(124, 16);
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_gridColumn7,
            this.layoutViewField_gridColumn8,
            this.layoutViewField_gridColumn9,
            this.layoutViewField_gridColumn10,
            this.layoutViewField_gridColumn11,
            this.layoutViewField_gridColumn12});
            this.layoutViewCard2.Name = "layoutViewCard2";
            this.layoutViewCard2.OptionsItemText.TextToControlDistance = 4;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 4;
            // 
            // frm_updateSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 604);
            this.Controls.Add(this.navigationPane1);
            this.Name = "frm_updateSP";
            this.Text = "Cập nhập sản phẩm";
            this.Load += new System.EventHandler(this.frm_updateSP_Load);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_chitiet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_gridColumn12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binding_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_sl;
        private System.Windows.Forms.TextBox txt_nsx;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.TextBox txt_maSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource binding_sp;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraGrid.GridControl grid_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_xoa;
        private DevExpress.XtraEditors.SimpleButton btn_sua;
        private DevExpress.XtraEditors.SimpleButton btn_them;
        private DevExpress.XtraEditors.SimpleButton btn_luu;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private System.Windows.Forms.ComboBox cmb_tgbaohanh;
        private DevExpress.XtraGrid.GridControl grid_chitiet;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn7;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn8;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn8;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn9;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn9;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn10;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn10;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn11;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn11;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn gridColumn12;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_gridColumn12;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;

    }
}