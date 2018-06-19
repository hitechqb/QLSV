using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iMic_QLSV.Repository;

namespace iMic_QLSV.View
{
    public partial class FrmThongTinSV : DevExpress.XtraEditors.XtraForm
    {
        private SinhVienEntities SinhVienEntities = new SinhVienEntities();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private tbl_SinhVien _sinhvien;
        private bool _role = true;
        public FrmThongTinSV(tbl_SinhVien sinhVien, bool role)
        {
            InitializeComponent();
            _sinhvien = sinhVien;
            _role = role;

            LoadMaKhoa();
        }

        #region FUNCTIONS

       
        /// <summary>
        /// Functions
        /// </summary>
        private void LoadInfoSV()
        {
            if(_sinhvien == null)
            {
                txtMSSV.ReadOnly = false;

                txtMSSV.Text = string.Empty;
                txtHo.Text = string.Empty;
                txtTen.Text = string.Empty;
                imgCbGioiTinh.EditValue = true.ToString();
                dtNgaySinh.EditValue = DateTime.Today;
                txtNoiSinh.Text = string.Empty;
            }
            else
            {
                txtMSSV.Text = _sinhvien.MSSV;
                txtHo.Text = _sinhvien.Ho;
                txtTen.Text = _sinhvien.Ten;
                imgCbGioiTinh.Text = _sinhvien.GioiTinh.ToString();
                dtNgaySinh.EditValue = _sinhvien.NTNS;
                txtNoiSinh.Text = _sinhvien.NoiSinh;
                cbMaKhoa.EditValue = _sinhvien.MaKhoa;
            }
        }

        private void LoadInfoLogin()
        {
            var infoSVLogin = Main._User.FirstOrDefault();
            txtUserName.Text = infoSVLogin.TenDangNhap;
            txtPassword.Text = infoSVLogin.MatKhau;
        }

        private void LoadMaKhoa()
        {
            SinhVienEntities = new SinhVienEntities();
            foreach (var item in SinhVienEntities.tbl_Khoa)
            {
                cbMaKhoa.Properties.Items.Add(item.MaKhoa);
            }
        }

        private void onAdd()
        {
            tbl_SinhVien sv = new tbl_SinhVien
            {
                MSSV = txtMSSV.Text,
                Ho = txtHo.Text,
                Ten = txtTen.Text,
                NTNS = dtNgaySinh.DateTime,
                GioiTinh = (imgCbGioiTinh.Text == "Nam") ? true : false,
                MaKhoa = cbMaKhoa.Text,
                NoiSinh = txtNoiSinh.Text,
            };

            var dbContext = SinhVienRepository.GetMSSV();
            var kq = dbContext[0].ToString();
            foreach (var item in dbContext)
            {
                if (txtMSSV.Text == item.ToString())
                {
                    Main alert = new Main();
                    alert.ShowAlert("Thông báo", "Mã số sinh viên đã tồn tại!");
                    txtMSSV.SelectAll();
                    return;
                }
            }
            SinhVienEntities.tbl_SinhVien.Add(sv);
            SinhVienEntities.SaveChanges();
            DialogResult = DialogResult.OK;
        }

        private void onUpdate()
        {
            var svContext = SinhVienRepository.GetObjectByID(_sinhvien.MSSV).FirstOrDefault();

            svContext.Ho = txtHo.Text;
            svContext.Ten = txtTen.Text;
            svContext.GioiTinh = (imgCbGioiTinh.Text == "Nam") ? true : false;
            svContext.NTNS = dtNgaySinh.DateTime;
            svContext.MaKhoa = cbMaKhoa.Text;
            svContext.NoiSinh = txtNoiSinh.Text;

            SinhVienRepository.dbContext.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void onSave()
        {
            if (_sinhvien == null)  //ADD NEW
            {
                onAdd();
            }
            else //UPDATE
            {
                onUpdate();
            }
        }

        #endregion

        #region EVENTS OF FORM
       
        /// <summary>
        /// Events of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmThongTinSV_Load(object sender, EventArgs e)
        {
            txtMSSV.ReadOnly 
                = txtHo.ReadOnly 
                = txtTen.ReadOnly 
                = txtNoiSinh.ReadOnly 
                = cbMaKhoa.ReadOnly 
                = dtNgaySinh.ReadOnly
                = imgCbGioiTinh.ReadOnly
                = !_role;

            LoadInfoSV();
            LoadInfoLogin();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            onSave();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void lblShow_Click(object sender, EventArgs e)
        {
            if(txtPassword.Properties.UseSystemPasswordChar == true)
            {
                txtPassword.Properties.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.Properties.UseSystemPasswordChar = true;
            }
        }
        #endregion
    }
}