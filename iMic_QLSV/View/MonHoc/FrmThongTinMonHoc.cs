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
    public partial class FrmThongTinMonHoc : DevExpress.XtraEditors.XtraForm
    {
        private tbl_DMMonHoc _MonHoc;
        private string _khoa;
        private KhoaRepository khoaRepository = new KhoaRepository();
        private MonHocRepository monHocRepository = new MonHocRepository();

        public FrmThongTinMonHoc(tbl_DMMonHoc MonHoc, string Khoa)
        {
            InitializeComponent();
            _MonHoc = MonHoc;

            _khoa = _MonHoc == null ? Khoa : _MonHoc.Khoa;
        }

        #region FUNCTIONS
       
        private void LoadData()
        {
            if(_MonHoc == null)
            {
                OnAdd();
            }
            else
            {
                OnUpdate();
            }
        }

        private void LoadKhoa()
        {
            var khoa = khoaRepository.GetAllKhoa();
            srcKhoa.Properties.DataSource = khoa;

            srcKhoa.Properties.ValueMember = "MaKhoa";
            srcKhoa.Properties.DisplayMember = "TenKhoa";

        }

        private void OnAdd()
        {
            //TODO
            txtMaMH.Text = string.Empty;
            txtTenMH.Text = string.Empty;
            spnSoTinChi.EditValue = 1;
            srcKhoa.EditValue = _khoa;
        }

        private void OnUpdate()
        {
            //TODO
            txtMaMH.Text = _MonHoc.MaMH;
            txtTenMH.Text = _MonHoc.TenMH;
            spnSoTinChi.EditValue = _MonHoc.SoTinChi;
            srcKhoa.EditValue = _khoa;

            txtMaMH.ReadOnly = true;
        }

        private void OnSave()
        {
            if(_MonHoc == null)
            {
                //TODO: ADD NEW
                tbl_DMMonHoc MonHoc = new tbl_DMMonHoc
                {
                    MaMH = txtMaMH.Text,
                    TenMH = txtTenMH.Text,
                    SoTinChi = Int32.Parse(spnSoTinChi.Text),
                    Khoa = srcKhoa.EditValue.ToString(),
                };

                var MaMH = monHocRepository.GetMonHocByMaMH(txtMaMH.Text);
                if (MaMH.Count > 0)
                {
                    XtraMessageBox.Show("Mã môn học đã tồn tại !", "Thông báo", MessageBoxButtons.OK);
                    txtMaMH.SelectAll();
                    txtMaMH.Focus();
                    return;
                }

                monHocRepository.dbMonHocContext.tbl_DMMonHoc.Add(MonHoc);
                monHocRepository.dbMonHocContext.SaveChanges();
            }

            else
            {
                //TODO: UPDATE
                var MonHoc = monHocRepository.GetMonHocByMaMH(txtMaMH.Text).FirstOrDefault();
                MonHoc.TenMH = txtTenMH.Text;
                MonHoc.SoTinChi = Int32.Parse(spnSoTinChi.Text);
                MonHoc.Khoa = srcKhoa.EditValue.ToString();

                monHocRepository.dbMonHocContext.SaveChanges();
            }

            DialogResult = DialogResult.OK;
        }
        #endregion

        #region EVENTS OF FORM  

        private void FrmThongTinMonHoc_Load(object sender, EventArgs e)
        {
            LoadKhoa();
            LoadData();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSave();
        }

        #endregion
    }
}