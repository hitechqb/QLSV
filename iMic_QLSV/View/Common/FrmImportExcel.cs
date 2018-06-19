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
using ClosedXML.Excel;
using iMic_QLSV.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace iMic_QLSV.View.Common
{
    public partial class FrmImportExcel : DevExpress.XtraEditors.XtraForm
    {
        private SinhVienRepository SinhVienRepository = new SinhVienRepository();
        private string _MaKhoa;
        public FrmImportExcel(string MaKhoa)
        {
            InitializeComponent();
            _MaKhoa = MaKhoa;
        }

        private void btnBrowse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ImportExcel();
        }

        #region FUNCTIONS

        /// <summary>
        /// Functions 
        /// </summary>
        private void ImportExcel()
        {
            if (OpenExcel.ShowDialog() == DialogResult.OK)
            {
                string PathFolder = OpenExcel.FileName;
                using (XLWorkbook workBook = new XLWorkbook(PathFolder))
                {
                    IXLWorksheet xLWorksheet = workBook.Worksheet("Temp");
                    DataTable dt = new DataTable();
                    bool firstRow = true;
                    foreach (IXLRow row in xLWorksheet.Rows())
                    {
                        if (firstRow)
                        {
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Columns.Add(cell.Value.ToString());
                            }
                            firstRow = false;
                        }
                        else
                        {
                            dt.Rows.Add();
                            int i = 0;
                            foreach (IXLCell cell in row.Cells())
                            {
                                dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                i++;
                            }
                        }
                    }
                    grc_SinhVien.DataSource = dt;
                }
                XtraMessageBox.Show("Nạp dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void UpdateGridToDatabase()
        {
            //if()
            Int32[] selectedRowHandles = grv_SinhVien.GetSelectedRows();
            if(selectedRowHandles.Length <= 0)
            {
                XtraMessageBox.Show("Vui lòng chọn sinh viên muốn cập nhật", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                for (int i = 0; i < selectedRowHandles.Length; i++)
                {
                    int selectedRowHandle = selectedRowHandles[i];
                    if (selectedRowHandle >= 0)
                    {
                        var db = grv_SinhVien.GetDataRow(selectedRowHandle); //DataRow
                        var mssv = SinhVienRepository.GetObjectByID(db.ItemArray[0].ToString());

                        if (mssv.Count > 0)
                        {
                            XtraMessageBox.Show("Mã số sinh viên " + db.ItemArray[0].ToString() + " đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                            continue;
                        }

                        if (db.ItemArray[6].ToString() != _MaKhoa)
                        {
                            XtraMessageBox.Show("Mã Khoa " + db.ItemArray[6].ToString() + " không đúng với khoa bạn đang cập nhật", "Thông báo", MessageBoxButtons.OK);
                            continue;
                        }

                        else
                        {
                            SinhVienRepository.UpdateGridViewToDataBase(db);
                        }
                    }
                }
                
            }
            
        }
        #endregion

        #region EVENTS OF FORM

        /// <summary>
        /// Events of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UpdateGridToDatabase();
            DialogResult = DialogResult.OK;
        }

        private void grv_SinhVien_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if(e.Column.FieldName == "MaKhoa")
            {
                string maKhoa = View.GetRowCellDisplayText(e.RowHandle, View.Columns["MaKhoa"]);
                if(maKhoa != _MaKhoa)
                {
                    e.Appearance.BackColor = Color.FromArgb(150, Color.Salmon);
                    e.Appearance.BackColor2 = Color.FromArgb(150, Color.White);
                }
            }
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}