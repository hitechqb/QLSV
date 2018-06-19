using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Repository
{
    public class SinhVienRepository
    {
        public SinhVienEntities dbContext = new SinhVienEntities();

        public void SaveChanges()
        {
            dbContext = new SinhVienEntities();
            dbContext.SaveChanges();
        }
        public List<string> GetMSSV()
        {
            dbContext = new SinhVienEntities();
            var MSSV = (from sv in dbContext.tbl_SinhVien
                        select sv.MSSV).ToList();

            return MSSV;
        }

        public List<tbl_SinhVien> GetAllSinhVien()
        {
            dbContext = new SinhVienEntities();
            var sinhvien = (from sv in dbContext.tbl_SinhVien
                            select sv).ToList();

            return sinhvien;
        }

        public IEnumerable<Object> GetAllSinhVienWithFullName()
        {
            dbContext = new SinhVienEntities();
            var sinhvien = from sv in dbContext.tbl_SinhVien.AsEnumerable()
                            select new
                            {
                                MSSV = sv.MSSV,
                                HoTen = sv.Ho + " " + sv.Ten
                            };

            return sinhvien;
        }

        public List<tbl_SinhVien> GetAllSinhVienNotAdmin()
        {
            dbContext = new SinhVienEntities();
            var sinhvien = (from sv in dbContext.tbl_SinhVien
                            where sv.MSSV !="admin"
                            orderby sv.MaKhoa ascending
                            select sv).ToList();

            return sinhvien;
        }

        public List<tbl_SinhVien> GetAllSinhVienNotActive(string currentSV)
        {
            dbContext = new SinhVienEntities();
            var sinhvien = (from sv in dbContext.tbl_SinhVien
                            where sv.isUserLogin != true || sv.MSSV == currentSV
                        select sv).ToList();

            return sinhvien;
        }

        public void UpdateIsActived(string newMSSV, string oldMSSV)
        {
            dbContext = new SinhVienEntities();
            var svNew = (from s in dbContext.tbl_SinhVien
                      where s.MSSV == newMSSV
                      select s).FirstOrDefault();
            svNew.isUserLogin = true;
            dbContext.SaveChanges();

            if (!string.IsNullOrEmpty(oldMSSV))
            {
                dbContext = new SinhVienEntities();
                var svOld = (from s in dbContext.tbl_SinhVien
                             where s.MSSV == oldMSSV
                             select s).FirstOrDefault();
                svOld.isUserLogin = false;

            }

            dbContext.SaveChanges();
        }

        public void DeactiveLogin(string MSSV)
        {
            dbContext = new SinhVienEntities();
            var sinhvien = (from sv in dbContext.tbl_SinhVien
                        where sv.MSSV == MSSV
                        select sv).FirstOrDefault();

            sinhvien.isUserLogin = false;
            dbContext.SaveChanges();
        }

        public void DeleteSinhVienByMSSV(string _MSSV)
        {
            dbContext = new SinhVienEntities();
            var sinhvien = dbContext.tbl_SinhVien.Where(sv => sv.MSSV == _MSSV).FirstOrDefault();
            dbContext.tbl_SinhVien.Remove(sinhvien);
            dbContext.SaveChanges();
        }

        public List<tbl_SinhVien> GetObjectByID(string ID)
        {
            dbContext = new SinhVienEntities();
            var dbSV = (from sv in dbContext.tbl_SinhVien
                        where sv.MSSV == ID
                        select sv).ToList();
            return dbSV;
        }

        public List<tbl_SinhVien> GetSinhVienByKhoa(string _MaKhoa)
        {
            var sinhvien = from sv in dbContext.tbl_SinhVien
                           where sv.MaKhoa == _MaKhoa
                           select sv;
            return sinhvien.ToList();
        }

        public IEnumerable<Object> GetAllSinhVienToExportExcel(string _maKhoa)
        {
            dbContext = new SinhVienEntities();
            var dbSV = from sv in dbContext.tbl_SinhVien
                       join BangKhoa in dbContext.tbl_Khoa
                       on sv.MaKhoa equals BangKhoa.MaKhoa
                       select new
                       {
                           sv.MSSV,
                           sv.Ho,
                           sv.Ten,
                           GioiTinh = sv.GioiTinh == true?"Nam": "Nữ",
                           sv.NTNS,
                           sv.NoiSinh,
                           sv.MaKhoa,
                           BangKhoa.TenKhoa,
                           sv.KetQuaTN,
                           sv.DTB,
                           sv.XepLoaiTN,
                       };
            return dbSV;
        }
        public IEnumerable<Object> GetSinhVienToExportExcel(string _maKhoa)
        {
            dbContext = new SinhVienEntities();
            var dbSV = from sv in dbContext.tbl_SinhVien
                       where sv.MaKhoa == _maKhoa
                       join BangKhoa in dbContext.tbl_Khoa
                       on sv.MaKhoa equals BangKhoa.MaKhoa
                       select new
                       {
                           sv.MSSV,
                           sv.Ho, 
                           sv.Ten,
                           GioiTinh = sv.GioiTinh == true ? "Nam" : "Nữ",
                           sv.NTNS,
                           sv.NoiSinh,
                           sv.MaKhoa,
                           BangKhoa.TenKhoa,
                           sv.KetQuaTN,
                           sv.DTB,
                           sv.XepLoaiTN,
                       };
            return dbSV;
        }
        public void UpdateGridViewToDataBase(DataRow db)
        {
            dbContext = new SinhVienEntities();
            tbl_SinhVien sv = new tbl_SinhVien
            {
                MSSV = db.ItemArray[0].ToString(),
                Ho = db.ItemArray[1].ToString(),
                Ten = db.ItemArray[2].ToString(),
                GioiTinh = (db.ItemArray[3].ToString() == "Nam")? true: false,
                NTNS = DateTime.Parse(db.ItemArray[4].ToString()),
                NoiSinh = db.ItemArray[5].ToString(),
                MaKhoa = db.ItemArray[6].ToString(),
            };
            dbContext.tbl_SinhVien.Add(sv);
            dbContext.SaveChanges();
        }

        //XÉT TN
        public void UpdateKetQuaTN(string MSSV, string XepLoai, double? DiemTB, bool KetQuaTN)
        {
            dbContext = new SinhVienEntities();
            var sinhvien = (from sv in dbContext.tbl_SinhVien
                           where sv.MSSV == MSSV
                           select sv).FirstOrDefault();

            sinhvien.XepLoaiTN = XepLoai;
            sinhvien.DTB = DiemTB;
            sinhvien.KetQuaTN = KetQuaTN;
            dbContext.SaveChanges();
        }
    }
}
