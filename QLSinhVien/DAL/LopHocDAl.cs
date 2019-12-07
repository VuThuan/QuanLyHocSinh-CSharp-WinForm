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
    class LopHocDAL : LopHocDTO
    {
        public List<LopHocDTO> ShowDataLopHoc()
        {
            List<LopHocDTO> lst = new List<LopHocDTO>();
            using (SqlConnection connection = DataConnection.GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from LopHoc", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read() && reader.HasRows)
                {
                    LopHocDTO LopHoc = new LopHocDTO()
                    {
                        MaLop = reader.GetValue(0).ToString(),
                        TenLop = reader.GetValue(1).ToString(),
                        MaGVCN = reader.GetValue(2).ToString()
                    };
                    lst.Add(LopHoc);
                }
                reader.Close();
                connection.Close();
            }
            return lst;
        }

        public bool InsertLopHoc(LopHocDTO LopHoc)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "insert into LopHoc values (@MaLop, @TenLop, @MaGVCN)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = LopHoc.MaLop;
                    command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = LopHoc.TenLop;
                    command.Parameters.Add("@MaGVCN", SqlDbType.NVarChar).Value = LopHoc.MaGVCN;
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

        public bool DeleteLopHoc(string MaLop)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    if (MessageBox.Show("Bạn có thật sự muốn xóa Môn học có mã số: " + MaLop, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        connection.Open();
                        string query = "delete from LopHoc where MaLop=" + "'" + MaLop + "'";
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

        public bool UpdateLopHoc(LopHocDTO LopHoc)
        {
            try
            {
                using (SqlConnection connection = DataConnection.GetConnection())
                {
                    connection.Open();
                    string query = "UPDATE LopHoc SET TenLop = @TenLop, MaGVCN = @MaGVCN WHERE MaLop = @MaLop";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@MaLop", SqlDbType.NVarChar).Value = LopHoc.MaLop;
                    command.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = LopHoc.TenLop;
                    command.Parameters.Add("@MaGVCN", SqlDbType.NVarChar).Value = LopHoc.MaGVCN;
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
