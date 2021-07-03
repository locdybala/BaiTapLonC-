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
    public partial class f_loaisach : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        public f_loaisach()
        {
            InitializeComponent();
            loadloaisach();
        }
        public void loadloaisach()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("select * from tb_loaisach");
            dt = dataprovider.execQuery(query.ToString());
            dgvloaissach.DataSource = dt;

        }

        private void dgvloaissach_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvloaissach.RowCount ; i++)
            {
                dgvloaissach.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgvloaissach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvloaissach.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvloaissach.Rows[rowID];
            txtmaloaisach.Text = row.Cells[1].Value.ToString();

            txttenloaisach.Text = row.Cells[2].Value.ToString();
        }
        public void XoaDL()
        {
            txtmaloaisach.ResetText();
            txttenloaisach.ResetText();
            txttenloaisach.Focus();
            loadloaisach();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string tenloaisach = txttenloaisach.Text;


            string sqlthem = "Insert into tb_loaisach values(N'" + tenloaisach + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadloaisach();
                XtraMessageBox.Show("Thêm loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm loại sách thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string maloaisach = txtmaloaisach.Text;
            string tenloaisach = txttenloaisach.Text;

            //khai báo chuỗi insert
            string sqlsua = "Update tb_loaisach set tenLoaiSach=N'" + tenloaisach + "' where maLoaiSach = N'" + maloaisach + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loadloaisach();
                XtraMessageBox.Show("Sửa loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa loại sách thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa loại sách :" + txttenloaisach.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string maloaisach = txtmaloaisach.Text;
                string query = "Delete from tb_loaisach where maLoaiSach=N'" + maloaisach + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loadloaisach();
                    XtraMessageBox.Show("Xóa loại sách thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa loại sách không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}