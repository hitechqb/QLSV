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
using System.Threading;

namespace iMic_QLSV.View.Login
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private LoginRepository loginRepository = new LoginRepository();
        public FrmLogin()
        {
            InitializeComponent();
        }

        #region FUNCTIONS
        
        private void Login()
        {
            if (CheckLogin())
            {
                ShowCloseFormWaitSplash.ShowWaitForm();
                var userName = loginRepository.GetFullNameByUser(TxtEmail.Text).ToString();

                var fMain = new Main(userName);
                fMain.FormClosed += FMain_FormClosed;
                fMain.Show();
                ShowCloseFormWaitSplash.CloseWaitForm();
                this.Hide();
            }
        }

        private bool CheckLogin()
        {
            bool isTrue = false;

            var userLogin = loginRepository.GetAllUser();
            foreach (var item in userLogin)
            {
                isTrue = TxtEmail.Text == item.TenDangNhap && TxtPassword.Text == item.MatKhau;
                if (isTrue)
                {
                    isTrue = true;
                    break;
                }
            }

            if (isTrue == true)
            {
                return true;
            }
            else
            {
                lblError.Text = "Thông tin đăng nhập bị sai. Vui lòng kiểm tra lại.";
                TxtEmail.SelectAll();
                TxtEmail.Focus();

                return false;
            }
        }

        #endregion

        #region EVENTS OF FORM

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ShowCloseFormWaitSplash.ShowSplashForm();
            Thread.Sleep(1500);
            ShowCloseFormWaitSplash.CloseSplashForm();
            lblError.Text = string.Empty;
            TxtEmail.Focus();
        }

        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            lblError.Text = string.Empty;
        }

        #endregion
    }
}