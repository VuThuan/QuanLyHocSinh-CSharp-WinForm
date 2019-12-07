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
            this.showdatakhoa = new System.Windows.Forms.DataGridView();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsua = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGVCN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.showdatakhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // showdatakhoa
            // 
            this.showdatakhoa.BackgroundColor = System.Drawing.Color.LightCyan;
            this.showdatakhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showdatakhoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.showdatakhoa.Location = new System.Drawing.Point(0, 137);
            this.showdatakhoa.Name = "showdatakhoa";
            this.showdatakhoa.Size = new System.Drawing.Size(489, 182);
            this.showdatakhoa.TabIndex = 0;
            this.showdatakhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showdatakhoa_CellClick);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(95, 15);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(184, 20);
            this.txtMaLop.TabIndex = 1;
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(95, 57);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(184, 20);
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
            this.btsua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btsua.Image = global::qlhocvien.Properties.Resources.refresh;
            this.btsua.Location = new System.Drawing.Point(350, 15);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(89, 32);
            this.btsua.TabIndex = 24;
            this.btsua.Text = "Load Data";
            this.btsua.Click += new System.EventHandler(this.Btsua_Click);
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
            this.txtMaGVCN.Size = new System.Drawing.Size(184, 20);
            this.txtMaGVCN.TabIndex = 26;
            // 
            // LopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 319);
            this.Controls.Add(this.txtMaGVCN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenLop);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.showdatakhoa);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LopHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp Học";
            this.Load += new System.EventHandler(this.LopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showdatakhoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView showdatakhoa;
		private System.Windows.Forms.TextBox txtMaLop;
		private System.Windows.Forms.TextBox txtTenLop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private DevComponents.DotNetBar.ButtonX btsua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGVCN;
    }
}