
namespace QLTV.GUI
{
    partial class frmTacGia
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
            System.Windows.Forms.Label maTacGiaLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label ngayMatLabel;
            System.Windows.Forms.Label queQuanLabel;
            System.Windows.Forms.Label moTaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTacGia));
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
            this.gcKho = new DevExpress.XtraGrid.GridControl();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQueQuan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupKho = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayMat = new DevExpress.XtraEditors.DateEdit();
            this.dateNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.txtQueQuan = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtMaTacGia = new DevExpress.XtraEditors.TextEdit();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            maTacGiaLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            ngayMatLabel = new System.Windows.Forms.Label();
            queQuanLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).BeginInit();
            this.nvgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKho)).BeginInit();
            this.groupKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMat.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maTacGiaLabel
            // 
            maTacGiaLabel.AutoSize = true;
            maTacGiaLabel.Location = new System.Drawing.Point(46, 60);
            maTacGiaLabel.Name = "maTacGiaLabel";
            maTacGiaLabel.Size = new System.Drawing.Size(78, 17);
            maTacGiaLabel.TabIndex = 0;
            maTacGiaLabel.Text = "Ma Tac Gia:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(94, 120);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(30, 17);
            hoLabel.TabIndex = 2;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(88, 182);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(36, 17);
            tenLabel.TabIndex = 4;
            tenLabel.Text = "Ten:";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(376, 58);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(75, 17);
            ngaySinhLabel.TabIndex = 6;
            ngaySinhLabel.Text = "Ngay Sinh:";
            // 
            // ngayMatLabel
            // 
            ngayMatLabel.AutoSize = true;
            ngayMatLabel.Location = new System.Drawing.Point(380, 118);
            ngayMatLabel.Name = "ngayMatLabel";
            ngayMatLabel.Size = new System.Drawing.Size(71, 17);
            ngayMatLabel.TabIndex = 8;
            ngayMatLabel.Text = "Ngay Mat:";
            // 
            // queQuanLabel
            // 
            queQuanLabel.AutoSize = true;
            queQuanLabel.Location = new System.Drawing.Point(49, 245);
            queQuanLabel.Name = "queQuanLabel";
            queQuanLabel.Size = new System.Drawing.Size(75, 17);
            queQuanLabel.TabIndex = 10;
            queQuanLabel.Text = "Que Quan:";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(734, 59);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(50, 17);
            moTaLabel.TabIndex = 12;
            moTaLabel.Text = "Mo Ta:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1152, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 734);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1152, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1152, 30);
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
            this.nvgt.Size = new System.Drawing.Size(1152, 27);
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
            // gcKho
            // 
            this.gcKho.DataSource = this.bdsTacGia;
            this.gcKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcKho.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKho.Location = new System.Drawing.Point(0, 0);
            this.gcKho.MainView = this.gridView1;
            this.gcKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKho.MenuManager = this.barManager1;
            this.gcKho.Name = "gcKho";
            this.gcKho.Size = new System.Drawing.Size(1152, 324);
            this.gcKho.TabIndex = 6;
            this.gcKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataSource = typeof(QLTV.Entity.TacGia);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaTacGia,
            this.colHo,
            this.colTen,
            this.colNgaySinh,
            this.colNgayMat,
            this.colQueQuan,
            this.colMoTa});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gcKho;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.FieldName = "MaTacGia";
            this.colMaTacGia.MinWidth = 25;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.VisibleIndex = 0;
            this.colMaTacGia.Width = 94;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.MinWidth = 25;
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            this.colHo.Width = 94;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.MinWidth = 25;
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            this.colTen.Width = 94;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgaySinh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.MinWidth = 25;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            this.colNgaySinh.Width = 94;
            // 
            // colNgayMat
            // 
            this.colNgayMat.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayMat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayMat.FieldName = "NgayMat";
            this.colNgayMat.MinWidth = 25;
            this.colNgayMat.Name = "colNgayMat";
            this.colNgayMat.Visible = true;
            this.colNgayMat.VisibleIndex = 4;
            this.colNgayMat.Width = 94;
            // 
            // colQueQuan
            // 
            this.colQueQuan.FieldName = "QueQuan";
            this.colQueQuan.MinWidth = 25;
            this.colQueQuan.Name = "colQueQuan";
            this.colQueQuan.Visible = true;
            this.colQueQuan.VisibleIndex = 5;
            this.colQueQuan.Width = 94;
            // 
            // colMoTa
            // 
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.MinWidth = 25;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 6;
            this.colMoTa.Width = 94;
            // 
            // groupKho
            // 
            this.groupKho.Controls.Add(this.dateNgayMat);
            this.groupKho.Controls.Add(this.dateNgaySinh);
            this.groupKho.Controls.Add(moTaLabel);
            this.groupKho.Controls.Add(this.txtMoTa);
            this.groupKho.Controls.Add(queQuanLabel);
            this.groupKho.Controls.Add(this.txtQueQuan);
            this.groupKho.Controls.Add(ngayMatLabel);
            this.groupKho.Controls.Add(ngaySinhLabel);
            this.groupKho.Controls.Add(tenLabel);
            this.groupKho.Controls.Add(this.txtTen);
            this.groupKho.Controls.Add(hoLabel);
            this.groupKho.Controls.Add(this.txtHo);
            this.groupKho.Controls.Add(maTacGiaLabel);
            this.groupKho.Controls.Add(this.txtMaTacGia);
            this.groupKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKho.Enabled = false;
            this.groupKho.Location = new System.Drawing.Point(0, 381);
            this.groupKho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupKho.Name = "groupKho";
            this.groupKho.Size = new System.Drawing.Size(1152, 353);
            this.groupKho.TabIndex = 13;
            this.groupKho.Text = "Thông tin tác giả";
            // 
            // dateNgayMat
            // 
            this.dateNgayMat.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "NgayMat", true));
            this.dateNgayMat.EditValue = null;
            this.dateNgayMat.Location = new System.Drawing.Point(457, 117);
            this.dateNgayMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayMat.MenuManager = this.barManager1;
            this.dateNgayMat.Name = "dateNgayMat";
            this.dateNgayMat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayMat.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayMat.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayMat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayMat.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayMat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayMat.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayMat.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayMat.Size = new System.Drawing.Size(210, 22);
            this.dateNgayMat.TabIndex = 15;
            this.dateNgayMat.Enter += new System.EventHandler(this.dateNgayMat_Enter);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "NgaySinh", true));
            this.dateNgaySinh.EditValue = null;
            this.dateNgaySinh.Location = new System.Drawing.Point(457, 57);
            this.dateNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgaySinh.MenuManager = this.barManager1;
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgaySinh.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgaySinh.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgaySinh.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgaySinh.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgaySinh.Size = new System.Drawing.Size(210, 22);
            this.dateNgaySinh.TabIndex = 14;
            this.dateNgaySinh.Enter += new System.EventHandler(this.dateNgaySinh_Enter);
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "MoTa", true));
            this.txtMoTa.Location = new System.Drawing.Point(790, 56);
            this.txtMoTa.MenuManager = this.barManager1;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(294, 157);
            this.txtMoTa.TabIndex = 13;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "QueQuan", true));
            this.txtQueQuan.Location = new System.Drawing.Point(130, 242);
            this.txtQueQuan.MenuManager = this.barManager1;
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(537, 22);
            this.txtQueQuan.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "Ten", true));
            this.txtTen.Location = new System.Drawing.Point(130, 179);
            this.txtTen.MenuManager = this.barManager1;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(191, 22);
            this.txtTen.TabIndex = 5;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "Ho", true));
            this.txtHo.Location = new System.Drawing.Point(130, 117);
            this.txtHo.MenuManager = this.barManager1;
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(191, 22);
            this.txtHo.TabIndex = 3;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTacGia, "MaTacGia", true));
            this.txtMaTacGia.Location = new System.Drawing.Point(130, 57);
            this.txtMaTacGia.MenuManager = this.barManager1;
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Properties.ReadOnly = true;
            this.txtMaTacGia.Size = new System.Drawing.Size(191, 22);
            this.txtMaTacGia.TabIndex = 1;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridSplitContainer1.Grid = this.gcKho;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 57);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gcKho);
            this.gridSplitContainer1.Size = new System.Drawing.Size(1152, 324);
            this.gridSplitContainer1.TabIndex = 18;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 754);
            this.Controls.Add(this.groupKho);
            this.Controls.Add(this.gridSplitContainer1);
            this.Controls.Add(this.nvgt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLTV.Properties.Resources.bodetails_16x16;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTacGia";
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).EndInit();
            this.nvgt.ResumeLayout(false);
            this.nvgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKho)).EndInit();
            this.groupKho.ResumeLayout(false);
            this.groupKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMat.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgaySinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueQuan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
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
        private DevExpress.XtraGrid.GridControl gcKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupKho;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTacGia;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMat;
        private DevExpress.XtraGrid.Columns.GridColumn colQueQuan;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtQueQuan;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtMaTacGia;
        private DevExpress.XtraEditors.DateEdit dateNgaySinh;
        private DevExpress.XtraEditors.DateEdit dateNgayMat;
    }
}