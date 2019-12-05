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

namespace QLHocSinh
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }
        public void DSMonHoc()
        {

            string sql = "SELECT * FROM MonHoc";
			using (SqlConnection connection = DataConnection.GetConnection())
			{
				connection.Open();
				SqlDataAdapter sa = new SqlDataAdapter(sql, connection);
				DataTable data = new DataTable();
				sa.Fill(data);
				showdatamonhoc.DataSource = data;
				connection.Close();
				connection.Dispose();
			}
			showdatamonhoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			showdatamonhoc.Columns[0].HeaderText = "Mã môn học";
			showdatamonhoc.Columns[1].HeaderText = "Tên môn học";
			showdatamonhoc.Columns[2].HeaderText = "Số tiết";
			showdatamonhoc.Columns[3].HeaderText = "Tổng số tiết";
			showdatamonhoc.Columns[4].HeaderText = "Mã giáo viên";
			showdatamonhoc.Columns[5].HeaderText = "Mã học sinh";
        }
        private void MonHoc_Load(object sender, EventArgs e)
        {
            try
            {
				DSMonHoc();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            try
            {
                this.DSMonHoc();
            }
            catch (Exception)
            {
                
                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {

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
    }
}
