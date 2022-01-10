
namespace QLTV.GUI
{
    partial class frmListBookBorrowed
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
            this.qLTVDataSet = new QLTV.QLTVDataSet();
            this.lOAD_LIST_BOOK_BORROWBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAD_LIST_BOOK_BORROWTableAdapter = new QLTV.QLTVDataSetTableAdapters.LOAD_LIST_BOOK_BORROWTableAdapter();
            this.tableAdapterManager = new QLTV.QLTVDataSetTableAdapters.TableAdapterManager();
            this.lOAD_LIST_BOOK_BORROWGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMuon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAD_LIST_BOOK_BORROWBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAD_LIST_BOOK_BORROWGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLTVDataSet
            // 
            this.qLTVDataSet.DataSetName = "QLTVDataSet";
            this.qLTVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAD_LIST_BOOK_BORROWBindingSource
            // 
            this.lOAD_LIST_BOOK_BORROWBindingSource.DataMember = "LOAD_LIST_BOOK_BORROW";
            this.lOAD_LIST_BOOK_BORROWBindingSource.DataSource = this.qLTVDataSet;
            // 
            // lOAD_LIST_BOOK_BORROWTableAdapter
            // 
            this.lOAD_LIST_BOOK_BORROWTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietNhapTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuMuonTableAdapter = null;
            this.tableAdapterManager.ChiTietPhieuTraTableAdapter = null;
            this.tableAdapterManager.ChiTietThanhLyTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.TuaSachTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTV.QLTVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAD_LIST_BOOK_BORROWGridControl
            // 
            this.lOAD_LIST_BOOK_BORROWGridControl.DataSource = this.lOAD_LIST_BOOK_BORROWBindingSource;
            this.lOAD_LIST_BOOK_BORROWGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lOAD_LIST_BOOK_BORROWGridControl.Location = new System.Drawing.Point(0, 92);
            this.lOAD_LIST_BOOK_BORROWGridControl.MainView = this.gridView1;
            this.lOAD_LIST_BOOK_BORROWGridControl.Name = "lOAD_LIST_BOOK_BORROWGridControl";
            this.lOAD_LIST_BOOK_BORROWGridControl.Size = new System.Drawing.Size(890, 529);
            this.lOAD_LIST_BOOK_BORROWGridControl.TabIndex = 2;
            this.lOAD_LIST_BOOK_BORROWGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.lOAD_LIST_BOOK_BORROWGridControl.DoubleClick += new System.EventHandler(this.lOAD_LIST_BOOK_BORROWGridControl_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSach,
            this.colMaISBN,
            this.colTenSach,
            this.colSoTrang,
            this.colNgayMuon});
            this.gridView1.GridControl = this.lOAD_LIST_BOOK_BORROWGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMaSach
            // 
            this.colMaSach.AppearanceHeader.BackColor = System.Drawing.Color.Blue;
            this.colMaSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaSach.AppearanceHeader.Options.UseBackColor = true;
            this.colMaSach.AppearanceHeader.Options.UseFont = true;
            this.colMaSach.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaSach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaSach.Caption = "Mã sách";
            this.colMaSach.FieldName = "MaSach";
            this.colMaSach.MinWidth = 25;
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.Visible = true;
            this.colMaSach.VisibleIndex = 0;
            this.colMaSach.Width = 94;
            // 
            // colMaISBN
            // 
            this.colMaISBN.AppearanceHeader.BackColor = System.Drawing.Color.Blue;
            this.colMaISBN.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMaISBN.AppearanceHeader.Options.UseBackColor = true;
            this.colMaISBN.AppearanceHeader.Options.UseFont = true;
            this.colMaISBN.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaISBN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaISBN.Caption = "Mã ISBN";
            this.colMaISBN.FieldName = "MaISBN";
            this.colMaISBN.MinWidth = 25;
            this.colMaISBN.Name = "colMaISBN";
            this.colMaISBN.Visible = true;
            this.colMaISBN.VisibleIndex = 1;
            this.colMaISBN.Width = 94;
            // 
            // colTenSach
            // 
            this.colTenSach.AppearanceHeader.BackColor = System.Drawing.Color.Blue;
            this.colTenSach.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colTenSach.AppearanceHeader.Options.UseBackColor = true;
            this.colTenSach.AppearanceHeader.Options.UseFont = true;
            this.colTenSach.AppearanceHeader.Options.UseTextOptions = true;
            this.colTenSach.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTenSach.Caption = "Tên sách";
            this.colTenSach.FieldName = "TenSach";
            this.colTenSach.MinWidth = 25;
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.Visible = true;
            this.colTenSach.VisibleIndex = 2;
            this.colTenSach.Width = 94;
            // 
            // colSoTrang
            // 
            this.colSoTrang.AppearanceHeader.BackColor = System.Drawing.Color.Blue;
            this.colSoTrang.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSoTrang.AppearanceHeader.Options.UseBackColor = true;
            this.colSoTrang.AppearanceHeader.Options.UseFont = true;
            this.colSoTrang.AppearanceHeader.Options.UseTextOptions = true;
            this.colSoTrang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSoTrang.Caption = "Số trang";
            this.colSoTrang.FieldName = "SoTrang";
            this.colSoTrang.MinWidth = 25;
            this.colSoTrang.Name = "colSoTrang";
            this.colSoTrang.Visible = true;
            this.colSoTrang.VisibleIndex = 3;
            this.colSoTrang.Width = 94;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.AppearanceHeader.BackColor = System.Drawing.Color.Blue;
            this.colNgayMuon.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNgayMuon.AppearanceHeader.Options.UseBackColor = true;
            this.colNgayMuon.AppearanceHeader.Options.UseFont = true;
            this.colNgayMuon.AppearanceHeader.Options.UseTextOptions = true;
            this.colNgayMuon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNgayMuon.Caption = "Ngày mượn";
            this.colNgayMuon.FieldName = "NgayMuon";
            this.colNgayMuon.MinWidth = 25;
            this.colNgayMuon.Name = "colNgayMuon";
            this.colNgayMuon.Visible = true;
            this.colNgayMuon.VisibleIndex = 4;
            this.colNgayMuon.Width = 94;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 100);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(170, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SÁCH MƯỢN/ĐĂNG KÝ MƯỢN";
            // 
            // frmListBookBorrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 621);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lOAD_LIST_BOOK_BORROWGridControl);
            this.Name = "frmListBookBorrowed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sách mượn";
            ((System.ComponentModel.ISupportInitialize)(this.qLTVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAD_LIST_BOOK_BORROWBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAD_LIST_BOOK_BORROWGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QLTVDataSet qLTVDataSet;
        private System.Windows.Forms.BindingSource lOAD_LIST_BOOK_BORROWBindingSource;
        private QLTVDataSetTableAdapters.LOAD_LIST_BOOK_BORROWTableAdapter lOAD_LIST_BOOK_BORROWTableAdapter;
        private QLTVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOAD_LIST_BOOK_BORROWGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSach;
        private DevExpress.XtraGrid.Columns.GridColumn colMaISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSach;
        private DevExpress.XtraGrid.Columns.GridColumn colSoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}