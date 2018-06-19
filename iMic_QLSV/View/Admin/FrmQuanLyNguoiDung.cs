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
using System.Data.Entity;


namespace iMic_QLSV.View.Admin
{
    public partial class FrmQuanLyNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private LoginRepository dbLoginContext = new LoginRepository();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        public FrmQuanLyNguoiDung()

        {
            InitializeComponent();
            LoadData();
        }

        #region FUNCTIONS

        private void LoadData()
        {
            //SinhVienEntities = new SinhVienEntities();

            var dbUser = dbLoginContext.GetAllUser();
            grc_DanhSachUser.Refresh();
            grc_DanhSachUser.DataSource = dbUser;
        }

        private void OnAdd()
        {
            ShowForm_ThongTinNguoiDung(null);
        }

        private void OnEdit()
        {
            var id = grv_DanhSachUser.GetFocusedRowCellValue(colTenDangNhap).ToString();
            var user = dbLoginContext.GetObjectByID(id).FirstOrDefault();
            ShowForm_ThongTinNguoiDung(user);
        }

        private void OnDelete()
        {
            try
            {
                var item = grv_DanhSachUser.GetSelectedRows().Length;
                if (item <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn user muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa user", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var rowHandle = grv_DanhSachUser.GetSelectedRows();

                    var MSSV = grv_DanhSachUser.GetRowCellValue(rowHandle[0], colMSSV).ToString();
                    SinhVienRepository.DeactiveLogin(MSSV);

                    var username = grv_DanhSachUser.GetRowCellValue(rowHandle[0], colTenDangNhap).ToString();
                    dbLoginContext.DeleteUserByUsername(username);

                    LoadData();
                    ShowAlert("Thông báo", "Cập nhật dữ liệu thành công");
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Người dùng đang login!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                return;
            }
        }

        private void ShowAlert(string tile, string text)
        {
            Main alert = new Main();
            alert.ShowAlert(tile, text);
        }

        #endregion

        #region EVENTS OF FORM

        /// <summary>
        /// Events of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnAdd();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grc_DanhSachUser_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        private void ShowForm_ThongTinNguoiDung(tbl_DangNhap obj)
        {
            var f = new View.Admin.FrmThongTinNguoiDung(obj);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Main alert = new Main();
                alert.ShowAlert("Thông báo", "Cập nhật thông tin thành công ");
                LoadData();
            }
        }

        private void grc_DanhSachUser_DoubleClick_1(object sender, EventArgs e)
        {
            OnEdit();
        }

        #endregion
    }
}