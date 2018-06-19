using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace iMic_QLSV.Report.View
{
    public partial class rptKetQuaTN : DevExpress.XtraReports.UI.XtraReport
    {
        private DataTable _dt = null;
        public rptKetQuaTN(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
            _dt.TableName = "SinhVienTable";
            xpcSinhVien.ObjectTypeName = _dt.TableName;
            this.DataSource = _dt;
        }

        #region FUNCTIONS

        public void ShowPreview()
        {
            ReportPrintTool printed_report = new ReportPrintTool(this);
            printed_report.PreviewForm.Shown += PreviewForm_Shown; ;
            printed_report.ShowPreviewDialog();
        }

        private void PreviewForm_Shown(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        public void PrintNow()
        {
            this.PrintDialog();
        }

        #endregion
    }
}
