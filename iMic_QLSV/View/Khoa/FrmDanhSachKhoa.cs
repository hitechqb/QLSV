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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace iMic_QLSV.View.Khoa
{
    public partial class FrmDanhSachKhoa : DevExpress.XtraEditors.XtraForm
    {
        private BindingList<tbl_Khoa> _listKhoa;
        private KhoaRepository khoaRepository = new KhoaRepository();

        public FrmDanhSachKhoa()
        {
            InitializeComponent();
        }

        #region EVENTS OF FORM

        private void FrmDanhSachKhoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnNew();
        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnDelete();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSave();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void grv_Khoa_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            //var MaKhoa = grv_Khoa.GetFocusedRowCellValue(colMaKhoa).ToString();
            //var TenKhoa = grv_Khoa.GetFocusedRowCellValue(colTenKhoa).ToString();

            if (grv_Khoa.IsNewItemRow(e.RowHandle))
            {
                //khoaRepository.UpdateKhoaFromGrid(MaKhoa.ToString(), TenKhoa.ToString());
                OnSave();
            }
            else
            {
                var MaKhoa = grv_Khoa.GetFocusedRowCellValue(colMaKhoa).ToString();
                var TenKhoa = grv_Khoa.GetFocusedRowCellValue(colTenKhoa).ToString();

                var Khoa = khoaRepository.UpdateKhoaByMaKhoa(MaKhoa).FirstOrDefault();
                Khoa.TenKhoa = TenKhoa;
            }

           
        }

        private void grv_Khoa_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (grv_Khoa.IsNewItemRow(e.RowHandle))
            {
                //var colMaKhoa = grv_Khoa.Columns["MaKhoa"];
                var MaKhoa = grv_Khoa.GetFocusedRowCellValue(colMaKhoa);
                var TenKhoa = grv_Khoa.GetFocusedRowCellValue(colTenKhoa);

                if (MaKhoa == null || string.IsNullOrEmpty(MaKhoa.ToString()))
                {
                    e.Valid = false;
                    grv_Khoa.SetColumnError(colMaKhoa, "Mã khoa không được trống");
                    return;
                }

                else
                {
                    var listMaKhoa = khoaRepository.GetAllKhoa();

                    foreach (var item in listMaKhoa)
                    {
                        if (MaKhoa.ToString() == item.MaKhoa.ToString())
                        {
                            e.Valid = false;
                            grv_Khoa.SetColumnError(colMaKhoa, "Mã khoa không được trùng");
                            return;
                        }
                    }

                    khoaRepository.UpdateKhoaFromGrid(MaKhoa.ToString(), TenKhoa.ToString());
                }
            }
        }

        private void grv_Khoa_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
        
        /// <summary>
        /// Chỉ cho phép Add New mới edit được Mã Khoa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grv_Khoa_ShowingEditor(object sender, CancelEventArgs e)
        {
            GridView view = sender as GridView;

            if (view.FocusedColumn == colMaKhoa)
            {
                if (!view.IsNewItemRow(view.FocusedRowHandle))
                    e.Cancel = true;
            }
        }
        #endregion

        #region FUNCTIONS

        //LoadData 
        private void LoadData()
        {

            khoaRepository.dbKhoaContext.tbl_Khoa.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                var listKhoa = khoaRepository.dbKhoaContext.tbl_Khoa.Local.ToBindingList();
                _listKhoa = listKhoa;
                grc_Khoa.DataSource = listKhoa;
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void OnNew()
        {
            grv_Khoa.AddNewRow();
            grv_Khoa.FocusedColumn = colMaKhoa;
            grv_Khoa.ShowEditor();
        }

        private void OnDelete()
        {
            var countKhoa = grv_Khoa.SelectedRowsCount;
            
            if (countKhoa <= 0)
            {
                XtraMessageBox.Show("Vui lòng chọn Khoa muốn xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            else
            {
                if(XtraMessageBox.Show("Bạn muốn xóa Khoa đã chọn", "Delete", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    Int32[] selectedRowHandles = grv_Khoa.GetSelectedRows();

                    for (int i = 0; i < selectedRowHandles.Length; i++)
                    {
                        int selectedRowHandle = selectedRowHandles[i];
                        if (selectedRowHandle >= 0)
                        {
                            var maKhoa = grv_Khoa.GetRowCellValue(selectedRowHandle, colMaKhoa).ToString(); //DataRow

                            var svKhoa = khoaRepository.GetTotalSinhVienByMaKhoa(maKhoa);
                            if (svKhoa > 0)
                            {
                                XtraMessageBox.Show("Khoa " + maKhoa + " đang có sinh viên, không thể xóa", "Thông báo", MessageBoxButtons.OK);
                                continue;
                            }
                            khoaRepository.DeleteKhoaByMaKhoa(maKhoa);
                        }
                    }
                    LoadData();
                }
            }
        }

        private void OnSave()
        {
            Main alert = new Main();
            alert.ShowAlert("Thông báo", "Cập nhật thành công");
            //grv_Khoa.FocusedRowHandle = e.RowHandle;
            grv_Khoa.FocusedColumn = colMaKhoa;
            grv_Khoa.ShowEditor();
        }

        #endregion
    }
}