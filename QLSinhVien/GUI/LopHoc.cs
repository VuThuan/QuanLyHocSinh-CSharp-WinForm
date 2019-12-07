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
    public partial class LopHoc : Form
    {
      
        public LopHoc()
        {
            InitializeComponent();
        }
         public void DSLopHoc()
         {
			string query = "select * from LopHoc";
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

       
        private void LopHoc_Load(object sender, EventArgs e)
        {
			DSLopHoc();
        }

        private void showdatakhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    txtMaLop.Text = showdatakhoa.Rows[index].Cells[0].Value.ToString();
                    txtTenLop.Text = showdatakhoa.Rows[index].Cells[1].Value.ToString();
                    txtMaGVCN.Text = showdatakhoa.Rows[index].Cells[2].Value.ToString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hãy Chọn Mã Lớp Học hoặc Tên Lớp Học");
            }
        }

        private void Btsua_Click(object sender, EventArgs e)
        {
            try
            {
                this.DSLopHoc();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi Không Thể Load ");
            }
        }
    }
}
