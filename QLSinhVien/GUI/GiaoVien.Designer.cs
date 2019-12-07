namespace QLHocSinh
{
	partial class GiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiangVien));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTuoiGV = new System.Windows.Forms.TextBox();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearchGV = new DevComponents.DotNetBar.ButtonX();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowDS = new DevComponents.DotNetBar.ButtonX();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.showdatagv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagv)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox4.Controls.Add(this.txtDiaChiGV);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTuoiGV);
            this.groupBox4.Controls.Add(this.btnThem);
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.btnShowDS);
            this.groupBox4.Controls.Add(this.txtTenGV);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtMaGV);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Location = new System.Drawing.Point(-4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 227);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Giáo Viên";
            // 
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(106, 131);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(145, 20);
            this.txtDiaChiGV.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Địa Chỉ";
            // 
            // txtTuoiGV
            // 
            this.txtTuoiGV.Location = new System.Drawing.Point(107, 101);
            this.txtTuoiGV.Name = "txtTuoiGV";
            this.txtTuoiGV.Size = new System.Drawing.Size(145, 20);
            this.txtTuoiGV.TabIndex = 48;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThem.Image = global::qlhocvien.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(19, 181);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.Btthem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoa.Image = global::qlhocvien.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(258, 181);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSearch);
            this.groupBox1.Controls.Add(this.btnSearchGV);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(276, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Giáo Viên";
            // 
            // cbSearch
            // 
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Items.AddRange(new object[] {
            "Tìm Theo Mã Giáo Viên",
            "Tìm Theo Tên Giáo Viên"});
            this.cbSearch.Location = new System.Drawing.Point(40, 31);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(145, 21);
            this.cbSearch.TabIndex = 43;
            this.cbSearch.Text = "Chọn";
            // 
            // btnSearchGV
            // 
            this.btnSearchGV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchGV.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSearchGV.Image = global::qlhocvien.Properties.Resources.search_user;
            this.btnSearchGV.Location = new System.Drawing.Point(128, 69);
            this.btnSearchGV.Name = "btnSearchGV";
            this.btnSearchGV.Size = new System.Drawing.Size(57, 24);
            this.btnSearchGV.TabIndex = 41;
            this.btnSearchGV.Text = "Tìm";
            this.btnSearchGV.Click += new System.EventHandler(this.btnSearchGV_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(40, 69);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(82, 20);
            this.txtSearch.TabIndex = 42;
            // 
            // btnShowDS
            // 
            this.btnShowDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnShowDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnShowDS.Image = global::qlhocvien.Properties.Resources.users;
            this.btnShowDS.Location = new System.Drawing.Point(372, 181);
            this.btnShowDS.Name = "btnShowDS";
            this.btnShowDS.Size = new System.Drawing.Size(145, 30);
            this.btnShowDS.TabIndex = 44;
            this.btnShowDS.Text = "Xem  Danh Sach";
            this.btnShowDS.Click += new System.EventHandler(this.btnShowDS_Click);
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(107, 68);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(145, 20);
            this.txtTenGV.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(16, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Tên Giáo Viên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(16, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Tuổi";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(16, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Mã Giáo Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(106, 33);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(145, 20);
            this.txtMaGV.TabIndex = 25;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSua.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btnSua.Location = new System.Drawing.Point(141, 181);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 30);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // showdatagv
            // 
            this.showdatagv.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showdatagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatagv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdatagv.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.showdatagv.Location = new System.Drawing.Point(0, 235);
            this.showdatagv.Name = "showdatagv";
            this.showdatagv.Size = new System.Drawing.Size(521, 227);
            this.showdatagv.TabIndex = 30;
            this.showdatagv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatagv_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 70);
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 462);
            this.Controls.Add(this.showdatagv);
            this.Controls.Add(this.groupBox4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giáo Viên";
            this.Load += new System.EventHandler(this.GiangVien_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showdatagv)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txtTenGV;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtMaGV;
		private DevComponents.DotNetBar.ButtonX btnSua;
		private System.Windows.Forms.DataGridView showdatagv;
		private System.Windows.Forms.ComboBox cbSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private DevComponents.DotNetBar.ButtonX btnSearchGV;
		private DevComponents.DotNetBar.ButtonX btnShowDS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
		private DevComponents.DotNetBar.ButtonX btnThem;
		private DevComponents.DotNetBar.ButtonX btnXoa;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuoiGV;
    }
}