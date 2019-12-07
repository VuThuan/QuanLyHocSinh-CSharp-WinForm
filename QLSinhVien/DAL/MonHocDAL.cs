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
    class MonHocDAL :  MonHocDTO
    {
        public List<MonHocDTO> ShowDataMonHoc()
        {
            List<MonHocDTO> lst = new List<MonHocDTO>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from MonHoc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    MonHocDTO monHoc = new MonHocDTO()
                    {
                        MaMH = reader.GetValue(0).ToString(),
                        TenMH = reader.GetValue(1).ToString(),
                        SoTiet = reader.GetValue(2).ToString(),
                        TongSoTiet = reader.GetValue(3).ToString(),
                        MaGV = reader.GetValue(4).ToString()
                    };
                    lst.Add(monHoc);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
        }

        public bool InsertMonHoc(MonHocDTO MonHoc)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "insert into MonHoc values (@MaMH, @TenMH, @SoTiet, @TongSoTiet, @MaGV)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaMH", SqlDbType.NVarChar).Value = MonHoc.MaMH;
                    command.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = MonHoc.TenMH;
                    command.Parameters.Add("@SoTiet", SqlDbType.NVarChar).Value = MonHoc.SoTiet;
                    command.Parameters.Add("@TongSoTiet", SqlDbType.SmallInt).Value = MonHoc.TongSoTiet;
                    command.Parameters.Add("@MaGV", SqlDbType.NVarChar).Value = MonHoc.MaGV;
                    command.ExecuteNonQuery();
                    connection.Close();
                    connection.Dispose();
                    MessageBox.Show("Thêm thành công.!!", "Thông báo cho mà biết này", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
                return false;
            }
        }

        public bool DeleteMonHoc(string MaMH)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học có mã số: " + MaMH, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from MonHoc where MaMH=" + "'" + MaMH + "'";
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

        public bool UpdateMonHoc(MonHocDTO MonHoc)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE MonHoc SET TenMH = @TenMH, SoTiet = @SoTiet, TongSoTiet = @TongSoTiet, MaGV = @MaGV WHERE MaMH = @MaMH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaMH", SqlDbType.NVarChar).Value = MonHoc.MaMH;
                    command.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = MonHoc.TenMH;
                    command.Parameters.Add("@SoTiet", SqlDbType.NVarChar).Value = MonHoc.SoTiet;
                    command.Parameters.Add("@TongSoTiet", SqlDbType.SmallInt).Value = MonHoc.TongSoTiet;
                    command.Parameters.Add("@MaGV", SqlDbType.NVarChar).Value = MonHoc.MaGV;
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
