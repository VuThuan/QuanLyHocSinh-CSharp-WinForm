using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHocSinh.DAL;
using QLHocSinh.DTO;

namespace QLHocSinh.BLL
{
    class GiaoVienBLL
    {
        GiaoVienDAL GiaoVien_dal = new GiaoVienDAL();

        public List<GiaoVienDTO> ShowDataGiaoVien()
        {
            return GiaoVien_dal.ShowDataGiaoVien();
        }

        public bool InsertGiaoVien(GiaoVienDTO GiaoVien)
        {
            return GiaoVien_dal.InsertGiaoVien(GiaoVien);
        }

        public bool DeleteGiaoVien(string MaGV)
        {
            return GiaoVien_dal.DeleteGiaoVien(MaGV);
        }

        public bool UpdateGiaoVien(GiaoVienDTO GiaoVien)
        {
            return GiaoVien_dal.UpdateGiaoVien(GiaoVien);
        }
    }
}
