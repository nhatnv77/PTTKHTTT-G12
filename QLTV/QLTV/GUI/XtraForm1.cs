using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class frmReview : DevExpress.XtraEditors.XtraForm
    {
        private string ReaderCode = ""; 
        public frmReview()
        {
            InitializeComponent();
        }
        public frmReview(String madocgia)
        {
            InitializeComponent();
            this.ReaderCode = madocgia; 
        }
        private void btnReview_Click(object sender, EventArgs e)
        {
        
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn gửi đánh giá này?", "Đánh giá thư viện", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = new SqlConnection(Program.connstr);
                cmd.CommandText = "INSERT_REVIEW";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Madocgia", SqlDbType.NVarChar).Value = ReaderCode;
                cmd.Parameters.Add("@diem", SqlDbType.Int).Value = nmGrade.Value;
                cmd.Parameters.Add("@noidung", SqlDbType.NVarChar).Value = txComment.Text;

                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
                cmd.Connection.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    XtraMessageBox.Show("Cảm ơn vì phản hồi của bạn!", "Đánh giá thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); 
                }
                catch (SqlException ex)
                {
                    XtraMessageBox.Show(ex.Message, "Lỗi thêm đánh giá!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (cmd.Connection != null)
                        cmd.Connection.Close();
                }

            }
        }
    }
}