
namespace QLTV.GUI
{
    partial class frmTheDocGia
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
            System.Windows.Forms.Label docGiaLabel;
            System.Windows.Forms.Label maDGLabel;
            System.Windows.Forms.Label ngayLapTheLabel;
            System.Windows.Forms.Label ngayHetHanLabel;
            System.Windows.Forms.Label soLuongMuonToiDaLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheDocGia));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.nvgt = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gcTheDG = new DevExpress.XtraGrid.GridControl();
            this.bdsTheDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.gvTheDG = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTheDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaDG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayLapThe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongMuonToiDa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupTheDG = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayLapThe = new DevExpress.XtraEditors.DateEdit();
            this.ckTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.txtMaTheDG = new DevExpress.XtraEditors.TextEdit();
            this.lkDocGia = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDocGia = new System.Windows.Forms.BindingSource(this.components);
            this.spinSoLuongMuonToiDa = new DevExpress.XtraEditors.SpinEdit();
            docGiaLabel = new System.Windows.Forms.Label();
            maDGLabel = new System.Windows.Forms.Label();
            ngayLapTheLabel = new System.Windows.Forms.Label();
            ngayHetHanLabel = new System.Windows.Forms.Label();
            soLuongMuonToiDaLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).BeginInit();
            this.nvgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTheDG)).BeginInit();
            this.groupTheDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLapThe.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLapThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheDG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuongMuonToiDa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // docGiaLabel
            // 
            docGiaLabel.AutoSize = true;
            docGiaLabel.Location = new System.Drawing.Point(76, 120);
            docGiaLabel.Name = "docGiaLabel";
            docGiaLabel.Size = new System.Drawing.Size(60, 17);
            docGiaLabel.TabIndex = 0;
            docGiaLabel.Text = "Doc Gia:";
            // 
            // maDGLabel
            // 
            maDGLabel.AutoSize = true;
            maDGLabel.Location = new System.Drawing.Point(34, 56);
            maDGLabel.Name = "maDGLabel";
            maDGLabel.Size = new System.Drawing.Size(102, 17);
            maDGLabel.TabIndex = 26;
            maDGLabel.Text = "Mã thẻ độc giả:";
            // 
            // ngayLapTheLabel
            // 
            ngayLapTheLabel.AutoSize = true;
            ngayLapTheLabel.Location = new System.Drawing.Point(38, 176);
            ngayLapTheLabel.Name = "ngayLapTheLabel";
            ngayLapTheLabel.Size = new System.Drawing.Size(98, 17);
            ngayLapTheLabel.TabIndex = 27;
            ngayLapTheLabel.Text = "Ngay Lap The:";
            // 
            // ngayHetHanLabel
            // 
            ngayHetHanLabel.AutoSize = true;
            ngayHetHanLabel.Location = new System.Drawing.Point(38, 235);
            ngayHetHanLabel.Name = "ngayHetHanLabel";
            ngayHetHanLabel.Size = new System.Drawing.Size(98, 17);
            ngayHetHanLabel.TabIndex = 28;
            ngayHetHanLabel.Text = "Ngay Het Han:";
            // 
            // soLuongMuonToiDaLabel
            // 
            soLuongMuonToiDaLabel.AutoSize = true;
            soLuongMuonToiDaLabel.Location = new System.Drawing.Point(539, 56);
            soLuongMuonToiDaLabel.Name = "soLuongMuonToiDaLabel";
            soLuongMuonToiDaLabel.Size = new System.Drawing.Size(153, 17);
            soLuongMuonToiDaLabel.TabIndex = 28;
            soLuongMuonToiDaLabel.Text = "So Luong Muon Toi Da:";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new System.Drawing.Point(614, 119);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(78, 17);
            trangThaiLabel.TabIndex = 29;
            trangThaiLabel.Text = "Trang Thai:";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnGhi,
            this.btnHuy,
            this.btnReload,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHuy, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 0;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.Image")));
            this.btnGhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGhi.ImageOptions.LargeImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnHuy
            // 
            this.btnHuy.Caption = "Hủy";
            this.btnHuy.Enabled = false;
            this.btnHuy.Id = 5;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.LargeImage")));
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHuy_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 7;
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.LargeImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1330, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 734);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1330, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 704);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1330, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 704);
            // 
            // nvgt
            // 
            this.nvgt.AddNewItem = null;
            this.nvgt.CountItem = this.bindingNavigatorCountItem;
            this.nvgt.DeleteItem = null;
            this.nvgt.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nvgt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.nvgt.Location = new System.Drawing.Point(0, 30);
            this.nvgt.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nvgt.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nvgt.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nvgt.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nvgt.Name = "nvgt";
            this.nvgt.PositionItem = this.bindingNavigatorPositionItem;
            this.nvgt.Size = new System.Drawing.Size(1330, 27);
            this.nvgt.TabIndex = 5;
            this.nvgt.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(67, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // gcTheDG
            // 
            this.gcTheDG.DataSource = this.bdsTheDocGia;
            this.gcTheDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTheDG.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTheDG.Location = new System.Drawing.Point(0, 57);
            this.gcTheDG.MainView = this.gvTheDG;
            this.gcTheDG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTheDG.MenuManager = this.barManager1;
            this.gcTheDG.Name = "gcTheDG";
            this.gcTheDG.Size = new System.Drawing.Size(1330, 331);
            this.gcTheDG.TabIndex = 6;
            this.gcTheDG.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTheDG});
            // 
            // bdsTheDocGia
            // 
            this.bdsTheDocGia.DataSource = typeof(QLTV.Entity.TheDocGia);
            // 
            // gvTheDG
            // 
            this.gvTheDG.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTheDG,
            this.colMaDG,
            this.colDocGia,
            this.gridColumn1,
            this.colNgayLapThe,
            this.colNgayHetHan,
            this.colSoLuongMuonToiDa,
            this.colTrangThai});
            this.gvTheDG.DetailHeight = 431;
            this.gvTheDG.GridControl = this.gcTheDG;
            this.gvTheDG.Name = "gvTheDG";
            this.gvTheDG.OptionsBehavior.Editable = false;
            this.gvTheDG.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvTheDG_FocusedRowChanged);
            // 
            // colMaTheDG
            // 
            this.colMaTheDG.FieldName = "MaTheDG";
            this.colMaTheDG.MinWidth = 25;
            this.colMaTheDG.Name = "colMaTheDG";
            this.colMaTheDG.Visible = true;
            this.colMaTheDG.VisibleIndex = 0;
            this.colMaTheDG.Width = 135;
            // 
            // colMaDG
            // 
            this.colMaDG.FieldName = "MaDG";
            this.colMaDG.MinWidth = 25;
            this.colMaDG.Name = "colMaDG";
            this.colMaDG.Visible = true;
            this.colMaDG.VisibleIndex = 1;
            this.colMaDG.Width = 135;
            // 
            // colDocGia
            // 
            this.colDocGia.Caption = "Họ";
            this.colDocGia.FieldName = "DocGia.Ho";
            this.colDocGia.MinWidth = 25;
            this.colDocGia.Name = "colDocGia";
            this.colDocGia.Visible = true;
            this.colDocGia.VisibleIndex = 2;
            this.colDocGia.Width = 135;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên";
            this.gridColumn1.FieldName = "DocGia.Ten";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 135;
            // 
            // colNgayLapThe
            // 
            this.colNgayLapThe.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayLapThe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayLapThe.FieldName = "NgayLapThe";
            this.colNgayLapThe.MinWidth = 25;
            this.colNgayLapThe.Name = "colNgayLapThe";
            this.colNgayLapThe.Visible = true;
            this.colNgayLapThe.VisibleIndex = 4;
            this.colNgayLapThe.Width = 150;
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayHetHan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayHetHan.FieldName = "NgayHetHan";
            this.colNgayHetHan.MinWidth = 25;
            this.colNgayHetHan.Name = "colNgayHetHan";
            this.colNgayHetHan.Visible = true;
            this.colNgayHetHan.VisibleIndex = 5;
            this.colNgayHetHan.Width = 144;
            // 
            // colSoLuongMuonToiDa
            // 
            this.colSoLuongMuonToiDa.FieldName = "SoLuongMuonToiDa";
            this.colSoLuongMuonToiDa.MinWidth = 25;
            this.colSoLuongMuonToiDa.Name = "colSoLuongMuonToiDa";
            this.colSoLuongMuonToiDa.Visible = true;
            this.colSoLuongMuonToiDa.VisibleIndex = 6;
            this.colSoLuongMuonToiDa.Width = 168;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.MinWidth = 25;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 7;
            this.colTrangThai.Width = 85;
            // 
            // groupTheDG
            // 
            this.groupTheDG.Controls.Add(this.spinSoLuongMuonToiDa);
            this.groupTheDG.Controls.Add(this.dateNgayHetHan);
            this.groupTheDG.Controls.Add(this.dateNgayLapThe);
            this.groupTheDG.Controls.Add(trangThaiLabel);
            this.groupTheDG.Controls.Add(this.ckTrangThai);
            this.groupTheDG.Controls.Add(soLuongMuonToiDaLabel);
            this.groupTheDG.Controls.Add(ngayHetHanLabel);
            this.groupTheDG.Controls.Add(ngayLapTheLabel);
            this.groupTheDG.Controls.Add(maDGLabel);
            this.groupTheDG.Controls.Add(this.txtMaTheDG);
            this.groupTheDG.Controls.Add(this.lkDocGia);
            this.groupTheDG.Controls.Add(docGiaLabel);
            this.groupTheDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTheDG.Enabled = false;
            this.groupTheDG.Location = new System.Drawing.Point(0, 388);
            this.groupTheDG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupTheDG.Name = "groupTheDG";
            this.groupTheDG.Size = new System.Drawing.Size(1330, 346);
            this.groupTheDG.TabIndex = 13;
            this.groupTheDG.Text = "Thông tin thẻ độc giả";
            // 
            // dateNgayHetHan
            // 
            this.dateNgayHetHan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheDocGia, "NgayHetHan", true));
            this.dateNgayHetHan.EditValue = null;
            this.dateNgayHetHan.Location = new System.Drawing.Point(142, 232);
            this.dateNgayHetHan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayHetHan.Name = "dateNgayHetHan";
            this.dateNgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayHetHan.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayHetHan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayHetHan.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayHetHan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayHetHan.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayHetHan.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayHetHan.Properties.NullText = "Chọn ngày ...";
            this.dateNgayHetHan.Size = new System.Drawing.Size(240, 22);
            this.dateNgayHetHan.TabIndex = 39;
            this.dateNgayHetHan.Enter += new System.EventHandler(this.dateNgayHetHan_Enter);
            // 
            // dateNgayLapThe
            // 
            this.dateNgayLapThe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheDocGia, "NgayLapThe", true));
            this.dateNgayLapThe.EditValue = null;
            this.dateNgayLapThe.Location = new System.Drawing.Point(142, 173);
            this.dateNgayLapThe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayLapThe.Name = "dateNgayLapThe";
            this.dateNgayLapThe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLapThe.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayLapThe.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayLapThe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayLapThe.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayLapThe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayLapThe.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayLapThe.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayLapThe.Properties.NullText = "Chọn ngày ...";
            this.dateNgayLapThe.Size = new System.Drawing.Size(240, 22);
            this.dateNgayLapThe.TabIndex = 38;
            this.dateNgayLapThe.Enter += new System.EventHandler(this.dateNgayLapThe_Enter);
            // 
            // ckTrangThai
            // 
            this.ckTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheDocGia, "TrangThai", true));
            this.ckTrangThai.Location = new System.Drawing.Point(698, 116);
            this.ckTrangThai.MenuManager = this.barManager1;
            this.ckTrangThai.Name = "ckTrangThai";
            this.ckTrangThai.Properties.Caption = "Được sử dụng";
            this.ckTrangThai.Size = new System.Drawing.Size(125, 24);
            this.ckTrangThai.TabIndex = 30;
            // 
            // txtMaTheDG
            // 
            this.txtMaTheDG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheDocGia, "MaTheDG", true));
            this.txtMaTheDG.Location = new System.Drawing.Point(142, 54);
            this.txtMaTheDG.MenuManager = this.barManager1;
            this.txtMaTheDG.Name = "txtMaTheDG";
            this.txtMaTheDG.Properties.ReadOnly = true;
            this.txtMaTheDG.Size = new System.Drawing.Size(240, 22);
            this.txtMaTheDG.TabIndex = 27;
            // 
            // lkDocGia
            // 
            this.lkDocGia.Location = new System.Drawing.Point(142, 117);
            this.lkDocGia.MenuManager = this.barManager1;
            this.lkDocGia.Name = "lkDocGia";
            this.lkDocGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkDocGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkDocGia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDG", "Ma DG", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho", "Ho", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MSSV", "MSSV", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SDT", "SDT", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkDocGia.Properties.DataSource = this.bdsDocGia;
            this.lkDocGia.Properties.DisplayMember = "MaDG";
            this.lkDocGia.Properties.NullText = "Chọn độc giả ...";
            this.lkDocGia.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkDocGia.Properties.ValueMember = "MaDG";
            this.lkDocGia.Size = new System.Drawing.Size(240, 22);
            this.lkDocGia.TabIndex = 26;
            // 
            // bdsDocGia
            // 
            this.bdsDocGia.DataSource = typeof(QLTV.Entity.DocGia);
            // 
            // spinSoLuongMuonToiDa
            // 
            this.spinSoLuongMuonToiDa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTheDocGia, "SoLuongMuonToiDa", true));
            this.spinSoLuongMuonToiDa.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuongMuonToiDa.Location = new System.Drawing.Point(698, 53);
            this.spinSoLuongMuonToiDa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinSoLuongMuonToiDa.MenuManager = this.barManager1;
            this.spinSoLuongMuonToiDa.Name = "spinSoLuongMuonToiDa";
            this.spinSoLuongMuonToiDa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoLuongMuonToiDa.Properties.DisplayFormat.FormatString = "n0";
            this.spinSoLuongMuonToiDa.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoLuongMuonToiDa.Properties.EditFormat.FormatString = "n0";
            this.spinSoLuongMuonToiDa.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoLuongMuonToiDa.Properties.IsFloatValue = false;
            this.spinSoLuongMuonToiDa.Properties.Mask.EditMask = "N00";
            this.spinSoLuongMuonToiDa.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinSoLuongMuonToiDa.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuongMuonToiDa.Size = new System.Drawing.Size(125, 24);
            this.spinSoLuongMuonToiDa.TabIndex = 40;
            // 
            // frmTheDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 754);
            this.Controls.Add(this.groupTheDG);
            this.Controls.Add(this.gcTheDG);
            this.Controls.Add(this.nvgt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLTV.Properties.Resources.bocontact2_16x16;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTheDocGia";
            this.Text = "Thẻ độc giả";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).EndInit();
            this.nvgt.ResumeLayout(false);
            this.nvgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTheDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTheDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTheDG)).EndInit();
            this.groupTheDG.ResumeLayout(false);
            this.groupTheDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLapThe.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayLapThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTheDG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkDocGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuongMuonToiDa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnHuy;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingNavigator nvgt;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.GridControl gcTheDG;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTheDG;
        private DevExpress.XtraEditors.GroupControl groupTheDG;
        private System.Windows.Forms.BindingSource bdsTheDocGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTheDG;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDG;
        private DevExpress.XtraGrid.Columns.GridColumn colDocGia;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayLapThe;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongMuonToiDa;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private System.Windows.Forms.BindingSource bdsDocGia;
        private DevExpress.XtraEditors.LookUpEdit lkDocGia;
        private DevExpress.XtraEditors.TextEdit txtMaTheDG;
        private DevExpress.XtraEditors.CheckEdit ckTrangThai;
        private DevExpress.XtraEditors.DateEdit dateNgayHetHan;
        private DevExpress.XtraEditors.DateEdit dateNgayLapThe;
        private DevExpress.XtraEditors.SpinEdit spinSoLuongMuonToiDa;
    }
}