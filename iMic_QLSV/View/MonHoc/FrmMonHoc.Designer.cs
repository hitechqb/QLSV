namespace iMic_QLSV.View.MonHoc
{
    partial class FrmMonHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonHoc));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateSamle = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.srcKhoa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.grv_Khoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grc_MonHoc = new DevExpress.XtraGrid.GridControl();
            this.grv_MonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTinChi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Khoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_MonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAddNew,
            this.btnExportExcel,
            this.btnDel,
            this.btnExit,
            this.btnCreateSamle,
            this.btnImportExcel,
            this.btnSave});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(200)))), ((int)(((byte)(223)))));
            this.bar2.BarAppearance.Hovered.Options.UseBackColor = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Thêm";
            this.btnAddNew.Hint = "Thêm (Ctrl + N)";
            this.btnAddNew.Id = 0;
            this.btnAddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNew.ImageOptions.SvgImage")));
            this.btnAddNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNew_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Hint = "Xóa";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Đóng";
            this.btnExit.Hint = "Đóng (Ctrl + W)";
            this.btnExit.Id = 3;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(639, 40);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 443);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(639, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 40);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 403);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(639, 40);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 403);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnExportExcel.Caption = "Xuất Excel";
            this.btnExportExcel.Id = 1;
            this.btnExportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcel.ImageOptions.SvgImage")));
            this.btnExportExcel.Name = "btnExportExcel";
            // 
            // btnCreateSamle
            // 
            this.btnCreateSamle.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCreateSamle.Caption = "Tạo dữ liệu mẫu";
            this.btnCreateSamle.Id = 4;
            this.btnCreateSamle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateSamle.ImageOptions.SvgImage")));
            this.btnCreateSamle.Name = "btnCreateSamle";
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Caption = "Import from Excel";
            this.btnImportExcel.Hint = "Ctrl + O";
            this.btnImportExcel.Id = 5;
            this.btnImportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportExcel.ImageOptions.SvgImage")));
            this.btnImportExcel.Name = "btnImportExcel";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 6;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.srcKhoa);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 40);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(639, 60);
            this.panelControl1.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Khoa";
            // 
            // srcKhoa
            // 
            this.srcKhoa.Location = new System.Drawing.Point(69, 22);
            this.srcKhoa.MenuManager = this.barManager;
            this.srcKhoa.Name = "srcKhoa";
            this.srcKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcKhoa.Properties.NullText = "";
            this.srcKhoa.Properties.PopupView = this.grv_Khoa;
            this.srcKhoa.Properties.ReadOnly = true;
            this.srcKhoa.Size = new System.Drawing.Size(178, 20);
            this.srcKhoa.TabIndex = 0;
            this.srcKhoa.EditValueChanged += new System.EventHandler(this.srcKhoa_EditValueChanged);
            // 
            // grv_Khoa
            // 
            this.grv_Khoa.ColumnPanelRowHeight = 26;
            this.grv_Khoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhoa,
            this.colTenKhoa});
            this.grv_Khoa.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.grv_Khoa.Name = "grv_Khoa";
            this.grv_Khoa.OptionsBehavior.Editable = false;
            this.grv_Khoa.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.grv_Khoa.OptionsView.ShowGroupPanel = false;
            this.grv_Khoa.OptionsView.ShowViewCaption = true;
            this.grv_Khoa.RowHeight = 26;
            this.grv_Khoa.ViewCaption = "Danh sách Khoa";
            this.grv_Khoa.ViewCaptionHeight = 26;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.Caption = "Mã khoa";
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.MaxWidth = 120;
            this.colMaKhoa.MinWidth = 80;
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 0;
            this.colMaKhoa.Width = 120;
            // 
            // colTenKhoa
            // 
            this.colTenKhoa.Caption = "Tên khoa";
            this.colTenKhoa.FieldName = "TenKhoa";
            this.colTenKhoa.Name = "colTenKhoa";
            this.colTenKhoa.Visible = true;
            this.colTenKhoa.VisibleIndex = 1;
            this.colTenKhoa.Width = 1365;
            // 
            // grc_MonHoc
            // 
            this.grc_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_MonHoc.Location = new System.Drawing.Point(0, 100);
            this.grc_MonHoc.MainView = this.grv_MonHoc;
            this.grc_MonHoc.MenuManager = this.barManager;
            this.grc_MonHoc.Name = "grc_MonHoc";
            this.grc_MonHoc.Size = new System.Drawing.Size(639, 343);
            this.grc_MonHoc.TabIndex = 6;
            this.grc_MonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_MonHoc});
            this.grc_MonHoc.DoubleClick += new System.EventHandler(this.grc_MonHoc_DoubleClick);
            // 
            // grv_MonHoc
            // 
            this.grv_MonHoc.ColumnPanelRowHeight = 26;
            this.grv_MonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colSoTinChi});
            this.grv_MonHoc.GridControl = this.grc_MonHoc;
            this.grv_MonHoc.Name = "grv_MonHoc";
            this.grv_MonHoc.OptionsBehavior.Editable = false;
            this.grv_MonHoc.OptionsCustomization.AllowColumnMoving = false;
            this.grv_MonHoc.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.grv_MonHoc.OptionsSelection.MultiSelect = true;
            this.grv_MonHoc.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grv_MonHoc.OptionsView.ShowFooter = true;
            this.grv_MonHoc.OptionsView.ShowGroupPanel = false;
            this.grv_MonHoc.OptionsView.ShowViewCaption = true;
            this.grv_MonHoc.RowHeight = 26;
            this.grv_MonHoc.ViewCaption = "Danh sách môn học";
            // 
            // colMaMH
            // 
            this.colMaMH.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMaMH.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMaMH.AppearanceCell.Options.UseFont = true;
            this.colMaMH.AppearanceCell.Options.UseForeColor = true;
            this.colMaMH.AppearanceCell.Options.UseTextOptions = true;
            this.colMaMH.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMH.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaMH.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaMH.Caption = "Mã môn học";
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.MaxWidth = 120;
            this.colMaMH.MinWidth = 80;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MaMH", "Tổng số môn học : {0}")});
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 1;
            this.colMaMH.Width = 80;
            // 
            // colTenMH
            // 
            this.colTenMH.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colTenMH.AppearanceCell.Image = ((System.Drawing.Image)(resources.GetObject("colTenMH.AppearanceCell.Image")));
            this.colTenMH.AppearanceCell.Options.UseForeColor = true;
            this.colTenMH.AppearanceCell.Options.UseImage = true;
            this.colTenMH.Caption = "Tên môn học";
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 2;
            // 
            // colSoTinChi
            // 
            this.colSoTinChi.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colSoTinChi.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoTinChi.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colSoTinChi.AppearanceCell.Options.UseBackColor = true;
            this.colSoTinChi.AppearanceCell.Options.UseFont = true;
            this.colSoTinChi.AppearanceCell.Options.UseForeColor = true;
            this.colSoTinChi.AppearanceCell.Options.UseTextOptions = true;
            this.colSoTinChi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTinChi.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTinChi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTinChi.Caption = "Số tín chỉ";
            this.colSoTinChi.FieldName = "SoTinChi";
            this.colSoTinChi.MaxWidth = 120;
            this.colSoTinChi.MinWidth = 50;
            this.colSoTinChi.Name = "colSoTinChi";
            this.colSoTinChi.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SoTinChi", "Tổng số tín chỉ :  {0:0.##}")});
            this.colSoTinChi.Visible = true;
            this.colSoTinChi.VisibleIndex = 3;
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 443);
            this.Controls.Add(this.grc_MonHoc);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách môn học";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Khoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_MonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnCreateSamle;
        private DevExpress.XtraBars.BarButtonItem btnImportExcel;
        private DevExpress.XtraGrid.GridControl grc_MonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_MonHoc;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit srcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Khoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTinChi;
    }
}