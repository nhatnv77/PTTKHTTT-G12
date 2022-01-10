using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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
    public partial class FrmRpListReaderCard : DevExpress.XtraEditors.XtraForm
    {
        public FrmRpListReaderCard()
        {
            InitializeComponent();
            cbStart.SelectedIndex = 0;
            cbEnd.SelectedIndex = 0; 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbEnd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbStart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            int start = int.Parse(cbStart.SelectedItem.ToString());
            int end = int.Parse(cbEnd.SelectedItem.ToString());
            if (start > end) XtraMessageBox.Show("Năm bắt đầu không thể sau năm kết thúc", "Cảnh báo", MessageBoxButtons.OK);
            else
            {
                XrptListReaderCardViaPhase report = new XrptListReaderCardViaPhase(start, end);
                report.lbHeader.Text = "DANH SÁCH THẺ ĐỘC GIẢ TỪ " + start + "-" + end;
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();
            }
        }
    }
}