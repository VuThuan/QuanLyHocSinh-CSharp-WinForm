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
using qlhocvien.GUI;

namespace QLHocSinh
{
    public partial class LopHoc : Form
    {
      
        public LopHoc()
        {
            InitializeComponent();
        }
        LopHocBLL lopHoc_Bll = new LopHocBLL();
        private void LopHoc_Load(object sender, EventArgs e)
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
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtMaGVCN.Text = "";
        }
        private bool ValidateTextbox()
        {
            if (string.IsNullOrEmpty(txtMaLop.Text) ||
                string.IsNullOrEmpty(txtTenLop.Text) ||
                string.IsNullOrEmpty(txtMaGVCN.Text)
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnShowDSLop_Click(object sender, EventArgs e)
        {
            List<LopHocDTO> lst = lopHoc_Bll.ShowDataLopHoc();
            showdatalophoc.DataSource = lst;
            ShowGridViewGV();
        }

        private void ShowGridViewGV()
        {
            showdatalophoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showdatalophoc.Columns[0].HeaderText = "Mã Lớp Học";
            showdatalophoc.Columns[1].HeaderText = "Tên Lớp Học";
            showdatalophoc.Columns[2].HeaderText = "Mã GVCN";
            addButtonForDataGridView();
        }

        private void btnThemLH_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateTextbox() == true)
                {
                    MessageBox.Show("Một hoặc vài trường cần thêm dữ liệu không được bỏ trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LopHocDTO LopHoc = new LopHocDTO()
                    {
                        MaLop = txtMaLop.Text,
                        TenLop = txtTenLop.Text,
                        MaGVCN = txtMaGVCN.Text
                    };
                    lopHoc_Bll.UpdateLopHoc(LopHoc);
                    this.btnShowDSLop_Click(null, null);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi: " + ex.Message);
                ClearTextbox();
            }
        }

        private void addButtonForDataGridView()
        {
            DataGridViewButtonColumn SelectButton = new DataGridViewButtonColumn();
            SelectButton.Name = "Danh Sách HS";
            SelectButton.Text = "Xem";
            SelectButton.DefaultCellStyle.ForeColor = Color.Blue;
            SelectButton.DefaultCellStyle.BackColor = Color.DarkRed;
            SelectButton.UseColumnTextForButtonValue = true;
            if (showdatalophoc.Columns["Danh Sách HS"] == null)
            {
                showdatalophoc.Columns.Insert(3, SelectButton);
            }
        }

        private void showdatakhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtMaLop.Text = showdatalophoc.Rows[index].Cells[0].Value.ToString();
                    txtTenLop.Text = showdatalophoc.Rows[index].Cells[1].Value.ToString();
                    txtMaGVCN.Text = showdatalophoc.Rows[index].Cells[2].Value.ToString();

                    if (e.ColumnIndex == showdatalophoc.Columns[3].Index)
                    {
                        DanhSachHocSinhThuocLop ds = new DanhSachHocSinhThuocLop();
                        ds.maLopHoc = txtMaLop.Text;
                        ds.ShowDialog();
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Chọn Mã Lớp Học hoặc Tên Lớp Học");
            }
        }

        private void btnSuaLH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaLop.Text == "" || txtTenLop.Text == "" || txtMaGVCN.Text == "")
                {
                    MessageBox.Show("Phải Nhập đủ Thông Tin");
                }

                else if (txtMaLop.Text != "")
                {
                    LopHocDTO LopHoc = new LopHocDTO()
                    {
                        MaLop = txtMaLop.Text,
                        TenLop = txtTenLop.Text,
                        MaGVCN = txtMaGVCN.Text
                    };
                    lopHoc_Bll.UpdateLopHoc(LopHoc);
                    this.btnShowDSLop_Click(null, null);
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

        private void btnXoaLH_Click(object sender, EventArgs e)
        {
            try
            {
                lopHoc_Bll.DeleteLopHoc(txtMaLop.Text);
                this.btnShowDSLop_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
