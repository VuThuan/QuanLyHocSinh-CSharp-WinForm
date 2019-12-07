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
using qlhocvien.DAL;
using qlhocvien.GUI;

namespace QLHocSinh
{
    public partial class LopHoc : Form
    {
      
        public LopHoc()
        {
            InitializeComponent();
        }

       
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

        private List<LH> DanhSachLH()
        {
            List<LH> lst = new List<LH>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from LopHoc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    LH lopHoc = new LH()
                    {
                        MaLop = reader.GetValue(0).ToString(),
                        TenLop = reader.GetValue(1).ToString(),
                        MaGVCN = reader.GetValue(2).ToString(),
                    };
                    lst.Add(lopHoc);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
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
            List<LH> lst = this.DanhSachLH();
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
                    //	ClearTextbox();
                    string query = "INSERT INTO LopHoc(MaLop,TenLop,MaGVCN) VALUES('" + txtMaLop.Text + "','" + txtTenLop.Text + "','" + txtMaGVCN.Text + "')";
                    using (SqlConnection connection = DataConnection.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnShowDSLop_Click(null, null);
                    }
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
                }
                if (e.ColumnIndex == showdatalophoc.Columns["Danh Sách HS"].Index)
                {
                    DanhSachHocSinhThuocLop ds = new DanhSachHocSinhThuocLop();
                    ds.maLopHoc = txtMaLop.Text;
                    ds.ShowDialog();
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
                    string sql = "UPDATE LopHoc SET TenLop ='" + txtTenLop.Text + "',  MaGVCN='" + txtMaGVCN.Text + "' WHERE MaGV='" + txtMaLop.Text + "'";
                    using (SqlConnection connection = DataConnection.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        connection.Dispose();
                    }
                    MessageBox.Show("Đã sửa xong rồi nhé.!!!");
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
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Lớp Học có mã số: " + txtMaLop.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from LopHoc where MaLop=" + "'" + txtMaLop.Text + "'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        this.btnShowDSLop_Click(null, null);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
