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
    public partial class f_phieunhap : DevExpress.XtraEditors.XtraForm
    {
        dataprovider dataprovider = new dataprovider();
        private int maNhanVien;
        private int maNhaCungCap;
        private int maPhieuNhap;
        public f_phieunhap()
        {
            InitializeComponent();
            Loaddgvphieunhap();
            loadcbbnnc();
            loadcbbnv();
        }
        private void Loaddgvphieunhap()
        {
            DataTable dt = new DataTable();
            StringBuilder query = new StringBuilder("Select maPhieuNhap,tenNhanVien,tenNhaCungCap,ngayNhap from tb_phieunhap,tb_nhacungcap,tb_nhanvien where tb_phieunhap.maNhaCungCap=tb_nhacungcap.maNhaCungCap and tb_nhanvien.maNhanVien=tb_phieunhap.maNhanVien");
            dt = dataprovider.execQuery(query.ToString());
            dgvphieunhap.DataSource = dt;
            maPhieuNhap = (int)dt.Rows[0][0];
        }
        private void loadcbbnv()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_nhanvien");
            cbbtennv.DisplayMember = "tenNhanVien";
            cbbtennv.ValueMember = "maNhanVien";
            cbbtennv.DataSource = dt;
        }
        private void loadcbbnnc()
        {
            DataTable dt = new DataTable();
            dt = dataprovider.execQuery("select * from tb_nhacungcap");
            cbbtenncc.DisplayMember = "tenNhaCungCap";
            cbbtenncc.ValueMember = "maNhaCungCap";
            cbbtenncc.DataSource = dt;
        }

        private void dgvphieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowID = e.RowIndex;
            if (rowID < 0) rowID = 0;
            if (rowID == dgvphieunhap.RowCount) rowID = rowID - 1;
            DataGridViewRow row = dgvphieunhap.Rows[rowID];
            txtmapn.Text = row.Cells[1].Value.ToString();
            cbbtennv.Text = row.Cells[2].Value.ToString();
            cbbtenncc.Text = row.Cells[3].Value.ToString();
            txtngaynhap.Text = (row.Cells[4].Value.ToString());
        }

        private void dgvphieunhap_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvphieunhap.RowCount; i++)
            {
                dgvphieunhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void cbbtennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maNhanVien = (int)comboBox.SelectedValue;
        }

        private void cbbtenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            maNhaCungCap = (int)comboBox.SelectedValue;
        }
        private void XoaDL()
        {
            txtmapn.ResetText();
            cbbtenncc.ResetText();
            cbbtennv.ResetText();
            txtngaynhap.ResetText();
            Loaddgvphieunhap();
        }


        private void dgvphieunhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int mapn = Int32.Parse(txtmapn.Text);
            f_phieunhapchitiet ct = new f_phieunhapchitiet(mapn);
            ct.ShowDialog();
        }

        private void btnctpn_Click(object sender, EventArgs e)
        {
            int mapn = Int32.Parse(txtmapn.Text);
            f_phieunhapchitiet ct = new f_phieunhapchitiet(mapn);
            ct.ShowDialog();
        }

        private void btnthem_Click_1(object sender, EventArgs e)
        {
            string ngaynhap = txtngaynhap.Text;
            string sqlthem = "Insert into tb_phieunhap values(N'" + maNhanVien + "',N'" + maNhaCungCap + "',N'" + ngaynhap + "')";
            StringBuilder query = new StringBuilder(sqlthem);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                Loaddgvphieunhap();
                XtraMessageBox.Show("Thêm phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Thêm phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string maphieunhap = txtmapn.Text;
            string ngaynhap = txtngaynhap.Text;
            string sqlsua = "Update tb_phieunhap set maNhanVien=N'" + maNhanVien + "',maNhaCungCap=N'" + maNhaCungCap + "',ngayNhap=N'" + ngaynhap + "' where maPhieuNhap = N'" + maphieunhap + "' ";
            StringBuilder query = new StringBuilder(sqlsua);



            int result = dataprovider.execNonQuery(query.ToString());
            if (result > 0)
            {
                XoaDL();
                Loaddgvphieunhap();
                XtraMessageBox.Show("Sửa phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Sửa phiếu nhập thất bại !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            DialogResult check = XtraMessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập :" + txtmapn.Text + "?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                string mapn = txtmapn.Text;
                string query = "Delete from tb_phieunhap where maPhieuNhap=N'" + mapn + "'";
                int result = dataprovider.execNonQuery(query.ToString());
                if (result > 0)
                {
                    XoaDL();
                    Loaddgvphieunhap();
                    XtraMessageBox.Show("Xóa phiếu nhập thành công !", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Xóa phiếu nhập không thành công !", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            int mapn = Int32.Parse(txtmapn.Text);
            f_phieunhapchitiet ct = new f_phieunhapchitiet(mapn);
            ct.ShowDialog();
        }

        private void btnreset_Click_1(object sender, EventArgs e)
        {
            XoaDL();
        }
    }
}