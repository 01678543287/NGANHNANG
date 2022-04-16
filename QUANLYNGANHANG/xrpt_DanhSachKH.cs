using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QUANLYNGANHANG
{
    public partial class xrpt_DanhSachKH : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpt_DanhSachKH(String serverName)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.StrConn;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = serverName;
            this.sqlDataSource1.Fill();
        }

    }
}
