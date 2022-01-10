
namespace QLTV.GUI
{
    partial class frmChuyenSachCacKe
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnChuyenXuong = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkKe1 = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsKe = new System.Windows.Forms.BindingSource(this.components);
            this.gcTuaSach = new DevExpress.XtraGrid.GridControl();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.gvSach1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.colTuaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiTietNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsKe2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bdsSach2 = new System.Windows.Forms.BindingSource(this.components);
            this.gvSach2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnChuyenLen = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkKe2 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKe1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKe2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKe2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.btnChuyenXuong);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lkKe1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1144, 65);
            this.panelControl1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::QLTV.Properties.Resources.close_32x32;
            this.btnClose.Location = new System.Drawing.Point(989, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 52);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnChuyenXuong
            // 
            this.btnChuyenXuong.ImageOptions.Image = global::QLTV.Properties.Resources.movedown_32x32;
            this.btnChuyenXuong.Location = new System.Drawing.Point(797, 6);
            this.btnChuyenXuong.Name = "btnChuyenXuong";
            this.btnChuyenXuong.Size = new System.Drawing.Size(146, 52);
            this.btnChuyenXuong.TabIndex = 36;
            this.btnChuyenXuong.Text = "Chuyển xuống";
            this.btnChuyenXuong.Click += new System.EventHandler(this.btnChuyenXuong_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(408, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(20, 17);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Kệ:";
            // 
            // lkKe1
            // 
            this.lkKe1.Location = new System.Drawing.Point(450, 21);
            this.lkKe1.Name = "lkKe1";
            this.lkKe1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkKe1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKe1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKe", "Ma Ke", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKe", "Ten Ke", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhu", "Ma Khu", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrangThai", "Trang Thai", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkKe1.Properties.DataSource = this.bdsKe;
            this.lkKe1.Properties.DisplayMember = "TenKe";
            this.lkKe1.Properties.NullText = "Chọn một kệ ...";
            this.lkKe1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkKe1.Properties.ValueMember = "MaKe";
            this.lkKe1.Size = new System.Drawing.Size(302, 22);
            this.lkKe1.TabIndex = 33;
            this.lkKe1.EditValueChanged += new System.EventHandler(this.lkKho1_EditValueChanged);
            // 
            // bdsKe
            // 
            this.bdsKe.DataSource = typeof(QLTV.Entity.KeSach);
            // 
            // gcTuaSach
            // 
            this.gcTuaSach.DataSource = this.bdsSach;
            this.gcTuaSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTuaSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.Location = new System.Drawing.Point(0, 65);
            this.gcTuaSach.MainView = this.gvSach1;
            this.gcTuaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.Name = "gcTuaSach";
            this.gcTuaSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gcTuaSach.Size = new System.Drawing.Size(1144, 293);
            this.gcTuaSach.TabIndex = 20;
            this.gcTuaSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach1});
            // 
            // bdsSach
            // 
            this.bdsSach.DataSource = typeof(QLTV.Entity.Sach);
            // 
            // gvSach1
            // 
            this.gvSach1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colMaISBN,
            this.gridColumn4,
            this.colTuaSach,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colChiTietNhap,
            this.gridColumn5,
            this.colTrangThai});
            this.gvSach1.DetailHeight = 431;
            this.gvSach1.GridControl = this.gcTuaSach;
            this.gvSach1.Name = "gvSach1";
            this.gvSach1.OptionsBehavior.Editable = false;
            this.gvSach1.RowHeight = 100;
            this.gvSach1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvSach1_CustomUnboundColumnData);
            // 
            // colMaSach
            // 
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.MinWidth = 25;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            this.colMaSach.Width = 94;
            // 
            // colMaISBN
            // 
            this.colMaISBN.FieldName = "MaISBN";
            this.colMaISBN.MinWidth = 25;
            this.colMaISBN.Name = "colMaISBN";
            this.colMaISBN.Visible = true;
            this.colMaISBN.VisibleIndex = 1;
            this.colMaISBN.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Hình ảnh";
            this.gridColumn4.ColumnEdit = this.repositoryItemPictureEdit1;
            this.gridColumn4.FieldName = "Image";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // colTuaSach
            // 
            this.colTuaSach.Caption = "Tên sách";
            this.colTuaSach.FieldName = "TuaSach.TenSach";
            this.colTuaSach.MinWidth = 25;
            this.colTuaSach.Name = "colTuaSach";
            this.colTuaSach.Visible = true;
            this.colTuaSach.VisibleIndex = 3;
            this.colTuaSach.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Thể loại";
            this.gridColumn1.FieldName = "TuaSach.TheLoai.TenTheLoai";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhà xuất bản";
            this.gridColumn2.FieldName = "TuaSach.DoiTac.TenDoiTac";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Ngày xuất bản";
            this.gridColumn3.FieldName = "TuaSach.NgayXuatBan";
            this.gridColumn3.MinWidth = 25;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 94;
            // 
            // colChiTietNhap
            // 
            this.colChiTietNhap.Caption = "Nhà cung cấp";
            this.colChiTietNhap.FieldName = "ChiTietNhap.DoiTac.TenDoiTac";
            this.colChiTietNhap.MinWidth = 25;
            this.colChiTietNhap.Name = "colChiTietNhap";
            this.colChiTietNhap.Visible = true;
            this.colChiTietNhap.VisibleIndex = 7;
            this.colChiTietNhap.Width = 94;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Hình ảnh";
            this.gridColumn5.FieldName = "TuaSach.HinhAnh";
            this.gridColumn5.MinWidth = 25;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Width = 94;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.MinWidth = 25;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 8;
            this.colTrangThai.Width = 94;
            // 
            // bdsKe2
            // 
            this.bdsKe2.DataSource = typeof(QLTV.Entity.KeSach);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bdsSach2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 423);
            this.gridControl1.MainView = this.gvSach2;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit2});
            this.gridControl1.Size = new System.Drawing.Size(1144, 293);
            this.gridControl1.TabIndex = 24;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSach2});
            // 
            // bdsSach2
            // 
            this.bdsSach2.DataSource = typeof(QLTV.Entity.Sach);
            // 
            // gvSach2
            // 
            this.gvSach2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13,
            this.gridColumn14,
            this.gridColumn15});
            this.gvSach2.DetailHeight = 431;
            this.gvSach2.GridControl = this.gridControl1;
            this.gvSach2.Name = "gvSach2";
            this.gvSach2.OptionsBehavior.Editable = false;
            this.gvSach2.RowHeight = 100;
            this.gvSach2.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvSach2_CustomUnboundColumnData);
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "MaSach";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 94;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "MaISBN";
            this.gridColumn7.MinWidth = 25;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 94;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Hình ảnh";
            this.gridColumn8.ColumnEdit = this.repositoryItemPictureEdit2;
            this.gridColumn8.FieldName = "Image";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 94;
            // 
            // repositoryItemPictureEdit2
            // 
            this.repositoryItemPictureEdit2.Name = "repositoryItemPictureEdit2";
            this.repositoryItemPictureEdit2.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Tên sách";
            this.gridColumn9.FieldName = "TuaSach.TenSach";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 3;
            this.gridColumn9.Width = 94;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Thể loại";
            this.gridColumn10.FieldName = "TuaSach.TheLoai.TenTheLoai";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 94;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Nhà xuất bản";
            this.gridColumn11.FieldName = "TuaSach.DoiTac.TenDoiTac";
            this.gridColumn11.MinWidth = 25;
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 5;
            this.gridColumn11.Width = 94;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ngày xuất bản";
            this.gridColumn12.FieldName = "TuaSach.NgayXuatBan";
            this.gridColumn12.MinWidth = 25;
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            this.gridColumn12.Width = 94;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Nhà cung cấp";
            this.gridColumn13.FieldName = "ChiTietNhap.DoiTac.TenDoiTac";
            this.gridColumn13.MinWidth = 25;
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 7;
            this.gridColumn13.Width = 94;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Hình ảnh";
            this.gridColumn14.FieldName = "TuaSach.HinhAnh";
            this.gridColumn14.MinWidth = 25;
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Width = 94;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "TrangThai";
            this.gridColumn15.MinWidth = 25;
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 8;
            this.gridColumn15.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnChuyenLen);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.lkKe2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 358);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1144, 65);
            this.panelControl2.TabIndex = 23;
            // 
            // btnChuyenLen
            // 
            this.btnChuyenLen.ImageOptions.Image = global::QLTV.Properties.Resources.moveup_32x32;
            this.btnChuyenLen.Location = new System.Drawing.Point(795, 6);
            this.btnChuyenLen.Name = "btnChuyenLen";
            this.btnChuyenLen.Size = new System.Drawing.Size(146, 52);
            this.btnChuyenLen.TabIndex = 37;
            this.btnChuyenLen.Text = "Chuyển lên";
            this.btnChuyenLen.Click += new System.EventHandler(this.btnChuyenLen_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(408, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(20, 17);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Kệ:";
            // 
            // lkKe2
            // 
            this.lkKe2.Location = new System.Drawing.Point(450, 21);
            this.lkKe2.Name = "lkKe2";
            this.lkKe2.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkKe2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKe2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKe", "Ma Ke", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKe", "Ten Ke", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKhu", "Ma Khu", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrangThai", "Trang Thai", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkKe2.Properties.DataSource = this.bdsKe2;
            this.lkKe2.Properties.DisplayMember = "TenKe";
            this.lkKe2.Properties.NullText = "Chọn một kệ ...";
            this.lkKe2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkKe2.Properties.ValueMember = "MaKe";
            this.lkKe2.Size = new System.Drawing.Size(302, 22);
            this.lkKe2.TabIndex = 33;
            this.lkKe2.EditValueChanged += new System.EventHandler(this.lkKho2_EditValueChanged);
            // 
            // frmChuyenSachCacKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 720);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.gcTuaSach);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::QLTV.Properties.Resources.converttorange_16x16;
            this.Name = "frmChuyenSachCacKe";
            this.Text = "Chuyển sách các kệ";
            this.Load += new System.EventHandler(this.frmChuyenSachCacKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKe1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKe2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSach2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKe2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkKe1;
        private System.Windows.Forms.BindingSource bdsKe;
        private DevExpress.XtraGrid.GridControl gcTuaSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach1;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private System.Windows.Forms.BindingSource bdsSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietNhap;
        private DevExpress.XtraEditors.SimpleButton btnChuyenXuong;
        private System.Windows.Forms.BindingSource bdsKe2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSach2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnChuyenLen;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkKe2;
        private System.Windows.Forms.BindingSource bdsSach2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}