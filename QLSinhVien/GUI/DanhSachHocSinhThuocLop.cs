using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLHocSinh;

namespace qlhocvien.GUI
{
    public partial class DanhSachHocSinhThuocLop : Form
    {
        public DanhSachHocSinhThuocLop()
        {
            InitializeComponent();
        }

        public string maLopHoc;

        private void DanhSachHocSinhThuocLop_Load(object sender, EventArgs e)
        {
            string sql = "SELECT hs.TenHS, hs.Tuoi, hs.GioiTinh, hs.NoiSinh, lh.TenLop From LopHoc as lh" +
                            " Inner join HocSinh as hs ON hs.MaLop = lh.MaLop " +
                            " WHERE lh.MaLop = '" + maLopHoc + "'";
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                showDanhSachHS.DataSource = dt;
                ShowGridViewDSHS();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void ShowGridViewDSHS()
        {
            showDanhSachHS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showDanhSachHS.Columns[0].HeaderText = "Tên HS";
            showDanhSachHS.Columns[1].HeaderText = "Tuổi";
            showDanhSachHS.Columns[2].HeaderText = "Giới Tính";
            showDanhSachHS.Columns[3].HeaderText = "Nơi Sinh";
            showDanhSachHS.Columns[4].HeaderText = "Tên Lớp";
        }
    }
}
