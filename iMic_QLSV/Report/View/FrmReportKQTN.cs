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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;

namespace iMic_QLSV.Report.View
{
    public partial class FrmReportKQTN : DevExpress.XtraEditors.XtraForm
    {
        private KhoaRepository KhoaRepository = new KhoaRepository();
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private MonHocRepository MonHocRepository = new MonHocRepository();
        private DiemRepository DiemRepository = new DiemRepository();
        private DataTable dtAll = null;

        private string _MaKhoa = string.Empty;

        public FrmReportKQTN(string MaKhoa)
        {
            InitializeComponent();

            LoadSrcKhoa();
            LoadSrcMonHoc();
            LoadGioiTinh();

            _MaKhoa = MaKhoa;
        }

        #region FUNCTIONS
        private void LoadSrcKhoa()
        {
            var khoa = KhoaRepository.GetAllKhoa();
            srcKhoa.DataSource = khoa;
            srcKhoa.ValueMember = "MaKhoa";
            srcKhoa.DisplayMember = "TenKhoa";
        }

        private void LoadSrcMonHoc()
        {
            var MonHoc = MonHocRepository.GetAllMonHoc();
            srcMonHoc.DataSource = MonHoc;
            srcMonHoc.ValueMember = "MaMH";
            srcMonHoc.DisplayMember = "TenMH";
        }

        private void LoadGioiTinh()
        {
            imgBoxGioiTinh.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Nam", true, 1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Nữ", false, 0)});
            imgBoxGioiTinh.SmallImages = imgList;
        }

        private void LoadData()
        {
            var dtGet = DiemRepository.GetDataKetQuaTN();
            dtAll = ConvertDataTable.LINQToDataTable(dtGet);
            grc_DanhSachSV.DataSource = dtAll;
        }

        private void LoadAllDataByKhoa()
        {
            if (barKhoa.EditValue.ToString() == "admin")
            {
                LoadData();
            }
            else
            {
                var dtGet = DiemRepository.GetDataKetQuaTNByKhoa(barKhoa.EditValue.ToString());
                dtAll = ConvertDataTable.LINQToDataTable(dtGet);
                grc_DanhSachSV.DataSource = dtAll;
                //string filterString = "[MaKhoa] = " + barKhoa.EditValue + "";
                //grv_DanhSachSV.Columns["MaKhoa"].FilterInfo = new ColumnFilterInfo(filterString);

                grv_DanhSachSV.ClearSorting();
                grv_DanhSachSV.Columns["MSSV"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
        }

        #endregion

        #region EVENTS OF FORM

        private void FrmReportKQTN_Load(object sender, EventArgs e)
        {
            //LoadData();
            barKhoa.EditValue = _MaKhoa;
            grv_DanhSachSV.Columns["MaKhoa"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;

            if(Main._userLogin != "admin")
            {
                srcKhoa.ReadOnly = true;
            }
        }

        private void barKhoa_EditValueChanged(object sender, EventArgs e)
        {
            barKetQua.EditValue = null;
            LoadAllDataByKhoa();
        }

        private void barKetQua_EditValueChanged(object sender, EventArgs e)
        {
            LoadAllDataByKetQuaTN();

            //FILLTER
            //var index = barKetQua.EditValue;
            //if(index != null)
            //{
            //    string filterString = "[KetQuaTN] = " + barKetQua.EditValue.ToString() + "";
            //    grv_DanhSachSV.Columns["KetQuaTN"].FilterInfo = new ColumnFilterInfo(filterString);
            //}
            //else
            //{
            //    grv_DanhSachSV.ClearColumnsFilter();
            //    LoadAllDataByKhoa();
            //}
        }

        private void LoadAllDataByKetQuaTN()
        {
            if(barKetQua.EditValue == null)
            {
                LoadAllDataByKhoa();
            }
            else
            {
                bool KetQua = bool.Parse(barKetQua.EditValue.ToString());
                var MaKhoa = barKhoa.EditValue.ToString();
                IEnumerable<Object> dtGet = null;
                if(MaKhoa == "admin")
                {
                    dtGet = DiemRepository.GetDataKetQuaByKetQuaTN(KetQua);
                }
                else
                {
                    dtGet = DiemRepository.GetDataKetQuaByMaKhoaAndKetQuaTN(barKhoa.EditValue.ToString(), KetQua);
                }

                dtAll = ConvertDataTable.LINQToDataTable(dtGet);
                grc_DanhSachSV.DataSource = dtAll;

                grv_DanhSachSV.ClearSorting();
                grv_DanhSachSV.Columns["MSSV"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            }
           
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(grv_DanhSachSV.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var f = new Report.View.rptKetQuaTN(dtAll);
            f.ShowPreview();
        }

        private void btnPrintNow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (grv_DanhSachSV.RowCount == 0)
            {
                XtraMessageBox.Show("Không có dữ liệu, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var f = new Report.View.rptKetQuaTN(dtAll);
            f.PrintNow();
        }
        #endregion

    }
}