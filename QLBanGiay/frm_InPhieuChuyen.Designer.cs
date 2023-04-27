namespace QLBanGiay
{
    partial class frm_InPhieuChuyen
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
            this.reportViewer_PC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer_PC
            // 
            this.reportViewer_PC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_PC.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_PC.Name = "reportViewer_PC";
            this.reportViewer_PC.Size = new System.Drawing.Size(960, 555);
            this.reportViewer_PC.TabIndex = 0;
            // 
            // frm_InPhieuChuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 555);
            this.Controls.Add(this.reportViewer_PC);
            this.Name = "frm_InPhieuChuyen";
            this.Text = "frm_InPhieuChuyen";
            this.Load += new System.EventHandler(this.frm_InPhieuChuyen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_PC;
    }
}