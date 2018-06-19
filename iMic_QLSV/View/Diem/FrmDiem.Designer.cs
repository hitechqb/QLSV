namespace iMic_QLSV.View.Diem
{
    partial class FrmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiem));
            this.grc_Diem = new DevExpress.XtraGrid.GridControl();
            this.grv_Diem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.grc_Diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // grc_Diem
            // 
            this.grc_Diem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_Diem.Location = new System.Drawing.Point(0, 42);
            this.grc_Diem.MainView = this.grv_Diem;
            this.grc_Diem.Name = "grc_Diem";
            this.grc_Diem.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2});
            this.grc_Diem.Size = new System.Drawing.Size(1037, 396);
            this.grc_Diem.TabIndex = 0;
            this.grc_Diem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_Diem});
            // 
            // grv_Diem
            // 
            this.grv_Diem.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(236)))), ((int)(((byte)(247)))));
            this.grv_Diem.Appearance.GroupRow.Options.UseBackColor = true;
            this.grv_Diem.ColumnPanelRowHeight = 24;
            this.grv_Diem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMSSV,
            this.colHo,
            this.colTen,
            this.colMaMH,
            this.colTenMH,
            this.colDiem});
            this.grv_Diem.GridControl = this.grc_Diem;
            this.grv_Diem.GroupCount = 1;
            this.grv_Diem.Name = "grv_Diem";
            this.grv_Diem.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.grv_Diem.OptionsBehavior.AutoExpandAllGroups = true;
            this.grv_Diem.OptionsCustomization.AllowColumnMoving = false;
            this.grv_Diem.OptionsDetail.AllowExpandEmptyDetails = true;
            this.grv_Diem.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            this.grv_Diem.OptionsView.ShowChildrenInGroupPanel = true;
            this.grv_Diem.OptionsView.ShowViewCaption = true;
            this.grv_Diem.RowHeight = 26;
            this.grv_Diem.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMSSV, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.grv_Diem.ViewCaption = "Danh mục điểm";
            this.grv_Diem.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grv_Diem_RowUpdated);
            // 
            // colMSSV
            // 
            this.colMSSV.Caption = "MSSV";
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.OptionsColumn.AllowEdit = false;
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 0;
            // 
            // colHo
            // 
            this.colHo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colHo.AppearanceCell.Options.UseForeColor = true;
            this.colHo.Caption = "Họ";
            this.colHo.FieldName = "Ho";
            this.colHo.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colHo.MaxWidth = 200;
            this.colHo.MinWidth = 120;
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.AllowEdit = false;
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 0;
            this.colHo.Width = 141;
            // 
            // colTen
            // 
            this.colTen.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colTen.AppearanceCell.Options.UseForeColor = true;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.colTen.MaxWidth = 120;
            this.colTen.MinWidth = 80;
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 80;
            // 
            // colMaMH
            // 
            this.colMaMH.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMaMH.AppearanceCell.Options.UseForeColor = true;
            this.colMaMH.Caption = "Mã môn học";
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.MaxWidth = 120;
            this.colMaMH.MinWidth = 50;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.OptionsColumn.AllowEdit = false;
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 2;
            // 
            // colTenMH
            // 
            this.colTenMH.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colTenMH.AppearanceCell.Options.UseForeColor = true;
            this.colTenMH.Caption = "Tên môn học";
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.OptionsColumn.AllowEdit = false;
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 3;
            // 
            // colDiem
            // 
            this.colDiem.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.colDiem.AppearanceCell.Options.UseBackColor = true;
            this.colDiem.AppearanceCell.Options.UseTextOptions = true;
            this.colDiem.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiem.AppearanceHeader.Options.UseTextOptions = true;
            this.colDiem.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDiem.Caption = "Điểm";
            this.colDiem.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colDiem.DisplayFormat.FormatString = "N2";
            this.colDiem.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiem.FieldName = "Diem";
            this.colDiem.MaxWidth = 120;
            this.colDiem.MinWidth = 50;
            this.colDiem.Name = "colDiem";
            this.colDiem.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colDiem.Visible = true;
            this.colDiem.VisibleIndex = 4;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.DisplayFormat.FormatString = "N2";
            this.repositoryItemSpinEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.EditFormat.FormatString = "N2";
            this.repositoryItemSpinEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            this.repositoryItemSpinEdit2.NullText = "-";
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.repositoryItemSpinEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.DisplayFormat.FormatString = "N0";
            this.repositoryItemSpinEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.EditFormat.FormatString = "N0";
            this.repositoryItemSpinEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
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
            this.btnReload});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 8;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Nạp lại";
            this.btnReload.Id = 7;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 6;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
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
            this.barDockControl1.Size = new System.Drawing.Size(1037, 42);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 438);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Size = new System.Drawing.Size(1037, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 42);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1037, 42);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Size = new System.Drawing.Size(0, 396);
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
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 438);
            this.Controls.Add(this.grc_Diem);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FrmDiem";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grc_Diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grc_Diem;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_Diem;
        private DevExpress.XtraGrid.Columns.GridColumn colMSSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
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
        private DevExpress.XtraBars.BarButtonItem btnReload;
    }
}