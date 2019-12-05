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

namespace QLHocSinh
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }

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

        private List<MH> DanhSachMH()
        {
            List<MH> lst = new List<MH>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from MonHoc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    MH mh = new MH()
                    {
                        MaMH = reader.GetValue(0).ToString(),
                        TenMH = reader.GetValue(1).ToString(),
                        SoTiet = reader.GetValue(2).ToString(),
                        TongSoTiet = reader.GetValue(3).ToString(),
                        MaGV = reader.GetValue(4).ToString(),
                        MaHS = reader.GetValue(5).ToString()
                    };
                    lst.Add(mh);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
        }

        private void btnDanhSachMH_Click(object sender, EventArgs e)
        {
            List<MH> lst = this.DanhSachMH();
            showdatamonhoc.DataSource = lst;
            showDataGridView();
        }

        private void showDataGridView()
        {
            showdatamonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showdatamonhoc.Columns[0].HeaderText = "Mã môn học";
            showdatamonhoc.Columns[1].HeaderText = "Tên môn học";
            showdatamonhoc.Columns[2].HeaderText = "Số tiết";
            showdatamonhoc.Columns[3].HeaderText = "Tổng số tiết";
            showdatamonhoc.Columns[4].HeaderText = "Mã giáo viên";
            showdatamonhoc.Columns[5].HeaderText = "Mã học sinh";
        }

        private bool ValidateTextbox()
        {
            if (string.IsNullOrEmpty(txtmamhmh.Text) ||
                string.IsNullOrEmpty(txttenmhmh.Text) ||
                string.IsNullOrEmpty(txtsotiethoc.Text) ||
                string.IsNullOrEmpty(txttongsotiet.Text) ||
                string.IsNullOrEmpty(txtmagvmh.Text) ||
                string.IsNullOrEmpty(txtmahvmh.Text)
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
            txtmamhmh.Text = "";
            txttenmhmh.Text = "";
            txtsotiethoc.Text = "";
            txttongsotiet.Text = "";
            txtmagvmh.Text = "";
            txtmahvmh.Text = "";
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
                    //	ClearTextbox();
                    string query = "INSERT INTO MonHoc(MaMH,TenMH,SoTiet, TongSoTiet, MaGV, MaHS) VALUES('" + txtmamhmh.Text + "','" + txttenmhmh.Text + "','" + txtsotiethoc.Text + "', '" + txttongsotiet.Text + "', '" + txtmagvmh.Text + "', '" + txtmahvmh.Text + "')";
                    using (SqlConnection connection = DataConnection.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnDanhSachMH_Click(null, null);
                    }
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
                    txtmamhmh.Text = showdatamonhoc.Rows[row].Cells[0].Value.ToString();
                    txttenmhmh.Text = showdatamonhoc.Rows[row].Cells[1].Value.ToString();
                    txtmagvmh.Text = showdatamonhoc.Rows[row].Cells[4].Value.ToString();
                    txttongsotiet.Text = showdatamonhoc.Rows[row].Cells[3].Value.ToString();
                    txtsotiethoc.Text = showdatamonhoc.Rows[row].Cells[2].Value.ToString();
                    txtmahvmh.Text = showdatamonhoc.Rows[row].Cells[5].Value.ToString();
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
                if (txtmamhmh.Text == "" || txttenmhmh.Text == "" || txtsotiethoc.Text == "" || txttongsotiet.Text == "" || txtmagvmh.Text == "" || txtmahvmh.Text == "")
                {
                    MessageBox.Show("Phải Nhập đủ Thông Tin");
                }

                else if (txtmamhmh.Text != "")
                {
                    string sql = "UPDATE MonHoc SET TenMH ='" + txttenmhmh.Text + "',  SoTiet='" + txtsotiethoc.Text + "',  TongSoTiet='" + txttongsotiet.Text + "',  MaGV='" + txtmagvmh.Text + "',  MaHS='" + txtmahvmh.Text + "' WHERE MaMH='" + txtmamhmh.Text + "'";
                    using (SqlConnection connection = DataConnection.GetConnection())
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.ExecuteNonQuery();

                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Đã sửa xong rồi nhé.!!!");
                        this.btnDanhSachMH_Click(null, null);
                    }
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
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học có mã số: " + txtmamhmh.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from MonHoc where MaMH=" + "'" + txtmamhmh.Text + "'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Xóa Thành Công.!!!");
                        this.btnDanhSachMH_Click(null, null);
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
