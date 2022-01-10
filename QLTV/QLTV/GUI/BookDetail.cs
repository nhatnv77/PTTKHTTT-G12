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
    public partial class BookDetail : DevExpress.XtraEditors.XtraForm
    {
        public BookDetail()
        {
            InitializeComponent();
        }
        public BookDetail(String bookName, String describtion, String author, String publishDate, String company, String totalPage )
        {
            InitializeComponent();
            lbBookName.Text = bookName;
            bookContent.Text = describtion;
            lbAuthorname.Text = author;
            lbPublishDate.Text = publishDate;
            lbCompany.Text = company;
            lbTotalPage.Text = totalPage; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookDetail_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbCompany_Click(object sender, EventArgs e)
        {

        }

        private void lbPublishDate_Click(object sender, EventArgs e)
        {

        }

        private void lbAuthorname_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Đăng ký mượn sách online? ", "Bạn có chắc chắn mượn sách này?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                XtraMessageBox.Show("Bạn đã đăng ký mượn sách thành công.\nHãy đến thư viện nhận sách trong 3 ngày bạn nhé!", "Chức năng mô phỏng-Đăng ký mượn sách thành công",  MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }
    }
}