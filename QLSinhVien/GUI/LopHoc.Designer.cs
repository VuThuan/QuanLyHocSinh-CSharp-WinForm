namespace QLHocSinh
{
	partial class LopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LopHoc));
            this.showdatalophoc = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsua = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGVCN = new System.Windows.Forms.TextBox();
            this.btnThemLH = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaLH = new DevComponents.DotNetBar.ButtonX();
            this.btnShowDSLop = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaLH = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.showdatalophoc)).BeginInit();
            this.SuspendLayout();
            // 
            // showdatalophoc
            // 
            this.showdatalophoc.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showdatalophoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatalophoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdatalophoc.Location = new System.Drawing.Point(0, 173);
            this.showdatalophoc.Name = "showdatalophoc";
            this.showdatalophoc.Size = new System.Drawing.Size(435, 182);
            this.showdatalophoc.TabIndex = 0;
            this.showdatalophoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatakhoa_CellClick);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(95, 15);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(218, 20);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(95, 57);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(218, 20);
            this.txtTenLop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Lớp";
            // 
            // btsua
            // 
            this.btsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsua.Location = new System.Drawing.Point(0, 0);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(0, 0);
            this.btsua.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 14);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã GVCN";
            // 
            // txtMaGVCN
            // 
            this.txtMaGVCN.Location = new System.Drawing.Point(95, 101);
            this.txtMaGVCN.Name = "txtMaGVCN";
            this.txtMaGVCN.Size = new System.Drawing.Size(218, 20);
            this.txtMaGVCN.TabIndex = 26;
            // 
            // btnThemLH
            // 
            this.btnThemLH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemLH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThemLH.Image = global::qlhocvien.Properties.Resources.add;
            this.btnThemLH.Location = new System.Drawing.Point(335, 15);
            this.btnThemLH.Name = "btnThemLH";
            this.btnThemLH.Size = new System.Drawing.Size(94, 30);
            this.btnThemLH.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnThemLH.TabIndex = 51;
            this.btnThemLH.Text = "Thêm";
            this.btnThemLH.Click += new System.EventHandler(this.btnThemLH_Click);
            // 
            // btnXoaLH
            // 
            this.btnXoaLH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaLH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoaLH.Image = global::qlhocvien.Properties.Resources.delete;
            this.btnXoaLH.Location = new System.Drawing.Point(335, 101);
            this.btnXoaLH.Name = "btnXoaLH";
            this.btnXoaLH.Size = new System.Drawing.Size(94, 30);
            this.btnXoaLH.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXoaLH.TabIndex = 50;
            this.btnXoaLH.Text = " Xóa";
            this.btnXoaLH.Click += new System.EventHandler(this.btnXoaLH_Click);
            // 
            // btnShowDSLop
            // 
            this.btnShowDSLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowDSLop.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnShowDSLop.Image = global::qlhocvien.Properties.Resources.users;
            this.btnShowDSLop.Location = new System.Drawing.Point(138, 127);
            this.btnShowDSLop.Name = "btnShowDSLop";
            this.btnShowDSLop.Size = new System.Drawing.Size(145, 40);
            this.btnShowDSLop.TabIndex = 49;
            this.btnShowDSLop.Text = "Xem  Danh Sach";
            this.btnShowDSLop.Click += new System.EventHandler(this.btnShowDSLop_Click);
            // 
            // btnSuaLH
            // 
            this.btnSuaLH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaLH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSuaLH.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btnSuaLH.Location = new System.Drawing.Point(335, 57);
            this.btnSuaLH.Name = "btnSuaLH";
            this.btnSuaLH.Size = new System.Drawing.Size(94, 30);
            this.btnSuaLH.TabIndex = 48;
            this.btnSuaLH.Text = "Sửa";
            this.btnSuaLH.Click += new System.EventHandler(this.btnSuaLH_Click);
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 355);
            this.Controls.Add(this.btnThemLH);
            this.Controls.Add(this.btnXoaLH);
            this.Controls.Add(this.btnShowDSLop);
            this.Controls.Add(this.btnSuaLH);
            this.Controls.Add(this.txtMaGVCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.showdatalophoc);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp Học";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdatalophoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView showdatalophoc;
		private System.Windows.Forms.TextBox txtMaLop;
		private System.Windows.Forms.TextBox txtTenLop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DevComponents.DotNetBar.ButtonX btsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGVCN;
        private DevComponents.DotNetBar.ButtonX btnThemLH;
        private DevComponents.DotNetBar.ButtonX btnXoaLH;
        private DevComponents.DotNetBar.ButtonX btnShowDSLop;
        private DevComponents.DotNetBar.ButtonX btnSuaLH;
    }
}