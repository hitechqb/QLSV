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
using iMic_QLSV.Helper;

namespace iMic_QLSV.View.MonHoc
{
    public partial class FrmDangKyMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private MonHocRepository MonHocRepository = new MonHocRepository();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private DiemRepository DiemRepository = new DiemRepository();
        private DataTable dtSinhVien = null;
        private DataTable dtMonHoc = null;

        public FrmDangKyMonHoc()
        {
            InitializeComponent();
            LoadSinhVien();
            LoadDataMonHoc();
        }

        #region FUNCTIONS
        
        private void LoadSinhVien()
        {
            var sinhvien = SinhVienRepository.GetAllSinhVienWithFullName();
            dtSinhVien = ConvertDataTable.LINQToDataTable(sinhvien);
            srcSinhVien.DataSource = dtSinhVien;
            srcSinhVien.ValueMember = "MSSV";
            srcSinhVien.DisplayMember = "HoTen";
        }

        private void LoadDataMonHoc()
        {
            var MonHoc = MonHocRepository.GetAllMonHoc();
            srcMonHoc.DataSource = MonHoc;
            srcMonHoc.ValueMember = "MaMH";
            srcMonHoc.DisplayMember = "TenMH";
        }

        private void LoadMonHocByKhoa()
        {
            var sinhvien = barSinhVien.EditValue.ToString();
            var Khoa = SinhVienRepository.GetObjectByID(sinhvien).FirstOrDefault();

            var MonHoc = MonHocRepository.GetNewMonHocByMaKhoa(sinhvien, Khoa.MaKhoa);
            dtMonHoc = ConvertDataTable.LINQToDataTable(MonHoc);
            grc_MonHoc.DataSource = dtMonHoc;
            
        }

        private void LoadData()
        {
            if (isAdmin())
            {
                //TODO
                srcSinhVien.ReadOnly = false;
            }
            else
            {
                //TODO
                srcSinhVien.ReadOnly = true;
            }
        }

        private bool isAdmin()
        {
            if (Main._userLogin == "admin")
                return true;
            return false;
        }

        private void ShowAlert(string text)
        {
            Main alert = new Main();
            alert.ShowAlert("Thông báo", text);
        }

        #endregion

        #region EVENTS OF FORM

        private void FrmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
            barSinhVien.EditValue = Main._User.FirstOrDefault().MSSV;
        }

        private void barSinhVien_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonHocByKhoa();
        }

        private void grv_MonHoc_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //var check = grv_MonHoc.GetFocusedRowCellValue(colDK).ToString();
            //Update to DB
            var index = grv_MonHoc.GetFocusedDataRow();

            int value = DiemRepository.UpdateThongTinDangKyMonHoc(barSinhVien.EditValue.ToString(), index);

            //RESULT of VALUE : 1->Đăng ký thành công ; 2 ->Không cho Hủy đăng ký vì có điểm; 3->Hủy thành công.
            if (value == 1)
            {
                ShowAlert("Đăng ký thành công");
            }
            else if (value == 2)
            {
                XtraMessageBox.Show("Môn học đã có điểm, không thể hủy đăng ký", "Thông báo", MessageBoxButtons.OK);
                LoadMonHocByKhoa();
            }
            else if (value == 3)
            {
                ShowAlert("Đã hủy đăng ký môn học");
            }

            //XtraMessageBox.Show(check, "Thông báo", MessageBoxButtons.OK);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadMonHocByKhoa();
        }

        #endregion

    }
}