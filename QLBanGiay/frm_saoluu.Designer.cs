namespace QLBanGiay
{
    partial class frm_saoluu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_đuongdan = new System.Windows.Forms.TextBox();
            this.txt_teptin = new System.Windows.Forms.TextBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.btn_dongy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(226, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sao lưu dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(90, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đường dẫn: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(90, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên tệp tin: ";
            // 
            // txt_đuongdan
            // 
            this.txt_đuongdan.Location = new System.Drawing.Point(195, 105);
            this.txt_đuongdan.Name = "txt_đuongdan";
            this.txt_đuongdan.Size = new System.Drawing.Size(314, 22);
            this.txt_đuongdan.TabIndex = 1;
            // 
            // txt_teptin
            // 
            this.txt_teptin.Location = new System.Drawing.Point(195, 167);
            this.txt_teptin.Name = "txt_teptin";
            this.txt_teptin.Size = new System.Drawing.Size(314, 22);
            this.txt_teptin.TabIndex = 2;
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(548, 93);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(75, 46);
            this.btn_chon.TabIndex = 5;
            this.btn_chon.Text = "Chọn..";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // btn_dongy
            // 
            this.btn_dongy.Location = new System.Drawing.Point(195, 255);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(75, 46);
            this.btn_dongy.TabIndex = 3;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.UseVisualStyleBackColor = true;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(358, 255);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 46);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_saoluu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 373);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.txt_teptin);
            this.Controls.Add(this.txt_đuongdan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_saoluu";
            this.Text = "Sao lưu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_đuongdan;
        private System.Windows.Forms.TextBox txt_teptin;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.Button btn_dongy;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}