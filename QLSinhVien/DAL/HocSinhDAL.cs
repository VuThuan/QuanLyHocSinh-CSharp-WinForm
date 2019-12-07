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
	public class HocSinhDAL : HocSinhDTO
	{
        public List<HocSinhDTO> ShowDataHocSinh()
        {
            List<HocSinhDTO> lst = new List<HocSinhDTO>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from HocSinh", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    HocSinhDTO HocSinh = new HocSinhDTO()
                    {
                        MaHS = reader.GetValue(0).ToString(),
                        TenHS = reader.GetValue(1).ToString(),
                        Tuoi = int.Parse(reader.GetValue(2).ToString()),
                        GioiTinh = reader.GetValue(3).ToString(),
                        NoiSinh = reader.GetValue(4).ToString(),
                        MaLop = reader.GetValue(5).ToString()
                    };
                    lst.Add(HocSinh);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
        }

        public bool InsertHocSinh(HocSinhDTO HocSinh)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "insert into HocSinh values (@MaHS, @TenHS, @Tuoi, @GioiTinh, @NoiSinh, @MaLop)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaHS", SqlDbType.NVarChar).Value = HocSinh.MaHS;
                    command.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = HocSinh.TenHS;
                    command.Parameters.Add("@Tuoi", SqlDbType.SmallInt).Value = HocSinh.Tuoi;
                    command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = HocSinh.GioiTinh;
                    command.Parameters.Add("@NoiSinh", SqlDbType.NVarChar).Value = HocSinh.NoiSinh;
                    command.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = HocSinh.MaLop;
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

        public bool DeleteHocSinh(string MaHS)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học có mã số: " + MaHS, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from HocSinh where MaHS=" + "'" + MaHS + "'";
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

        public bool UpdateHocSinh(HocSinhDTO HocSinh)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE HocSinh SET TenHS = @TenHS, Tuoi = @Tuoi, GioiTinh = @GioiTinh, NoiSinh = @NoiSinh, MaLop = @MaLop WHERE MaHS = @MaHS";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaHS", SqlDbType.NVarChar).Value = HocSinh.MaHS;
                    command.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = HocSinh.TenHS;
                    command.Parameters.Add("@Tuoi", SqlDbType.SmallInt).Value = HocSinh.Tuoi;
                    command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = HocSinh.GioiTinh;
                    command.Parameters.Add("@NoiSinh", SqlDbType.NVarChar).Value = HocSinh.NoiSinh;
                    command.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = HocSinh.MaLop;
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
