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
    public partial class frmInfoReader : DevExpress.XtraEditors.XtraForm
    {
        private String ReaderCode = ""; 
        public frmInfoReader()
        {
            InitializeComponent();
        }
        public frmInfoReader(String madocgia)
        {
            InitializeComponent();
            this.ReaderCode = madocgia.Trim();
            readerCode.Text = madocgia;
            this.ReadInfo();
           

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ReadInfo()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(Program.connstr);
            cmd.CommandText = "LOAD_READER_INFO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Madocgia", SqlDbType.NVarChar).Value = ReaderCode;
            Console.WriteLine("reader code: " + ReaderCode);
            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close(); 
            cmd.Connection.Open();

            try
            {
                SqlDataReader reader =  cmd.ExecuteReader();
                while (reader.Read())
                {
                    readerCode.Text = (string)reader.GetString(0); 
                    mssv.Text = (string)reader.GetString(1);
                    name.Text = reader.GetString(2);
                    txPhone.Text = reader.GetString(3);
                    txEmail.Text = reader.GetString(4);
                    pw.Text = reader.GetString(5); 
                }
            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi lúc đọc dữ liệu độc giả!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(cmd.Connection!=null)
                cmd.Connection.Close(); 
            }
        }

        private void ckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            pw.Properties.UseSystemPasswordChar = !ckShowPassword.Checked; 
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txEmail.Text.Trim().Equals(""))
            {
                XtraMessageBox.Show("Email không thể trống!");
                return; 
            }
            if(txPhone.Text.Trim().Length != 10)
            {
                XtraMessageBox.Show("Số điện thoại là bắt buộc và phải đủ 10 số!");
                return; 
            }
            if(pw.Text.Trim().Length < 5)
            {
                XtraMessageBox.Show("Mật khẩu phải có tối thiểu 5 kí tự!");
                return; 
            }

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = new SqlConnection(Program.connstr);
            cmd.CommandText = "UPDATE_READER_INFO";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Madocgia", SqlDbType.NVarChar).Value = ReaderCode;
            cmd.Parameters.Add("@sdt", SqlDbType.NVarChar).Value = txPhone.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = txEmail.Text;
            cmd.Parameters.Add("@matkhau", SqlDbType.NVarChar).Value = pw.Text;

            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            cmd.Connection.Open();

            try
            {
                cmd.ExecuteNonQuery();
                XtraMessageBox.Show( "Cập nhật thông tin thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi cập nhật thông tin độc giả!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cmd.Connection != null)
                    cmd.Connection.Close();
            }
        }
    }
}