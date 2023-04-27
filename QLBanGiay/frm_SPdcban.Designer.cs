namespace QLBanGiay
{
    partial class frm_SPdcban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SPdcban));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_in = new DevExpress.XtraEditors.SimpleButton();
            this.btn_all = new DevExpress.XtraEditors.SimpleButton();
            this.btn_xem = new DevExpress.XtraEditors.SimpleButton();
            this.rdb_spbancham = new System.Windows.Forms.RadioButton();
            this.rdb_spbanchay = new System.Windows.Forms.RadioButton();
            this.grid_sp = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(335, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM ĐƯỢC BÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_in);
            this.groupBox1.Controls.Add(this.btn_all);
            this.groupBox1.Controls.Add(this.btn_xem);
            this.groupBox1.Controls.Add(this.rdb_spbancham);
            this.groupBox1.Controls.Add(this.rdb_spbanchay);
            this.groupBox1.Location = new System.Drawing.Point(76, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 294);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.Location = new System.Drawing.Point(519, 213);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(106, 75);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "THOÁT";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_in
            // 
            this.btn_in.Image = ((System.Drawing.Image)(resources.GetObject("btn_in.Image")));
            this.btn_in.Location = new System.Drawing.Point(519, 120);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(106, 76);
            this.btn_in.TabIndex = 5;
            this.btn_in.Text = "IN";
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_all
            // 
            this.btn_all.Image = ((System.Drawing.Image)(resources.GetObject("btn_all.Image")));
            this.btn_all.Location = new System.Drawing.Point(489, 28);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(167, 73);
            this.btn_all.TabIndex = 4;
            this.btn_all.Text = "Tất cả sản phẩm";
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_xem
            // 
            this.btn_xem.Image = ((System.Drawing.Image)(resources.GetObject("btn_xem.Image")));
            this.btn_xem.Location = new System.Drawing.Point(299, 108);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(107, 62);
            this.btn_xem.TabIndex = 3;
            this.btn_xem.Text = "XEM";
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // rdb_spbancham
            // 
            this.rdb_spbancham.AutoSize = true;
            this.rdb_spbancham.Location = new System.Drawing.Point(116, 149);
            this.rdb_spbancham.Name = "rdb_spbancham";
            this.rdb_spbancham.Size = new System.Drawing.Size(159, 21);
            this.rdb_spbancham.TabIndex = 2;
            this.rdb_spbancham.TabStop = true;
            this.rdb_spbancham.Text = "Sản phẩm bán chậm";
            this.rdb_spbancham.UseVisualStyleBackColor = true;
            // 
            // rdb_spbanchay
            // 
            this.rdb_spbanchay.AutoSize = true;
            this.rdb_spbanchay.Location = new System.Drawing.Point(116, 108);
            this.rdb_spbanchay.Name = "rdb_spbanchay";
            this.rdb_spbanchay.Size = new System.Drawing.Size(155, 21);
            this.rdb_spbanchay.TabIndex = 2;
            this.rdb_spbanchay.TabStop = true;
            this.rdb_spbanchay.Text = "Sản phẩm bán chạy";
            this.rdb_spbanchay.UseVisualStyleBackColor = true;
            // 
            // grid_sp
            // 
            this.grid_sp.Location = new System.Drawing.Point(76, 430);
            this.grid_sp.MainView = this.gridView1;
            this.grid_sp.Name = "grid_sp";
            this.grid_sp.Size = new System.Drawing.Size(858, 200);
            this.grid_sp.TabIndex = 2;
            this.grid_sp.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grid_sp;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.RtfPageFooter = resources.GetString("gridView1.OptionsPrint.RtfPageFooter");
            this.gridView1.OptionsPrint.RtfPageHeader = resources.GetString("gridView1.OptionsPrint.RtfPageHeader");
            // 
            // frm_SPdcban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 618);
            this.Controls.Add(this.grid_sp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_SPdcban";
            this.Text = "Sản phẩm dược bán";
            this.Load += new System.EventHandler(this.frm_SPTonKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_sp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.SimpleButton btn_in;
        private DevExpress.XtraEditors.SimpleButton btn_all;
        private DevExpress.XtraEditors.SimpleButton btn_xem;
        private System.Windows.Forms.RadioButton rdb_spbancham;
        private System.Windows.Forms.RadioButton rdb_spbanchay;
        private DevExpress.XtraGrid.GridControl grid_sp;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}