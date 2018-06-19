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

namespace iMic_QLSV.View.Admin
{
    public partial class FrmThongTinNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        private RoleRepository dbRoleContext = new RoleRepository();
        private SinhVienRepository dbSinhVienContext = new SinhVienRepository();
        private LoginRepository dbLoginContext = new LoginRepository();
        private tbl_DangNhap _dangNhap;
        private static string oldMSSV;

        public FrmThongTinNguoiDung(tbl_DangNhap dangNhap)
        {
            InitializeComponent();
            _dangNhap = dangNhap;

            oldMSSV = (_dangNhap != null) ? _dangNhap.MSSV : null;
        }

        #region EVENTS OF FORM

       
        /// <summary>
        /// Events of Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadRole();
            LoadMSSVNotAcitve();
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OnSave();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        #endregion

        #region FUNCTIONS

        
        /// <summary>
        /// Functions 
        /// </summary>
        private void LoadInfo()
        {
            if(_dangNhap == null) // Add new
            {
                OnAdd();
            }
            else
            {
                OnUpdate();
            }
        }

        private void LoadRole()
        {
            var role = dbRoleContext.GetAllRole();
            foreach (var item in role)
            {
                cbRole.Properties.Items.Add(item.ID);
            }
        }

        private void LoadMSSVNotAcitve()
        {
            var dbSinhVien = dbSinhVienContext.GetAllSinhVienNotActive(oldMSSV);
            srcMSSV.Properties.DataSource = dbSinhVien;
            srcMSSV.Properties.ValueMember = "MSSV";
            srcMSSV.Properties.DisplayMember = "MSSV";
        }

        private void OnAdd()
        {
            txtUserName.ReadOnly = txtPassword.ReadOnly = false;

            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void OnUpdate()
        {
            txtUserName.Text = _dangNhap.TenDangNhap;
            txtPassword.Text = _dangNhap.MatKhau;
            cbRole.EditValue = _dangNhap.Role;
            srcMSSV.Text = _dangNhap.MSSV;
        }

        private void OnSave()
        {
            if(_dangNhap == null)
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    XtraMessageBox.Show("Tên đăng nhập không được trống", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                var user = dbLoginContext.GetAllUser().Where(us => us.TenDangNhap == txtUserName.Text).ToList().Count;
                if(user > 0)
                {
                    XtraMessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                    txtUserName.Focus();
                    txtUserName.SelectAll();
                    return;
                }


                tbl_DangNhap dbDangNhap = new tbl_DangNhap
                {
                    TenDangNhap = txtUserName.Text,
                    MatKhau = txtPassword.Text,
                    Role = Int32.Parse(cbRole.EditValue.ToString()),
                    MSSV = srcMSSV.EditValue.ToString(),
                };

                dbLoginContext.UpdateUserLogin(dbDangNhap);

                //Update isActive in table SinhVien
                if (!string.IsNullOrEmpty(srcMSSV.EditValue.ToString()))
                {
                    dbSinhVienContext.UpdateIsActived(srcMSSV.EditValue.ToString(), null);
                }
                DialogResult = DialogResult.OK;
            }

            else
            {
                var us = dbLoginContext.GetObjectByID(txtUserName.Text).FirstOrDefault();
                us.Role = Int32.Parse(cbRole.EditValue.ToString());
                us.MSSV = srcMSSV.EditValue.ToString();

                dbLoginContext.dbContext.SaveChanges();

                //Update isActive in table SinhVien
                if (!string.IsNullOrEmpty(srcMSSV.EditValue.ToString()))
                {
                    if(srcMSSV.EditValue.ToString() == oldMSSV)
                    {
                        dbSinhVienContext.UpdateIsActived(srcMSSV.EditValue.ToString(), null);
                    }
                    else
                    {
                        dbSinhVienContext.UpdateIsActived(srcMSSV.EditValue.ToString(), oldMSSV);
                    }
                }
                DialogResult = DialogResult.OK;
            }
        }

        private void srcMSSV_QueryPopUp(object sender, CancelEventArgs e)
        {
            LoadMSSVNotAcitve();
        }

        #endregion
    }
}