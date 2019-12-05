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
    public partial class Khoi : Form
    {
      
        public Khoi()
        {
            InitializeComponent();
        }
         public void DSKhoa()
         {
			string query = "select * from Khoi";
			using (SqlConnection connection = DataConnection.GetConnection())
			{
				connection.Open();
				SqlDataAdapter sa = new SqlDataAdapter(query, connection);
				DataTable data = new DataTable();
				sa.Fill(data);
				showdatakhoa.DataSource = data;
				connection.Close();
				connection.Dispose();
			}
         }
        private void Khoa_Load(object sender, EventArgs e)
        {
			DSKhoa();
        }

        private void showdatakhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtmakhoi.Text = showdatakhoa.Rows[index].Cells[0].Value.ToString();
                    txttenkhoi.Text = showdatakhoa.Rows[index].Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Chọn Mã Khối hoặc Tên Khối");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            try
            {
                this.DSKhoa();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }
    }
}
