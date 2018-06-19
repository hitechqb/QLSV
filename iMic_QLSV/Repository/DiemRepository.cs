using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Repository
{
    public class DiemRepository
    {
        public SinhVienEntities dbContext = new SinhVienEntities();

        public IEnumerable<Object> GetAllDanhSachDiem()
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem.AsEnumerable()
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         MaMH = diem.MaMH,
                         TenMH = MonHoc.TenMH,
                         Diem = diem.Diem,
                     };

            return ds;
        }

        public IEnumerable<Object> GetAllDanhSachDiemByKhoa(string _MaKhoa)
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem.AsEnumerable()
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     where SinhVien.MaKhoa == _MaKhoa
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         MaMH = diem.MaMH,
                         TenMH = MonHoc.TenMH,
                         Diem = diem.Diem,
                     };

            return ds;
        }

        public void DeleteSinhVienInDiemByMSSV(string _MSSV)
        {
            dbContext = new SinhVienEntities();
            var diem = from d in dbContext.tbl_Diem
                       where d.MSSV == _MSSV
                       select d;

            dbContext.tbl_Diem.RemoveRange(diem);
            dbContext.SaveChanges();
        }

        public int GetTotalDiemByMonHoc(string _MaMH)
        {
            dbContext = new SinhVienEntities();
            var total = from diem in dbContext.tbl_Diem
                        where diem.MaMH == _MaMH
                        select diem;

            return total.ToList().Count;
        }

        public bool UpdateDiemToDataBase(string MSSV, string MaMH, float Diem)
        {
            using (dbContext = new SinhVienEntities())
            {
                var diem = (from d in dbContext.tbl_Diem
                            where d.MSSV == MSSV && d.MaMH == MaMH
                            select d).FirstOrDefault();
                diem.Diem = Diem;
                dbContext.SaveChanges();
                return true;
            }
        }

        public int UpdateThongTinDangKyMonHoc(string _MSSV, DataRow index)
        {
            int result = 0;

            string _MaMH = index.ItemArray[0].ToString();
            bool _Diem = bool.Parse(index.ItemArray[1].ToString());

            dbContext = new SinhVienEntities();

            //Check 
            //(1) Nếu điểm = true (chưa đăng ký: Vì cellChanged tức là giá trị trước khi change là false) -> INSERT with Diem = NULL
            //(2) Nếu có điểm: -> không cho Hủy đăng ký. 
            //(3) Nếu điểm == null: -> có thể Hủy đăng ký. =>Remove.

            if (_Diem == true)
            {
                //TODO: (1) Insert
                tbl_Diem dtDiem = new tbl_Diem
                {
                    MSSV = _MSSV,
                    MaMH = _MaMH,
                    Diem = null
                };
                dbContext.tbl_Diem.Add(dtDiem);
                dbContext.SaveChanges();
                result = 1; // "Đã đăng ký môn học";
            }
            else
            {
                //TODO : 
                //Ktra Diem != null -> Không cho hủy đăng ký
                var _diem = dbContext.tbl_Diem.Where(d => d.MSSV == _MSSV
                                                                 && d.MaMH == _MaMH).FirstOrDefault();
                if (_diem.Diem != null)
                {
                    //TODO (2)
                    result = 2; // "Môn học này đã có điểm, không thể hủy đăng ký";
                }
                else
                {
                    //TODO (3)
                    dbContext.tbl_Diem.Remove(_diem);
                    dbContext.SaveChanges();
                    result = 3;  //"Hủy đăng ký thành công";
                }
            }

            return result;
        }

        //XÉT TN
        public List<tbl_Diem> GetMonHocByMSSV(string _MSSV)
        {
            dbContext = new SinhVienEntities();
            var MonHoc = from mh in dbContext.tbl_Diem
                         where mh.MSSV == _MSSV
                         select mh;
            return MonHoc.ToList();
        }

        public IEnumerable<Object> GetDataKetQuaTN()
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         NTNS = SinhVien.NTNS,
                         GioiTinh = SinhVien.GioiTinh,
                         MaKhoa = SinhVien.MaKhoa,
                         MonHoc = diem.MaMH,
                         Diem = diem.Diem,
                         DTB = SinhVien.DTB,
                         KetQuaTN = SinhVien.KetQuaTN,
                         XepLoaiTN = SinhVien.XepLoaiTN,
                     };

            return ds;
        }

        public IEnumerable<Object> GetDataKetQuaTNByKhoa(string _MaKhoa)
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     where SinhVien.MaKhoa == _MaKhoa
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         NTNS = SinhVien.NTNS,
                         GioiTinh = SinhVien.GioiTinh,
                         MaKhoa = SinhVien.MaKhoa,
                         MonHoc = diem.MaMH,
                         Diem = diem.Diem,
                         DTB = SinhVien.DTB,
                         KetQuaTN = SinhVien.KetQuaTN,
                         XepLoaiTN = SinhVien.XepLoaiTN,
                     };

            return ds;
        }

        public IEnumerable<Object> GetDataKetQuaByMaKhoaAndKetQuaTN(string _MaKhoa, bool _KetQua )
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     where SinhVien.MaKhoa == _MaKhoa && SinhVien.KetQuaTN == _KetQua
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         NTNS = SinhVien.NTNS,
                         GioiTinh = SinhVien.GioiTinh,
                         MaKhoa = SinhVien.MaKhoa,
                         MonHoc = diem.MaMH,
                         Diem = diem.Diem,
                         DTB = SinhVien.DTB,
                         KetQuaTN = SinhVien.KetQuaTN,
                         XepLoaiTN = SinhVien.XepLoaiTN,
                     };

            return ds;
        }

        public IEnumerable<Object> GetDataKetQuaByKetQuaTN(bool _KetQua)
        {
            dbContext = new SinhVienEntities();
            var ds = from diem in dbContext.tbl_Diem
                     join SinhVien in dbContext.tbl_SinhVien
                     on diem.MSSV equals SinhVien.MSSV
                     where SinhVien.KetQuaTN == _KetQua
                     join MonHoc in dbContext.tbl_DMMonHoc
                     on diem.MaMH equals MonHoc.MaMH
                     select new
                     {
                         MSSV = diem.MSSV,
                         Ho = SinhVien.Ho,
                         Ten = SinhVien.Ten,
                         NTNS = SinhVien.NTNS,
                         GioiTinh = SinhVien.GioiTinh,
                         MaKhoa = SinhVien.MaKhoa,
                         MonHoc = diem.MaMH,
                         Diem = diem.Diem,
                         DTB = SinhVien.DTB,
                         KetQuaTN = SinhVien.KetQuaTN,
                         XepLoaiTN = SinhVien.XepLoaiTN,
                     };

            return ds;
        }

    }
}
