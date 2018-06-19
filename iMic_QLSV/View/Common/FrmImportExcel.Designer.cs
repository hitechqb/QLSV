namespace iMic_QLSV.View.Common
{
    partial class FrmImportExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportExcel));
            this.grc_SinhVien = new DevExpress.XtraGrid.GridControl();
            this.grv_SinhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMSSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNTNS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.colNoiSinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKetQuaTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDTB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colXepLoaiTN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBrowse = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.OpenExcel = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grc_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // grc_SinhVien
            // 
            this.grc_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grc_SinhVien.Location = new System.Drawing.Point(0, 42);
            this.grc_SinhVien.MainView = this.grv_SinhVien;
            this.grc_SinhVien.Name = "grc_SinhVien";
            this.grc_SinhVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.grc_SinhVien.Size = new System.Drawing.Size(1045, 366);
            this.grc_SinhVien.TabIndex = 0;
            this.grc_SinhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv_SinhVien});
            // 
            // grv_SinhVien
            // 
            this.grv_SinhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.grv_SinhVien.GridControl = this.grc_SinhVien;
            this.grv_SinhVien.Name = "grv_SinhVien";
            this.grv_SinhVien.OptionsBehavior.Editable = false;
            this.grv_SinhVien.OptionsSelection.CheckBoxSelectorColumnWidth = 28;
            this.grv_SinhVien.OptionsSelection.MultiSelect = true;
            this.grv_SinhVien.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.grv_SinhVien.OptionsView.ShowGroupPanel = false;
            this.grv_SinhVien.OptionsView.ShowViewCaption = true;
            this.grv_SinhVien.RowHeight = 26;
            this.grv_SinhVien.ViewCaption = "Danh sách sinh viên";
            this.grv_SinhVien.ViewCaptionHeight = 25;
            this.grv_SinhVien.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.grv_SinhVien_RowCellStyle);
            // 
            // colMSSV
            // 
            this.colMSSV.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMSSV.AppearanceCell.Options.UseForeColor = true;
            this.colMSSV.Caption = "MSSV";
            this.colMSSV.FieldName = "MSSV";
            this.colMSSV.Name = "colMSSV";
            this.colMSSV.Visible = true;
            this.colMSSV.VisibleIndex = 1;
            this.colMSSV.Width = 74;
            // 
            // colHo
            // 
            this.colHo.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colHo.AppearanceCell.Options.UseForeColor = true;
            this.colHo.Caption = "Họ";
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 2;
            this.colHo.Width = 317;
            // 
            // colTen
            // 
            this.colTen.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colTen.AppearanceCell.Options.UseForeColor = true;
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            this.colTen.Width = 143;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colGioiTinh.AppearanceCell.Options.UseForeColor = true;
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            this.colGioiTinh.Width = 111;
            // 
            // colNTNS
            // 
            this.colNTNS.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colNTNS.AppearanceCell.Options.UseForeColor = true;
            this.colNTNS.Caption = "Ngày sinh";
            this.colNTNS.ColumnEdit = this.repositoryItemDateEdit1;
            this.colNTNS.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNTNS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNTNS.FieldName = "NTNS";
            this.colNTNS.GroupFormat.FormatString = "dd/MM/yyyy";
            this.colNTNS.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNTNS.Name = "colNTNS";
            this.colNTNS.Visible = true;
            this.colNTNS.VisibleIndex = 5;
            this.colNTNS.Width = 179;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.CalendarTimeProperties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.CalendarTimeProperties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // colNoiSinh
            // 
            this.colNoiSinh.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colNoiSinh.AppearanceCell.Options.UseForeColor = true;
            this.colNoiSinh.Caption = "Nơi sinh";
            this.colNoiSinh.FieldName = "NoiSinh";
            this.colNoiSinh.Name = "colNoiSinh";
            this.colNoiSinh.Visible = true;
            this.colNoiSinh.VisibleIndex = 8;
            this.colNoiSinh.Width = 143;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colMaKhoa.AppearanceCell.Options.UseForeColor = true;
            this.colMaKhoa.Caption = "Mã khoa";
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 6;
            this.colMaKhoa.Width = 129;
            // 
            // colKetQuaTN
            // 
            this.colKetQuaTN.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colKetQuaTN.AppearanceCell.Options.UseForeColor = true;
            this.colKetQuaTN.Caption = "Kết quả TN";
            this.colKetQuaTN.FieldName = "KetQuaTN";
            this.colKetQuaTN.Name = "colKetQuaTN";
            this.colKetQuaTN.Visible = true;
            this.colKetQuaTN.VisibleIndex = 7;
            this.colKetQuaTN.Width = 143;
            // 
            // colDTB
            // 
            this.colDTB.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colDTB.AppearanceCell.Options.UseForeColor = true;
            this.colDTB.Caption = "Điểm TB";
            this.colDTB.FieldName = "DTB";
            this.colDTB.Name = "colDTB";
            this.colDTB.Visible = true;
            this.colDTB.VisibleIndex = 9;
            this.colDTB.Width = 143;
            // 
            // colXepLoaiTN
            // 
            this.colXepLoaiTN.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.colXepLoaiTN.AppearanceCell.Options.UseForeColor = true;
            this.colXepLoaiTN.Caption = "Xếp loại TN";
            this.colXepLoaiTN.FieldName = "XepLoaiTN";
            this.colXepLoaiTN.Name = "colXepLoaiTN";
            this.colXepLoaiTN.Visible = true;
            this.colXepLoaiTN.VisibleIndex = 10;
            this.colXepLoaiTN.Width = 212;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBrowse,
            this.btnUpdate,
            this.btnClose,
            this.barStaticItem1,
            this.barStaticItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            this.barManager1.StatusBar = this.bar1;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnBrowse, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnClose, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Caption = "Nạp dữ liệu";
            this.btnBrowse.Hint = "Ctrl + O";
            this.btnBrowse.Id = 0;
            this.btnBrowse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBrowse.ImageOptions.SvgImage")));
            this.btnBrowse.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBrowse_ItemClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnUpdate.Caption = "Cập nhật dữ liệu";
            this.btnUpdate.Id = 1;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUpdate_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 2;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 3";
            this.bar1.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem2)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Custom 3";
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "(*) Chỉ cập nhật các giá trị có trạng thái Ready.";
            this.barStaticItem2.Id = 4;
            this.barStaticItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barStaticItem2.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon;
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.ItemAppearance.Normal.Options.UseForeColor = true;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1045, 42);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 408);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1045, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 42);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 366);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1045, 42);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 366);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "(*)";
            this.barStaticItem1.Id = 3;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // OpenExcel
            // 
            this.OpenExcel.FileName = "xtraOpenFileDialog1";
            // 
            // FrmImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 433);
            this.Controls.Add(this.grc_SinhVien);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmImportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật sinh viên từ Excel";
            ((System.ComponentModel.ISupportInitialize)(this.grc_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grc_SinhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grv_SinhVien;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBrowse;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
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
        private DevExpress.XtraEditors.XtraOpenFileDialog OpenExcel;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}