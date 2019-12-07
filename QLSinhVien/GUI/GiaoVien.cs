using QLHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using QLHocSinh.BLL;


namespace QLHocSinh
{
	public partial class GiangVien : Form
	{
		private string sql;
		GiaoVienBLL giaoVien_Bll = new GiaoVienBLL();
		
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

		private void ClearTextbox()
		{
			txtMaGV.Text = "";
			txtTenGV.Text = "";
			txtTuoiGV.Text = "";
            txtDiaChiGV.Text = "";
		}
		private bool ValidateTextbox()
		{
			if (string.IsNullOrEmpty(txtMaGV.Text) ||
				string.IsNullOrEmpty(txtTenGV.Text) ||
				string.IsNullOrEmpty(txtTuoiGV.Text)||
                string.IsNullOrEmpty(txtDiaChiGV.Text)
            )
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
					GiaoVienDTO giaoVien = new GiaoVienDTO()
					{
						MaGV = txtMaGV.Text,
						TenGV = txtTenGV.Text,
						Tuoi = txtTuoiGV.Text,
						DiaChi = txtDiaChiGV.Text
					};
					giaoVien_Bll.InsertGiaoVien(giaoVien);
					this.btnShowDS_Click(null, null);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi: " + ex.Message);
				ClearTextbox();
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaGV.Text == "" || txtTenGV.Text == "" || txtTuoiGV.Text == ""  || txtDiaChiGV.Text == "" )
				{
					MessageBox.Show("Phải Nhập đủ Thông Tin");
				}

				else if (txtMaGV.Text != "")
				{
					GiaoVienDTO giaoVien = new GiaoVienDTO()
					{
						MaGV = txtMaGV.Text,
						TenGV = txtTenGV.Text,
						Tuoi = txtTuoiGV.Text,
						DiaChi = txtDiaChiGV.Text
					};
					giaoVien_Bll.UpdateGiaoVien(giaoVien);
					ClearTextbox();
					this.btnShowDS_Click(null, null);
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

		private void btnSearchGV_Click(object sender, EventArgs e)
		{
			List<GiaoVienDTO> lst = giaoVien_Bll.ShowDataGiaoVien();
			List<GiaoVienDTO> search = new List<GiaoVienDTO>();
			string mgv = "Tìm Theo Mã Giáo Viên", tgv = "Tìm Theo Tên Giáo Viên";
			string tim = "";
			tim = txtSearch.Text.ToLower();
			try
			{
				if (string.IsNullOrEmpty(txtSearch.Text) == false)
				{
					if (cbSearch.Text.ToLower() == mgv.ToLower())
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
					else if (cbSearch.Text.ToLower() == tgv.ToLower())
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

		private void btnShowDS_Click(object sender, EventArgs e)
		{
			List<GiaoVienDTO> lst = giaoVien_Bll.ShowDataGiaoVien();
			showdatagv.DataSource = lst;
			ShowGridViewGV();
		}

		private void ShowGridViewGV()
		{
			showdatagv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			showdatagv.Columns[0].HeaderText = "Mã Giáo Viên";
			showdatagv.Columns[1].HeaderText = "Tên Giáo Viên";
			showdatagv.Columns[2].HeaderText = "Tuổi";
            showdatagv.Columns[3].HeaderText = "Địa Chỉ";
        }

		private void showdatagv_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int index = e.RowIndex;
			if (index >= 0)
			{
				txtMaGV.Text = showdatagv.Rows[index].Cells[0].Value.ToString();
				txtTenGV.Text = showdatagv.Rows[index].Cells[1].Value.ToString();
				txtTuoiGV.Text = showdatagv.Rows[index].Cells[2].Value.ToString();
                txtDiaChiGV.Text = showdatagv.Rows[index].Cells[3].Value.ToString();
            }
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				giaoVien_Bll.DeleteGiaoVien(txtMaGV.Text);
				this.btnShowDS_Click(null, null);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

    }
}
