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
using System.Data.Entity;
using iMic_QLSV.Repository;
using iMic_QLSV.Helper;
using System.Data.Entity.Migrations;

namespace iMic_QLSV.View.Diem
{
    public partial class FrmDiem : DevExpress.XtraEditors.XtraForm
    {
        private DiemRepository DiemRepository = new DiemRepository();
        private LoginRepository LoginRepository = new LoginRepository();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private KhoaRepository KhoaRepository = new KhoaRepository();
        private DataTable _dtDiem = null;
        public FrmDiem()
        {
            InitializeComponent();
            grv_Diem.RowHeight = 26;
        }

        #region FUNCTIONS
        private void LoadData()
        {
            grv_Diem.CloseEditor();
           // grv_Diem.EndDataUpdate();
            List<Object> diem = null;
            if (isAdmin())
            {
                diem = DiemRepository.GetAllDanhSachDiem().ToList();
            }
            else
            {
                var MSSV = Main._User.FirstOrDefault().MSSV;
                var khoa = SinhVienRepository.GetObjectByID(MSSV).FirstOrDefault();
                diem = DiemRepository.GetAllDanhSachDiemByKhoa(khoa.MaKhoa).ToList();
            }
            _dtDiem = ConvertDataTable.LINQToDataTable(diem);
            grc_Diem.DataSource = _dtDiem;
        }
       
        private bool isAdmin()
        {
            string user = Main._userLogin;
            if (user == "admin")
            {
                return true;
            }
            else
                return false;
        }

        private void ShowAlert(string tile, string text)
        {
            Main alert = new Main();
            alert.ShowAlert(tile, text);
        }
        private bool OnSave()
        {
            var count = grv_Diem.SelectedRowsCount;

            var getChanges = _dtDiem.GetChanges();
            if (getChanges == null || count <= 0)
            {
                return false;
            }
            else
            {
                var indexDiem = grv_Diem.GetFocusedDataRow();
                string MSSV = indexDiem.ItemArray[0].ToString();
                string MaMH = indexDiem.ItemArray[3].ToString();
                float Diem = float.Parse(indexDiem.ItemArray[5].ToString());

                var diem = DiemRepository.UpdateDiemToDataBase(MSSV, MaMH, Diem);
                return diem;
            }
        }
        #endregion

        #region EVENTS OF FORM
        private void FrmDiem_Load(object sender, EventArgs e)
        {
            //dbContext.tbl_Diem.Load();
            //grc_Diem.DataSource = dbContext.tbl_SinhVien.Local.ToBindingList();

            LoadData();

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OnSave())
            {
                ShowAlert("Thông báo", "Đã cập nhật!");
            }
            else
            {
                ShowAlert("Thông báo", "Dữ liệu chưa thay đổi");
            }
        }

        private void grv_Diem_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (OnSave())
            {
                ShowAlert("Thông báo", "Đã cập nhật!");
            }
        }
        
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion
        
    }
}