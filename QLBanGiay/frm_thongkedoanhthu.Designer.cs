namespace QLBanGiay
{
    partial class frm_thongkedoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_thongkedoanhthu));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xemthongke = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_theonam = new System.Windows.Forms.ComboBox();
            this.cmb_theothang = new System.Windows.Forms.ComboBox();
            this.dateTime_denngay = new System.Windows.Forms.DateTimePicker();
            this.dateTime_tungay = new System.Windows.Forms.DateTimePicker();
            this.dateTime_theongay = new System.Windows.Forms.DateTimePicker();
            this.rdb_tungay = new System.Windows.Forms.RadioButton();
            this.rdb_theothang = new System.Windows.Forms.RadioButton();
            this.rdb_theongay = new System.Windows.Forms.RadioButton();
            this.grid_doanhthu = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_doanhthu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(478, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_in);
            this.groupBox1.Controls.Add(this.btn_xemthongke);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_theonam);
            this.groupBox1.Controls.Add(this.cmb_theothang);
            this.groupBox1.Controls.Add(this.dateTime_denngay);
            this.groupBox1.Controls.Add(this.dateTime_tungay);
            this.groupBox1.Controls.Add(this.dateTime_theongay);
            this.groupBox1.Controls.Add(this.rdb_tungay);
            this.groupBox1.Controls.Add(this.rdb_theothang);
            this.groupBox1.Controls.Add(this.rdb_theongay);
            this.groupBox1.Location = new System.Drawing.Point(37, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1226, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_thoat
            // 
            this.btn_thoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(799, 198);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(137, 58);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.Location = new System.Drawing.Point(568, 198);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(137, 58);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "IN";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_xemthongke
            // 
            this.btn_xemthongke.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.btn_xemthongke.Image = ((System.Drawing.Image)(resources.GetObject("btn_xemthongke.Image")));
            this.btn_xemthongke.Location = new System.Drawing.Point(278, 198);
            this.btn_xemthongke.Name = "btn_xemthongke";
            this.btn_xemthongke.Size = new System.Drawing.Size(198, 58);
            this.btn_xemthongke.TabIndex = 4;
            this.btn_xemthongke.Text = "XEM THÔNG KÊ";
            this.btn_xemthongke.Click += new System.EventHandler(this.btn_xemthongke_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // cmb_theonam
            // 
            this.cmb_theonam.FormattingEnabled = true;
            this.cmb_theonam.Location = new System.Drawing.Point(655, 90);
            this.cmb_theonam.Name = "cmb_theonam";
            this.cmb_theonam.Size = new System.Drawing.Size(135, 24);
            this.cmb_theonam.TabIndex = 2;
            // 
            // cmb_theothang
            // 
            this.cmb_theothang.FormattingEnabled = true;
            this.cmb_theothang.Location = new System.Drawing.Point(458, 90);
            this.cmb_theothang.Name = "cmb_theothang";
            this.cmb_theothang.Size = new System.Drawing.Size(135, 24);
            this.cmb_theothang.TabIndex = 2;
            // 
            // dateTime_denngay
            // 
            this.dateTime_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_denngay.Location = new System.Drawing.Point(724, 138);
            this.dateTime_denngay.Name = "dateTime_denngay";
            this.dateTime_denngay.Size = new System.Drawing.Size(108, 22);
            this.dateTime_denngay.TabIndex = 1;
            // 
            // dateTime_tungay
            // 
            this.dateTime_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_tungay.Location = new System.Drawing.Point(489, 138);
            this.dateTime_tungay.Name = "dateTime_tungay";
            this.dateTime_tungay.Size = new System.Drawing.Size(118, 22);
            this.dateTime_tungay.TabIndex = 1;
            // 
            // dateTime_theongay
            // 
            this.dateTime_theongay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_theongay.Location = new System.Drawing.Point(458, 43);
            this.dateTime_theongay.Name = "dateTime_theongay";
            this.dateTime_theongay.Size = new System.Drawing.Size(135, 22);
            this.dateTime_theongay.TabIndex = 1;
            // 
            // rdb_tungay
            // 
            this.rdb_tungay.AutoSize = true;
            this.rdb_tungay.Checked = true;
            this.rdb_tungay.Location = new System.Drawing.Point(343, 138);
            this.rdb_tungay.Name = "rdb_tungay";
            this.rdb_tungay.Size = new System.Drawing.Size(140, 21);
            this.rdb_tungay.TabIndex = 0;
            this.rdb_tungay.TabStop = true;
            this.rdb_tungay.Text = "Thống kê từ ngày";
            this.rdb_tungay.UseVisualStyleBackColor = true;
            // 
            // rdb_theothang
            // 
            this.rdb_theothang.AutoSize = true;
            this.rdb_theothang.Location = new System.Drawing.Point(343, 91);
            this.rdb_theothang.Name = "rdb_theothang";
            this.rdb_theothang.Size = new System.Drawing.Size(107, 21);
            this.rdb_theothang.TabIndex = 0;
            this.rdb_theothang.Text = "Theo Tháng";
            this.rdb_theothang.UseVisualStyleBackColor = true;
            // 
            // rdb_theongay
            // 
            this.rdb_theongay.AutoSize = true;
            this.rdb_theongay.Location = new System.Drawing.Point(343, 46);
            this.rdb_theongay.Name = "rdb_theongay";
            this.rdb_theongay.Size = new System.Drawing.Size(99, 21);
            this.rdb_theongay.TabIndex = 0;
            this.rdb_theongay.Text = "Theo Ngày";
            this.rdb_theongay.UseVisualStyleBackColor = true;
            this.rdb_theongay.CheckedChanged += new System.EventHandler(this.rdb_theongay_CheckedChanged);
            // 
            // grid_doanhthu
            // 
            this.grid_doanhthu.Location = new System.Drawing.Point(37, 361);
            this.grid_doanhthu.MainView = this.gridView1;
            this.grid_doanhthu.Name = "grid_doanhthu";
            this.grid_doanhthu.Size = new System.Drawing.Size(1226, 200);
            this.grid_doanhthu.TabIndex = 2;
            this.grid_doanhthu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.grid_doanhthu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfPageFooter = resources.GetString("gridView1.OptionsPrint.RtfPageFooter");
            this.gridView1.OptionsPrint.RtfPageHeader = resources.GetString("gridView1.OptionsPrint.RtfPageHeader");
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số hóa đơn";
            this.gridColumn1.FieldName = "SoHD";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Mã sản phẩm";
            this.gridColumn2.FieldName = "MaSP";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Tên sản phẩm";
            this.gridColumn3.FieldName = "TenSP";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Đơn giá";
            this.gridColumn4.FieldName = "Gia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Sô lượng";
            this.gridColumn5.FieldName = "SoLuong";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Thành Tiền";
            this.gridColumn6.FieldName = "ThanhTien";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ThanhTien", "Tổng tiền={0:0.##}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frm_thongkedoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 571);
            this.Controls.Add(this.grid_doanhthu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_thongkedoanhthu";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frm_thongkedoanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_doanhthu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_xemthongke;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_theonam;
        private System.Windows.Forms.ComboBox cmb_theothang;
        private System.Windows.Forms.DateTimePicker dateTime_denngay;
        private System.Windows.Forms.DateTimePicker dateTime_tungay;
        private System.Windows.Forms.DateTimePicker dateTime_theongay;
        private System.Windows.Forms.RadioButton rdb_tungay;
        private System.Windows.Forms.RadioButton rdb_theothang;
        private System.Windows.Forms.RadioButton rdb_theongay;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraGrid.GridControl grid_doanhthu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}