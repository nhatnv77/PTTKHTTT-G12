
namespace QLTV.GUI
{
    partial class frmReadBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReadBook));
            this.tuaSachBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tuaSachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTVDataSet = new QLTV.QLTVDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tuaSachBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tuaSachTableAdapter = new QLTV.QLTVDataSetTableAdapters.TuaSachTableAdapter();
            this.tableAdapterManager = new QLTV.QLTVDataSetTableAdapters.TableAdapterManager();
            this.theDocGiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theDocGiaTableAdapter = new QLTV.QLTVDataSetTableAdapters.TheDocGiaTableAdapter();
            this.sP_GET_LIST_BOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_GET_LIST_BOOKTableAdapter = new QLTV.QLTVDataSetTableAdapters.SP_GET_LIST_BOOKTableAdapter();
            this.sP_GET_LIST_BOOKGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayXuatBan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTacgia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDoiTac = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tuaSachBindingNavigator)).BeginInit();
            this.tuaSachBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuaSachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDocGiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_LIST_BOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_LIST_BOOKGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tuaSachBindingNavigator
            // 
            this.tuaSachBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tuaSachBindingNavigator.BindingSource = this.tuaSachBindingSource;
            this.tuaSachBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tuaSachBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tuaSachBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tuaSachBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tuaSachBindingNavigatorSaveItem});
            this.tuaSachBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tuaSachBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tuaSachBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tuaSachBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tuaSachBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tuaSachBindingNavigator.Name = "tuaSachBindingNavigator";
            this.tuaSachBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tuaSachBindingNavigator.Size = new System.Drawing.Size(984, 27);
            this.tuaSachBindingNavigator.TabIndex = 0;
            this.tuaSachBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tuaSachBindingSource
            // 
            this.tuaSachBindingSource.DataMember = "TuaSach";
            this.tuaSachBindingSource.DataSource = this.qLTVDataSet;
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
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
            // tuaSachBindingNavigatorSaveItem
            // 
            this.tuaSachBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tuaSachBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tuaSachBindingNavigatorSaveItem.Image")));
            this.tuaSachBindingNavigatorSaveItem.Name = "tuaSachBindingNavigatorSaveItem";
            this.tuaSachBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tuaSachBindingNavigatorSaveItem.Text = "Save Data";
            this.tuaSachBindingNavigatorSaveItem.Click += new System.EventHandler(this.tuaSachBindingNavigatorSaveItem_Click);
            // 
            // tuaSachTableAdapter
            // 
            this.tuaSachTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietNhapTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuMuonTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuTraTableAdapter = null;
            this.tableAdapterManager.ChiTietThanhLyTableAdapter = null;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.DoiTacTableAdapter = null;
            this.tableAdapterManager.KeSachTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.KhuTableAdapter = null;
            this.tableAdapterManager.LoaiNVTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuMuonTableAdapter = null;
            this.tableAdapterManager.PhieuTraTableAdapter = null;
            this.tableAdapterManager.SachTableAdapter = null;
            this.tableAdapterManager.SachTrenKeTableAdapter = null;
            this.tableAdapterManager.SachTrongKhoTableAdapter = null;
            this.tableAdapterManager.SangTacTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TaiKhoanDGTableAdapter = null;
            this.tableAdapterManager.TaiKhoanNVTableAdapter = null;
            this.tableAdapterManager.TheDocGiaTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = null;
            this.tableAdapterManager.TuaSachTableAdapter = this.tuaSachTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLTV.QLTVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // theDocGiaBindingSource
            // 
            this.theDocGiaBindingSource.DataMember = "TheDocGia";
            this.theDocGiaBindingSource.DataSource = this.qLTVDataSet;
            // 
            // theDocGiaTableAdapter
            // 
            this.theDocGiaTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GET_LIST_BOOKBindingSource
            // 
            this.sP_GET_LIST_BOOKBindingSource.DataMember = "SP_GET_LIST_BOOK";
            this.sP_GET_LIST_BOOKBindingSource.DataSource = this.qLTVDataSet;
            // 
            // sP_GET_LIST_BOOKTableAdapter
            // 
            this.sP_GET_LIST_BOOKTableAdapter.ClearBeforeFill = true;
            // 
            // sP_GET_LIST_BOOKGridControl
            // 
            this.sP_GET_LIST_BOOKGridControl.DataSource = this.sP_GET_LIST_BOOKBindingSource;
            this.sP_GET_LIST_BOOKGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_GET_LIST_BOOKGridControl.Location = new System.Drawing.Point(0, 27);
            this.sP_GET_LIST_BOOKGridControl.MainView = this.gridView1;
            this.sP_GET_LIST_BOOKGridControl.Name = "sP_GET_LIST_BOOKGridControl";
            this.sP_GET_LIST_BOOKGridControl.Size = new System.Drawing.Size(984, 542);
            this.sP_GET_LIST_BOOKGridControl.TabIndex = 1;
            this.sP_GET_LIST_BOOKGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaISBN,
            this.colTenSach,
            this.colMoTa,
            this.colNgayXuatBan,
            this.colSoTrang,
            this.colTacgia,
            this.colTenDoiTac});
            this.gridView1.GridControl = this.sP_GET_LIST_BOOKGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // colMaISBN
            // 
            this.colMaISBN.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colMaISBN.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colMaISBN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaISBN.AppearanceCell.Options.UseBackColor = true;
            this.colMaISBN.AppearanceCell.Options.UseFont = true;
            this.colMaISBN.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colMaISBN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaISBN.AppearanceHeader.Options.UseBackColor = true;
            this.colMaISBN.AppearanceHeader.Options.UseFont = true;
            this.colMaISBN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaISBN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaISBN.Caption = "Mã ISBN";
            this.colMaISBN.FieldName = "MaISBN";
            this.colMaISBN.MinWidth = 25;
            this.colMaISBN.Name = "colMaISBN";
            this.colMaISBN.Visible = true;
            this.colMaISBN.VisibleIndex = 0;
            this.colMaISBN.Width = 94;
            // 
            // colTenSach
            // 
            this.colTenSach.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTenSach.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colTenSach.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSach.AppearanceCell.Options.UseBackColor = true;
            this.colTenSach.AppearanceCell.Options.UseFont = true;
            this.colTenSach.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colTenSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSach.AppearanceHeader.Options.UseBackColor = true;
            this.colTenSach.AppearanceHeader.Options.UseFont = true;
            this.colTenSach.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSach.Caption = "Tên sách";
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.MinWidth = 25;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 1;
            this.colTenSach.Width = 94;
            // 
            // colMoTa
            // 
            this.colMoTa.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colMoTa.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colMoTa.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMoTa.AppearanceCell.Options.UseBackColor = true;
            this.colMoTa.AppearanceCell.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colMoTa.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMoTa.AppearanceHeader.Options.UseBackColor = true;
            this.colMoTa.AppearanceHeader.Options.UseFont = true;
            this.colMoTa.AppearanceHeader.Options.UseTextOptions = true;
            this.colMoTa.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.MinWidth = 25;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 2;
            this.colMoTa.Width = 94;
            // 
            // colNgayXuatBan
            // 
            this.colNgayXuatBan.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colNgayXuatBan.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colNgayXuatBan.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayXuatBan.AppearanceCell.Options.UseBackColor = true;
            this.colNgayXuatBan.AppearanceCell.Options.UseFont = true;
            this.colNgayXuatBan.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colNgayXuatBan.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayXuatBan.AppearanceHeader.Options.UseBackColor = true;
            this.colNgayXuatBan.AppearanceHeader.Options.UseFont = true;
            this.colNgayXuatBan.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayXuatBan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayXuatBan.Caption = "Ngày xuất bản";
            this.colNgayXuatBan.FieldName = "NgayXuatBan";
            this.colNgayXuatBan.MinWidth = 25;
            this.colNgayXuatBan.Name = "colNgayXuatBan";
            this.colNgayXuatBan.Visible = true;
            this.colNgayXuatBan.VisibleIndex = 3;
            this.colNgayXuatBan.Width = 94;
            // 
            // colSoTrang
            // 
            this.colSoTrang.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colSoTrang.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colSoTrang.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoTrang.AppearanceCell.Options.UseBackColor = true;
            this.colSoTrang.AppearanceCell.Options.UseFont = true;
            this.colSoTrang.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colSoTrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoTrang.AppearanceHeader.Options.UseBackColor = true;
            this.colSoTrang.AppearanceHeader.Options.UseFont = true;
            this.colSoTrang.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTrang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTrang.Caption = "Số trang";
            this.colSoTrang.FieldName = "SoTrang";
            this.colSoTrang.MinWidth = 25;
            this.colSoTrang.Name = "colSoTrang";
            this.colSoTrang.Visible = true;
            this.colSoTrang.VisibleIndex = 4;
            this.colSoTrang.Width = 94;
            // 
            // colTacgia
            // 
            this.colTacgia.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTacgia.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colTacgia.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTacgia.AppearanceCell.Options.UseBackColor = true;
            this.colTacgia.AppearanceCell.Options.UseFont = true;
            this.colTacgia.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colTacgia.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTacgia.AppearanceHeader.Options.UseBackColor = true;
            this.colTacgia.AppearanceHeader.Options.UseFont = true;
            this.colTacgia.AppearanceHeader.Options.UseTextOptions = true;
            this.colTacgia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTacgia.Caption = "Tác giả";
            this.colTacgia.FieldName = "Tac gia";
            this.colTacgia.MinWidth = 25;
            this.colTacgia.Name = "colTacgia";
            this.colTacgia.Visible = true;
            this.colTacgia.VisibleIndex = 5;
            this.colTacgia.Width = 94;
            // 
            // colTenDoiTac
            // 
            this.colTenDoiTac.AppearanceCell.BackColor = System.Drawing.Color.White;
            this.colTenDoiTac.AppearanceCell.BackColor2 = System.Drawing.Color.White;
            this.colTenDoiTac.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDoiTac.AppearanceCell.Options.UseBackColor = true;
            this.colTenDoiTac.AppearanceCell.Options.UseFont = true;
            this.colTenDoiTac.AppearanceHeader.BackColor = System.Drawing.SystemColors.Highlight;
            this.colTenDoiTac.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenDoiTac.AppearanceHeader.Options.UseBackColor = true;
            this.colTenDoiTac.AppearanceHeader.Options.UseFont = true;
            this.colTenDoiTac.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenDoiTac.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenDoiTac.Caption = "Nhà xuất bản";
            this.colTenDoiTac.FieldName = "TenDoiTac";
            this.colTenDoiTac.MinWidth = 25;
            this.colTenDoiTac.Name = "colTenDoiTac";
            this.colTenDoiTac.Visible = true;
            this.colTenDoiTac.VisibleIndex = 6;
            this.colTenDoiTac.Width = 94;
            // 
            // frmReadBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 569);
            this.Controls.Add(this.sP_GET_LIST_BOOKGridControl);
            this.Controls.Add(this.tuaSachBindingNavigator);
            this.Name = "frmReadBook";
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.frmReadBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tuaSachBindingNavigator)).EndInit();
            this.tuaSachBindingNavigator.ResumeLayout(false);
            this.tuaSachBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tuaSachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theDocGiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_LIST_BOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_GET_LIST_BOOKGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource tuaSachBindingSource;
        private QLTVDataSetTableAdapters.TuaSachTableAdapter tuaSachTableAdapter;
        private QLTVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tuaSachBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tuaSachBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource theDocGiaBindingSource;
        private QLTVDataSetTableAdapters.TheDocGiaTableAdapter theDocGiaTableAdapter;
        private System.Windows.Forms.BindingSource sP_GET_LIST_BOOKBindingSource;
        private QLTVDataSetTableAdapters.SP_GET_LIST_BOOKTableAdapter sP_GET_LIST_BOOKTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_GET_LIST_BOOKGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayXuatBan;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colTacgia;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDoiTac;
    }
}