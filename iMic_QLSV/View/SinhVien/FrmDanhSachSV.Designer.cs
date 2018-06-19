namespace iMic_QLSV.View
{
    partial class FrmDanhSachSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhSachSV));
            this.grc_DanhSachSV = new DevExpress.XtraGrid.GridControl();
            this.grv_DanhSachSV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imgBoxGioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.imgList = new DevExpress.Utils.ImageCollection(this.components);
            this.colNTNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQuaTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.imbKetQuaTN = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colDTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXepLoaiTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.btnCreateSamle = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnAddNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.btnXetTotNghiep = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrint = new DevExpress.XtraBars.BarLinkContainerItem();
            this.btnPrintSV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPrinKQTN = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.SaveExcel = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.srcKhoa = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.grv_Khoa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.grc_DanhSachSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DanhSachSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbKetQuaTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Khoa)).BeginInit();
            this.SuspendLayout();
            // 
            // grc_DanhSachSV
            // 
            this.grc_DanhSachSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_DanhSachSV.Location = new System.Drawing.Point(2, 2);
            this.grc_DanhSachSV.MainView = this.grv_DanhSachSV;
            this.grc_DanhSachSV.Name = "grc_DanhSachSV";
            this.grc_DanhSachSV.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.imgBoxGioiTinh,
            this.imbKetQuaTN});
            this.grc_DanhSachSV.Size = new System.Drawing.Size(1167, 272);
            this.grc_DanhSachSV.TabIndex = 5;
            this.grc_DanhSachSV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_DanhSachSV});
            this.grc_DanhSachSV.DoubleClick += new System.EventHandler(this.grc_DanhSachSV_DoubleClick);
            // 
            // grv_DanhSachSV
            // 
            this.grv_DanhSachSV.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.grv_DanhSachSV.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.grv_DanhSachSV.ColumnPanelRowHeight = 26;
            this.grv_DanhSachSV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colGioiTinh,
            this.colNTNS,
            this.colNoiSinh,
            this.colMaKhoa,
            this.colKetQuaTN,
            this.colDTB,
            this.colXepLoaiTN});
            this.grv_DanhSachSV.GridControl = this.grc_DanhSachSV;
            this.grv_DanhSachSV.Name = "grv_DanhSachSV";
            this.grv_DanhSachSV.OptionsBehavior.Editable = false;
            this.grv_DanhSachSV.OptionsCustomization.AllowColumnMoving = false;
            this.grv_DanhSachSV.OptionsSelection.CheckBoxSelectorColumnWidth = 28;
            this.grv_DanhSachSV.OptionsSelection.MultiSelect = true;
            this.grv_DanhSachSV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grv_DanhSachSV.OptionsView.ShowFooter = true;
            this.grv_DanhSachSV.OptionsView.ShowGroupPanel = false;
            this.grv_DanhSachSV.OptionsView.ShowViewCaption = true;
            this.grv_DanhSachSV.RowHeight = 26;
            this.grv_DanhSachSV.ViewCaption = "Danh sách sinh viên";
            this.grv_DanhSachSV.ViewCaptionHeight = 25;
            this.grv_DanhSachSV.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grv_DanhSachSV_RowCellStyle);
            // 
            // colMSSV
            // 
            this.colMSSV.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMSSV.AppearanceCell.Options.UseForeColor = true;
            this.colMSSV.Caption = "MSSV";
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMSSV.MaxWidth = 100;
            this.colMSSV.MinWidth = 100;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "MSSV", "Tổng số SV : {0}")});
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 1;
            this.colMSSV.Width = 100;
            // 
            // colHo
            // 
            this.colHo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colHo.AppearanceCell.Options.UseForeColor = true;
            this.colHo.Caption = "Họ";
            this.colHo.FieldName = "Ho";
            this.colHo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colHo.MaxWidth = 200;
            this.colHo.MinWidth = 150;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 2;
            this.colHo.Width = 156;
            // 
            // colTen
            // 
            this.colTen.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colTen.AppearanceCell.Options.UseForeColor = true;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTen.MaxWidth = 100;
            this.colTen.MinWidth = 100;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            this.colTen.Width = 100;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colGioiTinh.AppearanceCell.Options.UseForeColor = true;
            this.colGioiTinh.AppearanceCell.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.AppearanceHeader.Options.UseTextOptions = true;
            this.colGioiTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.ColumnEdit = this.imgBoxGioiTinh;
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.ImageOptions.Alignment = System.Drawing.StringAlignment.Center;
            this.colGioiTinh.MaxWidth = 80;
            this.colGioiTinh.MinWidth = 80;
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            this.colGioiTinh.Width = 80;
            // 
            // imgBoxGioiTinh
            // 
            this.imgBoxGioiTinh.AutoHeight = false;
            this.imgBoxGioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imgBoxGioiTinh.Name = "imgBoxGioiTinh";
            this.imgBoxGioiTinh.SmallImages = this.imgList;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.InsertGalleryImage("miss_16x16.png", "devav/people/miss_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/miss_16x16.png"), 0);
            this.imgList.Images.SetKeyName(0, "miss_16x16.png");
            this.imgList.InsertGalleryImage("employee_16x16.png", "images/people/employee_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/people/employee_16x16.png"), 1);
            this.imgList.Images.SetKeyName(1, "employee_16x16.png");
            this.imgList.InsertGalleryImage("apply_16x16.png", "images/actions/apply_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_16x16.png"), 2);
            this.imgList.Images.SetKeyName(2, "apply_16x16.png");
            this.imgList.InsertGalleryImage("cancel_16x16.png", "images/actions/cancel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_16x16.png"), 3);
            this.imgList.Images.SetKeyName(3, "cancel_16x16.png");
            this.imgList.InsertGalleryImage("close_16x16.png", "devav/actions/close_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/actions/close_16x16.png"), 4);
            this.imgList.Images.SetKeyName(4, "close_16x16.png");
            this.imgList.InsertGalleryImage("employeeexcellence_16x16.png", "devav/people/employeeexcellence_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("devav/people/employeeexcellence_16x16.png"), 5);
            this.imgList.Images.SetKeyName(5, "employeeexcellence_16x16.png");
            // 
            // colNTNS
            // 
            this.colNTNS.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colNTNS.AppearanceCell.Options.UseForeColor = true;
            this.colNTNS.AppearanceCell.Options.UseTextOptions = true;
            this.colNTNS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNTNS.AppearanceHeader.Options.UseTextOptions = true;
            this.colNTNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNTNS.Caption = "Ngày sinh";
            this.colNTNS.FieldName = "NTNS";
            this.colNTNS.MaxWidth = 100;
            this.colNTNS.MinWidth = 100;
            this.colNTNS.Name = "colNTNS";
            this.colNTNS.Visible = true;
            this.colNTNS.VisibleIndex = 5;
            this.colNTNS.Width = 100;
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colNoiSinh.AppearanceCell.Options.UseForeColor = true;
            this.colNoiSinh.Caption = "Nơi sinh";
            this.colNoiSinh.FieldName = "NoiSinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Visible = true;
            this.colNoiSinh.VisibleIndex = 10;
            this.colNoiSinh.Width = 156;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMaKhoa.AppearanceCell.Options.UseForeColor = true;
            this.colMaKhoa.Caption = "Mã khoa";
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.MaxWidth = 100;
            this.colMaKhoa.MinWidth = 100;
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 6;
            this.colMaKhoa.Width = 100;
            // 
            // colKetQuaTN
            // 
            this.colKetQuaTN.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colKetQuaTN.AppearanceCell.Options.UseForeColor = true;
            this.colKetQuaTN.Caption = "Kết quả TN";
            this.colKetQuaTN.ColumnEdit = this.imbKetQuaTN;
            this.colKetQuaTN.FieldName = "KetQuaTN";
            this.colKetQuaTN.MaxWidth = 100;
            this.colKetQuaTN.MinWidth = 100;
            this.colKetQuaTN.Name = "colKetQuaTN";
            this.colKetQuaTN.Visible = true;
            this.colKetQuaTN.VisibleIndex = 8;
            this.colKetQuaTN.Width = 100;
            // 
            // imbKetQuaTN
            // 
            this.imbKetQuaTN.AutoHeight = false;
            this.imbKetQuaTN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imbKetQuaTN.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Đậu", true, 5),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Rớt", false, 4)});
            this.imbKetQuaTN.Name = "imbKetQuaTN";
            this.imbKetQuaTN.SmallImages = this.imgList;
            // 
            // colDTB
            // 
            this.colDTB.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colDTB.AppearanceCell.Options.UseForeColor = true;
            this.colDTB.AppearanceCell.Options.UseTextOptions = true;
            this.colDTB.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTB.AppearanceHeader.Options.UseTextOptions = true;
            this.colDTB.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDTB.Caption = "Điểm TB";
            this.colDTB.FieldName = "DTB";
            this.colDTB.MaxWidth = 100;
            this.colDTB.MinWidth = 100;
            this.colDTB.Name = "colDTB";
            this.colDTB.Visible = true;
            this.colDTB.VisibleIndex = 7;
            this.colDTB.Width = 100;
            // 
            // colXepLoaiTN
            // 
            this.colXepLoaiTN.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colXepLoaiTN.AppearanceCell.Options.UseForeColor = true;
            this.colXepLoaiTN.Caption = "Xếp loại TN";
            this.colXepLoaiTN.FieldName = "XepLoaiTN";
            this.colXepLoaiTN.MaxWidth = 200;
            this.colXepLoaiTN.MinWidth = 150;
            this.colXepLoaiTN.Name = "colXepLoaiTN";
            this.colXepLoaiTN.Visible = true;
            this.colXepLoaiTN.VisibleIndex = 9;
            this.colXepLoaiTN.Width = 150;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar6});
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
            this.btnXetTotNghiep,
            this.barButtonItem2,
            this.barListItem1,
            this.btnPrint,
            this.btnPrintSV,
            this.btnPrinKQTN});
            this.barManager.MainMenu = this.bar6;
            this.barManager.MaxItemId = 12;
            // 
            // bar6
            // 
            this.bar6.BarAppearance.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(200)))), ((int)(((byte)(223)))));
            this.bar6.BarAppearance.Hovered.Options.UseBackColor = true;
            this.bar6.BarName = "Main menu";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateSamle, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnImportExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAddNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExportExcel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXetTotNghiep, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawBorder = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.MultiLine = true;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Main menu";
            // 
            // btnCreateSamle
            // 
            this.btnCreateSamle.Caption = "Tạo dữ liệu mẫu";
            this.btnCreateSamle.Id = 4;
            this.btnCreateSamle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateSamle.ImageOptions.SvgImage")));
            this.btnCreateSamle.Name = "btnCreateSamle";
            this.btnCreateSamle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateSamle_ItemClick);
            // 
            // btnImportExcel
            // 
            this.btnImportExcel.Caption = "Import from Excel";
            this.btnImportExcel.Hint = "Ctrl + O";
            this.btnImportExcel.Id = 5;
            this.btnImportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportExcel.ImageOptions.SvgImage")));
            this.btnImportExcel.Name = "btnImportExcel";
            this.btnImportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportExcel_ItemClick);
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
            // btnExportExcel
            // 
            this.btnExportExcel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnExportExcel.Caption = "Xuất Excel";
            this.btnExportExcel.Id = 1;
            this.btnExportExcel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportExcel.ImageOptions.SvgImage")));
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportExcel_ItemClick);
            // 
            // btnXetTotNghiep
            // 
            this.btnXetTotNghiep.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnXetTotNghiep.Caption = "Xét tốt nghiệp";
            this.btnXetTotNghiep.Id = 6;
            this.btnXetTotNghiep.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXetTotNghiep.ImageOptions.SvgImage")));
            this.btnXetTotNghiep.Name = "btnXetTotNghiep";
            this.btnXetTotNghiep.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXetTotNghiep_ItemClick);
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
            // btnPrint
            // 
            this.btnPrint.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnPrint.Caption = "In";
            this.btnPrint.Id = 9;
            this.btnPrint.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrint.ImageOptions.SvgImage")));
            this.btnPrint.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrintSV),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPrinKQTN)});
            this.btnPrint.Name = "btnPrint";
            // 
            // btnPrintSV
            // 
            this.btnPrintSV.Caption = "Danh sách sinh viên";
            this.btnPrintSV.Id = 10;
            this.btnPrintSV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrintSV.ImageOptions.SvgImage")));
            this.btnPrintSV.Name = "btnPrintSV";
            // 
            // btnPrinKQTN
            // 
            this.btnPrinKQTN.Caption = "Kết quả tốt nghiệp";
            this.btnPrinKQTN.Id = 11;
            this.btnPrinKQTN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrinKQTN.ImageOptions.SvgImage")));
            this.btnPrinKQTN.Name = "btnPrinKQTN";
            this.btnPrinKQTN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrinKQTN_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(1175, 42);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 370);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(1175, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 42);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 328);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1175, 42);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 328);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "In kết quả tốt nghiệp";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 8;
            this.barListItem1.Name = "barListItem1";
            // 
            // SaveExcel
            // 
            this.SaveExcel.FileName = "xtraSaveFileDialog1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 42);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1175, 328);
            this.panelControl1.TabIndex = 10;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.grc_DanhSachSV);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 50);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1171, 276);
            this.panelControl3.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.srcKhoa);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1171, 48);
            this.panelControl2.TabIndex = 0;
            // 
            // srcKhoa
            // 
            this.srcKhoa.Location = new System.Drawing.Point(113, 15);
            this.srcKhoa.MenuManager = this.barManager;
            this.srcKhoa.Name = "srcKhoa";
            this.srcKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.srcKhoa.Properties.NullText = "";
            this.srcKhoa.Properties.PopupView = this.grv_Khoa;
            this.srcKhoa.Properties.ReadOnly = true;
            this.srcKhoa.Size = new System.Drawing.Size(273, 20);
            this.srcKhoa.TabIndex = 2;
            this.srcKhoa.EditValueChanged += new System.EventHandler(this.srcKhoa_EditValueChanged);
            // 
            // grv_Khoa
            // 
            this.grv_Khoa.ColumnPanelRowHeight = 26;
            this.grv_Khoa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã khoa";
            this.gridColumn1.FieldName = "MaKhoa";
            this.gridColumn1.MaxWidth = 120;
            this.gridColumn1.MinWidth = 80;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 120;
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
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Danh sách khoa";
            // 
            // FrmDanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 370);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmDanhSachSV";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.FrmDanhSachSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grc_DanhSachSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DanhSachSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbKetQuaTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Khoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grc_DanhSachSV;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_DanhSachSV;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNTNS;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiSinh;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colKetQuaTN;
        private DevExpress.XtraGrid.Columns.GridColumn colDTB;
        private DevExpress.XtraGrid.Columns.GridColumn colXepLoaiTN;
        private DevExpress.Utils.ImageCollection imgList;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarButtonItem btnAddNew;
        private DevExpress.XtraBars.BarButtonItem btnExportExcel;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnCreateSamle;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraEditors.XtraSaveFileDialog SaveExcel;
        private DevExpress.XtraBars.BarButtonItem btnImportExcel;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox imgBoxGioiTinh;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit srcKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Khoa;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhoa;
        private DevExpress.XtraBars.BarButtonItem btnXetTotNghiep;
        private DevExpress.XtraBars.BarLinkContainerItem btnPrint;
        private DevExpress.XtraBars.BarButtonItem btnPrintSV;
        private DevExpress.XtraBars.BarButtonItem btnPrinKQTN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox imbKetQuaTN;
    }
}