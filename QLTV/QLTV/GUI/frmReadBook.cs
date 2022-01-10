using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class frmReadBook : DevExpress.XtraEditors.XtraForm
    {
        public frmReadBook()
        {
            InitializeComponent();
        }

        private void tuaSachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tuaSachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTVDataSet);

        }

        private void frmReadBook_Load(object sender, EventArgs e)
        {
            this.qLTVDataSet.EnforceConstraints = false;
            this.sP_GET_LIST_BOOKTableAdapter.Connection.ConnectionString
                = this.theDocGiaTableAdapter.Connection.ConnectionString
                = this.tuaSachTableAdapter.Connection.ConnectionString
                = Program.connstr;

            // TODO: This line of code loads data into the 'qLTVDataSet.SP_GET_LIST_BOOK' table. You can move, or remove it, as needed.
            this.sP_GET_LIST_BOOKTableAdapter.Fill(this.qLTVDataSet.SP_GET_LIST_BOOK);
            // TODO: This line of code loads data into the 'qLTVDataSet.TheDocGia' table. You can move, or remove it, as needed.
            this.theDocGiaTableAdapter.Fill(this.qLTVDataSet.TheDocGia);
            // TODO: This line of code loads data into the 'qLTVDataSet.TuaSach' table. You can move, or remove it, as needed.
            this.tuaSachTableAdapter.Fill(this.qLTVDataSet.TuaSach);
            gridView1.OptionsBehavior.Editable = false; 
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //String bookName, String describtion, String author, String publishDate, String company, String totalPage
            String bookName = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenSach").ToString();
            String describtion = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MoTa").ToString();
            String author = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tac gia").ToString();
            String publishDate = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgayXuatBan").ToString();
            String company = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDoiTac").ToString();
            String totalPage = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoTrang").ToString();
            BookDetail bookDetail = new BookDetail(bookName,describtion,author,publishDate,company,totalPage);
            bookDetail.Show(); 

        }
    }
}