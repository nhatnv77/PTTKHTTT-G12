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
    public partial class frmListBookBorrowed : DevExpress.XtraEditors.XtraForm
    {
        private string ReaderCode = ""; 
        public frmListBookBorrowed()
        {
            InitializeComponent();
        }
        public frmListBookBorrowed(String madocgia)
        {
            InitializeComponent();
            this.ReaderCode = madocgia;
            fillListBook();
            gridView1.OptionsBehavior.Editable = false;
        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.lOAD_LIST_BOOK_BORROWTableAdapter.Fill(this.qLTVDataSet.LOAD_LIST_BOOK_BORROW, madocgiaToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }
        private void fillListBook()
        {
            try
            {
                this.lOAD_LIST_BOOK_BORROWTableAdapter.Fill(this.qLTVDataSet.LOAD_LIST_BOOK_BORROW, this.ReaderCode);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    this.lOAD_LIST_BOOK_BORROWTableAdapter.Fill(this.qLTVDataSet.LOAD_LIST_BOOK_BORROW, madocgiaToolStripTextBox.Text);
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void lOAD_LIST_BOOK_BORROWGridControl_DoubleClick(object sender, EventArgs e)
        {
           DialogResult dialog = XtraMessageBox.Show("Bạn có muốn hủy mượn sách này?", "Cảnh báo-Chức năng mô phỏng", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                XtraMessageBox.Show("Hủy mượn sách(mô phỏng) thành công!", "Thông báo-Chức năng mô phỏng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}