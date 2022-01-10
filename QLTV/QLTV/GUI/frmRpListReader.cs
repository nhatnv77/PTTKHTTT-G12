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
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace QLTV.GUI
{
    public partial class frmRpListReader : DevExpress.XtraEditors.XtraForm
    {
        public frmRpListReader()
        {
            InitializeComponent();
            cbmstart.SelectedIndex = 0;
            cbmend.SelectedIndex = 0; 
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int start = int.Parse(cbmstart.SelectedItem.ToString()); 
            int end = int.Parse(cbmend.SelectedItem.ToString());
            if (start > end) XtraMessageBox.Show("Năm bắt đầu không thể sau năm kết thúc", "Cảnh báo", MessageBoxButtons.OK);
            else
            {
                XrptListReaderViaPhase report = new XrptListReaderViaPhase(start, end);
                report.lbHeader.Text = "DANH SÁCH ĐỘC GIẢ TỪ " + start + "-" + end;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog(); 
            }
        }
    }
}