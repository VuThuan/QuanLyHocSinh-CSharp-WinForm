using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
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
						MaLop = reader.GetValue(5).ToString()
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
			if (string.IsNullOrEmpty(txtMaHS.Text) ||
				string.IsNullOrEmpty(cbMaLop.Text) ||
				string.IsNullOrEmpty(txtHoTen.Text) ||
				string.IsNullOrEmpty(txtTuoi.Text) ||
				string.IsNullOrEmpty(cbGioiTinh.Text) ||
				string.IsNullOrEmpty(txtNoiSinh.Text))
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
			txtMaHS.Text = "";
			cbMaLop.Text = "Chọn";
			txtHoTen.Text = "";
			txtTuoi.Text = "";
			cbGioiTinh.Text = "Chọn";
			txtNoiSinh.Text = "";
		}
		private void BtnThem_Click(object sender, EventArgs e)
		{
			//		ClearTextBox();
			try
			{
				if (Check() == true)
				{
                    string query = "INSERT INTO HocSinh(MaHS,TenHS,Tuoi, GioiTinh, NoiSinh, MaLop) VALUES('" + txtMaHS.Text + "','" + txtHoTen.Text + "','" + txtTuoi.Text + "','" + cbGioiTinh.Text + "','" + txtNoiSinh.Text + "','" + cbMaLop.SelectedValue + "')";
                    using (SqlConnection connection = DataConnection.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnDSHS_Click(null, null);
                    }
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

		private void BtnXoa_Click(object sender, EventArgs e)
		{
			try
			{

				DialogResult ok;
				ok = MessageBox.Show("Bạn thực sự muốn xóa Học Sinh: " + txtHoTen.Text + " có mã số :" + txtMaHS.Text + " chứ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ok == DialogResult.Yes)
				{

					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						string sql = "";
						sql = "delete from HocSinh where MaHS='" + txtMaHS.Text + "'";
						SqlCommand command = new SqlCommand(sql, connection);
						command.ExecuteNonQuery();
						connection.Close();
						MessageBox.Show("Xóa Thành Công Rồi Nhé.!!!");
						this.btnDSHS_Click(null, null);
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

		private void BtnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaHS.Text == "" || txtHoTen.Text == "" || txtNoiSinh.Text == "" || cbMaLop.Text == "" || cbGioiTinh.Text == "[--Chọn Một--]" || cbMaLop.Text == "" || cbMaLop.Text == "[--Chọn Một--]")
				{
					MessageBox.Show("Bạn chưa nhập đủ điều kiện", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else if (txtMaHS.Text.ToString().Length > 10)
				{
					MessageBox.Show("Mã học sinh không được quá 10 kí tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtMaHS.Text = "";
				}
				else if (txtHoTen.Text.ToString().Length > 25)
				{
					MessageBox.Show("Tên học sinh phải Nhỏ Hơn 25 Ký Tự", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTuoi.Text = "";
				}
				else if (Int32.Parse(txtTuoi.Text) > 18)
				{
					MessageBox.Show("Học sinh phải nhỏ hơn mười tám tuổi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					txtTuoi.Text = "";
				}

				else
				{
					string sql = "";
					sql = "UPDATE HocSinh SET TenHS ='" + txtHoTen.Text + "', Tuoi ='" + txtTuoi.Text + "',GioiTinh ='" + cbGioiTinh.Text + "',Noisinh='" + txtNoiSinh.Text + "',MaLop ='" + cbMaLop.SelectedValue + "' WHERE MaHS='" + txtMaHS.Text + "'";
					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						SqlCommand sqlcommand = new SqlCommand(sql, connection);
						sqlcommand.ExecuteNonQuery();
						MessageBox.Show("Đã sửa thông tin học sinh có Mã Số : " + txtMaHS.Text + " Thành Công");
						connection.Close();
						connection.Dispose();
					}
					ClearTextBox();
					this.btnDSHS_Click(null, null);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi :" + ex.Message);
			}
		}
		private void ClearTextBox()
		{
			txtMaHS.Text = "";
			cbMaLop.Text = "Chọn";
			txtHoTen.Text = "";
			txtTuoi.Text = "";
			cbGioiTinh.Text = "Chọn";
			txtNoiSinh.Text = "";
		}

		private void btnDSHS_Click(object sender, EventArgs e)
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
			showdata.Columns[5].HeaderText = "Mã Lớp";
		}

		private void btnSearch_Click_1(object sender, EventArgs e)
		{
			string msv = "Tìm Theo Mã Học Sinh", ht = "Tìm Theo Tên Học Sinh";
			string tim = "";
			List<HocSinh> lst = GetAllStudens();
			List<HocSinh> search = new List<HocSinh>();
			tim = txtSearch.Text.ToLower();
			try
			{
				if (txtSearch.Text != "")
				{
					if (cbSearch.Text.ToLower() == msv.ToLower())
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
					else if (cbSearch.Text.ToLower() == ht.ToLower())
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

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login f1 = new Login();
			f1.ShowDialog();
			if (Login.flag == true)
			{
				qlhv.Enabled = true;
				GiaoVienMon.Enabled = true;
				gdangnhap.Visible = false;
				gdangxuat.Visible = true;
			}
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			qlhv.Enabled = false;
			GiaoVienMon.Enabled = false;

			gdangnhap.Visible = true;
			MessageBox.Show("Đăng Xuất Thành Công,");
		}

		private void btnThoatForm_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThoatFormLogout_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void btnLogoLink_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.haui.edu.vn/vn", null);
		}

		private void LinkWebsiteHaui_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.haui.edu.vn/vn", null);
		}

		private void btnShowDSGV_Click(object sender, EventArgs e)
		{
			GiangVien view = new GiangVien();
			view.ShowDialog();
		}
		private void btnShowLopHoc_Click(object sender, EventArgs e)
		{
			LopHoc k = new LopHoc();
			k.ShowDialog();
		}

		private void btnShowMonHoc_Click(object sender, EventArgs e)
		{
			MonHoc mh = new MonHoc();
			mh.ShowDialog();
		}

		private void Showdata_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txtMaHS.Text = showdata.Rows[index].Cells[0].Value.ToString();
				txtHoTen.Text = showdata.Rows[index].Cells[1].Value.ToString();
				txtTuoi.Text = showdata.Rows[index].Cells[2].Value.ToString();
				cbGioiTinh.Text = showdata.Rows[index].Cells[3].Value.ToString();
				txtNoiSinh.Text = showdata.Rows[index].Cells[4].Value.ToString();
				cbMaLop.SelectedValue = showdata.Rows[index].Cells[5].Value.ToString();
			}
		}

		private void QlSinhVien_Load(object sender, EventArgs e)
		{
			txtMaHS.Text = txtMaHS.Text.Trim();
            Load_CBLopHoc();
			//	txtmahv.ReadOnly = true;
			qlhv.Enabled = false;
			GiaoVienMon.Enabled = false;
			gdangnhap.Visible = true;
			gdangxuat.Visible = false;
		}

        private void Load_CBLopHoc()
        {
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from LopHoc", connection);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();

                dt.Load(reader);
                cbMaLop.DataSource = dt;
                cbMaLop.DisplayMember = "TenLop";
                cbMaLop.ValueMember = "MaLop";
            }
        }
    }
}
