
namespace QLTV.GUI
{
    partial class frmKhu
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
            System.Windows.Forms.Label maKhuLabel;
            System.Windows.Forms.Label tenKhuLabel;
            System.Windows.Forms.Label viTriLabel;
            System.Windows.Forms.Label trangThaiLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhu));
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
            this.gcKhu = new DevExpress.XtraGrid.GridControl();
            this.bdsKhu = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupKhu = new DevExpress.XtraEditors.GroupControl();
            this.ckTrangThai = new DevExpress.XtraEditors.CheckEdit();
            this.txtViTri = new DevExpress.XtraEditors.MemoEdit();
            this.txtTenKhu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKhu = new DevExpress.XtraEditors.TextEdit();
            maKhuLabel = new System.Windows.Forms.Label();
            tenKhuLabel = new System.Windows.Forms.Label();
            viTriLabel = new System.Windows.Forms.Label();
            trangThaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).BeginInit();
            this.nvgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKhu)).BeginInit();
            this.groupKhu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maKhuLabel
            // 
            maKhuLabel.AutoSize = true;
            maKhuLabel.Location = new System.Drawing.Point(61, 59);
            maKhuLabel.Name = "maKhuLabel";
            maKhuLabel.Size = new System.Drawing.Size(58, 17);
            maKhuLabel.TabIndex = 0;
            maKhuLabel.Text = "Ma Khu:";
            // 
            // tenKhuLabel
            // 
            tenKhuLabel.AutoSize = true;
            tenKhuLabel.Location = new System.Drawing.Point(55, 113);
            tenKhuLabel.Name = "tenKhuLabel";
            tenKhuLabel.Size = new System.Drawing.Size(64, 17);
            tenKhuLabel.TabIndex = 2;
            tenKhuLabel.Text = "Ten Khu:";
            // 
            // viTriLabel
            // 
            viTriLabel.AutoSize = true;
            viTriLabel.Location = new System.Drawing.Point(77, 169);
            viTriLabel.Name = "viTriLabel";
            viTriLabel.Size = new System.Drawing.Size(42, 17);
            viTriLabel.TabIndex = 4;
            viTriLabel.Text = "Vi Tri:";
            // 
            // trangThaiLabel
            // 
            trangThaiLabel.AutoSize = true;
            trangThaiLabel.Location = new System.Drawing.Point(533, 58);
            trangThaiLabel.Name = "trangThaiLabel";
            trangThaiLabel.Size = new System.Drawing.Size(78, 17);
            trangThaiLabel.TabIndex = 6;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1052, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 734);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1052, 20);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1052, 30);
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
            this.nvgt.Size = new System.Drawing.Size(1052, 27);
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
            // gcKhu
            // 
            this.gcKhu.DataSource = this.bdsKhu;
            this.gcKhu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKhu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKhu.Location = new System.Drawing.Point(0, 57);
            this.gcKhu.MainView = this.gridView1;
            this.gcKhu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcKhu.MenuManager = this.barManager1;
            this.gcKhu.Name = "gcKhu";
            this.gcKhu.Size = new System.Drawing.Size(1052, 324);
            this.gcKhu.TabIndex = 6;
            this.gcKhu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsKhu
            // 
            this.bdsKhu.DataSource = typeof(QLTV.Entity.Khu);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhu,
            this.colTenKhu,
            this.colViTri,
            this.colTrangThai});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gcKhu;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaKhu
            // 
            this.colMaKhu.FieldName = "MaKhu";
            this.colMaKhu.MinWidth = 25;
            this.colMaKhu.Name = "colMaKhu";
            this.colMaKhu.Visible = true;
            this.colMaKhu.VisibleIndex = 0;
            this.colMaKhu.Width = 94;
            // 
            // colTenKhu
            // 
            this.colTenKhu.FieldName = "TenKhu";
            this.colTenKhu.MinWidth = 25;
            this.colTenKhu.Name = "colTenKhu";
            this.colTenKhu.Visible = true;
            this.colTenKhu.VisibleIndex = 1;
            this.colTenKhu.Width = 94;
            // 
            // colViTri
            // 
            this.colViTri.FieldName = "ViTri";
            this.colViTri.MinWidth = 25;
            this.colViTri.Name = "colViTri";
            this.colViTri.Visible = true;
            this.colViTri.VisibleIndex = 2;
            this.colViTri.Width = 94;
            // 
            // colTrangThai
            // 
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.MinWidth = 25;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 3;
            this.colTrangThai.Width = 94;
            // 
            // groupKhu
            // 
            this.groupKhu.Controls.Add(trangThaiLabel);
            this.groupKhu.Controls.Add(this.ckTrangThai);
            this.groupKhu.Controls.Add(viTriLabel);
            this.groupKhu.Controls.Add(this.txtViTri);
            this.groupKhu.Controls.Add(tenKhuLabel);
            this.groupKhu.Controls.Add(this.txtTenKhu);
            this.groupKhu.Controls.Add(maKhuLabel);
            this.groupKhu.Controls.Add(this.txtMaKhu);
            this.groupKhu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupKhu.Enabled = false;
            this.groupKhu.Location = new System.Drawing.Point(0, 381);
            this.groupKhu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupKhu.Name = "groupKhu";
            this.groupKhu.Size = new System.Drawing.Size(1052, 353);
            this.groupKhu.TabIndex = 13;
            this.groupKhu.Text = "Thông tin khu";
            // 
            // ckTrangThai
            // 
            this.ckTrangThai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhu, "TrangThai", true));
            this.ckTrangThai.Location = new System.Drawing.Point(617, 55);
            this.ckTrangThai.MenuManager = this.barManager1;
            this.ckTrangThai.Name = "ckTrangThai";
            this.ckTrangThai.Properties.Caption = "Đang hoạt động";
            this.ckTrangThai.Size = new System.Drawing.Size(136, 24);
            this.ckTrangThai.TabIndex = 7;
            // 
            // txtViTri
            // 
            this.txtViTri.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhu, "ViTri", true));
            this.txtViTri.Location = new System.Drawing.Point(125, 166);
            this.txtViTri.MenuManager = this.barManager1;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Size = new System.Drawing.Size(388, 136);
            this.txtViTri.TabIndex = 5;
            // 
            // txtTenKhu
            // 
            this.txtTenKhu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhu, "TenKhu", true));
            this.txtTenKhu.Location = new System.Drawing.Point(125, 110);
            this.txtTenKhu.MenuManager = this.barManager1;
            this.txtTenKhu.Name = "txtTenKhu";
            this.txtTenKhu.Size = new System.Drawing.Size(211, 22);
            this.txtTenKhu.TabIndex = 3;
            // 
            // txtMaKhu
            // 
            this.txtMaKhu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKhu, "MaKhu", true));
            this.txtMaKhu.Location = new System.Drawing.Point(125, 56);
            this.txtMaKhu.MenuManager = this.barManager1;
            this.txtMaKhu.Name = "txtMaKhu";
            this.txtMaKhu.Size = new System.Drawing.Size(211, 22);
            this.txtMaKhu.TabIndex = 1;
            // 
            // frmKhu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 754);
            this.Controls.Add(this.groupKhu);
            this.Controls.Add(this.gcKhu);
            this.Controls.Add(this.nvgt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLTV.Properties.Resources.purple_bookshelf_16x16;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmKhu";
            this.Text = "Khu";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).EndInit();
            this.nvgt.ResumeLayout(false);
            this.nvgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKhu)).EndInit();
            this.groupKhu.ResumeLayout(false);
            this.groupKhu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViTri.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhu.Properties)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gcKhu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupKhu;
        private System.Windows.Forms.BindingSource bdsKhu;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhu;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhu;
        private DevExpress.XtraGrid.Columns.GridColumn colViTri;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.TextEdit txtTenKhu;
        private DevExpress.XtraEditors.TextEdit txtMaKhu;
        private DevExpress.XtraEditors.MemoEdit txtViTri;
        private DevExpress.XtraEditors.CheckEdit ckTrangThai;
    }
}