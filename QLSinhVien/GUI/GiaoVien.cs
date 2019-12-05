using qlhocvien.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace QLHocSinh
{
	public partial class GiangVien : Form
	{
		private string sql;
		public GiangVien()
		{
			InitializeComponent();
		}

		private void GiangVien_Load(object sender, EventArgs e)
		{
			try
			{
               
            }
			catch (Exception)
			{

				MessageBox.Show("Lỗi Kết Nối, Vui Lòng Thử Lại");
			}
		}
		public List<GV> DanhSachGV()
		{
			List<GV> lst = new List<GV>();
			using (SqlConnection connection = DataConnection.GetConnection())
			{
				connection.Open();
				SqlCommand command = new SqlCommand("select * from giaovien", connection);
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read() && reader.HasRows)
				{
					GV gv = new GV()
					{
						MaGV = reader.GetValue(0).ToString(),
						TenGV = reader.GetValue(1).ToString(),
						MaKhoa = reader.GetValue(2).ToString()
					};
					lst.Add(gv);
				}
				reader.Close();
				connection.Close();
			}
			return lst;
		}

		private void ClearTextbox()
		{
			txtmagv.Text = "";
			txttengv.Text = "";
			cbmakhoigv.Text = "Chọn";
		}
		private bool ValidateTextbox()
		{
			if (string.IsNullOrEmpty(txtmagv.Text) ||
				string.IsNullOrEmpty(txttengv.Text) ||
				string.IsNullOrEmpty(cbmakhoigv.Text))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		private void Btthem_Click(object sender, EventArgs e)
		{
			try
			{
				if (ValidateTextbox() == true)
				{
					MessageBox.Show("Một hoặc vài trường cần thêm dữ liệu không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					//	ClearTextbox();
					string query = "INSERT INTO GiaoVien(MaGV,TenGV,MaKhoi) VALUES('" + txtmagv.Text + "','" + txttengv.Text + "','" + cbmakhoigv.Text + "')";
					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						SqlCommand command = new SqlCommand(query, connection);
						command.ExecuteNonQuery();
						connection.Close();
						connection.Dispose();
						MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.ButtonX1_Click(null, null);
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi: " + ex.Message);
				ClearTextbox();
			}
		}

		private void Btsua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtmagv.Text == "" || txttengv.Text == "" || cbmakhoigv.Text == "[--Chọn Một--]"  || cbmakhoigv.Text == "" )
				{
					MessageBox.Show("Phải Nhập đủ Thông Tin");
				}

				else if (txtmagv.Text != "")
				{
					sql = "UPDATE GiaoVien SET TenGV ='" + txttengv.Text + "',  MaKhoi='" + cbmakhoigv.Text + "' WHERE MaGV='" + txtmagv.Text + "'";
					using (SqlConnection connection = DataConnection.GetConnection())
					{
						connection.Open();
						SqlCommand command = new SqlCommand(sql, connection);
						command.ExecuteNonQuery();

						connection.Close();
						connection.Dispose();
					}
					MessageBox.Show("Đã sửa xong rồi nhé.!!!");
					this.ButtonX1_Click(null, null);
				}
				else
				{
					MessageBox.Show("Hãy Nhập Thông Tin Vào Box ...", "Thông báo");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Có Lỗi :" + ex.Message);
			}
		}

		private void Timgv_Click(object sender, EventArgs e)
		{
			List<GV> lst = DanhSachGV();
			List<GV> search = new List<GV>();
			string mgv = "Tìm Theo Mã Giáo Viên", tgv = "Tìm Theo Tên Giáo Viên";
			string tim = "";
			tim = txtsearch.Text.ToLower();
			try
			{
				if (string.IsNullOrEmpty(txtsearch.Text) == false)
				{
					if (cbsearch.Text.ToLower() == mgv.ToLower())
					{
						foreach (var item in lst)
						{
							if (item.MaGV.ToLower().Contains(tim))
							{
								search.Add(item);
							}
						}
						showdatagv.DataSource = search;
						ShowGridViewGV();
					}
					else if (cbsearch.Text.ToLower() == tgv.ToLower())
					{
						foreach (var item in lst)
						{
							if (item.TenGV.ToLower().Contains(tim))
							{
								search.Add(item);
							}
						}
						showdatagv.DataSource = search;
						ShowGridViewGV();
					}
					else
					{
						MessageBox.Show("Vui Lòng Chọn Tìm Theo Mã Giáo Viên Hoặc Theo Tên Giáo Viên");
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

		private void ButtonX1_Click(object sender, EventArgs e)
		{
			List<GV> lst = this.DanhSachGV();
			showdatagv.DataSource = lst;
			ShowGridViewGV();
		}

		private void ShowGridViewGV()
		{
			showdatagv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			showdatagv.Columns[0].HeaderText = "Mã Giáo Viên";
			showdatagv.Columns[1].HeaderText = "Tên Giáo Viên";
			showdatagv.Columns[2].HeaderText = "Mã khoa";
		}

		private void showdatagv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txtmagv.Text = showdatagv.Rows[index].Cells[0].Value.ToString();
				txttengv.Text = showdatagv.Rows[index].Cells[1].Value.ToString();
				cbmakhoigv.Text = showdatagv.Rows[index].Cells[2].Value.ToString();
			}
		}

		private void btxoa_Click(object sender, EventArgs e)
		{
			try
			{
				using (SqlConnection connection = DataConnection.GetConnection())
				{
					if (MessageBox.Show("Bạn có thật sự muốn xóa Giáo Viên có mã số: " + txtmagv.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
					{
						connection.Open();
						string query = "delete from giaovien where magv=" + "'" + txtmagv.Text + "'";
						SqlCommand command = new SqlCommand(query, connection);
						command.ExecuteNonQuery();
						connection.Close();
						connection.Dispose();
						this.ButtonX1_Click(null, null);
					}
					
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
