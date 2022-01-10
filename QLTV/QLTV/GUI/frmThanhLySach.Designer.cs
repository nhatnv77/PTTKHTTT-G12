
namespace QLTV.GUI
{
    partial class frmThanhLySach
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
            this.btnThanhLySach = new System.Windows.Forms.Button();
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
            this.dateNgayThanhLy = new DevExpress.XtraEditors.DateEdit();
            this.pnlNhapLieu = new DevExpress.XtraEditors.PanelControl();
            this.lkNhaTL = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsDoiTac = new System.Windows.Forms.BindingSource(this.components);
            this.bdsTheLoai = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            ngayXuatBanLabel = new System.Windows.Forms.Label();
            doiTacLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThanhLy.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThanhLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).BeginInit();
            this.pnlNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaTL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // ngayXuatBanLabel
            // 
            ngayXuatBanLabel.AutoSize = true;
            ngayXuatBanLabel.Location = new System.Drawing.Point(58, 45);
            ngayXuatBanLabel.Name = "ngayXuatBanLabel";
            ngayXuatBanLabel.Size = new System.Drawing.Size(99, 17);
            ngayXuatBanLabel.TabIndex = 36;
            ngayXuatBanLabel.Text = "Ngày thanh lý:";
            // 
            // doiTacLabel
            // 
            doiTacLabel.AutoSize = true;
            doiTacLabel.Location = new System.Drawing.Point(61, 109);
            doiTacLabel.Name = "doiTacLabel";
            doiTacLabel.Size = new System.Drawing.Size(91, 17);
            doiTacLabel.TabIndex = 38;
            doiTacLabel.Text = "Nhà thanh lý:";
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
            this.lkKho.Properties.NullText = "Chọn kho chứa sách cần thanh lý ...";
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
            // btnThanhLySach
            // 
            this.btnThanhLySach.Location = new System.Drawing.Point(542, 34);
            this.btnThanhLySach.Name = "btnThanhLySach";
            this.btnThanhLySach.Size = new System.Drawing.Size(138, 38);
            this.btnThanhLySach.TabIndex = 35;
            this.btnThanhLySach.Text = "Thanh lý sách";
            this.btnThanhLySach.UseVisualStyleBackColor = true;
            this.btnThanhLySach.Click += new System.EventHandler(this.btnThanhLySach_Click);
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
            this.gcTuaSach.Size = new System.Drawing.Size(1144, 375);
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
            // dateNgayThanhLy
            // 
            this.dateNgayThanhLy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTuaSach, "NgayXuatBan", true));
            this.dateNgayThanhLy.EditValue = null;
            this.dateNgayThanhLy.Location = new System.Drawing.Point(163, 42);
            this.dateNgayThanhLy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateNgayThanhLy.Name = "dateNgayThanhLy";
            this.dateNgayThanhLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThanhLy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayThanhLy.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayThanhLy.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayThanhLy.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateNgayThanhLy.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateNgayThanhLy.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateNgayThanhLy.Properties.MaxValue = new System.DateTime(((long)(0)));
            this.dateNgayThanhLy.Size = new System.Drawing.Size(227, 22);
            this.dateNgayThanhLy.TabIndex = 37;
            this.dateNgayThanhLy.Enter += new System.EventHandler(this.dateNgayNhap_Enter);
            // 
            // pnlNhapLieu
            // 
            this.pnlNhapLieu.Controls.Add(this.lkNhaTL);
            this.pnlNhapLieu.Controls.Add(doiTacLabel);
            this.pnlNhapLieu.Controls.Add(this.btnThanhLySach);
            this.pnlNhapLieu.Controls.Add(this.dateNgayThanhLy);
            this.pnlNhapLieu.Controls.Add(ngayXuatBanLabel);
            this.pnlNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhapLieu.Enabled = false;
            this.pnlNhapLieu.Location = new System.Drawing.Point(0, 447);
            this.pnlNhapLieu.Name = "pnlNhapLieu";
            this.pnlNhapLieu.Size = new System.Drawing.Size(1144, 273);
            this.pnlNhapLieu.TabIndex = 38;
            // 
            // lkNhaTL
            // 
            this.lkNhaTL.Location = new System.Drawing.Point(163, 106);
            this.lkNhaTL.Name = "lkNhaTL";
            this.lkNhaTL.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lkNhaTL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkNhaTL.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaDoiTac", "Ma Doi Tac", 87, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TenDoiTac", "Ten Doi Tac", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DiaChi", "Dia Chi", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SDT", "SDT", 34, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Email", "Email", 41, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MoTa", "Mo Ta", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkNhaTL.Properties.DataSource = this.bdsDoiTac;
            this.lkNhaTL.Properties.DisplayMember = "TenDoiTac";
            this.lkNhaTL.Properties.NullText = "Chọn nhà thanh lý ...";
            this.lkNhaTL.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.lkNhaTL.Properties.ValueMember = "MaDoiTac";
            this.lkNhaTL.Size = new System.Drawing.Size(240, 22);
            this.lkNhaTL.TabIndex = 39;
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
            this.btnClose.Location = new System.Drawing.Point(769, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 52);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmThanhLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 720);
            this.Controls.Add(this.pnlNhapLieu);
            this.Controls.Add(this.gcTuaSach);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::QLTV.Properties.Resources.outbox_16x16;
            this.Name = "frmThanhLySach";
            this.Text = "Thanh lý sách";
            this.Load += new System.EventHandler(this.frmNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTuaSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPictureEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThanhLy.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayThanhLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlNhapLieu)).EndInit();
            this.pnlNhapLieu.ResumeLayout(false);
            this.pnlNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkNhaTL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDoiTac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTheLoai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource bdsTuaSach;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkKho;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.Button btnThanhLySach;
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
        private DevExpress.XtraEditors.DateEdit dateNgayThanhLy;
        private DevExpress.XtraEditors.PanelControl pnlNhapLieu;
        private DevExpress.XtraEditors.LookUpEdit lkNhaTL;
        private System.Windows.Forms.BindingSource bdsDoiTac;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.BindingSource bdsTheLoai;
        private DevExpress.XtraGrid.Columns.GridColumn colChiTietNhap;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}