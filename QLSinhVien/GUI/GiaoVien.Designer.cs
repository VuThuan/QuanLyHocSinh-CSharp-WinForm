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
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btxoa = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbsearch = new System.Windows.Forms.ComboBox();
            this.timgv = new DevComponents.DotNetBar.ButtonX();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.btsua = new DevComponents.DotNetBar.ButtonX();
            this.showdatagv = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTuoiGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChiGV = new System.Windows.Forms.TextBox();
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
            this.groupBox4.Controls.Add(this.btxoa);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.buttonX1);
            this.groupBox4.Controls.Add(this.txtTenGV);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtMaGV);
            this.groupBox4.Controls.Add(this.btsua);
            this.groupBox4.Location = new System.Drawing.Point(-4, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(523, 227);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Giáo Viên";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
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
            // btxoa
            // 
            this.btxoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btxoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btxoa.Image = global::qlhocvien.Properties.Resources.delete;
            this.btxoa.Location = new System.Drawing.Point(258, 181);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(95, 30);
            this.btxoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btxoa.TabIndex = 46;
            this.btxoa.Text = " Xóa";
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbsearch);
            this.groupBox1.Controls.Add(this.timgv);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Location = new System.Drawing.Point(276, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Giáo Viên";
            // 
            // cbsearch
            // 
            this.cbsearch.FormattingEnabled = true;
            this.cbsearch.Items.AddRange(new object[] {
            "Tìm Theo Mã Giáo Viên",
            "Tìm Theo Tên Giáo Viên"});
            this.cbsearch.Location = new System.Drawing.Point(40, 31);
            this.cbsearch.Name = "cbsearch";
            this.cbsearch.Size = new System.Drawing.Size(145, 21);
            this.cbsearch.TabIndex = 43;
            this.cbsearch.Text = "Chọn";
            // 
            // timgv
            // 
            this.timgv.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.timgv.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.timgv.Image = global::qlhocvien.Properties.Resources.search_user;
            this.timgv.Location = new System.Drawing.Point(120, 69);
            this.timgv.Name = "timgv";
            this.timgv.Size = new System.Drawing.Size(57, 24);
            this.timgv.TabIndex = 41;
            this.timgv.Text = "Tìm";
            this.timgv.Click += new System.EventHandler(this.Timgv_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(40, 69);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(74, 20);
            this.txtsearch.TabIndex = 42;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.buttonX1.Image = global::qlhocvien.Properties.Resources.users;
            this.buttonX1.Location = new System.Drawing.Point(372, 181);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(145, 30);
            this.buttonX1.TabIndex = 44;
            this.buttonX1.Text = "Xem  Danh Sach";
            this.buttonX1.Click += new System.EventHandler(this.ButtonX1_Click);
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
            // btsua
            // 
            this.btsua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btsua.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btsua.Location = new System.Drawing.Point(141, 181);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(95, 30);
            this.btsua.TabIndex = 23;
            this.btsua.Text = "Sửa";
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
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
            // txtTuoiGV
            // 
            this.txtTuoiGV.Location = new System.Drawing.Point(107, 101);
            this.txtTuoiGV.Name = "txtTuoiGV";
            this.txtTuoiGV.Size = new System.Drawing.Size(145, 20);
            this.txtTuoiGV.TabIndex = 48;
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
            // txtDiaChiGV
            // 
            this.txtDiaChiGV.Location = new System.Drawing.Point(106, 131);
            this.txtDiaChiGV.Name = "txtDiaChiGV";
            this.txtDiaChiGV.Size = new System.Drawing.Size(145, 20);
            this.txtDiaChiGV.TabIndex = 50;
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
		private DevComponents.DotNetBar.ButtonX btsua;
		private System.Windows.Forms.DataGridView showdatagv;
		private System.Windows.Forms.ComboBox cbsearch;
		private System.Windows.Forms.TextBox txtsearch;
		private DevComponents.DotNetBar.ButtonX timgv;
		private DevComponents.DotNetBar.ButtonX buttonX1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
		private DevComponents.DotNetBar.ButtonX btnThem;
		private DevComponents.DotNetBar.ButtonX btxoa;
        private System.Windows.Forms.TextBox txtDiaChiGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTuoiGV;
    }
}