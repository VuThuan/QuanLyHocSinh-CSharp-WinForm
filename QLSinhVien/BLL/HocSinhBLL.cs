using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHocSinh.DAL;
using QLHocSinh.DTO;

namespace QLHocSinh.BLL
{
	public class HocSinhBLL
    {
        HocSinhDAL HocSinh_dal = new HocSinhDAL();

        public List<HocSinhDTO> ShowDataHocSinh()
        {
            return HocSinh_dal.ShowDataHocSinh();
        }

        public bool InsertHocSinh(HocSinhDTO HocSinh)
        {
            return HocSinh_dal.InsertHocSinh(HocSinh);
        }

        public bool DeleteHocSinh(string MaHS)
        {
            return HocSinh_dal.DeleteHocSinh(MaHS);
        }

        public bool UpdateHocSinh(HocSinhDTO HocSinh)
        {
            return HocSinh_dal.UpdateHocSinh(HocSinh);
        }
    }
}
