using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLHocSinh
{
	public class HocSinhDAL
	{
		public static void AddStudent (HocSinh hocSinh)
		{
			try
			{
				using (SqlConnection connection = DataConnection.GetConnection())
				{
					connection.Open();
					string query = "insert into HocSinh values (@MaHS, @TenHS, @Tuoi, @GioiTinh, @NoiSinh, @MaKhoi)";
					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.Add("@MaHS", SqlDbType.Char).Value = hocSinh.MaHS;
					command.Parameters.Add("@TenHS", SqlDbType.NVarChar).Value = hocSinh.TenHS;
					command.Parameters.Add("@Tuoi", SqlDbType.SmallInt).Value = hocSinh.Tuoi;
					command.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = hocSinh.GioiTinh;
					command.Parameters.Add("@NoiSinh", SqlDbType.NVarChar).Value = hocSinh.NoiSinh;
					command.Parameters.Add("@MaKhoi", SqlDbType.Char).Value = hocSinh.MaKhoi;
					command.ExecuteNonQuery();
					connection.Close();
					connection.Dispose();
				
				}
			}
			catch (SqlException ex)
			{
				throw ex;
			}
		}

		// các hàm còn lại

	}
}
