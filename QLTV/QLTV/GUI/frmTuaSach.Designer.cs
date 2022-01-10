
namespace QLTV.GUI
{
    partial class frmTuaSach
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
            System.Windows.Forms.Label maISBNLabel;
            System.Windows.Forms.Label tenSachLabel;
            System.Windows.Forms.Label theLoaiLabel;
            System.Windows.Forms.Label tacGiaLabel;
            System.Windows.Forms.Label doiTacLabel;
            System.Windows.Forms.Label ngayXuatBanLabel;
            System.Windows.Forms.Label soTrangLabel;
            System.Windows.Forms.Label chieuDaiLabel;
            System.Windows.Forms.Label chieuRongLabel;
            System.Windows.Forms.Label chatLieuGiayLabel;
            System.Windows.Forms.Label moTaLabel;
            System.Windows.Forms.Label giaTienLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuaSach));
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
            this.bdsTuaSach = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkChonTheLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsTheLoai = new System.Windows.Forms.BindingSource(this.components);
            this.groupTuaSach = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayXB = new DevExpress.XtraEditors.DateEdit();
            this.spinChieuRong = new DevExpress.XtraEditors.SpinEdit();
            this.spinChieuDai = new DevExpress.XtraEditors.SpinEdit();
            this.spinGiaTien = new DevExpress.XtraEditors.SpinEdit();
            this.spinSoTrang = new DevExpress.XtraEditors.SpinEdit();
            this.picHinhAnh = new DevExpress.XtraEditors.PictureEdit();
            this.lkNhaXB = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDoiTac = new System.Windows.Forms.BindingSource(this.components);
            this.lkTacGia = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsTacGia = new System.Windows.Forms.BindingSource(this.components);
            this.txtMoTa = new DevExpress.XtraEditors.MemoEdit();
            this.txtChatLieuGiay = new DevExpress.XtraEditors.TextEdit();
            this.lkTheLoai = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTenSach = new DevExpress.XtraEditors.TextEdit();
            this.txtMaISBN = new DevExpress.XtraEditors.TextEdit();
            this.gcTuaSach = new DevExpress.XtraGrid.GridControl();
            this.gvTuaSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTheLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChieuDai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChieuRong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChatLieuGiay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHinhAnh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTacGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemPictureEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            maISBNLabel = new System.Windows.Forms.Label();
            tenSachLabel = new System.Windows.Forms.Label();
            theLoaiLabel = new System.Windows.Forms.Label();
            tacGiaLabel = new System.Windows.Forms.Label();
            doiTacLabel = new System.Windows.Forms.Label();
            ngayXuatBanLabel = new System.Windows.Forms.Label();
            soTrangLabel = new System.Windows.Forms.Label();
            chieuDaiLabel = new System.Windows.Forms.Label();
            chieuRongLabel = new System.Windows.Forms.Label();
            chatLieuGiayLabel = new System.Windows.Forms.Label();
            moTaLabel = new System.Windows.Forms.Label();
            giaTienLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).BeginInit();
            this.nvgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkChonTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTuaSach)).BeginInit();
            this.groupTuaSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinChieuRong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinChieuDai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTrang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChatLieuGiay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaISBN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // maISBNLabel
            // 
            maISBNLabel.AutoSize = true;
            maISBNLabel.Location = new System.Drawing.Point(68, 47);
            maISBNLabel.Name = "maISBNLabel";
            maISBNLabel.Size = new System.Drawing.Size(63, 17);
            maISBNLabel.TabIndex = 0;
            maISBNLabel.Text = "Ma ISBN:";
            // 
            // tenSachLabel
            // 
            tenSachLabel.AutoSize = true;
            tenSachLabel.Location = new System.Drawing.Point(61, 105);
            tenSachLabel.Name = "tenSachLabel";
            tenSachLabel.Size = new System.Drawing.Size(70, 17);
            tenSachLabel.TabIndex = 2;
            tenSachLabel.Text = "Ten Sach:";
            // 
            // theLoaiLabel
            // 
            theLoaiLabel.AutoSize = true;
            theLoaiLabel.Location = new System.Drawing.Point(67, 168);
            theLoaiLabel.Name = "theLoaiLabel";
            theLoaiLabel.Size = new System.Drawing.Size(64, 17);
            theLoaiLabel.TabIndex = 4;
            theLoaiLabel.Text = "The Loai:";
            // 
            // tacGiaLabel
            // 
            tacGiaLabel.AutoSize = true;
            tacGiaLabel.Location = new System.Drawing.Point(74, 223);
            tacGiaLabel.Name = "tacGiaLabel";
            tacGiaLabel.Size = new System.Drawing.Size(57, 17);
            tacGiaLabel.TabIndex = 6;
            tacGiaLabel.Text = "Tac Gia:";
            // 
            // doiTacLabel
            // 
            doiTacLabel.AutoSize = true;
            doiTacLabel.Location = new System.Drawing.Point(35, 281);
            doiTacLabel.Name = "doiTacLabel";
            doiTacLabel.Size = new System.Drawing.Size(96, 17);
            doiTacLabel.TabIndex = 8;
            doiTacLabel.Text = "Nhà xuất bản:";
            // 
            // ngayXuatBanLabel
            // 
            ngayXuatBanLabel.AutoSize = true;
            ngayXuatBanLabel.Location = new System.Drawing.Point(405, 49);
            ngayXuatBanLabel.Name = "ngayXuatBanLabel";
            ngayXuatBanLabel.Size = new System.Drawing.Size(104, 17);
            ngayXuatBanLabel.TabIndex = 10;
            ngayXuatBanLabel.Text = "Ngay Xuat Ban:";
            // 
            // soTrangLabel
            // 
            soTrangLabel.AutoSize = true;
            soTrangLabel.Location = new System.Drawing.Point(846, 44);
            soTrangLabel.Name = "soTrangLabel";
            soTrangLabel.Size = new System.Drawing.Size(69, 17);
            soTrangLabel.TabIndex = 12;
            soTrangLabel.Text = "So Trang:";
            // 
            // chieuDaiLabel
            // 
            chieuDaiLabel.AutoSize = true;
            chieuDaiLabel.Location = new System.Drawing.Point(846, 100);
            chieuDaiLabel.Name = "chieuDaiLabel";
            chieuDaiLabel.Size = new System.Drawing.Size(70, 17);
            chieuDaiLabel.TabIndex = 14;
            chieuDaiLabel.Text = "Chieu Dai:";
            // 
            // chieuRongLabel
            // 
            chieuRongLabel.AutoSize = true;
            chieuRongLabel.Location = new System.Drawing.Point(832, 166);
            chieuRongLabel.Name = "chieuRongLabel";
            chieuRongLabel.Size = new System.Drawing.Size(84, 17);
            chieuRongLabel.TabIndex = 16;
            chieuRongLabel.Text = "Chieu Rong:";
            // 
            // chatLieuGiayLabel
            // 
            chatLieuGiayLabel.AutoSize = true;
            chatLieuGiayLabel.Location = new System.Drawing.Point(816, 222);
            chatLieuGiayLabel.Name = "chatLieuGiayLabel";
            chatLieuGiayLabel.Size = new System.Drawing.Size(100, 17);
            chatLieuGiayLabel.TabIndex = 18;
            chatLieuGiayLabel.Text = "Chat Lieu Giay:";
            // 
            // moTaLabel
            // 
            moTaLabel.AutoSize = true;
            moTaLabel.Location = new System.Drawing.Point(459, 108);
            moTaLabel.Name = "moTaLabel";
            moTaLabel.Size = new System.Drawing.Size(50, 17);
            moTaLabel.TabIndex = 20;
            moTaLabel.Text = "Mo Ta:";
            // 
            // giaTienLabel
            // 
            giaTienLabel.AutoSize = true;
            giaTienLabel.Location = new System.Drawing.Point(856, 280);
            giaTienLabel.Name = "giaTienLabel";
            giaTienLabel.Size = new System.Drawing.Size(60, 17);
            giaTienLabel.TabIndex = 22;
            giaTienLabel.Text = "Gia Tien:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(1088, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 17);
            label1.TabIndex = 28;
            label1.Text = "Hình ảnh:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1651, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 887);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1651, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 857);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1651, 30);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 857);
            // 
            // nvgt
            // 
            this.nvgt.AddNewItem = null;
            this.nvgt.BindingSource = this.bdsTuaSach;
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
            this.nvgt.Size = new System.Drawing.Size(1651, 31);
            this.nvgt.TabIndex = 5;
            this.nvgt.Text = "bindingNavigator1";
            // 
            // bdsTuaSach
            // 
            this.bdsTuaSach.DataSource = typeof(QLTV.Entity.TuaSach);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.lkChonTheLoai);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 61);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1651, 53);
            this.panelControl1.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(268, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 21);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thể loại:";
            // 
            // lkChonTheLoai
            // 
            this.lkChonTheLoai.Location = new System.Drawing.Point(349, 19);
            this.lkChonTheLoai.MenuManager = this.barManager1;
            this.lkChonTheLoai.Name = "lkChonTheLoai";
            this.lkChonTheLoai.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkChonTheLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkChonTheLoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTheLoai", "Ma The Loai", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTheLoai", "Ten The Loai", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkChonTheLoai.Properties.DataSource = this.bdsTheLoai;
            this.lkChonTheLoai.Properties.DisplayMember = "TenTheLoai";
            this.lkChonTheLoai.Properties.NullText = "Chọn thể loại ...";
            this.lkChonTheLoai.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkChonTheLoai.Properties.ValueMember = "MaTheLoai";
            this.lkChonTheLoai.Size = new System.Drawing.Size(302, 22);
            this.lkChonTheLoai.TabIndex = 2;
            this.lkChonTheLoai.EditValueChanged += new System.EventHandler(this.lkTheLoai_EditValueChanged);
            // 
            // bdsTheLoai
            // 
            this.bdsTheLoai.DataSource = typeof(QLTV.Entity.TheLoai);
            // 
            // groupTuaSach
            // 
            this.groupTuaSach.Controls.Add(this.dateNgayXB);
            this.groupTuaSach.Controls.Add(this.spinChieuRong);
            this.groupTuaSach.Controls.Add(this.spinChieuDai);
            this.groupTuaSach.Controls.Add(this.spinGiaTien);
            this.groupTuaSach.Controls.Add(this.spinSoTrang);
            this.groupTuaSach.Controls.Add(label1);
            this.groupTuaSach.Controls.Add(this.picHinhAnh);
            this.groupTuaSach.Controls.Add(this.lkNhaXB);
            this.groupTuaSach.Controls.Add(this.lkTacGia);
            this.groupTuaSach.Controls.Add(giaTienLabel);
            this.groupTuaSach.Controls.Add(moTaLabel);
            this.groupTuaSach.Controls.Add(this.txtMoTa);
            this.groupTuaSach.Controls.Add(chatLieuGiayLabel);
            this.groupTuaSach.Controls.Add(this.txtChatLieuGiay);
            this.groupTuaSach.Controls.Add(chieuRongLabel);
            this.groupTuaSach.Controls.Add(chieuDaiLabel);
            this.groupTuaSach.Controls.Add(soTrangLabel);
            this.groupTuaSach.Controls.Add(ngayXuatBanLabel);
            this.groupTuaSach.Controls.Add(doiTacLabel);
            this.groupTuaSach.Controls.Add(tacGiaLabel);
            this.groupTuaSach.Controls.Add(theLoaiLabel);
            this.groupTuaSach.Controls.Add(this.lkTheLoai);
            this.groupTuaSach.Controls.Add(tenSachLabel);
            this.groupTuaSach.Controls.Add(this.txtTenSach);
            this.groupTuaSach.Controls.Add(maISBNLabel);
            this.groupTuaSach.Controls.Add(this.txtMaISBN);
            this.groupTuaSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupTuaSach.Enabled = false;
            this.groupTuaSach.Location = new System.Drawing.Point(0, 438);
            this.groupTuaSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupTuaSach.Name = "groupTuaSach";
            this.groupTuaSach.Size = new System.Drawing.Size(1651, 449);
            this.groupTuaSach.TabIndex = 20;
            this.groupTuaSach.Text = "Thông tin tựa sách";
            // 
            // dateNgayXB
            // 
            this.dateNgayXB.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "NgayXuatBan", true));
            this.dateNgayXB.EditValue = null;
            this.dateNgayXB.Location = new System.Drawing.Point(515, 46);
            this.dateNgayXB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayXB.MenuManager = this.barManager1;
            this.dateNgayXB.Name = "dateNgayXB";
            this.dateNgayXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayXB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayXB.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayXB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayXB.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayXB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayXB.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayXB.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayXB.Size = new System.Drawing.Size(267, 22);
            this.dateNgayXB.TabIndex = 33;
            this.dateNgayXB.Enter += new System.EventHandler(this.dateNgayXB_Enter);
            // 
            // spinChieuRong
            // 
            this.spinChieuRong.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "ChieuRong", true));
            this.spinChieuRong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinChieuRong.Location = new System.Drawing.Point(922, 166);
            this.spinChieuRong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinChieuRong.MenuManager = this.barManager1;
            this.spinChieuRong.Name = "spinChieuRong";
            this.spinChieuRong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinChieuRong.Properties.DisplayFormat.FormatString = "n0";
            this.spinChieuRong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinChieuRong.Properties.EditFormat.FormatString = "n0";
            this.spinChieuRong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinChieuRong.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinChieuRong.Properties.IsFloatValue = false;
            this.spinChieuRong.Properties.Mask.EditMask = "N00";
            this.spinChieuRong.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinChieuRong.Size = new System.Drawing.Size(125, 24);
            this.spinChieuRong.TabIndex = 32;
            // 
            // spinChieuDai
            // 
            this.spinChieuDai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "ChieuDai", true));
            this.spinChieuDai.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinChieuDai.Location = new System.Drawing.Point(922, 100);
            this.spinChieuDai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinChieuDai.MenuManager = this.barManager1;
            this.spinChieuDai.Name = "spinChieuDai";
            this.spinChieuDai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinChieuDai.Properties.DisplayFormat.FormatString = "n0";
            this.spinChieuDai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinChieuDai.Properties.EditFormat.FormatString = "n0";
            this.spinChieuDai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinChieuDai.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinChieuDai.Properties.IsFloatValue = false;
            this.spinChieuDai.Properties.Mask.EditMask = "N00";
            this.spinChieuDai.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinChieuDai.Size = new System.Drawing.Size(125, 24);
            this.spinChieuDai.TabIndex = 31;
            // 
            // spinGiaTien
            // 
            this.spinGiaTien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "GiaTien", true));
            this.spinGiaTien.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinGiaTien.Location = new System.Drawing.Point(922, 273);
            this.spinGiaTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinGiaTien.MenuManager = this.barManager1;
            this.spinGiaTien.Name = "spinGiaTien";
            this.spinGiaTien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinGiaTien.Properties.DisplayFormat.FormatString = "n0";
            this.spinGiaTien.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinGiaTien.Properties.EditFormat.FormatString = "n0";
            this.spinGiaTien.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinGiaTien.Properties.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.spinGiaTien.Properties.IsFloatValue = false;
            this.spinGiaTien.Properties.Mask.EditMask = "N00";
            this.spinGiaTien.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinGiaTien.Size = new System.Drawing.Size(125, 24);
            this.spinGiaTien.TabIndex = 30;
            // 
            // spinSoTrang
            // 
            this.spinSoTrang.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "SoTrang", true));
            this.spinSoTrang.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoTrang.Location = new System.Drawing.Point(922, 42);
            this.spinSoTrang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinSoTrang.MenuManager = this.barManager1;
            this.spinSoTrang.Name = "spinSoTrang";
            this.spinSoTrang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoTrang.Properties.DisplayFormat.FormatString = "n0";
            this.spinSoTrang.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoTrang.Properties.EditFormat.FormatString = "n0";
            this.spinSoTrang.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoTrang.Properties.IsFloatValue = false;
            this.spinSoTrang.Properties.Mask.EditMask = "N00";
            this.spinSoTrang.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinSoTrang.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoTrang.Size = new System.Drawing.Size(125, 24);
            this.spinSoTrang.TabIndex = 29;
            // 
            // picHinhAnh
            // 
            this.picHinhAnh.Location = new System.Drawing.Point(1161, 44);
            this.picHinhAnh.MenuManager = this.barManager1;
            this.picHinhAnh.Name = "picHinhAnh";
            this.picHinhAnh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picHinhAnh.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.picHinhAnh.Size = new System.Drawing.Size(105, 133);
            this.picHinhAnh.TabIndex = 27;
            // 
            // lkNhaXB
            // 
            this.lkNhaXB.Location = new System.Drawing.Point(137, 278);
            this.lkNhaXB.MenuManager = this.barManager1;
            this.lkNhaXB.Name = "lkNhaXB";
            this.lkNhaXB.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkNhaXB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhaXB.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDoiTac", "Ma Doi Tac", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDoiTac", "Ten Doi Tac", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiaChi", "Dia Chi", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SDT", "SDT", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkNhaXB.Properties.DataSource = this.bdsDoiTac;
            this.lkNhaXB.Properties.DisplayMember = "TenDoiTac";
            this.lkNhaXB.Properties.NullText = "Chọn nhà xuất bản ...";
            this.lkNhaXB.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkNhaXB.Properties.ValueMember = "MaDoiTac";
            this.lkNhaXB.Size = new System.Drawing.Size(240, 22);
            this.lkNhaXB.TabIndex = 26;
            // 
            // bdsDoiTac
            // 
            this.bdsDoiTac.DataSource = typeof(QLTV.Entity.DoiTac);
            // 
            // lkTacGia
            // 
            this.lkTacGia.Location = new System.Drawing.Point(137, 220);
            this.lkTacGia.MenuManager = this.barManager1;
            this.lkTacGia.Name = "lkTacGia";
            this.lkTacGia.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkTacGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTacGia.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTacGia", "Ma Tac Gia", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ho", "Ho", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten", "Ten", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgaySinh", "Ngay Sinh", 67, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayMat", "Ngay Mat", 63, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("QueQuan", "Que Quan", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkTacGia.Properties.DataSource = this.bdsTacGia;
            this.lkTacGia.Properties.DisplayMember = "MaTacGia";
            this.lkTacGia.Properties.NullText = "Chọn tác giả ...";
            this.lkTacGia.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkTacGia.Properties.ValueMember = "MaTacGia";
            this.lkTacGia.Size = new System.Drawing.Size(240, 22);
            this.lkTacGia.TabIndex = 25;
            // 
            // bdsTacGia
            // 
            this.bdsTacGia.DataSource = typeof(QLTV.Entity.TacGia);
            // 
            // txtMoTa
            // 
            this.txtMoTa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "MoTa", true));
            this.txtMoTa.Location = new System.Drawing.Point(515, 101);
            this.txtMoTa.MenuManager = this.barManager1;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(267, 199);
            this.txtMoTa.TabIndex = 21;
            // 
            // txtChatLieuGiay
            // 
            this.txtChatLieuGiay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "ChatLieuGiay", true));
            this.txtChatLieuGiay.Location = new System.Drawing.Point(922, 219);
            this.txtChatLieuGiay.MenuManager = this.barManager1;
            this.txtChatLieuGiay.Name = "txtChatLieuGiay";
            this.txtChatLieuGiay.Size = new System.Drawing.Size(125, 22);
            this.txtChatLieuGiay.TabIndex = 19;
            // 
            // lkTheLoai
            // 
            this.lkTheLoai.Location = new System.Drawing.Point(137, 165);
            this.lkTheLoai.MenuManager = this.barManager1;
            this.lkTheLoai.Name = "lkTheLoai";
            this.lkTheLoai.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkTheLoai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTheLoai.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTheLoai", "Ma The Loai", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenTheLoai", "Ten The Loai", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkTheLoai.Properties.DataSource = this.bdsTheLoai;
            this.lkTheLoai.Properties.DisplayMember = "TenTheLoai";
            this.lkTheLoai.Properties.NullText = "Chọn thể loại ...";
            this.lkTheLoai.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkTheLoai.Properties.ValueMember = "MaTheLoai";
            this.lkTheLoai.Size = new System.Drawing.Size(240, 22);
            this.lkTheLoai.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "TenSach", true));
            this.txtTenSach.Location = new System.Drawing.Point(137, 102);
            this.txtTenSach.MenuManager = this.barManager1;
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(240, 22);
            this.txtTenSach.TabIndex = 3;
            // 
            // txtMaISBN
            // 
            this.txtMaISBN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "MaISBN", true));
            this.txtMaISBN.Location = new System.Drawing.Point(137, 44);
            this.txtMaISBN.MenuManager = this.barManager1;
            this.txtMaISBN.Name = "txtMaISBN";
            this.txtMaISBN.Size = new System.Drawing.Size(240, 22);
            this.txtMaISBN.TabIndex = 1;
            // 
            // gcTuaSach
            // 
            this.gcTuaSach.DataSource = this.bdsTuaSach;
            this.gcTuaSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTuaSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.Location = new System.Drawing.Point(0, 114);
            this.gcTuaSach.MainView = this.gvTuaSach;
            this.gcTuaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.MenuManager = this.barManager1;
            this.gcTuaSach.Name = "gcTuaSach";
            this.gcTuaSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gcTuaSach.Size = new System.Drawing.Size(1651, 324);
            this.gcTuaSach.TabIndex = 19;
            this.gcTuaSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTuaSach});
            // 
            // gvTuaSach
            // 
            this.gvTuaSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaISBN,
            this.colTenSach,
            this.colMaTheLoai,
            this.colMaNXB,
            this.colNgayXuatBan,
            this.colSoTrang,
            this.colChieuDai,
            this.colChieuRong,
            this.colChatLieuGiay,
            this.colHinhAnh,
            this.colMoTa,
            this.colGiaTien,
            this.colMaTacGia,
            this.colImage});
            this.gvTuaSach.DetailHeight = 431;
            this.gvTuaSach.GridControl = this.gcTuaSach;
            this.gvTuaSach.Name = "gvTuaSach";
            this.gvTuaSach.OptionsBehavior.Editable = false;
            this.gvTuaSach.RowHeight = 100;
            this.gvTuaSach.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colHinhAnh, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gvTuaSach.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvTuaSach_FocusedRowChanged);
            this.gvTuaSach.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // colMaISBN
            // 
            this.colMaISBN.FieldName = "MaISBN";
            this.colMaISBN.MinWidth = 25;
            this.colMaISBN.Name = "colMaISBN";
            this.colMaISBN.Visible = true;
            this.colMaISBN.VisibleIndex = 0;
            this.colMaISBN.Width = 94;
            // 
            // colTenSach
            // 
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.MinWidth = 25;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 2;
            this.colTenSach.Width = 94;
            // 
            // colMaTheLoai
            // 
            this.colMaTheLoai.Caption = "Thể loại";
            this.colMaTheLoai.FieldName = "TheLoai.TenTheLoai";
            this.colMaTheLoai.MinWidth = 25;
            this.colMaTheLoai.Name = "colMaTheLoai";
            this.colMaTheLoai.Visible = true;
            this.colMaTheLoai.VisibleIndex = 3;
            this.colMaTheLoai.Width = 94;
            // 
            // colMaNXB
            // 
            this.colMaNXB.Caption = "Nhà xuất bản";
            this.colMaNXB.FieldName = "DoiTac.TenDoiTac";
            this.colMaNXB.MinWidth = 25;
            this.colMaNXB.Name = "colMaNXB";
            this.colMaNXB.Visible = true;
            this.colMaNXB.VisibleIndex = 5;
            this.colMaNXB.Width = 94;
            // 
            // colNgayXuatBan
            // 
            this.colNgayXuatBan.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNgayXuatBan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNgayXuatBan.FieldName = "NgayXuatBan";
            this.colNgayXuatBan.MinWidth = 25;
            this.colNgayXuatBan.Name = "colNgayXuatBan";
            this.colNgayXuatBan.Visible = true;
            this.colNgayXuatBan.VisibleIndex = 6;
            this.colNgayXuatBan.Width = 94;
            // 
            // colSoTrang
            // 
            this.colSoTrang.FieldName = "SoTrang";
            this.colSoTrang.MinWidth = 25;
            this.colSoTrang.Name = "colSoTrang";
            this.colSoTrang.Visible = true;
            this.colSoTrang.VisibleIndex = 7;
            this.colSoTrang.Width = 94;
            // 
            // colChieuDai
            // 
            this.colChieuDai.FieldName = "ChieuDai";
            this.colChieuDai.MinWidth = 25;
            this.colChieuDai.Name = "colChieuDai";
            this.colChieuDai.Visible = true;
            this.colChieuDai.VisibleIndex = 8;
            this.colChieuDai.Width = 94;
            // 
            // colChieuRong
            // 
            this.colChieuRong.FieldName = "ChieuRong";
            this.colChieuRong.MinWidth = 25;
            this.colChieuRong.Name = "colChieuRong";
            this.colChieuRong.Visible = true;
            this.colChieuRong.VisibleIndex = 9;
            this.colChieuRong.Width = 94;
            // 
            // colChatLieuGiay
            // 
            this.colChatLieuGiay.FieldName = "ChatLieuGiay";
            this.colChatLieuGiay.MinWidth = 25;
            this.colChatLieuGiay.Name = "colChatLieuGiay";
            this.colChatLieuGiay.Visible = true;
            this.colChatLieuGiay.VisibleIndex = 10;
            this.colChatLieuGiay.Width = 94;
            // 
            // colHinhAnh
            // 
            this.colHinhAnh.FieldName = "HinhAnh";
            this.colHinhAnh.MinWidth = 25;
            this.colHinhAnh.Name = "colHinhAnh";
            this.colHinhAnh.Width = 94;
            // 
            // colMoTa
            // 
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.MinWidth = 25;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 11;
            this.colMoTa.Width = 94;
            // 
            // colGiaTien
            // 
            this.colGiaTien.FieldName = "GiaTien";
            this.colGiaTien.MinWidth = 25;
            this.colGiaTien.Name = "colGiaTien";
            this.colGiaTien.Visible = true;
            this.colGiaTien.VisibleIndex = 12;
            this.colGiaTien.Width = 94;
            // 
            // colMaTacGia
            // 
            this.colMaTacGia.Caption = "Tác giả";
            this.colMaTacGia.FieldName = "colMaTacGia";
            this.colMaTacGia.MinWidth = 25;
            this.colMaTacGia.Name = "colMaTacGia";
            this.colMaTacGia.UnboundExpression = "[TacGia.Ho] + \' \' + [TacGia.Ten]";
            this.colMaTacGia.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.colMaTacGia.Visible = true;
            this.colMaTacGia.VisibleIndex = 4;
            this.colMaTacGia.Width = 94;
            // 
            // colImage
            // 
            this.colImage.Caption = "Hình ảnh";
            this.colImage.ColumnEdit = this.repositoryItemPictureEdit1;
            this.colImage.FieldName = "Image";
            this.colImage.MinWidth = 25;
            this.colImage.Name = "colImage";
            this.colImage.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 1;
            this.colImage.Width = 94;
            // 
            // repositoryItemPictureEdit1
            // 
            this.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1";
            this.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            // 
            // frmTuaSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1651, 907);
            this.Controls.Add(this.groupTuaSach);
            this.Controls.Add(this.gcTuaSach);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.nvgt);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Image = global::QLTV.Properties.Resources.Book_16x16;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmTuaSach";
            this.Text = "Tựa sách";
            this.Load += new System.EventHandler(this.frmKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nvgt)).EndInit();
            this.nvgt.ResumeLayout(false);
            this.nvgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkChonTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupTuaSach)).EndInit();
            this.groupTuaSach.ResumeLayout(false);
            this.groupTuaSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinChieuRong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinChieuDai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinGiaTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoTrang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHinhAnh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoTa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChatLieuGiay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaISBN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
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
        private System.Windows.Forms.BindingSource bdsTuaSach;
        private DevExpress.XtraEditors.GroupControl groupTuaSach;
        private DevExpress.XtraGrid.GridControl gcTuaSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTuaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNXB;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colChieuDai;
        private DevExpress.XtraGrid.Columns.GridColumn colChieuRong;
        private DevExpress.XtraGrid.Columns.GridColumn colChatLieuGiay;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTacGia;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkChonTheLoai;
        private System.Windows.Forms.BindingSource bdsTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colHinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit repositoryItemPictureEdit1;
        private DevExpress.XtraEditors.LookUpEdit lkTheLoai;
        private DevExpress.XtraEditors.TextEdit txtTenSach;
        private DevExpress.XtraEditors.TextEdit txtMaISBN;
        private System.Windows.Forms.BindingSource bdsTacGia;
        private DevExpress.XtraEditors.MemoEdit txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtChatLieuGiay;
        private DevExpress.XtraEditors.LookUpEdit lkNhaXB;
        private DevExpress.XtraEditors.LookUpEdit lkTacGia;
        private System.Windows.Forms.BindingSource bdsDoiTac;
        private DevExpress.XtraEditors.PictureEdit picHinhAnh;
        private DevExpress.XtraEditors.SpinEdit spinSoTrang;
        private DevExpress.XtraEditors.SpinEdit spinGiaTien;
        private DevExpress.XtraEditors.SpinEdit spinChieuRong;
        private DevExpress.XtraEditors.SpinEdit spinChieuDai;
        private DevExpress.XtraEditors.DateEdit dateNgayXB;
    }
}