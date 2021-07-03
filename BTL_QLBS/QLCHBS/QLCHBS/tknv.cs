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
    public partial class tknv : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public tknv()
        {
            InitializeComponent();
            loadnv();
        }
        private void loadnv()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tb_nhanvien");
            dt = dataprovider.execQuery(query.ToString());
            dgvnhanvien.DataSource = dt;
        }
    }
}