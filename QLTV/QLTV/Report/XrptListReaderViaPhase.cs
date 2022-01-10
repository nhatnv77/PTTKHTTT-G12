using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLTV
{
    public partial class XrptListReaderViaPhase : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptListReaderViaPhase()
        {
            InitializeComponent();
        }
        public XrptListReaderViaPhase(int start, int end)
        {
            InitializeComponent();
            //this.sqlDataSource1.Connection.ConnectionString = Program.
            this.sqlDataSource1.Queries[0].Parameters[0].Value = start;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = end;
            this.sqlDataSource1.Fill();
        }
    }
}
