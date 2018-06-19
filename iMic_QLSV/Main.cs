using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using iMic_QLSV.Repository;
using iMic_QLSV.Helper;

namespace iMic_QLSV
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static SinhVienRepository dbSVContext = new SinhVienRepository();
        public static KhoaRepository dbKhoaContext = new KhoaRepository();
        public static LoginRepository dbLoginContext = new LoginRepository();
        public static List<tbl_DangNhap> _User;
        private tbl_Khoa _Khoa;
        public static string _userLogin;

        public Main(string userLogin)
        {
            InitializeComponent();

            _userLogin = userLogin; //get username
            _User = User(_userLogin); //get Object User -> a record in tbl_DangNhap
            LoadInforInMainForm();
        }
        public Main()
        {
            InitializeComponent();
        }

        #region FUNCTIONS

        
        private List<tbl_DangNhap> User(string userLogin)
        {
            var dbSinhVien = dbLoginContext.GetObjectByID(userLogin);
            return dbSinhVien;
        }

        private void LoadInforInMainForm()
        {
            btnUserLogin.Caption ="User: " + _userLogin;
            lblMSSV.Caption = "MSSV: "+ _User.FirstOrDefault().MSSV;
            var SinhVien = dbSVContext.GetObjectByID(_User.FirstOrDefault().MSSV).FirstOrDefault();
            lblSinhVien.Caption = SinhVien.Ho +" "+ SinhVien.Ten;
            _Khoa = dbKhoaContext.GetKhoaByMaKhoa(SinhVien.MaKhoa).FirstOrDefault();
            lblKhoa.Caption = _Khoa.TenKhoa;
        }
        private void LoadInfoPersonal()
        {
            var mssv = _User.FirstOrDefault().MSSV;

            bool role = mssv == "admin" ? true : false;
            var sv = dbSVContext.GetObjectByID(mssv);
            var fInfo = new View.FrmThongTinSV(sv.FirstOrDefault(), role);
            if (fInfo.ShowDialog() == DialogResult.OK)
            {
                ShowAlert("Thông báo", "Cập nhật thông tin thành công ");
            }
        }

        private Form GetFormChild(string fName)
        {
            return this.MdiChildren.FirstOrDefault(fr => fr.Name == fName);
        }

        private bool CheckRole()
        {
            bool isAdmin = true;
            if (_userLogin != "admin")
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        private void EnabledForRole()
        {

        }

        private void DisableForRole()
        {
            btnQuanLyNguoiDung.Enabled = false;
            btnKhoa.Enabled = false;
        }

        private void LoadFunctionRole()
        {
            if (CheckRole()) // true -> Admin
            {
                //TODO
                EnabledForRole();
            }

            else
            {
                DisableForRole();
            }
        }

        private void ShowForm_DanhSachSinhVien()
        {
            string fName = "DanhSachSinhVien";
            Form f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.FrmDanhSachSV();
                f.Name = fName;
                f.MdiParent = this;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowForm_QuanTriNguoiDung()
        {
            string fName = "DanhSachNguoiDung";
            Form f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.Admin.FrmQuanLyNguoiDung();
                f.Name = fName;
                f.MdiParent = this;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowForm_Khoa()
        {
            string fName = "DanhSachKhoa";
            Form f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.Khoa.FrmDanhSachKhoa();
                f.Name = fName;
                f.MdiParent = this;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowForm_MonHoc()
        {
            string fName = "MonHoc";
            var f = GetFormChild(fName);
            if(f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.MonHoc.FrmMonHoc();
                f.Name = fName;
                f.MdiParent = this;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowFrom_DangKyMonHoc()
        {
            string fName = "DangKyMonHoc";
            var f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.MonHoc.FrmDangKyMonHoc();
                f.MdiParent = this;
                f.Name = fName;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowForm_Diem()
        {
            string fName = "DanhMucDiem";
            Form f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new View.Diem.FrmDiem();
                f.Name = fName;
                f.MdiParent = this;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        private void ShowForm_KetQuaTotNghiep()
        {
            string fName = "KetQua";
            var f = GetFormChild(fName);
            if (f == null)
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                f = new Report.View.FrmReportKQTN(_Khoa.MaKhoa);
                f.MdiParent = this;
                f.Name = fName;
                f.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
            }
            else
            {
                f.Activate();
            }
        }

        public void ShowAlert(string title, string caption)
        {
            alertInfo.Show(this, title, caption);
        }
        
        #endregion

        #region EVENTS OF FORM


        private void Main_Load(object sender, EventArgs e)
        {
            LoadFunctionRole();
            //ShowForm_DanhSachSinhVien();
            lblTime.Caption = DateTime.Now.ToLongDateString();
        }

        private void btnDanhSachSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_DanhSachSinhVien();
            if(CheckRole())
            {
                EnabledForRole();
            }
            else
            {
                DisableForRole();
            }
        }

        private void btnDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_Diem();
        }


        private void btnThongTinCaNhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadInfoPersonal();
        }
        
        private void btnQuanLyNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_QuanTriNguoiDung();
        }

        private void btnKhoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_Khoa();
        }

        private void btnMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_MonHoc();
        }

        private void btnDangKyMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowFrom_DangKyMonHoc();
        }

        private void btnKetQuaTN_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm_KetQuaTotNghiep();
        }

        private void btnInfoSoftware_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new View.Common.FrmInformation();
            f.ShowDialog();
        }

        #endregion

    }
}