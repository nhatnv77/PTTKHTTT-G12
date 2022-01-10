
namespace QLTV.GUI
{
    partial class frmNhapSach
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
            System.Windows.Forms.Label ngayXuatBanLabel;
            System.Windows.Forms.Label doiTacLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lkKho = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.btnNhapSach = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.spinSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.lkTuaSach = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsTuaSach = new System.Windows.Forms.BindingSource(this.components);
            this.gcTuaSach = new DevExpress.XtraGrid.GridControl();
            this.bdsSach = new System.Windows.Forms.BindingSource(this.components);
            this.gvNhapSach = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.dateNgayNhap = new DevExpress.XtraEditors.DateEdit();
            this.pnlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.lkNhaCC = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDoiTac = new System.Windows.Forms.BindingSource(this.components);
            this.bdsTheLoai = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ngayXuatBanLabel = new System.Windows.Forms.Label();
            doiTacLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTuaSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayXuatBanLabel
            // 
            ngayXuatBanLabel.AutoSize = true;
            ngayXuatBanLabel.Location = new System.Drawing.Point(76, 152);
            ngayXuatBanLabel.Name = "ngayXuatBanLabel";
            ngayXuatBanLabel.Size = new System.Drawing.Size(80, 17);
            ngayXuatBanLabel.TabIndex = 36;
            ngayXuatBanLabel.Text = "Ngày nhập:";
            // 
            // doiTacLabel
            // 
            doiTacLabel.AutoSize = true;
            doiTacLabel.Location = new System.Drawing.Point(61, 216);
            doiTacLabel.Name = "doiTacLabel";
            doiTacLabel.Size = new System.Drawing.Size(98, 17);
            doiTacLabel.TabIndex = 38;
            doiTacLabel.Text = "Nhà cung cấp:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.lkKho);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1144, 72);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(345, 30);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(26, 16);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Kho:";
            // 
            // lkKho
            // 
            this.lkKho.Location = new System.Drawing.Point(378, 27);
            this.lkKho.Name = "lkKho";
            this.lkKho.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkKho.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaKho", "Ma Kho", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenKho", "Ten Kho", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ViTri", "Vi Tri", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrangThai", "Trang Thai", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkKho.Properties.DataSource = this.bdsKho;
            this.lkKho.Properties.DisplayMember = "TenKho";
            this.lkKho.Properties.NullText = "Chọn kho nhập sách ...";
            this.lkKho.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkKho.Properties.ValueMember = "MaKho";
            this.lkKho.Size = new System.Drawing.Size(302, 22);
            this.lkKho.TabIndex = 33;
            this.lkKho.EditValueChanged += new System.EventHandler(this.lkKho_EditValueChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataSource = typeof(QLTV.Entity.Kho);
            // 
            // btnNhapSach
            // 
            this.btnNhapSach.Location = new System.Drawing.Point(576, 112);
            this.btnNhapSach.Name = "btnNhapSach";
            this.btnNhapSach.Size = new System.Drawing.Size(138, 38);
            this.btnNhapSach.TabIndex = 35;
            this.btnNhapSach.Text = "Nhập sách vào kho";
            this.btnNhapSach.UseVisualStyleBackColor = true;
            this.btnNhapSach.Click += new System.EventHandler(this.btnNhapSach_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(96, 93);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 17);
            this.labelControl2.TabIndex = 32;
            this.labelControl2.Text = "Số lượng:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(96, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 17);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "Tựa sách:";
            // 
            // spinSoLuong
            // 
            this.spinSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuong.Location = new System.Drawing.Point(163, 89);
            this.spinSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spinSoLuong.Name = "spinSoLuong";
            this.spinSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.spinSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoLuong.Properties.EditFormat.FormatString = "n0";
            this.spinSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinSoLuong.Properties.IsFloatValue = false;
            this.spinSoLuong.Properties.Mask.EditMask = "N00";
            this.spinSoLuong.Properties.MaxValue = new decimal(new int[] {
            2000000000,
            0,
            0,
            0});
            this.spinSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinSoLuong.Size = new System.Drawing.Size(153, 24);
            this.spinSoLuong.TabIndex = 30;
            // 
            // lkTuaSach
            // 
            this.lkTuaSach.Location = new System.Drawing.Point(163, 36);
            this.lkTuaSach.Name = "lkTuaSach";
            this.lkTuaSach.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkTuaSach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkTuaSach.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaISBN", "Ma ISBN", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenSach", "Ten Sach", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTheLoai", "Ma The Loai", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaTacGia", "Ma Tac Gia", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaNXB", "Ma NXB", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NgayXuatBan", "Ngay Xuat Ban", 93, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SoTrang", "So Trang", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChieuDai", "Chieu Dai", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChieuRong", "Chieu Rong", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChatLieuGiay", "Chat Lieu Giay", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GiaTien", "Gia Tien", 57, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkTuaSach.Properties.DataSource = this.bdsTuaSach;
            this.lkTuaSach.Properties.DisplayMember = "TenSach";
            this.lkTuaSach.Properties.NullText = "Chọn tựa sách nhập ...";
            this.lkTuaSach.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkTuaSach.Properties.ValueMember = "MaISBN";
            this.lkTuaSach.Size = new System.Drawing.Size(302, 22);
            this.lkTuaSach.TabIndex = 4;
            // 
            // bdsTuaSach
            // 
            this.bdsTuaSach.DataSource = typeof(QLTV.Entity.TuaSach);
            // 
            // gcTuaSach
            // 
            this.gcTuaSach.DataSource = this.bdsSach;
            this.gcTuaSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTuaSach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.Location = new System.Drawing.Point(0, 72);
            this.gcTuaSach.MainView = this.gvNhapSach;
            this.gcTuaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcTuaSach.Name = "gcTuaSach";
            this.gcTuaSach.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemPictureEdit1});
            this.gcTuaSach.Size = new System.Drawing.Size(1144, 324);
            this.gcTuaSach.TabIndex = 20;
            this.gcTuaSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhapSach});
            // 
            // bdsSach
            // 
            this.bdsSach.DataSource = typeof(QLTV.Entity.Sach);
            // 
            // gvNhapSach
            // 
            this.gvNhapSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gvNhapSach.DetailHeight = 431;
            this.gvNhapSach.GridControl = this.gcTuaSach;
            this.gvNhapSach.Name = "gvNhapSach";
            this.gvNhapSach.OptionsBehavior.Editable = false;
            this.gvNhapSach.RowHeight = 100;
            this.gvNhapSach.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gvNhapSach_CustomUnboundColumnData);
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
            // dateNgayNhap
            // 
            this.dateNgayNhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "NgayXuatBan", true));
            this.dateNgayNhap.EditValue = null;
            this.dateNgayNhap.Location = new System.Drawing.Point(163, 149);
            this.dateNgayNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayNhap.Name = "dateNgayNhap";
            this.dateNgayNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhap.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayNhap.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayNhap.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayNhap.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayNhap.Size = new System.Drawing.Size(227, 22);
            this.dateNgayNhap.TabIndex = 37;
            this.dateNgayNhap.Enter += new System.EventHandler(this.dateNgayNhap_Enter);
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.Controls.Add(this.lkNhaCC);
            this.pnlNhapLieu.Controls.Add(doiTacLabel);
            this.pnlNhapLieu.Controls.Add(this.btnNhapSach);
            this.pnlNhapLieu.Controls.Add(this.dateNgayNhap);
            this.pnlNhapLieu.Controls.Add(ngayXuatBanLabel);
            this.pnlNhapLieu.Controls.Add(this.lkTuaSach);
            this.pnlNhapLieu.Controls.Add(this.spinSoLuong);
            this.pnlNhapLieu.Controls.Add(this.labelControl1);
            this.pnlNhapLieu.Controls.Add(this.labelControl2);
            this.pnlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhapLieu.Enabled = false;
            this.pnlNhapLieu.Location = new System.Drawing.Point(0, 396);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(1144, 324);
            this.pnlNhapLieu.TabIndex = 38;
            // 
            // lkNhaCC
            // 
            this.lkNhaCC.Location = new System.Drawing.Point(163, 213);
            this.lkNhaCC.Name = "lkNhaCC";
            this.lkNhaCC.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkNhaCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhaCC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDoiTac", "Ma Doi Tac", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDoiTac", "Ten Doi Tac", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiaChi", "Dia Chi", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SDT", "SDT", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkNhaCC.Properties.DataSource = this.bdsDoiTac;
            this.lkNhaCC.Properties.DisplayMember = "TenDoiTac";
            this.lkNhaCC.Properties.NullText = "Chọn nhà cung cấp ...";
            this.lkNhaCC.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkNhaCC.Properties.ValueMember = "MaDoiTac";
            this.lkNhaCC.Size = new System.Drawing.Size(240, 22);
            this.lkNhaCC.TabIndex = 39;
            // 
            // bdsDoiTac
            // 
            this.bdsDoiTac.DataSource = typeof(QLTV.Entity.DoiTac);
            // 
            // bdsTheLoai
            // 
            this.bdsTheLoai.DataSource = typeof(QLTV.Entity.TheLoai);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = global::QLTV.Properties.Resources.close_32x32;
            this.btnClose.Location = new System.Drawing.Point(766, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 52);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 720);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.gcTuaSach);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::QLTV.Properties.Resources.inbox_16x16;
            this.Name = "frmNhapSach";
            this.Text = "Nhập sách";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkTuaSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit lkTuaSach;
        private System.Windows.Forms.BindingSource bdsTuaSach;
        private DevExpress.XtraEditors.SpinEdit spinSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkKho;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.Button btnNhapSach;
        private DevExpress.XtraGrid.GridControl gcTuaSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhapSach;
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
        private DevExpress.XtraEditors.DateEdit dateNgayNhap;
        private DevExpress.XtraEditors.PanelControl pnlNhapLieu;
        private DevExpress.XtraEditors.LookUpEdit lkNhaCC;
        private System.Windows.Forms.BindingSource bdsDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource bdsTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietNhap;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}