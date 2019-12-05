namespace QLHocSinh
{
	partial class MonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHoc));
            this.showdatamonhoc = new System.Windows.Forms.DataGridView();
            this.txtmamhmh = new System.Windows.Forms.TextBox();
            this.txttenmhmh = new System.Windows.Forms.TextBox();
            this.txtmagvmh = new System.Windows.Forms.TextBox();
            this.txttongsotiet = new System.Windows.Forms.TextBox();
            this.txtsotiethoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmahvmh = new System.Windows.Forms.TextBox();
            this.btnXemLai = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMH = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaMH = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaMH = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.showdatamonhoc)).BeginInit();
            this.SuspendLayout();
            // 
            // showdatamonhoc
            // 
            this.showdatamonhoc.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showdatamonhoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatamonhoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdatamonhoc.GridColor = System.Drawing.Color.LightCyan;
            this.showdatamonhoc.Location = new System.Drawing.Point(0, 175);
            this.showdatamonhoc.Name = "showdatamonhoc";
            this.showdatamonhoc.Size = new System.Drawing.Size(457, 145);
            this.showdatamonhoc.TabIndex = 0;
            this.showdatamonhoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatamonhoc_CellClick);
            // 
            // txtmamhmh
            // 
            this.txtmamhmh.Location = new System.Drawing.Point(108, 49);
            this.txtmamhmh.Name = "txtmamhmh";
            this.txtmamhmh.Size = new System.Drawing.Size(114, 20);
            this.txtmamhmh.TabIndex = 1;
            // 
            // txttenmhmh
            // 
            this.txttenmhmh.Location = new System.Drawing.Point(108, 74);
            this.txttenmhmh.Name = "txttenmhmh";
            this.txttenmhmh.Size = new System.Drawing.Size(114, 20);
            this.txttenmhmh.TabIndex = 2;
            // 
            // txtmagvmh
            // 
            this.txtmagvmh.Location = new System.Drawing.Point(327, 46);
            this.txtmagvmh.Name = "txtmagvmh";
            this.txtmagvmh.Size = new System.Drawing.Size(100, 20);
            this.txtmagvmh.TabIndex = 3;
            // 
            // txttongsotiet
            // 
            this.txttongsotiet.Location = new System.Drawing.Point(327, 72);
            this.txttongsotiet.Name = "txttongsotiet";
            this.txttongsotiet.Size = new System.Drawing.Size(100, 20);
            this.txttongsotiet.TabIndex = 4;
            // 
            // txtsotiethoc
            // 
            this.txtsotiethoc.Location = new System.Drawing.Point(327, 98);
            this.txtsotiethoc.Name = "txtsotiethoc";
            this.txtsotiethoc.Size = new System.Drawing.Size(100, 20);
            this.txtsotiethoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số Tiết Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng Số Tiết";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Giáo Viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Môn Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Môn Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 14);
            this.label6.TabIndex = 27;
            this.label6.Text = "Mã Học Sinh";
            // 
            // txtmahvmh
            // 
            this.txtmahvmh.Location = new System.Drawing.Point(108, 98);
            this.txtmahvmh.Name = "txtmahvmh";
            this.txtmahvmh.Size = new System.Drawing.Size(114, 20);
            this.txtmahvmh.TabIndex = 26;
            // 
            // btnXemLai
            // 
            this.btnXemLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXemLai.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXemLai.Location = new System.Drawing.Point(173, 8);
            this.btnXemLai.Name = "btnXemLai";
            this.btnXemLai.Size = new System.Drawing.Size(99, 35);
            this.btnXemLai.TabIndex = 25;
            this.btnXemLai.Text = "Load Dữ Liệu";
            this.btnXemLai.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnThemMH.Image = global::qlhocvien.Properties.Resources.add;
            this.btnThemMH.Location = new System.Drawing.Point(62, 134);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(95, 30);
            this.btnThemMH.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnThemMH.TabIndex = 50;
            this.btnThemMH.Text = "Thêm";
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // btnXoaMH
            // 
            this.btnXoaMH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaMH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnXoaMH.Image = global::qlhocvien.Properties.Resources.delete;
            this.btnXoaMH.Location = new System.Drawing.Point(291, 134);
            this.btnXoaMH.Name = "btnXoaMH";
            this.btnXoaMH.Size = new System.Drawing.Size(95, 30);
            this.btnXoaMH.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.btnXoaMH.TabIndex = 49;
            this.btnXoaMH.Text = " Xóa";
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaMH.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btnSuaMH.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btnSuaMH.Location = new System.Drawing.Point(177, 134);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(95, 30);
            this.btnSuaMH.TabIndex = 48;
            this.btnSuaMH.Text = "Sửa";
            // 
            // MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 320);
            this.Controls.Add(this.btnThemMH);
            this.Controls.Add(this.btnXoaMH);
            this.Controls.Add(this.btnSuaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmahvmh);
            this.Controls.Add(this.btnXemLai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsotiethoc);
            this.Controls.Add(this.txttongsotiet);
            this.Controls.Add(this.txtmagvmh);
            this.Controls.Add(this.txttenmhmh);
            this.Controls.Add(this.txtmamhmh);
            this.Controls.Add(this.showdatamonhoc);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Môn Học";
            this.Load += new System.EventHandler(this.MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdatamonhoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView showdatamonhoc;
		private System.Windows.Forms.TextBox txtmamhmh;
		private System.Windows.Forms.TextBox txttenmhmh;
		private System.Windows.Forms.TextBox txtmagvmh;
		private System.Windows.Forms.TextBox txttongsotiet;
		private System.Windows.Forms.TextBox txtsotiethoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtmahvmh;
        private DevComponents.DotNetBar.ButtonX btnXemLai;
        private DevComponents.DotNetBar.ButtonX btnThemMH;
        private DevComponents.DotNetBar.ButtonX btnXoaMH;
        private DevComponents.DotNetBar.ButtonX btnSuaMH;
    }
}