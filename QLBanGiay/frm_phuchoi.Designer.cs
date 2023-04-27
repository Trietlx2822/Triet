namespace QLBanGiay
{
    partial class frm_phuchoi
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
            this.txt_chonteptin = new System.Windows.Forms.TextBox();
            this.btn_chon = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_dongy = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(182, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phục hồi dữ liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn tệp tin:";
            // 
            // txt_chonteptin
            // 
            this.txt_chonteptin.Location = new System.Drawing.Point(192, 100);
            this.txt_chonteptin.Name = "txt_chonteptin";
            this.txt_chonteptin.Size = new System.Drawing.Size(213, 22);
            this.txt_chonteptin.TabIndex = 2;
            // 
            // btn_chon
            // 
            this.btn_chon.Location = new System.Drawing.Point(426, 83);
            this.btn_chon.Name = "btn_chon";
            this.btn_chon.Size = new System.Drawing.Size(80, 57);
            this.btn_chon.TabIndex = 3;
            this.btn_chon.Text = "Chọn";
            this.btn_chon.UseVisualStyleBackColor = true;
            this.btn_chon.Click += new System.EventHandler(this.btn_chon_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_dongy
            // 
            this.btn_dongy.Location = new System.Drawing.Point(152, 186);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.Size = new System.Drawing.Size(76, 50);
            this.btn_dongy.TabIndex = 4;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.UseVisualStyleBackColor = true;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(329, 186);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(76, 50);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // frm_phuchoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 292);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.btn_chon);
            this.Controls.Add(this.txt_chonteptin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_phuchoi";
            this.Text = "Phục hồi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_chonteptin;
        private System.Windows.Forms.Button btn_chon;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_dongy;
        private System.Windows.Forms.Button btn_thoat;
    }
}