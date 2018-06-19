using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Repository
{
    public class KhoaRepository
    {
        public SinhVienEntities dbKhoaContext = new SinhVienEntities();

        public List<tbl_Khoa> GetAllKhoa()
        {
            dbKhoaContext = new SinhVienEntities();
            var listKhoa = (from k in dbKhoaContext.tbl_Khoa
                            select k).ToList();
            return listKhoa;
        }

        public List<tbl_Khoa> UpdateKhoaByMaKhoa(string MaKhoa)
        {
            dbKhoaContext = new SinhVienEntities();
            var khoa = (from k in dbKhoaContext.tbl_Khoa
                       where k.MaKhoa == MaKhoa
                       select k).ToList();
            return khoa;
        }

        public void UpdateKhoaFromGrid(string _MaKhoa, string _TenKhoa)
        {
            dbKhoaContext = new SinhVienEntities();
            tbl_Khoa khoa = new tbl_Khoa
            {
                MaKhoa = _MaKhoa,
                TenKhoa = _TenKhoa,
            };
            dbKhoaContext.tbl_Khoa.Add(khoa);
            dbKhoaContext.SaveChanges(); 
        }

        public int GetTotalSinhVienByMaKhoa(string MaKhoa)
        {
            dbKhoaContext = new SinhVienEntities();
            var total = (from sv in dbKhoaContext.tbl_SinhVien
                         where sv.MaKhoa == MaKhoa
                         select sv).ToArray().Length;
            return total;
        }

        public List<tbl_Khoa> GetKhoaByMaKhoa(string _MaKhoa)
        {
            dbKhoaContext = new SinhVienEntities();
            var tblKhoa = from k in dbKhoaContext.tbl_Khoa
                          where k.MaKhoa == _MaKhoa
                          select k;
            return tblKhoa.ToList();
        }

        public void DeleteKhoaByMaKhoa(string _MaKhoa)
        {
            tbl_Khoa khoa = new tbl_Khoa { MaKhoa = _MaKhoa };
            this.dbKhoaContext.tbl_Khoa.Attach(khoa);
            this.dbKhoaContext.Entry(khoa).State = System.Data.Entity.EntityState.Deleted;
            this.dbKhoaContext.SaveChanges();
        }

    }
}
