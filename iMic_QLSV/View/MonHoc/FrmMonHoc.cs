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

namespace iMic_QLSV.View.MonHoc
{
    public partial class FrmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private SinhVienRepository sinhVienRepository = new SinhVienRepository();
        private KhoaRepository khoaRepository = new KhoaRepository();
        private DiemRepository diemRepository = new DiemRepository();
        private MonHocRepository monHocRepository = new MonHocRepository();

        public FrmMonHoc()
        {
            InitializeComponent();

            if (isAdmin())
            {
                srcKhoa.ReadOnly = false;
            }
            LoadKhoa();
        }

        #region FUNCTIONS 

        private bool isAdmin()
        {
            var user = Main._User.FirstOrDefault().TenDangNhap;
            return user == "admin" ? true : false;
        }

        private void LoadKhoa()
        {
            var ListKhoa = khoaRepository.GetAllKhoa();

            srcKhoa.Properties.DataSource = ListKhoa;
            srcKhoa.Properties.ValueMember = "MaKhoa";
            srcKhoa.Properties.DisplayMember = "TenKhoa";
        }

        private void LoadData()
        {
            var _khoa = sinhVienRepository.GetObjectByID(Main._User.FirstOrDefault().MSSV).FirstOrDefault();
            srcKhoa.EditValue = _khoa.MaKhoa;

            LoadMonHocByMaKhoa(_khoa.MaKhoa);
        }

        private void OnDelete()
        {
            var countMonHoc = grv_MonHoc.SelectedRowsCount;

            if (countMonHoc <= 0)
            {
                XtraMessageBox.Show("Vui lòng chọn môn học muốn xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            else
            {
                if (XtraMessageBox.Show("Bạn muốn xóa môn học đã chọn", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Int32[] selectedRowHandles = grv_MonHoc.GetSelectedRows();

                    for (int i = 0; i < selectedRowHandles.Length; i++)
                    {
                        int selectedRowHandle = selectedRowHandles[i];
                        if (selectedRowHandle >= 0)
                        {
                            var maMH = grv_MonHoc.GetRowCellValue(selectedRowHandle, colMaMH).ToString();

                            var mhDiem = diemRepository.GetTotalDiemByMonHoc(maMH);
                            if (mhDiem > 0)
                            {
                                XtraMessageBox.Show("Môn học có mã " + maMH + " đang có điểm, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                                continue;
                            }

                            monHocRepository.DeleteMonHocByMaMH(maMH);
                        }
                    }

                    LoadData();
                    ShowAlert();
                }
            }
        }

        private void ShowAlert()
        {
            Main alert = new Main();
            alert.ShowAlert("Thông công", "Cập nhật thành công");
        }

        private void LoadMonHocByMaKhoa(string _maKhoa)
        {
            var MonHoc = monHocRepository.GetMonHocByMaKhoa(_maKhoa);
            grc_MonHoc.DataSource = MonHoc;
        }

        private void OnEdit()
        {
            string MaMH = grv_MonHoc.GetFocusedRowCellValue(colMaMH).ToString();
            var MonHoc = monHocRepository.GetMonHocByMaMH(MaMH);

            var f = new View.MonHoc.FrmThongTinMonHoc(MonHoc.FirstOrDefault(), srcKhoa.EditValue.ToString());
            if(f.ShowDialog() == DialogResult.OK)
            {
                ShowAlert();
                LoadMonHocByMaKhoa(srcKhoa.EditValue.ToString());
            }

        }
        #endregion

        #region EVENTS OF FORM

        private void srcKhoa_EditValueChanged(object sender, EventArgs e)
        {
            LoadMonHocByMaKhoa(srcKhoa.EditValue.ToString());
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var f = new View.MonHoc.FrmThongTinMonHoc(null, srcKhoa.EditValue.ToString());
            if(f.ShowDialog() == DialogResult.OK)
            {
                ShowAlert();
                LoadMonHocByMaKhoa(srcKhoa.EditValue.ToString());
            }
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
            

            //var selectItems = grv_MonHoc.GetSelectedRows();
            //if(selectItems.Length <= 0 || selectItems == null)
            //{
            //    XtraMessageBox.Show("Vui lòng chọn môn học cần xóa", "Thông báo", MessageBoxButtons.OK);
            //    return;
            //}
            //else
            //{
            //   if(XtraMessageBox.Show("Bạn muốn xóa môn học đã chọn", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        grv_MonHoc.DeleteSelectedRows();
            //        monHocRepository.dbMonHocContext.SaveChanges();

            //        ShowAlert();
            //    }
            //}
        }


        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grc_MonHoc_DoubleClick(object sender, EventArgs e)
        {
            OnEdit();
        }

        #endregion
    }
}