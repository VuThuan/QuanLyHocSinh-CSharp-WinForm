using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using QLHocSinh.DTO;
using QLHocSinh.BLL;


namespace QLHocSinh
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

        MonHocBLL monHoc_bll = new MonHocBLL();

        private void MonHoc_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Lỗi");

            }
        }

        private void showDataGridView()
        {
            showdatamonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showdatamonhoc.Columns[0].HeaderText = "Mã môn học";
            showdatamonhoc.Columns[1].HeaderText = "Tên môn học";
            showdatamonhoc.Columns[2].HeaderText = "Số tiết";
            showdatamonhoc.Columns[3].HeaderText = "Tổng số tiết";
            showdatamonhoc.Columns[4].HeaderText = "Mã giáo viên";
        }

        private bool ValidateTextbox()
        {
            if (string.IsNullOrEmpty(txtMaMH.Text) ||
                string.IsNullOrEmpty(txtTenMH.Text) ||
                string.IsNullOrEmpty(txtSoTietHoc.Text) ||
                string.IsNullOrEmpty(txtTongSoTiet.Text) ||
                string.IsNullOrEmpty(txtMaGVMH.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ClearTextbox()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtSoTietHoc.Text = "";
            txtTongSoTiet.Text = "";
            txtMaGVMH.Text = "";
        }


        private void btnDanhSachMH_Click(object sender, EventArgs e)
        {
            List<MonHocDTO> lst = monHoc_bll.ShowDataMonHoc();
            showdatamonhoc.DataSource = lst;
            showDataGridView();
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTextbox() == true)
                {
                    MessageBox.Show("Một hoặc vài trường cần thêm dữ liệu không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MonHocDTO monHoc = new MonHocDTO() 
                    {
                        MaMH = txtMaMH.Text,
                        TenMH = txtTenMH.Text,
                        SoTiet = txtSoTietHoc.Text,
                        TongSoTiet = txtTongSoTiet.Text,
                        MaGV = txtMaGVMH.Text
                    };
                    monHoc_bll.InsertMonHoc(monHoc);
                    this.btnDanhSachMH_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi: " + ex.Message);
                ClearTextbox();
            }
        }

        private void showdatamonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (row >= 0)
                {
                    txtMaMH.Text = showdatamonhoc.Rows[row].Cells[0].Value.ToString();
                    txtTenMH.Text = showdatamonhoc.Rows[row].Cells[1].Value.ToString();
                    txtMaGVMH.Text = showdatamonhoc.Rows[row].Cells[4].Value.ToString();
                    txtTongSoTiet.Text = showdatamonhoc.Rows[row].Cells[3].Value.ToString();
                    txtSoTietHoc.Text = showdatamonhoc.Rows[row].Cells[2].Value.ToString();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMH.Text == "" || txtTenMH.Text == "" || txtSoTietHoc.Text == "" || txtTongSoTiet.Text == "" || txtMaGVMH.Text == "")
                {
                    MessageBox.Show("Phải Nhập đủ Thông Tin");
                }

                else if (txtMaMH.Text != "")
                {
                    MonHocDTO monHoc = new MonHocDTO()
                    {
                        MaMH = txtMaMH.Text,
                        TenMH = txtTenMH.Text,
                        SoTiet = txtSoTietHoc.Text,
                        TongSoTiet = txtTongSoTiet.Text,
                        MaGV = txtMaGVMH.Text
                    };
                    monHoc_bll.UpdateMonHoc(monHoc);
                    this.btnDanhSachMH_Click(null, null);
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

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            try
            {
                monHoc_bll.DeleteMonHoc(txtMaMH.Text);
                this.btnDanhSachMH_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
