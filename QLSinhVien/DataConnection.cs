using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace QLHocSinh
{
	public class DataConnection
    {
        private static readonly string str = @"Data Source=DESKTOP-H3U36OI\SQLEXPRESS;Initial Catalog=QuanLyHocSinhTH;Integrated Security=True";
		
		public static SqlConnection GetConnection()
		{
			return new SqlConnection(str);
		}
	}
}
