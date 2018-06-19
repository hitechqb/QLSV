namespace iMic_QLSV.View.MonHoc
{
    partial class FrmDangKyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangKyMonHoc));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSinhVien = new DevExpress.XtraBars.BarEditItem();
            this.srcSinhVien = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateSamle = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.grc_MonHoc = new DevExpress.XtraGrid.GridControl();
            this.grv_MonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.srcMonHoc = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
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
            this.btnSave,
            this.barSinhVien,
            this.btnReload});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 9;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.srcSinhVien});
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
            new DevExpress.XtraBars.LinkPersistInfo(((DevExpress.XtraBars.BarLinkUserDefines)((DevExpress.XtraBars.BarLinkUserDefines.PaintStyle | DevExpress.XtraBars.BarLinkUserDefines.Width))), this.barSinhVien, "", false, true, true, 228, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSinhVien
            // 
            this.barSinhVien.Caption = "Sinh viên";
            this.barSinhVien.Edit = this.srcSinhVien;
            this.barSinhVien.Id = 7;
            this.barSinhVien.Name = "barSinhVien";
            this.barSinhVien.EditValueChanged += new System.EventHandler(this.barSinhVien_EditValueChanged);
            // 
            // srcSinhVien
            // 
            this.srcSinhVien.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.srcSinhVien.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.srcSinhVien.Appearance.Options.UseBackColor = true;
            this.srcSinhVien.Appearance.Options.UseFont = true;
            this.srcSinhVien.AppearanceReadOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.srcSinhVien.AppearanceReadOnly.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.srcSinhVien.AppearanceReadOnly.Options.UseBackColor = true;
            this.srcSinhVien.AppearanceReadOnly.Options.UseFont = true;
            this.srcSinhVien.AutoHeight = false;
            this.srcSinhVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcSinhVien.Name = "srcSinhVien";
            this.srcSinhVien.PopupView = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.ColumnPanelRowHeight = 26;
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHoTen});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowViewCaption = true;
            this.repositoryItemSearchLookUpEdit1View.RowHeight = 26;
            this.repositoryItemSearchLookUpEdit1View.ViewCaption = "Danh sách sinh viên";
            // 
            // colMSSV
            // 
            this.colMSSV.Caption = "MSSV";
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.MaxWidth = 150;
            this.colMSSV.MinWidth = 80;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 0;
            this.colMSSV.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
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
            this.barDockControl1.Size = new System.Drawing.Size(636, 42);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 416);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(636, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 42);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 374);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(636, 42);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 374);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Caption = "Thêm";
            this.btnAddNew.Hint = "Thêm (Ctrl + N)";
            this.btnAddNew.Id = 0;
            this.btnAddNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddNew.ImageOptions.SvgImage")));
            this.btnAddNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.btnAddNew.Name = "btnAddNew";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnExportExcel.Caption = "Xuất Excel";
            this.btnExportExcel.Id = 1;
            this.btnExportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcel.ImageOptions.SvgImage")));
            this.btnExportExcel.Name = "btnExportExcel";
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Hint = "Xóa";
            this.btnDel.Id = 2;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
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
            // grc_MonHoc
            // 
            this.grc_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_MonHoc.Location = new System.Drawing.Point(0, 42);
            this.grc_MonHoc.MainView = this.grv_MonHoc;
            this.grc_MonHoc.MenuManager = this.barManager;
            this.grc_MonHoc.Name = "grc_MonHoc";
            this.grc_MonHoc.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.srcMonHoc,
            this.repositoryItemImageComboBox1});
            this.grc_MonHoc.Size = new System.Drawing.Size(636, 374);
            this.grc_MonHoc.TabIndex = 4;
            this.grc_MonHoc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_MonHoc});
            // 
            // grv_MonHoc
            // 
            this.grv_MonHoc.ColumnPanelRowHeight = 26;
            this.grv_MonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colDK});
            this.grv_MonHoc.GridControl = this.grc_MonHoc;
            this.grv_MonHoc.Name = "grv_MonHoc";
            this.grv_MonHoc.OptionsCustomization.AllowColumnMoving = false;
            this.grv_MonHoc.OptionsSelection.MultiSelect = true;
            this.grv_MonHoc.OptionsView.ShowGroupPanel = false;
            this.grv_MonHoc.OptionsView.ShowViewCaption = true;
            this.grv_MonHoc.RowHeight = 26;
            this.grv_MonHoc.ViewCaption = "Danh sách  môn học";
            this.grv_MonHoc.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grv_MonHoc_CellValueChanged);
            // 
            // colMaMH
            // 
            this.colMaMH.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMaMH.AppearanceCell.Options.UseForeColor = true;
            this.colMaMH.Caption = "Môn học";
            this.colMaMH.ColumnEdit = this.srcMonHoc;
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.OptionsColumn.AllowEdit = false;
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 0;
            this.colMaMH.Width = 516;
            // 
            // srcMonHoc
            // 
            this.srcMonHoc.AutoHeight = false;
            this.srcMonHoc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcMonHoc.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("srcMonHoc.ContextImageOptions.Image")));
            this.srcMonHoc.Name = "srcMonHoc";
            this.srcMonHoc.PopupView = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDK
            // 
            this.colDK.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colDK.AppearanceCell.Options.UseForeColor = true;
            this.colDK.AppearanceCell.Options.UseTextOptions = true;
            this.colDK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDK.Caption = "Đăng ký";
            this.colDK.ColumnEdit = this.repositoryItemImageComboBox1;
            this.colDK.FieldName = "DangKy";
            this.colDK.Name = "colDK";
            this.colDK.Visible = true;
            this.colDK.VisibleIndex = 1;
            // 
            // repositoryItemImageComboBox1
            // 
            this.repositoryItemImageComboBox1.AutoHeight = false;
            this.repositoryItemImageComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Đã đăng ký", true, 0),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Chưa đăng ký", false, 1)});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.imageCollection1;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "apply_16x16.png");
            this.imageCollection1.InsertGalleryImage("unfreezepanes_16x16.png", "images/spreadsheet/unfreezepanes_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/spreadsheet/unfreezepanes_16x16.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "unfreezepanes_16x16.png");
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Nạp lại";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // FrmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 416);
            this.Controls.Add(this.grc_MonHoc);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.MaximizeBox = false;
            this.Name = "FrmDangKyMonHoc";
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.FrmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grc_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.srcMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnCreateSamle;
        private DevExpress.XtraBars.BarButtonItem btnImportExcel;
        private DevExpress.XtraGrid.GridControl grc_MonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_MonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarEditItem barSinhVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit srcSinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit srcMonHoc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDK;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnReload;
    }
}