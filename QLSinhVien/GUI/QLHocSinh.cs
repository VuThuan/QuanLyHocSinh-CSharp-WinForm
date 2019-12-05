using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace QLHocSinh
{
	public partial class QLHocSinh : Form
	{
		public QLHocSinh()
		{
			InitializeComponent();
		}
		public List<HocSinh> GetAllStudens()
		{
			List<HocSinh> lst = new List<HocSinh>();
			using (SqlConnection connection = DataConnection.GetConnection())
			{
				connection.Open();
				SqlCommand command = new SqlCommand("select * from HocSinh", connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read() && reader.HasRows)
				{
                    HocSinh sv = new HocSinh()
					{
						MaHS = reader.GetValue(0).ToString(),
						TenHS = reader.GetValue(1).ToString(),
						Tuoi = int.Parse(reader.GetValue(2).ToString()),
						GioiTinh = reader.GetValue(3).ToString(),
						NoiSinh = reader.GetValue(4).ToString(),
						MaKhoi = reader.GetValue(5).ToString()
					};
					lst.Add(sv);
				}
				connection.Close();
				connection.Dispose();
			}
			return lst;
		}

		private void ButtonItem29_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetAllStudens();
			}
			catch
			{
				throw;
			}
		}
		public bool Check()
		{
			if (string.IsNullOrEmpty(txtmahv.Text) ||
				string.IsNullOrEmpty(cbmakhoi.Text) ||
				string.IsNullOrEmpty(txthoten.Text) ||
				string.IsNullOrEmpty(txttuoi.Text) ||
				string.IsNullOrEmpty(cbgioitinh.Text) ||
				string.IsNullOrEmpty(txtnoisinh.Text))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public void ClearTextbox()
		{
			txtmahv.Text = "";
			cbmakhoi.Text = "Chọn";
			txthoten.Text = "";
			txttuoi.Text = "";
			cbgioitinh.Text = "Chọn";
			txtnoisinh.Text = "";
		}
		private void Btthem_Click(object sender, EventArgs e)
		{
			//		ClearTextBox();
			try
			{
				if (Check() == true)
				{
                    HocSinh hocSinh = new HocSinh()
					{
						MaHS = txtmahv.Text.Trim(),
						TenHS = txthoten.Text.Trim(),
						Tuoi = int.Parse(txttuoi.Text),
						GioiTinh = cbgioitinh.Text,
						NoiSinh = txtnoisinh.Text.Trim(),
						MaKhoi = cbmakhoi.Text.Trim()
					};
					HocSinhDAL.AddStudent(hocSinh);
					this.ButtonX1_Click(null, null);
					ClearTextBox();
				}
				else
				{
					MessageBox.Show("Bạn cần nhập đủ tất cả các trường dữ liệu nhé.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error ???");
			}
		}

		private void Btxoa_Click(object sender, EventArgs e)
		{
			try
			{

				DialogResult ok;
				ok = MessageBox.Show("Bạn thực sự muốn xóa Học Sinh: " + txthoten.Text + " có mã số :" + txtmahv.Text + " chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ok == DialogResult.Yes)
				{

					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						string sql = "";
						sql = "delete from HocSinh where MaHS='" + txtmahv.Text + "'";
						SqlCommand command = new SqlCommand(sql, connection);
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Xóa Thành Công Rồi Nhé.!!!");
						this.ButtonX1_Click(null, null);
						ClearTextbox();
					}
				}
				else
				{
					return;
				}
			}

			catch (Exception ex)
			{
				MessageBox.Show("Bắt Lỗi: Exception  " + ex.Message);

			}
		}

		private void Btsua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtmahv.Text == "" || txthoten.Text == "" || txtnoisinh.Text == "" || cbmakhoi.Text == "" || cbgioitinh.Text == "[--Chọn Một--]" || cbmakhoi.Text == "" || cbmakhoi.Text == "[--Chọn Một--]")
				{
					MessageBox.Show("Bạn chưa nhập đủ điều kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (txtmahv.Text.ToString().Length > 10)
				{
					MessageBox.Show("Mã học sinh không được quá 10 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtmahv.Text = "";
				}
				else if (txthoten.Text.ToString().Length > 25)
				{
					MessageBox.Show("Tên học sinh phải Nhỏ Hơn 25 Ký Tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txttuoi.Text = "";
				}
				else if (Int32.Parse(txttuoi.Text) > 18)
				{
					MessageBox.Show("Học sinh phải nhỏ hơn mười tám tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txttuoi.Text = "";
				}

				else
				{
					string sql = "";
					sql = "UPDATE HocSinh SET TenHS ='" + txthoten.Text + "', Tuoi ='" + txttuoi.Text + "',GioiTinh ='" + cbgioitinh.Text + "',Noisinh='" + txtnoisinh.Text + "',MaKhoi ='" + cbmakhoi.Text + "' WHERE MaHS='" + txtmahv.Text + "'";
					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						SqlCommand sqlcommand = new SqlCommand(sql, connection);
						sqlcommand.ExecuteNonQuery();
						MessageBox.Show("Đã sửa thông tin học sinh có Mã Số : " + txtmahv.Text + " Thành Công");
						connection.Close();
						connection.Dispose();
					}
					ClearTextBox();
					this.ButtonX1_Click(null, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi :" + ex.Message);
			}
		}
		private void ClearTextBox()
		{
			txtmahv.Text = "";
			cbmakhoi.Text = "Chọn";
			txthoten.Text = "";
			txttuoi.Text = "";
			cbgioitinh.Text = "Chọn";
			txtnoisinh.Text = "";
		}

		private void ButtonX1_Click(object sender, EventArgs e)
		{
			List<HocSinh> list = GetAllStudens();
			showdata.DataSource = list;
			ShowGridView();
		}
		private void ShowGridView()
		{
			showdata.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			showdata.Columns[0].HeaderText = "Mã học sinh";
			showdata.Columns[1].HeaderText = "Tên học sinh";
			showdata.Columns[2].HeaderText = "Tuổi";
			showdata.Columns[3].HeaderText = "Giới tính";
			showdata.Columns[4].HeaderText = "Nơi sinh";
			showdata.Columns[5].HeaderText = "Mã Khối";
		}

		private void Btsearch_Click_1(object sender, EventArgs e)
		{
			string msv = "Tìm Theo Mã Học Sinh", ht = "Tìm Theo Tên Học Sinh";
			string tim = "";
			List<HocSinh> lst = GetAllStudens();
			List<HocSinh> search = new List<HocSinh>();
			tim = txtsearch.Text.ToLower();
			try
			{
				if (txtsearch.Text != "")
				{
					if (cbsearch.Text.ToLower() == msv.ToLower())
					{
						foreach (var item in lst)
						{
							if (item.MaHS.ToLower().Contains(tim) == true)
							{
								search.Add(item);
							}
						}
						// hiển thị kết quả tìm kiếm lên datagridview
						showdata.DataSource = search;
						ShowGridView();
					}
					else if (cbsearch.Text.ToLower() == ht.ToLower())
					{
						foreach (var item in lst)
						{
							if (item.TenHS.ToLower().Contains(tim) == true)
							{
								search.Add(item);
							}
						}
						// hiển thị kết quả tìm kiếm lên datagridview
						showdata.DataSource = search;
						ShowGridView();
					}
					else
					{
						MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Học Sinh Hoặc Theo Tên Học Sinh");
					}
				}
				else
				{
					MessageBox.Show("Hãy Nhập Từ Khóa Cần Tìm!!");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Lỗi" + ex.Message);
			}
		}

		private void ButtonX3_Click(object sender, EventArgs e)
		{
			Login f1 = new Login();
			f1.ShowDialog();
			if (Login.flag == true)
			{
				qlhv.Enabled = true;
				giangvienkhoa.Enabled = true;
				gdangnhap.Visible = false;
				gdangxuat.Visible = true;
			}
		}

		private void ButtonX5_Click(object sender, EventArgs e)
		{
			qlhv.Enabled = false;
			giangvienkhoa.Enabled = false;

			gdangnhap.Visible = true;
			MessageBox.Show("Đăng Xuất Thành Công,");
			//Application.Exit();
		}

		private void ButtonX6_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ButtonX4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ButtonItem23_Click(object sender, EventArgs e)
		{
			Process.Start("", null);
		}

		private void ButtonItem17_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.haui.edu.vn/vn", null);
		}

		private void ButtonItem29_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.haui.edu.vn/vn", null);
		}

		private void ButtonItem26_Click(object sender, EventArgs e)
		{
			Process.Start("", null);
		}


		private void ButtonItem31_Click(object sender, EventArgs e)
		{
			ColorDialog dlg = new ColorDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtmahv.ForeColor = txthoten.ForeColor = cbmakhoi.ForeColor = gdangnhap.ForeColor = gdangxuat.ForeColor = groupBox1.ForeColor = groupBox2.ForeColor  = ribbonControl1.ForeColor = cbgioitinh.ForeColor = txttuoi.ForeColor = showdata.ForeColor = dlg.Color;
			}
		}

		private void ButtonItem32_Click(object sender, EventArgs e)
		{
			FontDialog dlg = new FontDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				txtmahv.Font = txthoten.Font = cbmakhoi.Font = gdangnhap.Font = gdangxuat.Font = groupBox1.Font = groupBox2.Font  = ribbonControl1.Font = cbgioitinh.Font = txttuoi.Font = showdata.Font = dlg.Font;
			}
		}

		private void Btgiangvien_Click(object sender, EventArgs e)
		{
			GiangVien view = new GiangVien();
			view.ShowDialog();
		}
		private void ButtonX8_Click(object sender, EventArgs e)
		{
			Khoi k = new Khoi();
			k.ShowDialog();
		}

		private void ButtonX9_Click(object sender, EventArgs e)
		{
			MonHoc mh = new MonHoc();
			mh.ShowDialog();
		}
	
		private void MởToolStripMenuItem_Click(object sender, EventArgs e)
		{
            QLHocSinh f = new QLHocSinh();
			f.Show();
		}

		private void ButtonItem7_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Showdata_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txtmahv.Text = showdata.Rows[index].Cells[0].Value.ToString();
				txthoten.Text = showdata.Rows[index].Cells[1].Value.ToString();
				txttuoi.Text = showdata.Rows[index].Cells[2].Value.ToString();
				cbgioitinh.Text = showdata.Rows[index].Cells[3].Value.ToString();
				txtnoisinh.Text = showdata.Rows[index].Cells[4].Value.ToString();
				cbmakhoi.Text = showdata.Rows[index].Cells[5].Value.ToString();
			}
		}

		private void QlSinhVien_Load(object sender, EventArgs e)
		{
			txtmahv.Text = txtmahv.Text.Trim();
			//	txtmahv.ReadOnly = true;
			qlhv.Enabled = false;
			giangvienkhoa.Enabled = false;
			gdangnhap.Visible = true;
			gdangxuat.Visible = false;
		}

    }
}
