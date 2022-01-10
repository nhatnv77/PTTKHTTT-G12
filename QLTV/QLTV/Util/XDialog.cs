using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Util
{
    public static class XDialog
    {
        public static DialogResult Error(string message)
        {
            return XtraMessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(string message)
        {
            return XtraMessageBox.Show(message, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        public static DialogResult Inform(string message)
        {
            return XtraMessageBox.Show(message, "Xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
