using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLHocSinh.DAL;
using QLHocSinh.DTO;

namespace QLHocSinh.BLL
{
    class MonHocBLL
    {
        MonHocDAL monHoc_dal = new MonHocDAL();

        public List<MonHocDTO> ShowDataMonHoc()
        {
            return monHoc_dal.ShowDataMonHoc();
        }

        public bool InsertMonHoc(MonHocDTO MonHoc)
        {
            return monHoc_dal.InsertMonHoc(MonHoc);
        }

        public bool DeleteMonHoc(string MaMH)
        {
            return monHoc_dal.DeleteMonHoc(MaMH);
        }

        public bool UpdateMonHoc(MonHocDTO monHoc)
        {
            return monHoc_dal.UpdateMonHoc(monHoc);
        }
    }
}
