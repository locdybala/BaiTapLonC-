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

namespace QLCHBS
{
    public partial class f_hoadon : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private int maNhanVien;
        private int maKhachHang;
        public f_hoadon()
        {
            InitializeComponent();
            loaddgvhoadon();
            loadcbbnv();
            loadcbbkh();
        }

        private void loaddgvhoadon()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select maHoaDon,tenKhachHang,sdtKH,ngaylap,tenNhanVien from tb_hoadon,tb_khachhang,tb_nhanvien where tb_hoadon.maKhachHang=tb_khachhang.maKhachHang and tb_nhanvien.maNhanVien=tb_hoadon.manv ");
            dt = dataprovider.execQuery(query.ToString());
            dgvhoadon.DataSource = dt;
        }
        private void loadcbbnv()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_nhanvien");
            cbbtennv.DisplayMember = "tenNhanVien";
            cbbtennv.ValueMember = "maNhanVien";
            cbbtennv.DataSource = dt;
        }
        private void loadcbbkh()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_khachhang");
            cbbkh.DisplayMember = "tenKhachHang";
            cbbkh.ValueMember = "maKhachHang";
            cbbkh.DataSource = dt;
        }

        private void cbbtennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maNhanVien = (int)comboBox.SelectedValue;
        }

        private void cbbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maKhachHang = (int)comboBox.SelectedValue;
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvhoadon.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvhoadon.Rows[rowID];
            txtmahd.Text = row.Cells[1].Value.ToString();
            cbbkh.Text = row.Cells[2].Value.ToString();
            txtngaylap.Text = row.Cells[4].Value.ToString();
            cbbtennv.Text = row.Cells[5].Value.ToString();

        }

        private void dgvhoadon_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvhoadon.RowCount; i++)
            {
                dgvhoadon.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private void XoaDL()
        {
            txtmahd.ResetText();
            txtngaylap.ResetText();
            cbbkh.ResetText();
            cbbtennv.ResetText();
            loaddgvhoadon();
        }

        
       

        private void dgvhoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int mahd = Int32.Parse(txtmahd.Text);
            f_hoadonchitiet f = new f_hoadonchitiet(mahd);
            f.ShowDialog();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {

            string ngaylap = txtngaylap.Text;
            string sqlthem = "Insert into tb_hoadon values(N'" + maKhachHang + "',N'" + ngaylap + "',N'" + maNhanVien + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loaddgvhoadon();
                XtraMessageBox.Show("Thêm hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm hóa đơn thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string mahd = txtmahd.Text;
            string ngaylap = txtngaylap.Text;
            string sqlsua = "Update tb_hoadon set maKhachHang=N'" + maKhachHang + "',ngaylap=N'" + ngaylap + "',manv=N'" + maNhanVien + "' where maHoaDon = N'" + mahd + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                loaddgvhoadon();
                XtraMessageBox.Show("Sửa Hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa hóa đơn thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn hóa đơn số :" + txtmahd.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string mahd = txtmahd.Text;
                string query = "Delete from tb_hoadon where maHoaDon=N'" + mahd + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    loaddgvhoadon();
                    XtraMessageBox.Show("Xóa hóa đơn thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa hóa đơn không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            int mahd = Int32.Parse(txtmahd.Text);
            f_hoadonchitiet f = new f_hoadonchitiet(mahd);
            f.ShowDialog();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}