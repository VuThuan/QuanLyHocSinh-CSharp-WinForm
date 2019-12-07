using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLHocSinh.DTO;
using System.Data;
using System.Windows.Forms;



namespace QLHocSinh.DAL
{
	public class GiaoVienDAL : GiaoVienDTO
	{
        public List<GiaoVienDTO> ShowDataGiaoVien()
        {
            List<GiaoVienDTO> lst = new List<GiaoVienDTO>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from GiaoVien", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    GiaoVienDTO GiaoVien = new GiaoVienDTO()
                    {
                        MaGV = reader.GetValue(0).ToString(),
                        TenGV = reader.GetValue(1).ToString(),
                        Tuoi = reader.GetValue(2).ToString(),
                        DiaChi = reader.GetValue(3).ToString()
                    };
                    lst.Add(GiaoVien);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
        }

        public bool InsertGiaoVien(GiaoVienDTO GiaoVien)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "insert into GiaoVien values (@MaGV, @TenGV, @Tuoi, @DiaChi)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaGV", SqlDbType.NVarChar).Value = GiaoVien.MaGV;
                    command.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = GiaoVien.TenGV;
                    command.Parameters.Add("@Tuoi", SqlDbType.SmallInt).Value = GiaoVien.Tuoi;
                    command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = GiaoVien.DiaChi;
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                return false;
            }
        }

        public bool DeleteGiaoVien(string MaGV)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học có mã số: " + MaGV, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from GiaoVien where MaGV=" + "'" + MaGV + "'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        connection.Close();
                        connection.Dispose();
                        MessageBox.Show("Xóa Thành Công.!!!");
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool UpdateGiaoVien(GiaoVienDTO GiaoVien)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE GiaoVien SET TenGV = @TenGV, Tuoi = @Tuoi, DiaChi = @DiaChi WHERE MaGV = @MaGV";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaGV", SqlDbType.NVarChar).Value = GiaoVien.MaGV;
                    command.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = GiaoVien.TenGV;
                    command.Parameters.Add("@Tuoi", SqlDbType.SmallInt).Value = GiaoVien.Tuoi;
                    command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = GiaoVien.DiaChi;
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    MessageBox.Show("Sửa thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                return false;
            }
        }
    }
}
