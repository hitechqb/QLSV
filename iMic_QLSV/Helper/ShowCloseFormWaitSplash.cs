using DevExpress.XtraSplashScreen;
using iMic_QLSV.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iMic_QLSV.Helper
{
    public class ShowCloseFormWaitSplash
    {
        public static void ShowSplashForm()
        {
            if (SplashScreenManager.Default != null) return;
            SplashScreenManager.ShowForm(typeof(FrmSplash));
        }

        public static void ShowSplashForm(string description)
        {
            if (SplashScreenManager.Default != null && SplashScreenManager.Default.IsSplashFormVisible)
            {
                SplashScreenManager.Default.SendCommand(null, description);
                return;
            }
            SplashScreenManager.ShowForm(typeof(FrmSplash));
        }

        public static void CloseSplashForm()
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }

        public static void ShowWaitForm()
        {
            if (SplashScreenManager.Default != null) return;
            SplashScreenManager.ShowForm(typeof(FrmWait));
        }

        public static void CloseWaitForm()
        {
            if (SplashScreenManager.Default != null)
                SplashScreenManager.CloseForm();
        }
    }
}
