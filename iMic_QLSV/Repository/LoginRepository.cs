using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace iMic_QLSV.Repository
{
    public class LoginRepository
    {
        public SinhVienEntities dbContext = new SinhVienEntities();
       
        public List<tbl_DangNhap> GetAllUser()
        {
            dbContext = new SinhVienEntities();
            var user = (from us in dbContext.tbl_DangNhap
                             select us).ToList();
            
            return user;
        }

        public void DeleteUserByUsername(string username)
        {
            dbContext = new SinhVienEntities();
            var user = (from us in dbContext.tbl_DangNhap
                       where us.TenDangNhap == username
                       select us).FirstOrDefault();
            dbContext.tbl_DangNhap.Remove(user);
            dbContext.SaveChanges();
        }

        public void UpdateUserLogin(tbl_DangNhap dtDangNhap)
        {
            dbContext.tbl_DangNhap.Add(dtDangNhap);
            dbContext.SaveChanges();
        }

        public List<tbl_DangNhap> GetObjectByID(string ID)
        {
            dbContext = new SinhVienEntities();
            var dsSV = from sv in dbContext.tbl_DangNhap
                       where sv.TenDangNhap == ID
                       select sv;

            return dsSV.ToList();
        }
        public string GetFullNameByUser(string user)
        {
            dbContext = new SinhVienEntities();
            var userName = (from us in dbContext.tbl_DangNhap
                            where us.TenDangNhap == user
                            select us.TenDangNhap).FirstOrDefault();
            return userName.ToString();
        }

    }
}
