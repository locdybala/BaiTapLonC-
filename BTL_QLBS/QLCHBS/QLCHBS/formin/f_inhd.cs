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

namespace QLCHBS
{
    public partial class f_inhd : DevExpress.XtraEditors.XtraForm
    {
        public f_inhd(Object report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
        }
    }
}