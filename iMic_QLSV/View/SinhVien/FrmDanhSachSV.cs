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
using ClosedXML.Excel;
using DevExpress.XtraGrid.Views.Grid;

namespace iMic_QLSV.View
{
    public partial class FrmDanhSachSV : DevExpress.XtraEditors.XtraForm
    {
        private KhoaRepository KhoaRepository = new KhoaRepository();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private MonHocRepository MonHocRepository = new MonHocRepository();
        private DiemRepository DiemRepository = new DiemRepository();
        public FrmDanhSachSV()
        {
            InitializeComponent();

            if (!CheckUser())
            {
                btnAddNew.Enabled 
                    = btnDel.Enabled 
                    = false;

                srcKhoa.ReadOnly = true;
            }

            LoadKhoa();
        }
        #region FUNCTIONS

       
        /// <summary>
        /// Functions: LoadData, ExportExcel, ImportExcel, ShowFormDetail
        /// </summary> 

        private void LoadData()
        {
            List<tbl_SinhVien> dtSV = null;
            #region LoadData By Instantiate DbContext
            if (CheckUser())
            {
                //Load Data for Admin
                dtSV = SinhVienRepository.GetAllSinhVienNotAdmin();
                srcKhoa.ReadOnly = false;
            }

            else
            {
                //Load Data for Khoa
                var MSSV = Main._User.FirstOrDefault().MSSV;
                var khoa = SinhVienRepository.GetObjectByID(MSSV).FirstOrDefault();
                srcKhoa.EditValue = khoa.MaKhoa;
                dtSV = SinhVienRepository.GetSinhVienByKhoa(khoa.MaKhoa);
                 
            }

            imgBoxGioiTinh.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Nam", true, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Nữ", false, 0)});
            imgBoxGioiTinh.SmallImages = imgList;

            grc_DanhSachSV.DataSource = dtSV;
            if (srcKhoa.EditValue == null)
            {
                srcKhoa.EditValue = "admin";
            }

            #endregion
        }

        private void LoadKhoa()
        {
            var ListKhoa = KhoaRepository.GetAllKhoa();
            srcKhoa.Properties.DataSource = ListKhoa;
            srcKhoa.Properties.ValueMember = "MaKhoa";
            srcKhoa.Properties.DisplayMember = "TenKhoa";
        }

        private bool CheckUser()
        {
            if(Main._userLogin != "admin")
            {
                return false;
            }
            return true;
        }

        private void ShowFormDetail(tbl_SinhVien sinhvien, bool role)
        {
            var f = new View.FrmThongTinSV(sinhvien, role);
            if (f.ShowDialog() == DialogResult.OK)
            {
                Main alert = new Main();
                alert.ShowAlert("Thông báo", "Cập nhật thành công!");
                LoadSinhVienByKhoa();
            }
            else
            {
                Main alert = new Main();
                alert.ShowAlert("Thông báo", "Bạn bấm cancel!");
            }
        }

        private void ExportExcel()
        {
            IEnumerable<Object> dtSV = null;
            var MaKhoa = srcKhoa.EditValue.ToString();
            if(MaKhoa == "admin")
            {
                dtSV = SinhVienRepository.GetAllSinhVienToExportExcel(srcKhoa.EditValue.ToString());
            }
            else
            {
                dtSV = SinhVienRepository.GetSinhVienToExportExcel(srcKhoa.EditValue.ToString());
            }

            DataTable dt = ConvertDataTable.LINQToDataTable(dtSV);
            SaveExcel.FileName = "DanhSachSV";

            if (SaveExcel.ShowDialog() == DialogResult.OK)
            {
                string FolderPath = SaveExcel.FileName;
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add(dt, "Temp");
                    wb.SaveAs(FolderPath + ".xlsx");
                }

                XtraMessageBox.Show("Xuất Excel thành công !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ImportExcel()
        {
            if(srcKhoa.EditValue.ToString() == "admin")
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa để cập nhật sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                var f = new View.Common.FrmImportExcel(srcKhoa.EditValue.ToString());
                if (f.ShowDialog() == DialogResult.OK)
                {
                    Main alert = new Main();
                    alert.ShowAlert("Thông báo", "Dữ liệu cập nhật thành công");
                    LoadSinhVienByKhoa();
                }

                else
                {
                    Main alert = new Main();
                    alert.ShowAlert("Thông báo", "Bạn bấm cancel ");
                }
            }
        }

        private void XetTotNghiep()
        {
            //(1) - Các sinh viên phải có tổng tín chỉ là bằng 6 và điểm các môn phài lớn hơn hoặc bằng 5 theo từng khoa.
            //Nếu thiếu điểm hoặc có môn dưới 5 thì 
            //phải xuất ra thông báo ngay cột xếp loại tốt nghiệp là chưa đủ điều kiện xét tốt nghiệp.

            //=> THUẬT TOÁN cho (1):  
            /* Kiểm tra các môn học sinh viên đăng ký (Bảng Điểm) -> MonHoc Đăng ký < 0 -> return KHÔNG ĐỦ ĐK
                - Nếu Điểm == NULL || Điểm < 5 -> return KHÔNG ĐỦ ĐK.
                - Sum(chứng chỉ) các môn học đã đăng ký.
                    + Nếu < 6 -> return "KHÔNG ĐỦ ĐK";

                Else: 
                - Xét Tốt Nghiệp.
            */

            var SelectItems = grv_DanhSachSV.GetSelectedRows();
            if (SelectItems.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sinh viên cần xét tốt nghiệp", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                KiemTraDieuKienXetTN();
                LoadSinhVienByKhoa();
                XtraMessageBox.Show("Đã xét tốt nghiệp cho sinh viên được chọn", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void KiemTraDieuKienXetTN()
        {
            var SelectItems = grv_DanhSachSV.GetSelectedRows();
            foreach (var item in SelectItems)
            {
                var MSSV = grv_DanhSachSV.GetRowCellValue(item, colMSSV).ToString();
                string XepLoai = string.Empty;
                var listMH = DiemRepository.GetMonHocByMSSV(MSSV);

                if (listMH.Count <= 0)
                {
                    XepLoai = "Chưa đủ điều kiện TN";
                    //XtraMessageBox.Show("Không đủ ĐK Xét TN vì chưa đăng ký môn học nào", "Thông báo", MessageBoxButtons.OK);
                    UpdateKetQuaTN(MSSV, XepLoai, 0, false);
                    continue;
                }
                else
                {
                    int? soChungChi = 0;
                    int isBreak = 0;
                    foreach (var maMH in listMH)
                    {
                        //Check Diem = null -> chưa có điểm -> Không đủ DK
                        if (maMH.Diem == null || maMH.Diem < 5)
                        {
                            XepLoai = "Chưa đủ điều kiện TN";
                            //XtraMessageBox.Show("Không đủ ĐK Xét TN vì có môn học chưa có điểm hoặc có môn học điểm < 5", "Thông báo", MessageBoxButtons.OK);
                            UpdateKetQuaTN(MSSV, XepLoai, 0, false);
                            isBreak = 1;
                            break;
                        }

                        soChungChi += MonHocRepository.GetMonHocByMaMH(maMH.MaMH).FirstOrDefault().SoTinChi;
                    }
                    if (isBreak > 0)
                        continue;

                    else
                    {
                        if (soChungChi < 6)
                        {
                            XepLoai = "Chưa đủ điều kiện TN";
                            //XtraMessageBox.Show("Không đủ ĐK Xét TN vì Tổng số chứng chỉ < 6", "Thông báo", MessageBoxButtons.OK);
                            UpdateKetQuaTN(MSSV, XepLoai, 0, false);
                            continue;
                        }
                        else
                        {

                            //TODO: UpdateKQ -> Tính ĐTB
                            double? TongDiem = 0;
                            foreach (var MonHoc in listMH)
                            {
                                TongDiem += MonHoc.Diem;
                            }

                            double? DiemTB = TongDiem / listMH.Count;
                            if (DiemTB >= 5 && DiemTB < 7)
                            {
                                XepLoai = "Trung Bình";
                            }

                            else if (DiemTB >= 7 && DiemTB < 8)
                            {
                                XepLoai = "Khá";
                            }

                            else if (DiemTB >= 8)
                            {
                                XepLoai = "Giỏi";
                            }

                            string DTB = String.Format("{0:N2}", DiemTB);

                            UpdateKetQuaTN(MSSV, XepLoai, double.Parse(DTB), true);
                        }
                    }

                }
            }
        }

        private void UpdateKetQuaTN(string MSSV, string XepLoai, double? DiemTB, bool KetQuaTN)
        {
            try
            {
                SinhVienRepository.UpdateKetQuaTN(MSSV, XepLoai, DiemTB, KetQuaTN);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        private void PrintKetQuaTotNghiep()
        {
            var f = new Report.View.FrmReportKQTN(srcKhoa.EditValue.ToString());
            f.ShowDialog();

            grc_DanhSachSV.Refresh();
        }
        private void ShowAlert()
        {
            Main alert = new Main();
            alert.ShowAlert("Thông báo", "Cập nhật dữ liệu thành công");
        }

        #endregion

        #region EVENTS OF FORM

        
        /// <summary>
        /// Events of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmDanhSachSV_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grc_DanhSachSV_DoubleClick(object sender, EventArgs e)
        {
            bool role = true;
            if (!CheckUser())
            {
                role = false;
            }

            string mssv = grv_DanhSachSV.GetFocusedRowCellValue(colMSSV).ToString();
            var sinhvien = SinhVienRepository.GetObjectByID(mssv).FirstOrDefault();
            ShowFormDetail(sinhvien, role);
        }

        private void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormDetail(null, true);
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void OnDelete()
        {
            try
            {
                var selectItems = grv_DanhSachSV.GetSelectedRows();
                if (selectItems.Length <= 0)
                {
                    XtraMessageBox.Show("Vui lòng chọn sinh viên muốn xóa!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (XtraMessageBox.Show("Bạn muốn xóa sinh viên", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (var item in selectItems)
                    {
                        var MSSV = grv_DanhSachSV.GetRowCellValue(item,colMSSV).ToString();
                        //var MSSV = value[0].ToString();
                        //Kiểm tra MSSV đã có điểm chưa, tức là đã đăng ký môn học chưa? 
                        var ListDiem = DiemRepository.GetMonHocByMSSV(MSSV);

                        if(ListDiem.Count > 0)
                        {
                            foreach (var diem in ListDiem)
                            {
                                if (diem.Diem != null)
                                {
                                    XtraMessageBox.Show("Sinh viên " + MSSV + " đã đăng ký môn học", "Thông báo", MessageBoxButtons.OK);
                                    break;
                                }
                                else
                                {
                                    //Delete in Table DIEM
                                    DiemRepository.DeleteSinhVienInDiemByMSSV(MSSV);
                                    
                                    //Delete SINHVIEN
                                    SinhVienRepository.DeleteSinhVienByMSSV(MSSV);
                                    break;
                                }
                            }

                        }

                        else
                        {
                            //Delete SINHVIEN
                            SinhVienRepository.DeleteSinhVienByMSSV(MSSV);
                        }
                    }

                    LoadData();
                    //grv_DanhSachSV.DeleteSelectedRows();
                    //SinhVienRepository.SaveChanges();
                    ShowAlert();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Sinh viên đang chứa điểm!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnCreateSamle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tbl_SinhVien sv = new tbl_SinhVien
            {
                MSSV = "AD01",
                Ho = "Đảo Hải",
                Ten = "Tặc",
                NTNS = DateTime.Today,
                GioiTinh = true,
                MaKhoa = "CNTT",
                NoiSinh = "Đảo Robinxon",
            };

            SinhVienRepository.dbContext.tbl_SinhVien.Add(sv);
            SinhVienRepository.dbContext.SaveChanges();
            Main alert = new Main();
            alert.ShowAlert("Cập nhật thành công", "Thông báo");
            LoadData();
        }

        private void btnExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExportExcel();
        }

        private void btnImportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportExcel();
        }

        private void srcKhoa_EditValueChanged(object sender, EventArgs e)
        {
            LoadSinhVienByKhoa();
        }

        private void LoadSinhVienByKhoa()
        {
            List<tbl_SinhVien> dtSV = null;
            var khoa = srcKhoa.EditValue.ToString();
            if (khoa == "admin")
            {
                dtSV = SinhVienRepository.GetAllSinhVienNotAdmin();
            }
            else
            {
                dtSV = SinhVienRepository.GetSinhVienByKhoa(srcKhoa.EditValue.ToString());
            }
            grc_DanhSachSV.DataSource = dtSV;
        }

        private void grv_DanhSachSV_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.Column.FieldName == "DTB")
            {
                string DTB = View.GetRowCellDisplayText(e.RowHandle, View.Columns["DTB"]);
                if (!string.IsNullOrEmpty(DTB))
                {
                    if (double.Parse(DTB) == 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                        e.Appearance.BackColor2 = Color.FromArgb(150, Color.White);
                    }
                }
            }
            if (e.Column.FieldName == "XepLoaiTN")
            {
                string XepLoaiTN = View.GetRowCellDisplayText(e.RowHandle, View.Columns["XepLoaiTN"]);
                if (XepLoaiTN == "Chưa đủ điều kiện TN")
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.White);
                }
            }

        }

        private void btnXetTotNghiep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XetTotNghiep();
        }

        private void btnPrinKQTN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PrintKetQuaTotNghiep();
        }

        #endregion

    }
}