﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLHocSinh.DTO
{
    class MonHocDTO
    {
        public string MaMH { get; set; }
        public string TenMH { get; set; }
        public string SoTiet { get; set; }
        public string TongSoTiet { get; set; }
        public string MaGV { get; set; }
    }
}
