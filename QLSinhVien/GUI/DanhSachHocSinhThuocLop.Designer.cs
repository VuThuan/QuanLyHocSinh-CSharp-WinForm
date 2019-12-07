namespace qlhocvien.GUI
{
    partial class DanhSachHocSinhThuocLop
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
            this.showDanhSachHS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.showDanhSachHS)).BeginInit();
            this.SuspendLayout();
            // 
            // showDanhSachHS
            // 
            this.showDanhSachHS.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showDanhSachHS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDanhSachHS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showDanhSachHS.Location = new System.Drawing.Point(0, 4);
            this.showDanhSachHS.Name = "showDanhSachHS";
            this.showDanhSachHS.Size = new System.Drawing.Size(479, 224);
            this.showDanhSachHS.TabIndex = 52;
            // 
            // DanhSachHocSinhThuocLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 228);
            this.Controls.Add(this.showDanhSachHS);
            this.MaximizeBox = false;
            this.Name = "DanhSachHocSinhThuocLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachHocSinhThuocLop";
            this.Load += new System.EventHandler(this.DanhSachHocSinhThuocLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDanhSachHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showDanhSachHS;
    }
}