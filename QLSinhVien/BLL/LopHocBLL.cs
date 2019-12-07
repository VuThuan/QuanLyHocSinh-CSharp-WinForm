using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHocSinh.DAL;
using QLHocSinh.DTO;

namespace QLHocSinh.BLL
{
    class LopHocBLL
    {
        LopHocDAL LopHoc_dal = new LopHocDAL();

        public List<LopHocDTO> ShowDataLopHoc()
        {
            return LopHoc_dal.ShowDataLopHoc();
        }

        public bool InsertLopHoc(LopHocDTO LopHoc)
        {
            return LopHoc_dal.InsertLopHoc(LopHoc);
        }

        public bool DeleteLopHoc(string MaLop)
        {
            return LopHoc_dal.DeleteLopHoc(MaLop);
        }

        public bool UpdateLopHoc(LopHocDTO LopHoc)
        {
            return LopHoc_dal.UpdateLopHoc(LopHoc);
        }
    }
}
