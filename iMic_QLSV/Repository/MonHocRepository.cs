using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Repository
{
    public class MonHocRepository
    {
        public SinhVienEntities dbMonHocContext = new SinhVienEntities();

        public List<tbl_DMMonHoc> GetAllMonHoc()
        {
            dbMonHocContext = new SinhVienEntities();

            var MonHoc = from mn in dbMonHocContext.tbl_DMMonHoc
                         select mn;
            return MonHoc.ToList();
        }

        public List<tbl_DMMonHoc> GetMonHocByMaKhoa(string _maKhoa)
        {
            dbMonHocContext = new SinhVienEntities();

            if(_maKhoa == "admin")
            {
                var MonHoc = from mn in dbMonHocContext.tbl_DMMonHoc
                             select mn;
                return MonHoc.ToList();
            }
            else
            {
                var MonHoc = from mn in dbMonHocContext.tbl_DMMonHoc
                             where mn.Khoa == _maKhoa
                             select mn;
                return MonHoc.ToList();
            }
        }

        public IEnumerable<Object> GetNewMonHocByMaKhoa(string MSSV, string _maKhoa)
        {
            dbMonHocContext = new SinhVienEntities();

                if (_maKhoa == "admin")
            {
                var MonHoc = from mn in dbMonHocContext.tbl_DMMonHoc.AsEnumerable()
                             select new
                             {
                                 MaMH = mn.MaMH,
                                 DangKy = (dbMonHocContext.tbl_Diem.Where(d => d.MSSV == MSSV && d.MaMH == mn.MaMH)).ToList().Count != 0 ? true : false
                             };
                return MonHoc;
            }
            else
            {
                var MonHoc = from mn in dbMonHocContext.tbl_DMMonHoc.AsEnumerable()
                             where mn.Khoa == _maKhoa
                             select new
                             {
                                 MaMH = mn.MaMH,
                                 DangKy = (dbMonHocContext.tbl_Diem.Where(d => d.MSSV == MSSV && d.MaMH == mn.MaMH)).ToList().Count != 0 ? true : false
                             };
                return MonHoc;
            }
        }

        

        public List<tbl_DMMonHoc> GetMonHocByMaMH(string _maMH)
        {
            dbMonHocContext = new SinhVienEntities();

            var MonHoc = from mh in dbMonHocContext.tbl_DMMonHoc
                         where mh.MaMH == _maMH
                         select mh;
            return MonHoc.ToList();
        }

        public void DeleteMonHocByMaMH(string _MaMH)
        {
            
            //tbl_DMMonHoc deleteMonHoc = null;
            using (dbMonHocContext = new SinhVienEntities())
            {
                var deleteMonHoc = dbMonHocContext.tbl_DMMonHoc.Where(d => d.MaMH == _MaMH).FirstOrDefault();
                dbMonHocContext.tbl_DMMonHoc.Remove(deleteMonHoc);
                dbMonHocContext.SaveChanges();
            }
        }
    }
}
