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
    public partial class f_khachhang : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public f_khachhang()
        {
            InitializeComponent();
            loadkh();
        }
        private void loadkh()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tb_khachhang");
            dt = dataprovider.execQuery(query.ToString());
            dgvkh.DataSource = dt;

        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvkh.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvkh.Rows[rowID];
            txtmakh.Text = row.Cells[1].Value.ToString();

            txttenkh.Text = row.Cells[2].Value.ToString();
            txtdiachi.Text = row.Cells[3].Value.ToString();

            txtsdt.Text = row.Cells[4].Value.ToString();
        }

        private void dgvkh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {

            for (int i = 0; i < dgvkh.RowCount; i++)
            {
                dgvkh.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void XoaDL()
        {
            txtmakh.ResetText();
            txttenkh.ResetText();
            txtsdt.ResetText();
            txtdiachi.ResetText();
            txttenkh.Focus();
            loadkh();
        }

        

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string tenkh = txttenkh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string sqlthem = "Insert into tb_khachhang values(N'" + tenkh + "',N'" + diachi + "',N'" + sdt + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadkh();
                XtraMessageBox.Show("Thêm khách hàng thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm khách hàng thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string makh = txtmakh.Text;
            string tenkh = txttenkh.Text;
            string diachi = txtdiachi.Text;
            string sdt = txtsdt.Text;
            string sqlsua = "Update tb_khachhang set tenKhachHang=N'" + tenkh + "',diachiKH=N'" + diachi + "',sdtKH=N'" + sdt + "' where maKhachHang = N'" + makh + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadkh();
                XtraMessageBox.Show("Sửa thông tin khách hàng thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa thông tin khách hàng thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng :" + txttenkh.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string makh = txtmakh.Text;
                string query = "Delete from tb_khachhang where maKhachHang=N'" + makh + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadkh();
                    XtraMessageBox.Show("Xóa khách hàng thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa khách hàng không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}